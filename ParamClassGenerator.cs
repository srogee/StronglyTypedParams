using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace StronglyTypedParams
{
    public class ParamClassGenerator
    {
        public const string ParamDefinitionsDir = @"C:\Users\rid3r\Downloads\Yapped-Rune-Bear-2_1_0\Paramdex\ER\Defs";
        public const string ParamNamesDir = @"C:\Users\rid3r\Downloads\Yapped-Rune-Bear-2_1_0\Paramdex\ER\Names";
        private const string GeneratedClassesDir = @"C:\Users\rid3r\Documents\GitHub\StronglyTypedParams\Generated";

        public static HashSet<string> CellNamesToIgnore = new HashSet<string>(new string[] { "pad", "padding", "reserve", "Reserved0", "reserved1", "reservedarea", "ReservedAreaWeaponTypeThatCanBeInstalled", "VisionDistance", "ColorShade1G", "ColorShade1B" }.Select(str => str.ToLower()));

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

        public void Run()
        {
            Directory.CreateDirectory(GeneratedClassesDir);

            var paramNames = new List<string>();
            foreach (var file in Directory.EnumerateFiles(ParamDefinitionsDir, "*.xml"))
            {
                var paramName = Path.GetFileNameWithoutExtension(file);
                paramNames.Add(paramName);
                AddSource($"{paramName}.cs", GenerateParamRowClass(paramName, file));
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

                    public RegulationParams(BND4 data)
                    {{
                        Data = data;
                        ParamsByName = new Dictionary<string, object>();
                    }}

                    private ParamCollection<T> GetOrLoadParam<T>(string paramName) where T : ParamRow, new()
                    {{
                        if (!ParamsByName.ContainsKey(paramName)) {{
                            LoadParam<T>(paramName);
                        }}

                        return (ParamCollection<T>)ParamsByName[paramName];
                    }}

                    private void LoadParam<T>(string paramName) where T : ParamRow, new()
                    {{
                        Console.WriteLine(""Loading param "" + paramName);
                        BinderFile paramFile = Data.Files.Find(file => Path.GetFileNameWithoutExtension(file.Name) == paramName);
						if (paramFile == null)
                        {{
                            Console.WriteLine(""Error when loading param "" + paramName);
                            ParamsByName.Add(paramName, null);
                            return;
                        }}
                        var paramCollection = new ParamCollection<T>(PARAM.Read(paramFile.Bytes), paramName);
                        ParamsByName.Add(paramName, paramCollection);
                    }}
            ";
            foreach (var paramName in paramNames)
            {
                source += $"\n\t\tpublic ParamCollection<{paramName}> {paramName} => GetOrLoadParam<{paramName}>(\"{paramName}\");";
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
            var splitDef = def.Split(new char[] { ' ', ':', '[' });
            var type = GetTypeFromSoulsType(splitDef[0]);
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
                set => CellsByName[""{name}""].Value = value;
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

        private string GenerateParamRowClass(string paramName, string paramDefPath)
        {
            var defs = XElement.Load(paramDefPath);
            string source = $@"
            namespace StronglyTypedParams
            {{
                public class {paramName} : ParamRow
                {{
                    public {paramName}() : base()
                    {{
                    }}
            ";

            var fields = defs.Descendants("Fields").First().Descendants("Field");

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
