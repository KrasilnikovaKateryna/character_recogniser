namespace DigitClassification;

using System.Drawing;

public static class BitmapExtensions
{
    // creating a matrix from the bitmap
    public static double[,] CreateMatrix(this Bitmap image, float threshold)
    {
        var matrix = new double[image.Width, image.Height];
        for (int y = 0; y < image.Height; y++)
        {
            for (int x = 0; x < image.Width; x++)
            {
                // determination of pixel brightness
                var brightness = image.GetPixel(x, y).GetBrightness();
                if (brightness < threshold)
                    matrix[x, y] = 0.0;
                else
                    matrix[x, y] = 1.0;
            }
        }

        return matrix;
    }
}