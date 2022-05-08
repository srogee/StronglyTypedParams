using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace StronglyTypedParams
{
    public class ParamInstance
    {
        public string InstanceName;
        public string Type;
        public string ClassName;
    }

    public class ParamType
    {
        public string Name;
        public string Type;
        public XElement Xml;
    }

    public class ParamClassGenerator
    {
        public const string ParamDefinitionsDir = @"C:\Users\rid3r\Downloads\Yapped-Rune-Bear-2_1_0\Paramdex\ER\Defs";
        public const string ParamNamesDir = @"C:\Users\rid3r\Downloads\Yapped-Rune-Bear-2_1_0\Paramdex\ER\Names";
        public const string ParamTdfsDir = @"C:\Users\rid3r\Downloads\Yapped-Rune-Bear-2_1_0\Paramdex\ER\Tdfs";
        public const string RegulationInPath = @"Z:\SteamLibrary\steamapps\common\ELDEN RING\Game\regulation.bin.bak";
        public const string RegulationOutPath = @"Z:\SteamLibrary\steamapps\common\ELDEN RING\Game\regulation.bin";
        private const string GeneratedClassesDir = @"C:\Users\rid3r\Documents\GitHub\StronglyTypedParams\Generated";

        public static HashSet<string> CellNamesToIgnore = new HashSet<string>(new string[] { "pad", "padding", "reserve", "Reserved0", "reserved1", "reservedarea", "ReservedAreaWeaponTypeThatCanBeInstalled", "VisionDistance", "ColorShade1G", "ColorShade1B", "Blank" }.Select(str => str.ToLower()));
        private HashSet<string> GeneratedEnums;

        private ParamClassGenerator()
        {
            GeneratedEnums = new HashSet<string>();
        }

        public static void Generate()
        {
            var generator = new ParamClassGenerator();
            generator.Clean();
            generator.Run();
        }

        public void Clean()
        {
            Directory.CreateDirectory(GeneratedClassesDir);

            Console.WriteLine($"Cleaning generated files...");
            foreach (var file in Directory.EnumerateFiles(GeneratedClassesDir))
            {
                File.Delete(file);
            }
        }

        private List<ParamInstance> GetParamNamesAndTypes()
        {
            var regulationParams = SoulsFormats.SFUtil.DecryptERRegulation(RegulationInPath);
            var returnValue = new List<ParamInstance>();

            // Debug
            foreach (var file in regulationParams.Files)
            {
                var soulsParam = SoulsFormats.PARAM.Read(file.Bytes);
                var oneParam = new ParamInstance()
                {
                    InstanceName = Path.GetFileNameWithoutExtension(file.Name),
                    Type = soulsParam.ParamType
                };
                returnValue.Add(oneParam);
                Console.WriteLine($"{oneParam.InstanceName} - {oneParam.Type}");
            }

            return returnValue;
        }

        private List<ParamType> GetParamDefs()
        {
            var returnValue = new List<ParamType>();

            foreach (var file in Directory.EnumerateFiles(ParamDefinitionsDir, "*.xml"))
            {
                var xml = XElement.Load(file);
                var oneParamType = new ParamType()
                {
                    Name = Path.GetFileNameWithoutExtension(file),
                    Type = xml.Descendants("ParamType").First().Value,
                    Xml = xml
                };
                returnValue.Add(oneParamType);
            }

            return returnValue;
        }

        public void Run()
        {
            Directory.CreateDirectory(GeneratedClassesDir);

            string enums = "";
            foreach (var paramTdfFile in Directory.EnumerateFiles(ParamTdfsDir, "*.tdf"))
            {
                var enumName = Path.GetFileNameWithoutExtension(paramTdfFile);
                var generatedCode = GenerateEnum(enumName, File.ReadAllText(paramTdfFile));
                GeneratedEnums.Add(enumName);
                enums += generatedCode;
            }
            AddSource("Enums.cs", enums);

            var paramInstances = GetParamNamesAndTypes();
            var paramDefs = GetParamDefs();

            foreach (var paramDef in paramDefs)
            {
                AddSource($"{paramDef.Name}.cs", GenerateParamRowClass(paramDef));
                var instances = paramInstances.Where(param => param.Type == paramDef.Type);
                foreach (var instance in instances) {
                    instance.ClassName = paramDef.Name;
                }
            }

            var source = $@"
            using SoulsFormats;
            using System;
            using System.Collections.Generic;
            using System.IO;

            namespace StronglyTypedParams
            {{
                public class RegulationParams
                {{
                    private BND4 Data;
                    private Dictionary<string, object> ParamsByName;

                    private RegulationParams(BND4 data)
                    {{
                        Data = data;
                        ParamsByName = new Dictionary<string, object>();
                    }}

                    public static RegulationParams Load(string path)
                    {{
                        var data = SFUtil.DecryptERRegulation(path);
                        return new RegulationParams(data);
                    }}

                    public void Save(string path)
                    {{
                        {string.Join("\n", paramInstances.Select(param => $"SaveParam<{param.ClassName}>(\"{param.InstanceName}\");"))}
                        SFUtil.EncryptERRegulation(path, Data);
                    }}

                    private ParamCollection<T> GetOrLoadParam<T>(string paramName, string paramClassName) where T : ParamRow, new()
                    {{
                        if (!ParamsByName.ContainsKey(paramName)) {{
                            LoadParam<T>(paramName, paramClassName);
                        }}

                        return (ParamCollection<T>)ParamsByName[paramName];
                    }}

                    private void LoadParam<T>(string paramName, string paramClassName) where T : ParamRow, new()
                    {{
                        BinderFile paramFile = Data.Files.Find(file => Path.GetFileNameWithoutExtension(file.Name) == paramName);
						if (paramFile == null)
                        {{
                            Console.WriteLine(""Error when loading param "" + paramName);
                            ParamsByName.Add(paramName, null);
                            return;
                        }}
                        var paramCollection = new ParamCollection<T>(PARAM.Read(paramFile.Bytes), paramName, paramClassName);
                        ParamsByName.Add(paramName, paramCollection);
                    }}

                    private void SaveParam<T>(string paramName) where T : ParamRow, new()
                    {{
                        if (ParamsByName.ContainsKey(paramName))
                        {{
                            BinderFile paramFile = Data.Files.Find(file => Path.GetFileNameWithoutExtension(file.Name) == paramName);
                            if (paramFile != null && ParamsByName[paramName] != null)
                            {{
                                var collection = ParamsByName[paramName] as ParamCollection<T>;
                                paramFile.Bytes = collection.ToByteArray();
                            }}
                        }}
                    }}
            ";
            foreach (var param in paramInstances)
            {
                source += $"\n\t\tpublic ParamCollection<{param.ClassName}> {param.InstanceName} => GetOrLoadParam<{param.ClassName}>(\"{param.InstanceName}\",\"{param.ClassName}\");";
            }
            source += $@"
                }}
            }}
            ";
            AddSource($"RegulationParams.cs", source);
        }

        private string GenerateProperty(XElement fieldDef, HashSet<string> existingFieldNames)
        {
            var def = fieldDef.Attribute("Def").Value;
            var enumName = fieldDef.Descendants("Enum").FirstOrDefault()?.Value;
            var splitDef = def.Split(new char[] { ' ', ':', '[' });
            var backingType = GetTypeFromSoulsType(splitDef[0]);
            var displayName = fieldDef.Descendants("DisplayName").First().Value;
            var name = GetFieldName(displayName);
            if (string.IsNullOrWhiteSpace(name))
            {
                return "";
            }

            if (existingFieldNames.Contains(name))
            {
                return "";
            }

            existingFieldNames.Add(name);

            var description = fieldDef.Descendants("Description").FirstOrDefault()?.Value;
            description = description?.Replace("\n", "\n///");

            var type = backingType;
            if (!string.IsNullOrWhiteSpace(enumName) && GeneratedEnums.Contains(enumName))
            {
                type = GetFriendlyEnumName(enumName);
            }

            return $@"
            // Def=""{def}""
            /// <summary>
            /// {displayName} ({splitDef[0]})
            /// </summary>
            /// <remarks>
            /// {description}
            /// </remarks>
            public {type} {name} 
            {{
                get => ({type})CellsByName[""{name}""].Value;
                set => CellsByName[""{name}""].Value = ({backingType})value;
            }}
            ";
        }

        public static string GetFieldName(string name)
        {
            var allowedCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789_";
            var result = "";
            var capNext = true;
            foreach (var character in name)
            {
                if (allowedCharacters.Contains(character))
                {
                    result += capNext ? character.ToString().ToUpper() : character.ToString();
                    capNext = false;
                }
                else
                {
                    if (character == '%')
                    {
                        result += "Percent";
                    }

                    capNext = true;
                }
            }

            // If first character is a number, prepend underscore
            if (result.Length > 0 && int.TryParse(result.Substring(0, 1), out _))
            {
                return "_" + result;
            }

            return result;
        }

        private string GetTypeFromSoulsType(string type)
        {
            switch (type)
            {
                case "s8": return "sbyte";
                case "u8": return "byte";
                case "s16": return "short";
                case "u16": return "ushort";
                case "s32": return "int";
                case "u32": return "uint";
                case "f32": return "float";
                default: return "object";
            }
        }

        private string GenerateEnum(string enumName, string definition)
        {
            var paramTdf = new SoulsFormats.PARAMTDF(definition);
            var soulsTypeName = Enum.GetName(typeof(SoulsFormats.PARAMDEF.DefType), paramTdf.Type);
            var existingNames = new HashSet<string>();
            string source = $@"
                // {enumName}
                public enum {GetFriendlyEnumName(enumName)} : {GetTypeFromSoulsType(soulsTypeName)}
                {{
                    {string.Join(",\n", paramTdf.Entries.Select(entry => $"{GetEnumValueName(entry.Name)} = {entry.Value}"))}
                }}
            ";

            string GetEnumValueName(string name)
            {
                var initialName = GetFieldName(name);
                var finalName = initialName;
                var counter = 1;
                while (existingNames.Contains(finalName))
                {
                    counter++;
                    finalName = initialName + counter;
                }
                existingNames.Add(finalName);
                return finalName;
            }

            return source;
        }

        private string GetFriendlyEnumName(string enumName)
        {
            var caps = true;
            var allowedCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var result = "";
            foreach (var character in enumName)
            {
                if (allowedCharacters.Contains(character))
                {
                    result += caps ? character.ToString().ToUpper() : character.ToString().ToLower();
                    caps = false;
                }
                else
                {
                    caps = true;
                }
            }
            return result;
        }

        private string GenerateParamRowClass(ParamType paramDef)
        {
            string source = $@"
            namespace StronglyTypedParams
            {{
                // {paramDef.Type}
                public class {paramDef.Name} : ParamRow
                {{
                    public {paramDef.Name}() : base()
                    {{
                    }}
            ";

            var fields = paramDef.Xml.Descendants("Fields").First().Descendants("Field");

            HashSet<string> existingFieldNames = new HashSet<string>();
            foreach (var def in fields)
            {
                source += "\n" + GenerateProperty(def, existingFieldNames);
            }

            source += $@"
                }}
            }}
            ";
            return source;
        }

        private void AddSource(string name, string source)
        {
            File.WriteAllText(Path.Combine(GeneratedClassesDir, name), source);
            Console.WriteLine($"Added source file {name}");
        }
    }
}
