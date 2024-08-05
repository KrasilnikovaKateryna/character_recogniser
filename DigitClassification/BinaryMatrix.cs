namespace DigitClassification;

public class BinaryMatrix
{
    private double[,] _matrix;

    private BinaryMatrix()
    {
    }

    private BinaryMatrix(Bitmap image, float threshold)
    {
        if (image.PixelFormat != System.Drawing.Imaging.PixelFormat.Format8bppIndexed)
            throw new ArgumentException("Image must be 8bpIndexed format", nameof(image));

        _matrix = image.CreateMatrix(threshold);
    }

    // conversion of the matrix into a one-dimensional array with validation
    public void Flatten(Action<double[]> onValid)
    {
        if (_matrix == null) return;

        onValid(_matrix.Flatten());
    }

    public static BinaryMatrix Create(Bitmap image, float threshold) => new(image, threshold);
    public static BinaryMatrix Empty() => new();
}