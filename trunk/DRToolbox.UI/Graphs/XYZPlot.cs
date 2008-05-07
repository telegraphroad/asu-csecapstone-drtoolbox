using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;

namespace DRToolbox.UI.Graphs
{
    #region Structs
    public struct VertexPositionNormalColored
    {
        #region Global Objects
        public Vector3 Position;
        public Color Color;
        public Vector3 Normal;
        #endregion

        #region Global Constants
        public static int SizeInBytes = 28;
        #endregion

        #region Struct Methods
        public static VertexElement[] VertexElements = new VertexElement[]
        {
            new VertexElement( 0, 0, VertexElementFormat.Vector3, VertexElementMethod.Default, VertexElementUsage.Position, 0 ),
            new VertexElement( 0, sizeof(float) * 3, VertexElementFormat.Color, VertexElementMethod.Default, VertexElementUsage.Color, 0 ),
            new VertexElement( 0, sizeof(float) * 4, VertexElementFormat.Vector3, VertexElementMethod.Default, VertexElementUsage.Normal, 0 ),
        };
        #endregion
    }
    #endregion

    #region Classes
    public class XYZPlotter : Microsoft.Xna.Framework.Game
    {
        #region Class Objects
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        BasicEffect basicEffect;
        Vector3 cameraPosition;
        Vector3 cameraTarget;
        Vector3 cameraUp;
        Matrix proj;
        Matrix view;
        VertexBuffer vb;
        IndexBuffer ib;
        CollisionMesh collision1;
        #endregion

        #region Global Vars
        float speed = 0.1f;
        bool isViewChanged = false;
        int previousWheel = 0;
        int previousX;
        int previousY;
        bool pressed = false;
        #endregion

        #region Constructors
        public XYZPlotter()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            this.IsMouseVisible = true;
        }
        #endregion

        #region Class Methods
        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            #region Camera
            float aspectRatio = (float)graphics.GraphicsDevice.Viewport.Width / (float)graphics.GraphicsDevice.Viewport.Height;
            proj = Matrix.CreatePerspectiveFieldOfView(MathHelper.ToRadians(45f), aspectRatio, 1f, 100000.0f);
            cameraPosition = new Vector3(0.0f, 0, 20.0f);
            cameraTarget = Vector3.Zero;
            cameraUp = Vector3.Up;
            view = Matrix.CreateLookAt(cameraPosition, cameraTarget, cameraUp);
            #endregion

            #region CreateEffect
            basicEffect = new BasicEffect(graphics.GraphicsDevice, null);
            basicEffect.Alpha = 1.0f;
            basicEffect.DiffuseColor = new Vector3(1.0f, 1.0f, 1.0f);
            basicEffect.SpecularColor = new Vector3(0.25f, 0.25f, 0.25f);
            basicEffect.SpecularPower = 5.0f;
            basicEffect.AmbientLightColor = new Vector3(0.75f, 0.75f, 0.75f);

            basicEffect.DirectionalLight0.Enabled = true;
            basicEffect.DirectionalLight0.DiffuseColor = Vector3.One;
            basicEffect.DirectionalLight0.Direction = Vector3.Normalize(new Vector3(1.0f, -1.0f, -1.0f));
            basicEffect.DirectionalLight0.SpecularColor = Vector3.One;

            basicEffect.DirectionalLight1.Enabled = true;
            basicEffect.DirectionalLight1.DiffuseColor = new Vector3(0.5f, 0.5f, 0.5f);
            basicEffect.DirectionalLight1.Direction = Vector3.Normalize(new Vector3(-1.0f, -1.0f, 1.0f));
            basicEffect.DirectionalLight1.SpecularColor = new Vector3(0.5f, 0.5f, 0.5f);

            basicEffect.VertexColorEnabled = true;
            basicEffect.LightingEnabled = true;
            basicEffect.View = view;
            basicEffect.Projection = proj;
            #endregion

            collision1 = CollisionMesh.BoxPrimitive(8, 8, 8, new Vector3(0, 0, 0), Vector3.Zero);

            #region Vertex Buffer
            VertexPositionNormalColored[] vertices = new VertexPositionNormalColored[16];
            for (int i = 0; i < 8; i++)
            {
                vertices[i].Position = collision1.Vertices[i];
                vertices[i].Color = Color.Goldenrod;
                vertices[i].Normal = vertices[i].Position;
                vertices[i].Normal.Normalize();
                //vertices[i + 8].Position = collision2.Vertices[i];
                //vertices[i + 8].Color = Color.Black;
                //vertices[i + 8].Normal = vertices[i + 8].Position;
                //vertices[i + 8].Normal.Normalize();
            }
            vb = new VertexBuffer(graphics.GraphicsDevice, VertexPositionNormalColored.SizeInBytes * 16, BufferUsage.WriteOnly);
            vb.SetData(vertices); 
            #endregion

            #region Index Buffer
            int[] indices = new int[72];
            for (int i = 0; i < 36; i++)
            {
                indices[i] = collision1.Indices[i];
                //indices[i + 36] = collision2.Indices[i];
            }
            ib = new IndexBuffer(graphics.GraphicsDevice, typeof(int), 72, BufferUsage.WriteOnly);
            ib.SetData(indices); 
            #endregion

            collision1.RefreshMatrix();

            graphics.GraphicsDevice.RenderState.CullMode = CullMode.None;
            graphics.GraphicsDevice.Vertices[0].SetSource(vb, 0, VertexPositionNormalColored.SizeInBytes);
            graphics.GraphicsDevice.Indices = ib;
            graphics.GraphicsDevice.VertexDeclaration = new VertexDeclaration(graphics.GraphicsDevice, VertexPositionNormalColored.VertexElements);
        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {
            KeyboardState keys = Keyboard.GetState();
            #region Collision1
            if (keys.IsKeyDown(Keys.W))
            {
                collision1.Rotation.X += 0.01f;
                collision1.isChanged = true;
            }
            else if (keys.IsKeyDown(Keys.S))
            {
                collision1.Rotation.X -= 0.01f;
                collision1.isChanged = true;
            }

            if (keys.IsKeyDown(Keys.A))
            {
                collision1.Rotation.Y += 0.01f;
                collision1.isChanged = true;
            }
            else if (keys.IsKeyDown(Keys.D))
            {
                collision1.Rotation.Y -= 0.01f;
                collision1.isChanged = true;
            }

            if (keys.IsKeyDown(Keys.Q))
            {
                collision1.Rotation.Z += 0.01f;
                collision1.isChanged = true;
            }
            else if (keys.IsKeyDown(Keys.E))
            {
                collision1.Rotation.Z -= 0.01f;
                collision1.isChanged = true;
            }
            #endregion
            MouseState mouse = Mouse.GetState();

            #region View
            int buffer = previousWheel - mouse.ScrollWheelValue;
            if (buffer != 0)
            {
                Vector3 toAdd;
                Vector3.Normalize(ref cameraPosition, out toAdd);
                cameraPosition += toAdd * buffer * 0.00005f * cameraPosition.LengthSquared();
                previousWheel = mouse.ScrollWheelValue;
                isViewChanged = true;
            }

            if (mouse.LeftButton == ButtonState.Pressed)
            {
                if (!pressed)
                {
                    previousY = mouse.Y;
                    previousX = mouse.X;
                    pressed = true;
                }

                buffer = previousY - mouse.Y;
                if (buffer != 0)
                {
                    Matrix matrix;
                    Matrix.CreateRotationX((float)(Math.PI / 180.0f * buffer), out matrix);
                    Vector3.Transform(ref cameraPosition, ref matrix, out cameraPosition);
                    isViewChanged = true;
                    previousY = mouse.Y;
                }

                buffer = previousX - mouse.X;
                if (buffer != 0)
                {
                    Matrix matrix;
                    Matrix.CreateRotationY((float)(Math.PI / 180.0f * buffer), out matrix);
                    Vector3.Transform(ref cameraPosition, ref matrix, out cameraPosition);
                    isViewChanged = true;
                    previousX = mouse.X;
                }
            }

            if ((mouse.LeftButton == ButtonState.Released) && (pressed))
                pressed = false;
            #endregion

            if (isViewChanged)
            {
                Matrix.CreateLookAt(ref cameraPosition, ref cameraTarget, ref cameraUp, out view);
                basicEffect.View = view;
                isViewChanged = false;
            }
            collision1.RefreshMatrix();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            graphics.GraphicsDevice.Clear(Color.Black);
            basicEffect.World = collision1.WorldMatrix;
            basicEffect.Begin();
            foreach (EffectPass pass in basicEffect.CurrentTechnique.Passes)
            {
                pass.Begin();

                graphics.GraphicsDevice.DrawIndexedPrimitives(PrimitiveType.LineList, 0, 0, 8, 0, 6);

                pass.End();
            }
            basicEffect.End();

            base.Draw(gameTime);
        }
        #endregion
    }

    public class CollisionMesh
    {
        #region Class Objects
        public Vector3[] Vertices;        
        public Vector3 Position;
        public Vector3 Rotation;
        public Matrix WorldMatrix;
        #endregion

        #region Class Vars
        public byte[] Indices;
        public byte[] IndicesOfEdges;
        public bool isChanged;
        static readonly float TOWORK = 0.99f;
        #endregion

        #region Constructors
        public CollisionMesh(Vector3 position, Vector3 rotation)
        {
            Position = position;
            Rotation = rotation;
            isChanged = true;
            RefreshMatrix();
        }
        #endregion

        #region Class Methods
        public void RefreshMatrix()
        {
            if (isChanged)
            {
                WorldMatrix = Matrix.CreateFromYawPitchRoll(Rotation.X, Rotation.Y, Rotation.Z) * Matrix.CreateTranslation(Position);
                isChanged = false;
            }
        }

        public static CollisionMesh BoxPrimitive(float a, float b, float c, Vector3 position, Vector3 rotation)
        {
            CollisionMesh collision = new CollisionMesh(position, rotation);

            #region Vertices
            collision.Vertices = new Vector3[8];

            collision.Vertices[0].X = -a / 2;
            collision.Vertices[0].Y = b / 2;
            collision.Vertices[0].Z = c / 2;

            collision.Vertices[1].X = a / 2;
            collision.Vertices[1].Y = b / 2;
            collision.Vertices[1].Z = c / 2;

            collision.Vertices[2].X = a / 2;
            collision.Vertices[2].Y = -b / 2;
            collision.Vertices[2].Z = c / 2;

            collision.Vertices[3].X = -a / 2;
            collision.Vertices[3].Y = -b / 2;
            collision.Vertices[3].Z = c / 2;

            collision.Vertices[4].X = -a / 2;
            collision.Vertices[4].Y = b / 2;
            collision.Vertices[4].Z = -c / 2;

            collision.Vertices[5].X = a / 2;
            collision.Vertices[5].Y = b / 2;
            collision.Vertices[5].Z = -c / 2;

            collision.Vertices[6].X = a / 2;
            collision.Vertices[6].Y = -b / 2;
            collision.Vertices[6].Z = -c / 2;

            collision.Vertices[7].X = -a / 2;
            collision.Vertices[7].Y = -b / 2;
            collision.Vertices[7].Z = -c / 2;
            #endregion

            #region Indices
            collision.Indices = new byte[36];

            collision.Indices[0] = 0;
            collision.Indices[1] = 1;
            collision.Indices[2] = 2;

            collision.Indices[3] = 2;
            collision.Indices[4] = 3;
            collision.Indices[5] = 0;

            collision.Indices[6] = 0;
            collision.Indices[7] = 4;
            collision.Indices[8] = 5;

            collision.Indices[9] = 5;
            collision.Indices[10] = 1;
            collision.Indices[11] = 0;

            collision.Indices[12] = 2;
            collision.Indices[13] = 1;
            collision.Indices[14] = 5;

            collision.Indices[15] = 5;
            collision.Indices[16] = 6;
            collision.Indices[17] = 2;

            collision.Indices[18] = 3;
            collision.Indices[19] = 2;
            collision.Indices[20] = 6;

            collision.Indices[21] = 6;
            collision.Indices[22] = 7;
            collision.Indices[23] = 3;

            collision.Indices[24] = 0;
            collision.Indices[25] = 3;
            collision.Indices[26] = 7;

            collision.Indices[27] = 7;
            collision.Indices[28] = 4;
            collision.Indices[29] = 0;

            collision.Indices[30] = 7;
            collision.Indices[31] = 6;
            collision.Indices[32] = 5;

            collision.Indices[33] = 5;
            collision.Indices[34] = 4;
            collision.Indices[35] = 7;
            #endregion

            #region IndicesOfEdges
            collision.IndicesOfEdges = new byte[24];
            collision.IndicesOfEdges[0] = 0;
            collision.IndicesOfEdges[1] = 1;

            collision.IndicesOfEdges[2] = 1;
            collision.IndicesOfEdges[3] = 2;

            collision.IndicesOfEdges[4] = 2;
            collision.IndicesOfEdges[5] = 3;

            collision.IndicesOfEdges[6] = 3;
            collision.IndicesOfEdges[7] = 0;

            collision.IndicesOfEdges[8] = 4;
            collision.IndicesOfEdges[9] = 5;

            collision.IndicesOfEdges[10] = 5;
            collision.IndicesOfEdges[11] = 6;

            collision.IndicesOfEdges[12] = 6;
            collision.IndicesOfEdges[13] = 7;

            collision.IndicesOfEdges[14] = 7;
            collision.IndicesOfEdges[15] = 4;

            collision.IndicesOfEdges[16] = 0;
            collision.IndicesOfEdges[17] = 4;

            collision.IndicesOfEdges[18] = 1;
            collision.IndicesOfEdges[19] = 5;

            collision.IndicesOfEdges[20] = 2;
            collision.IndicesOfEdges[21] = 6;

            collision.IndicesOfEdges[22] = 3;
            collision.IndicesOfEdges[23] = 7;
            #endregion

            return collision;
        }

        public static bool CheckPlaneIntersection(Vector3 oldPoint, Vector3 newPoint, Vector3 A, Vector3 B, Vector3 C)
        {
            oldPoint -= B;
            newPoint -= B;
            A -= B;
            C -= B;
            Vector3 normal = Vector3.Cross(A, C);
            float buff1 = Vector3.Dot(oldPoint, normal);
            float buff2 = Vector3.Dot(newPoint, normal);
            return ((buff1 >= 0) && (buff2 <= 0));
        }

        public static bool CheckPlaneIntersection2(Vector3 oldPoint, Vector3 newPoint, Vector3 A, Vector3 B, Vector3 C)
        {
            oldPoint -= B;
            newPoint -= B;
            A -= B;
            C -= B;
            Vector3 normal = Vector3.Cross(A*1000, C*1000);
            if (normal == Vector3.Zero)
            {
                return false;
            }
            else
            {
                float buff1 = Vector3.Dot(oldPoint, normal);
                float buff2 = Vector3.Dot(newPoint, normal);
                //now the vertices only have to be on the opposite side so we need
                //and additional “or”
                return (((buff1 >= 0) && (buff2 <= 0)) || ((buff1 <= 0) && (buff2 >= 0)));
            }
        }

        public static bool CheckRayTriangleIntersection(Vector3 oldPoint, Vector3 newPoint, Vector3 A, Vector3 B, Vector3 C)
        {
            Vector3 O, N, V, Cross;

            V = B - A;
            O = oldPoint - A;
            N = newPoint - A;
            Cross = Vector3.Cross(V, O);
            if (Vector3.Dot(Cross, N) <= 0f)
                return false;
            else
            {
                V = C - B;
                O = oldPoint - B;
                N = newPoint - B;
                Cross = Vector3.Cross(V, O);
                if (Vector3.Dot(Cross, N) <= 0f)
                    return false;
                else
                {
                    V = A - C;
                    O = oldPoint - C;
                    N = newPoint - C;
                    Cross = Vector3.Cross(V, O);
                    if (Vector3.Dot(Cross, N) <= 0f)
                        return false;
                    else
                        return true;
                }
            }

        }

        public static bool CheckRayTriangleIntersection(Vector3 oldPoint, Vector3 newPoint, Vector3 A, Vector3 B, Vector3 C, Vector3 D)
        {
            Vector3 O, N, V, Cross;

            V = B - A;
            O = oldPoint - A;
            N = newPoint - A;
            Cross = Vector3.Cross(V, O);
            
            if (Vector3.Dot(Cross, N) < 0f)
            {
                V = C - B;
                O = oldPoint - B;
                N = newPoint - B;
                Cross = Vector3.Cross(V, O);
                if (Vector3.Dot(Cross, N) >= 0f)
                {
                    return false;
                }
                else
                {
                    V = D - C;
                    O = oldPoint - C;
                    N = newPoint - C;
                    Cross = Vector3.Cross(V, O);
                    if (Vector3.Dot(Cross, N) >= 0f)
                    {
                        return false;
                    }
                    else
                    {
                        V = A - D;
                        O = oldPoint - D;
                        N = newPoint - D;
                        Cross = Vector3.Cross(V, O);
                        if (Vector3.Dot(Cross, N) >= 0f)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
            }
            else
            {
                V = C - B;
                O = oldPoint - B;
                N = newPoint - B;
                Cross = Vector3.Cross(V, O);
                if (Vector3.Dot(Cross, N) <= 0f)
                {
                    return false;
                }
                else
                {
                    V = D - C;
                    O = oldPoint - C;
                    N = newPoint - C;
                    Cross = Vector3.Cross(V, O);
                    if (Vector3.Dot(Cross, N) <= 0f)
                    {
                        return false;
                    }
                    else
                    {
                        V = A - D;
                        O = oldPoint - D;
                        N = newPoint - D;
                        Cross = Vector3.Cross(V, O);
                        if (Vector3.Dot(Cross, N) <= 0f)
                        {
                            return false;
                        }
                        else
                            return true;
                    }
                }
            }
        }

        public static float Intersection(Vector3 LinePoint1, Vector3 dir, Vector3 A, Vector3 B, Vector3 C)
        {
            Vector3 normal = Vector3.Cross(A-B,C-B);
            Vector3 org = LinePoint1 - B;
            float U = -Vector3.Dot(org, normal) / Vector3.Dot(dir, normal);
            return U;
        }

        public Vector3[] ReturnWorldVertices()
        {
            Vector3[] worldVertices = new Vector3[Vertices.Length];
            for (byte i = 0; i < Vertices.Length; i++)
            {
                worldVertices[i] = Vector3.Transform(Vertices[i], WorldMatrix);
            }
            return worldVertices;
        }
        
        public Vector3 EdgeIntersection(Vector3 A, Vector3 B, Vector3 E, Vector3 movement)
        {
            float dirx = B.X - A.X;
            float diry = B.Y - A.Y;
            float t = ((A.Y - E.Y) * dirx + (E.X - A.X) * diry) / (movement.Y * dirx - movement.X * diry);
            Vector3 point = E + movement * t;
            point = E - point;
            return point;
        }

        public void Move(Vector3 movement, CollisionMesh otherMesh)
        {
            Vector3[] This = ReturnWorldVertices();
            Vector3[] Other = otherMesh.ReturnWorldVertices();
            Vector3[] New = new Vector3[This.Length];

            bool changed = true;
            int index = -1;
            for (int i = 0; i < This.Length; i++)
            {
                if (changed)
                {
                    if (index == i)
                    {
                        changed = false;
                    }
                    else
                    {
                        New[i] = This[i] + movement;
                    }
                }
                for (int j = 0; j < otherMesh.Indices.Length; j += 3)
                {
                    if ((CheckPlaneIntersection(This[i], New[i], Other[otherMesh.Indices[j]], Other[otherMesh.Indices[j + 1]], Other[otherMesh.Indices[j + 2]])) &&
                        (CheckRayTriangleIntersection(This[i], New[i], Other[otherMesh.Indices[j]], Other[otherMesh.Indices[j + 1]], Other[otherMesh.Indices[j + 2]])))
                    {
                        movement = movement * (Intersection(This[i], movement, Other[otherMesh.Indices[j]], Other[otherMesh.Indices[j + 1]], Other[otherMesh.Indices[j + 2]]) * TOWORK);
                        changed = true;
                        New[i] = This[i] + movement;
                        index = i;
                    }
                }
            }

            Vector3[] OtherMoved = new Vector3[Other.Length];
            index = -1;
            changed = true;
            for (int i = 0; i < Other.Length; i++)
            {
                if (changed)
                {
                    if (index == i)
                    {
                        changed = false;
                    }
                    else
                    {
                        OtherMoved[i] = Other[i] - movement;
                    }

                }
                for (int j = 0; j < Indices.Length; j += 3)
                {
                    if ((CheckPlaneIntersection(Other[i], OtherMoved[i], This[Indices[j]], This[Indices[j + 1]], This[Indices[j + 2]])) &&
                        (CheckRayTriangleIntersection(Other[i], OtherMoved[i], This[Indices[j]], This[Indices[j + 1]], This[Indices[j + 2]])))
                    {
                        movement = movement * (Intersection(Other[i], -movement, This[Indices[j]], This[Indices[j + 1]], This[Indices[j + 2]]) * TOWORK);
                        changed = true;
                        OtherMoved[i] = Other[i] - movement;
                        index = i;
                    }
                }
            }

            int l = 0;
            while ((changed) && (l < This.Length))
            {
                if (index == l)
                {
                    changed = false;
                }
                else
                {
                    New[l] = This[l] + movement;
                }
                l++;
            }

            for (int i = 0; i < otherMesh.IndicesOfEdges.Length; i+=2)
            {
                for (int j = 0; j < IndicesOfEdges.Length; j += 2)
                {
                    if ((CheckPlaneIntersection2(Other[otherMesh.IndicesOfEdges[i]], Other[otherMesh.IndicesOfEdges[i+1]], This[IndicesOfEdges[j]], New[IndicesOfEdges[j+1]], This[IndicesOfEdges[j+1]])) &&
                        (CheckRayTriangleIntersection(Other[otherMesh.IndicesOfEdges[i]], Other[otherMesh.IndicesOfEdges[i + 1]], This[IndicesOfEdges[j]], This[IndicesOfEdges[j + 1]], New[IndicesOfEdges[j + 1]], New[IndicesOfEdges[j]])))
                    {
                        Vector3 direction = Other[otherMesh.IndicesOfEdges[i+1]] - Other[otherMesh.IndicesOfEdges[i]];
                        float U = Intersection(Other[otherMesh.IndicesOfEdges[i]], direction, This[IndicesOfEdges[j]], New[IndicesOfEdges[j+1]], This[IndicesOfEdges[j+1]]);
                        Vector3 Point = Other[otherMesh.IndicesOfEdges[i]] + U * direction;
                        movement = EdgeIntersection(This[IndicesOfEdges[j]], This[IndicesOfEdges[j + 1]], Point, movement) * TOWORK;

                        for (int k = 0; k < This.Length; k++)
                        {
                            New[k] = This[k] + movement;
                        }
                    }
                }
            }

            if (movement.Length() > 0.0001f)
            {
                Position += movement;
                isChanged = true;
                RefreshMatrix();
            }
        }
        #endregion
    }
    #endregion
}