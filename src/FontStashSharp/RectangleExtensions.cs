namespace FontStashSharp;

#if RAYLIB
internal static class RectangleExtensions
{
  public static float Left(this Rectangle rectangle)
  {
	return rectangle.X;
  }

  public static float Right(this Rectangle rectangle)
  {
	return rectangle.X + rectangle.Width;
  }

  public static float Bottom(this Rectangle rectangle)
  {
	return rectangle.Y + rectangle.Height;
  }
}
#endif
