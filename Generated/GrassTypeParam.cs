
namespace StronglyTypedParams
{
    public class GrassTypeParam : ParamRow
    {
        public GrassTypeParam() : base()
        {
        }


        // Def="u16 lodRange"
        /// <summary>
        /// LOD Distance (u16)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public ushort LODDistance
        {
            get => (ushort)CellsByName["LODDistance"].Value;
            set => CellsByName["LODDistance"].Value = value;
        }


        // Def="u8 lod0ClusterType"
        /// <summary>
        /// LOD 0 - Cluster Type (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte LOD0ClusterType
        {
            get => (byte)CellsByName["LOD0ClusterType"].Value;
            set => CellsByName["LOD0ClusterType"].Value = value;
        }


        // Def="u8 lod1ClusterType"
        /// <summary>
        /// LOD 1 - Cluster Type (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte LOD1ClusterType
        {
            get => (byte)CellsByName["LOD1ClusterType"].Value;
            set => CellsByName["LOD1ClusterType"].Value = value;
        }


        // Def="u8 lod2ClusterType"
        /// <summary>
        /// LOD 2 - Cluster Type (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte LOD2ClusterType
        {
            get => (byte)CellsByName["LOD2ClusterType"].Value;
            set => CellsByName["LOD2ClusterType"].Value = value;
        }


        // Def="dummy8 pad0[2]"
        /// <summary>
        /// pad0 (dummy8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object Pad0
        {
            get => (object)CellsByName["Pad0"].Value;
            set => CellsByName["Pad0"].Value = value;
        }


        // Def="u8 distributionType"
        /// <summary>
        /// Placement Method (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte PlacementMethod
        {
            get => (byte)CellsByName["PlacementMethod"].Value;
            set => CellsByName["PlacementMethod"].Value = value;
        }


        // Def="f32 baseDensity = 1"
        /// <summary>
        /// Base Density (f32)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public float BaseDensity
        {
            get => (float)CellsByName["BaseDensity"].Value;
            set => CellsByName["BaseDensity"].Value = value;
        }


        // Def="fixstrW model0Name[16]"
        /// <summary>
        /// Model Name [0] (fixstrW)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object ModelName0
        {
            get => (object)CellsByName["ModelName0"].Value;
            set => CellsByName["ModelName0"].Value = value;
        }


        // Def="fixstrW flatTextureName[32]"
        /// <summary>
        /// Flat Texture Name (fixstrW)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object FlatTextureName
        {
            get => (object)CellsByName["FlatTextureName"].Value;
            set => CellsByName["FlatTextureName"].Value = value;
        }


        // Def="fixstrW billboardTextureName[32]"
        /// <summary>
        /// Billboard Texture Name (fixstrW)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object BillboardTextureName
        {
            get => (object)CellsByName["BillboardTextureName"].Value;
            set => CellsByName["BillboardTextureName"].Value = value;
        }


        // Def="u8 normalInfluence"
        /// <summary>
        /// Effect of Tilt % (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte EffectOfTiltPercent
        {
            get => (byte)CellsByName["EffectOfTiltPercent"].Value;
            set => CellsByName["EffectOfTiltPercent"].Value = value;
        }


        // Def="u8 inclinationMax = 90"
        /// <summary>
        /// Maximum Tilt Angle (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte MaximumTiltAngle
        {
            get => (byte)CellsByName["MaximumTiltAngle"].Value;
            set => CellsByName["MaximumTiltAngle"].Value = value;
        }


        // Def="u8 inclinationJitter"
        /// <summary>
        /// Randomness of Tilt Angle (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte RandomnessOfTiltAngle
        {
            get => (byte)CellsByName["RandomnessOfTiltAngle"].Value;
            set => CellsByName["RandomnessOfTiltAngle"].Value = value;
        }


        // Def="u8 scaleBaseMin = 100"
        /// <summary>
        /// Width Scale - Min (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte WidthScaleMin
        {
            get => (byte)CellsByName["WidthScaleMin"].Value;
            set => CellsByName["WidthScaleMin"].Value = value;
        }


        // Def="u8 scaleBaseMax = 100"
        /// <summary>
        /// Width Scale - Max (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte WidthScaleMax
        {
            get => (byte)CellsByName["WidthScaleMax"].Value;
            set => CellsByName["WidthScaleMax"].Value = value;
        }


        // Def="u8 scaleHeightMin = 100"
        /// <summary>
        /// Height Scale - Min (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte HeightScaleMin
        {
            get => (byte)CellsByName["HeightScaleMin"].Value;
            set => CellsByName["HeightScaleMin"].Value = value;
        }


        // Def="u8 scaleHeightMax = 100"
        /// <summary>
        /// Height Scale - Max (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte HeightScaleMax
        {
            get => (byte)CellsByName["HeightScaleMax"].Value;
            set => CellsByName["HeightScaleMax"].Value = value;
        }


        // Def="u8 colorShade1_r = 255"
        /// <summary>
        /// Color Shade [1]: R (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte ColorShade1R
        {
            get => (byte)CellsByName["ColorShade1R"].Value;
            set => CellsByName["ColorShade1R"].Value = value;
        }


        // Def="u8 colorShade1_g = 255"
        /// <summary>
        /// Color Shade [1]: G (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte ColorShade1G
        {
            get => (byte)CellsByName["ColorShade1G"].Value;
            set => CellsByName["ColorShade1G"].Value = value;
        }


        // Def="u8 colorShade1_b = 255"
        /// <summary>
        /// Color Shade [1]: B (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte ColorShade1B
        {
            get => (byte)CellsByName["ColorShade1B"].Value;
            set => CellsByName["ColorShade1B"].Value = value;
        }


        // Def="u8 colorShade2_r = 255"
        /// <summary>
        /// Color Shade [2]: R (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte ColorShade2R
        {
            get => (byte)CellsByName["ColorShade2R"].Value;
            set => CellsByName["ColorShade2R"].Value = value;
        }




        // Def="u8 flatSplitType"
        /// <summary>
        /// Plane Split Type (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte PlaneSplitType
        {
            get => (byte)CellsByName["PlaneSplitType"].Value;
            set => CellsByName["PlaneSplitType"].Value = value;
        }


        // Def="u8 flatBladeCount = 2"
        /// <summary>
        /// Number of Planes (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte NumberOfPlanes
        {
            get => (byte)CellsByName["NumberOfPlanes"].Value;
            set => CellsByName["NumberOfPlanes"].Value = value;
        }


        // Def="s8 flatSlant"
        /// <summary>
        /// Plane Angle (s8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public sbyte PlaneAngle
        {
            get => (sbyte)CellsByName["PlaneAngle"].Value;
            set => CellsByName["PlaneAngle"].Value = value;
        }


        // Def="f32 flatRadius"
        /// <summary>
        /// Plane Distance (f32)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public float PlaneDistance
        {
            get => (float)CellsByName["PlaneDistance"].Value;
            set => CellsByName["PlaneDistance"].Value = value;
        }


        // Def="u8 castShadow = 1"
        /// <summary>
        /// Cast Shadow (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte CastShadow
        {
            get => (byte)CellsByName["CastShadow"].Value;
            set => CellsByName["CastShadow"].Value = value;
        }


        // Def="u8 windAmplitude = 80"
        /// <summary>
        /// Wind Amplitude (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte WindAmplitude
        {
            get => (byte)CellsByName["WindAmplitude"].Value;
            set => CellsByName["WindAmplitude"].Value = value;
        }


        // Def="dummy8 pad1[1]"
        /// <summary>
        /// pad1 (dummy8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object Pad1
        {
            get => (object)CellsByName["Pad1"].Value;
            set => CellsByName["Pad1"].Value = value;
        }


        // Def="u8 windCycle = 40"
        /// <summary>
        /// Wind Speed (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte WindSpeed
        {
            get => (byte)CellsByName["WindSpeed"].Value;
            set => CellsByName["WindSpeed"].Value = value;
        }


        // Def="f32 orientationAngle = -1"
        /// <summary>
        /// Direction (f32)
        /// </summary>
        /// <remarks>
        /// Random for -1
        /// </remarks>
        public float Direction
        {
            get => (float)CellsByName["Direction"].Value;
            set => CellsByName["Direction"].Value = value;
        }


        // Def="f32 orientationRange = -1"
        /// <summary>
        /// Direction Range (f32)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public float DirectionRange
        {
            get => (float)CellsByName["DirectionRange"].Value;
            set => CellsByName["DirectionRange"].Value = value;
        }


        // Def="f32 spacing"
        /// <summary>
        /// Model Spacing (f32)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public float ModelSpacing
        {
            get => (float)CellsByName["ModelSpacing"].Value;
            set => CellsByName["ModelSpacing"].Value = value;
        }


        // Def="u8 dithering"
        /// <summary>
        /// Dithering (u8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public byte Dithering
        {
            get => (byte)CellsByName["Dithering"].Value;
            set => CellsByName["Dithering"].Value = value;
        }


        // Def="dummy8 pad[3]"
        /// <summary>
        /// pad2 (dummy8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object Pad2
        {
            get => (object)CellsByName["Pad2"].Value;
            set => CellsByName["Pad2"].Value = value;
        }


        // Def="fixstrW simpleModelName[16]"
        /// <summary>
        /// Simple Model Name (fixstrW)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object SimpleModelName
        {
            get => (object)CellsByName["SimpleModelName"].Value;
            set => CellsByName["SimpleModelName"].Value = value;
        }


        // Def="fixstrW model1Name[16]"
        /// <summary>
        /// Model Name [1] (fixstrW)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object ModelName1
        {
            get => (object)CellsByName["ModelName1"].Value;
            set => CellsByName["ModelName1"].Value = value;
        }

    }
}
