
            namespace StronglyTypedParams
            {
                public class MenuOffscrRendParam : ParamRow
                {
                    public MenuOffscrRendParam() : base()
                    {
                    }
            

            // Def="f32 camAtPosX"
            /// <summary>
            /// Camera Gaze Point: X (f32)
            /// </summary>
            /// <remarks>
            /// Camera gaze point X
            /// </remarks>
            public float CameraGazePointX 
            {
                get => (float)CellsByName["CameraGazePointX"].Value;
                set => CellsByName["CameraGazePointX"].Value = value;
            }
            

            // Def="f32 camAtPosY"
            /// <summary>
            /// Camera Gaze Point: Y (f32)
            /// </summary>
            /// <remarks>
            /// Camera gaze point Y
            /// </remarks>
            public float CameraGazePointY 
            {
                get => (float)CellsByName["CameraGazePointY"].Value;
                set => CellsByName["CameraGazePointY"].Value = value;
            }
            

            // Def="f32 camAtPosZ"
            /// <summary>
            /// Camera Gaze Point: Z (f32)
            /// </summary>
            /// <remarks>
            /// Camera gaze point Z
            /// </remarks>
            public float CameraGazePointZ 
            {
                get => (float)CellsByName["CameraGazePointZ"].Value;
                set => CellsByName["CameraGazePointZ"].Value = value;
            }
            

            // Def="f32 camDist = 10"
            /// <summary>
            /// Camera Distance (f32)
            /// </summary>
            /// <remarks>
            /// Camera distance
            /// </remarks>
            public float CameraDistance 
            {
                get => (float)CellsByName["CameraDistance"].Value;
                set => CellsByName["CameraDistance"].Value = value;
            }
            

            // Def="f32 camRotX"
            /// <summary>
            /// Camera Rotation: X (f32)
            /// </summary>
            /// <remarks>
            /// Camera oriented X
            /// </remarks>
            public float CameraRotationX 
            {
                get => (float)CellsByName["CameraRotationX"].Value;
                set => CellsByName["CameraRotationX"].Value = value;
            }
            

            // Def="f32 camRotY"
            /// <summary>
            /// Camera Rotation: Y (f32)
            /// </summary>
            /// <remarks>
            /// Suitable for camera Y
            /// </remarks>
            public float CameraRotationY 
            {
                get => (float)CellsByName["CameraRotationY"].Value;
                set => CellsByName["CameraRotationY"].Value = value;
            }
            

            // Def="f32 camFov = 49"
            /// <summary>
            /// Camera Field of View (f32)
            /// </summary>
            /// <remarks>
            /// Camera angle of view
            /// </remarks>
            public float CameraFieldOfView 
            {
                get => (float)CellsByName["CameraFieldOfView"].Value;
                set => CellsByName["CameraFieldOfView"].Value = value;
            }
            

            // Def="f32 camDistMin"
            /// <summary>
            /// Camera Distance - Minimum (f32)
            /// </summary>
            /// <remarks>
            /// Shortest distance when operating the camera
            /// </remarks>
            public float CameraDistanceMinimum 
            {
                get => (float)CellsByName["CameraDistanceMinimum"].Value;
                set => CellsByName["CameraDistanceMinimum"].Value = value;
            }
            

            // Def="f32 camDistMax = 100"
            /// <summary>
            /// Camera Distance - Maximum (f32)
            /// </summary>
            /// <remarks>
            /// Longest distance when operating the camera
            /// </remarks>
            public float CameraDistanceMaximum 
            {
                get => (float)CellsByName["CameraDistanceMaximum"].Value;
                set => CellsByName["CameraDistanceMaximum"].Value = value;
            }
            

            // Def="f32 camRotXMin = -89"
            /// <summary>
            /// Camera Rotation - Minimum (f32)
            /// </summary>
            /// <remarks>
            /// Minimum orientation when operating the camera
            /// </remarks>
            public float CameraRotationMinimum 
            {
                get => (float)CellsByName["CameraRotationMinimum"].Value;
                set => CellsByName["CameraRotationMinimum"].Value = value;
            }
            

            // Def="f32 camRotXMax = 89"
            /// <summary>
            /// Camera Rotation - Maximum (f32)
            /// </summary>
            /// <remarks>
            /// Maximum orientation when operating the camera
            /// </remarks>
            public float CameraRotationMaximum 
            {
                get => (float)CellsByName["CameraRotationMaximum"].Value;
                set => CellsByName["CameraRotationMaximum"].Value = value;
            }
            

            // Def="u32 GparamID = 10"
            /// <summary>
            /// GPARAM ID (u32)
            /// </summary>
            /// <remarks>
            /// GparamID
            /// </remarks>
            public uint GPARAMID 
            {
                get => (uint)CellsByName["GPARAMID"].Value;
                set => CellsByName["GPARAMID"].Value = value;
            }
            

            // Def="u32 envTexId = 10"
            /// <summary>
            /// Env Texture ID (u32)
            /// </summary>
            /// <remarks>
            /// Environment map texture ID. It corresponds to 4 digits of N: \ GR \ data \ Other \ SysEnvTex \ GILM ???? _rem.dds.
            /// </remarks>
            public uint EnvTextureID 
            {
                get => (uint)CellsByName["EnvTextureID"].Value;
                set => CellsByName["EnvTextureID"].Value = value;
            }
            

            // Def="u32 Grapm_ID_forPS4 = 10"
            /// <summary>
            /// GPARAM ID - PS4 (u32)
            /// </summary>
            /// <remarks>
            /// Gparam ID (for PS4)
            /// </remarks>
            public uint GPARAMIDPS4 
            {
                get => (uint)CellsByName["GPARAMIDPS4"].Value;
                set => CellsByName["GPARAMIDPS4"].Value = value;
            }
            

            // Def="u32 Grapm_ID_forXB1 = 10"
            /// <summary>
            /// GPARAM ID - XB1 (u32)
            /// </summary>
            /// <remarks>
            /// Gparam ID (for Xbox One)
            /// </remarks>
            public uint GPARAMIDXB1 
            {
                get => (uint)CellsByName["GPARAMIDXB1"].Value;
                set => CellsByName["GPARAMIDXB1"].Value = value;
            }
            

            // Def="dummy8 pad[4]"
            /// <summary>
            /// reserve (dummy8)
            /// </summary>
            /// <remarks>
            /// reserve
            /// </remarks>
            public object Reserve 
            {
                get => (object)CellsByName["Reserve"].Value;
                set => CellsByName["Reserve"].Value = value;
            }
            
                }
            }
            