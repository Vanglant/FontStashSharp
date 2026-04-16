#if MONOGAME || FNA || XNA
global using Microsoft.Xna.Framework;
global using Microsoft.Xna.Framework.Graphics;
global using static Microsoft.Xna.Framework.Graphics.SpriteFont;
#elif STRIDE
global using Stride.Core.Mathematics;
global using Stride.Graphics;
global using Texture2D = Stride.Graphics.Texture;
#elif RAYLIB
global using Raylib_cs;
global using System.Numerics;
global using Color = Raylib_cs.Color;
global using Matrix = System.Numerics.Matrix3x2;
global using Point = System.Numerics.Vector2;
global using Rectangle = Raylib_cs.Rectangle;
global using Texture2D = Raylib_cs.Texture2D;
#else
global using System.Drawing;
global using System.Numerics;
global using Color = FontStashSharp.FSColor;
global using Matrix = System.Numerics.Matrix3x2;
global using Texture2D = System.Object;
#endif