
namespace StronglyTypedParams
{
    public class PhantomParam : ParamRow
    {
        public PhantomParam() : base()
        {
        }


        // Def="f32 edgeColorA = 1"
        /// <summary>
        /// Edge Color: Alpha (f32)
        /// </summary>
        /// <remarks>
        /// Edge color A.
        /// </remarks>
        public float EdgeColorAlpha
        {
            get => (float)CellsByName["EdgeColorAlpha"].Value;
            set => CellsByName["EdgeColorAlpha"].Value = value;
        }


        // Def="f32 frontColorA"
        /// <summary>
        /// Front Color: Alpha (f32)
        /// </summary>
        /// <remarks>
        /// The front color is A.
        /// </remarks>
        public float FrontColorAlpha
        {
            get => (float)CellsByName["FrontColorAlpha"].Value;
            set => CellsByName["FrontColorAlpha"].Value = value;
        }


        // Def="f32 diffMulColorA = 1"
        /// <summary>
        /// Diffuse Color: Alpha (f32)
        /// </summary>
        /// <remarks>
        /// Diffuse multiplication color A.
        /// </remarks>
        public float DiffuseColorAlpha
        {
            get => (float)CellsByName["DiffuseColorAlpha"].Value;
            set => CellsByName["DiffuseColorAlpha"].Value = value;
        }


        // Def="f32 specMulColorA = 1"
        /// <summary>
        /// Specular Color: Alpha (f32)
        /// </summary>
        /// <remarks>
        /// Specular multiplication color A.
        /// </remarks>
        public float SpecularColorAlpha
        {
            get => (float)CellsByName["SpecularColorAlpha"].Value;
            set => CellsByName["SpecularColorAlpha"].Value = value;
        }


        // Def="f32 lightColorA"
        /// <summary>
        /// Light Color: Alpha (f32)
        /// </summary>
        /// <remarks>
        /// Light color A.
        /// </remarks>
        public float LightColorAlpha
        {
            get => (float)CellsByName["LightColorAlpha"].Value;
            set => CellsByName["LightColorAlpha"].Value = value;
        }


        // Def="u8 edgeColorR = 255"
        /// <summary>
        /// Edge Color: R (u8)
        /// </summary>
        /// <remarks>
        /// Edge color R.
        /// </remarks>
        public byte EdgeColorR
        {
            get => (byte)CellsByName["EdgeColorR"].Value;
            set => CellsByName["EdgeColorR"].Value = value;
        }


        // Def="u8 edgeColorG = 255"
        /// <summary>
        /// Edge Color: G (u8)
        /// </summary>
        /// <remarks>
        /// Edge color G.
        /// </remarks>
        public byte EdgeColorG
        {
            get => (byte)CellsByName["EdgeColorG"].Value;
            set => CellsByName["EdgeColorG"].Value = value;
        }


        // Def="u8 edgeColorB = 255"
        /// <summary>
        /// Edge Color: B (u8)
        /// </summary>
        /// <remarks>
        /// Edge color B.
        /// </remarks>
        public byte EdgeColorB
        {
            get => (byte)CellsByName["EdgeColorB"].Value;
            set => CellsByName["EdgeColorB"].Value = value;
        }


        // Def="u8 frontColorR"
        /// <summary>
        /// Front Color: R (u8)
        /// </summary>
        /// <remarks>
        /// The front color is R.
        /// </remarks>
        public byte FrontColorR
        {
            get => (byte)CellsByName["FrontColorR"].Value;
            set => CellsByName["FrontColorR"].Value = value;
        }


        // Def="u8 frontColorG"
        /// <summary>
        /// Front Color: G (u8)
        /// </summary>
        /// <remarks>
        /// The front color is G.
        /// </remarks>
        public byte FrontColorG
        {
            get => (byte)CellsByName["FrontColorG"].Value;
            set => CellsByName["FrontColorG"].Value = value;
        }


        // Def="u8 frontColorB"
        /// <summary>
        /// Front Color: B (u8)
        /// </summary>
        /// <remarks>
        /// Front color B.
        /// </remarks>
        public byte FrontColorB
        {
            get => (byte)CellsByName["FrontColorB"].Value;
            set => CellsByName["FrontColorB"].Value = value;
        }


        // Def="u8 diffMulColorR = 255"
        /// <summary>
        /// Diffuse Color: R (u8)
        /// </summary>
        /// <remarks>
        /// Diffuse multiplication color R.
        /// </remarks>
        public byte DiffuseColorR
        {
            get => (byte)CellsByName["DiffuseColorR"].Value;
            set => CellsByName["DiffuseColorR"].Value = value;
        }


        // Def="u8 diffMulColorG = 255"
        /// <summary>
        /// Diffuse Color: G (u8)
        /// </summary>
        /// <remarks>
        /// Diffuse multiplication color G.
        /// </remarks>
        public byte DiffuseColorG
        {
            get => (byte)CellsByName["DiffuseColorG"].Value;
            set => CellsByName["DiffuseColorG"].Value = value;
        }


        // Def="u8 diffMulColorB = 255"
        /// <summary>
        /// Diffuse Color: B (u8)
        /// </summary>
        /// <remarks>
        /// Diffuse multiplication color B.
        /// </remarks>
        public byte DiffuseColorB
        {
            get => (byte)CellsByName["DiffuseColorB"].Value;
            set => CellsByName["DiffuseColorB"].Value = value;
        }


        // Def="u8 specMulColorR = 255"
        /// <summary>
        /// Specular Color: R (u8)
        /// </summary>
        /// <remarks>
        /// Specular multiplication color R.
        /// </remarks>
        public byte SpecularColorR
        {
            get => (byte)CellsByName["SpecularColorR"].Value;
            set => CellsByName["SpecularColorR"].Value = value;
        }


        // Def="u8 specMulColorG = 255"
        /// <summary>
        /// Specular Color: G (u8)
        /// </summary>
        /// <remarks>
        /// Specular multiplication color G.
        /// </remarks>
        public byte SpecularColorG
        {
            get => (byte)CellsByName["SpecularColorG"].Value;
            set => CellsByName["SpecularColorG"].Value = value;
        }


        // Def="u8 specMulColorB = 255"
        /// <summary>
        /// Specular Color: B (u8)
        /// </summary>
        /// <remarks>
        /// Specular multiplication color B.
        /// </remarks>
        public byte SpecularColorB
        {
            get => (byte)CellsByName["SpecularColorB"].Value;
            set => CellsByName["SpecularColorB"].Value = value;
        }


        // Def="u8 lightColorR"
        /// <summary>
        /// Light Color: R (u8)
        /// </summary>
        /// <remarks>
        /// Light color R.
        /// </remarks>
        public byte LightColorR
        {
            get => (byte)CellsByName["LightColorR"].Value;
            set => CellsByName["LightColorR"].Value = value;
        }


        // Def="u8 lightColorG"
        /// <summary>
        /// Light Color: G (u8)
        /// </summary>
        /// <remarks>
        /// Light color G.
        /// </remarks>
        public byte LightColorG
        {
            get => (byte)CellsByName["LightColorG"].Value;
            set => CellsByName["LightColorG"].Value = value;
        }


        // Def="u8 lightColorB"
        /// <summary>
        /// Light Color: B (u8)
        /// </summary>
        /// <remarks>
        /// Light color B.
        /// </remarks>
        public byte LightColorB
        {
            get => (byte)CellsByName["LightColorB"].Value;
            set => CellsByName["LightColorB"].Value = value;
        }


        // Def="dummy8 reserve[1]"
        /// <summary>
        /// Reserve (dummy8)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object Reserve
        {
            get => (object)CellsByName["Reserve"].Value;
            set => CellsByName["Reserve"].Value = value;
        }


        // Def="f32 alpha = 1"
        /// <summary>
        /// Overall Alpha (f32)
        /// </summary>
        /// <remarks>
        /// The overall transparency.
        /// </remarks>
        public float OverallAlpha
        {
            get => (float)CellsByName["OverallAlpha"].Value;
            set => CellsByName["OverallAlpha"].Value = value;
        }


        // Def="f32 blendRate = 1"
        /// <summary>
        /// Blend Rate (f32)
        /// </summary>
        /// <remarks>
        /// The blend ratio.
        /// </remarks>
        public float BlendRate
        {
            get => (float)CellsByName["BlendRate"].Value;
            set => CellsByName["BlendRate"].Value = value;
        }


        // Def="u8 blendType"
        /// <summary>
        /// Blend Type (u8)
        /// </summary>
        /// <remarks>
        /// The type of alpha blend.
        /// </remarks>
        public byte BlendType
        {
            get => (byte)CellsByName["BlendType"].Value;
            set => CellsByName["BlendType"].Value = value;
        }


        // Def="u8 isEdgeSubtract"
        /// <summary>
        /// Perform Edge Color Subtraction (u8)
        /// </summary>
        /// <remarks>
        /// Whether to perform edge color subtraction.
        /// </remarks>
        public byte PerformEdgeColorSubtraction
        {
            get => (byte)CellsByName["PerformEdgeColorSubtraction"].Value;
            set => CellsByName["PerformEdgeColorSubtraction"].Value = value;
        }


        // Def="u8 isFrontSubtract"
        /// <summary>
        /// Perform Front Color Subtraction (u8)
        /// </summary>
        /// <remarks>
        /// Is it front color subtraction?
        /// </remarks>
        public byte PerformFrontColorSubtraction
        {
            get => (byte)CellsByName["PerformFrontColorSubtraction"].Value;
            set => CellsByName["PerformFrontColorSubtraction"].Value = value;
        }


        // Def="u8 isNo2Pass"
        /// <summary>
        /// Is 1 Pass Only (u8)
        /// </summary>
        /// <remarks>
        /// Do you not do 2pass?
        /// </remarks>
        public byte Is1PassOnly
        {
            get => (byte)CellsByName["Is1PassOnly"].Value;
            set => CellsByName["Is1PassOnly"].Value = value;
        }


        // Def="f32 edgePower = 1"
        /// <summary>
        /// Edge Width (f32)
        /// </summary>
        /// <remarks>
        /// Edge width
        /// </remarks>
        public float EdgeWidth
        {
            get => (float)CellsByName["EdgeWidth"].Value;
            set => CellsByName["EdgeWidth"].Value = value;
        }


        // Def="f32 glowScale"
        /// <summary>
        /// Glow Strength (f32)
        /// </summary>
        /// <remarks>
        /// Glow strength
        /// </remarks>
        public float GlowStrength
        {
            get => (float)CellsByName["GlowStrength"].Value;
            set => CellsByName["GlowStrength"].Value = value;
        }

    }
}
