namespace FontStashSharp.Interfaces
{
  public interface IFontStashRenderer
  {
#if MONOGAME || FNA || XNA || STRIDE
		GraphicsDevice GraphicsDevice { get; }
#else
	ITexture2DManager TextureManager { get; }
#endif

	void Draw(Texture2D texture, Vector2 pos, Rectangle? src, Color color, float rotation, Vector2 scale, float depth);
  }
}
