using System.Text;

namespace DigitClassification;

public static class DoubleArrayExtensions
{
    // conversion of the matrix into a one-dimensional array
    public static double[] Flatten(this double[,] matrix)
    {
        List<double> flattenMatrix = new List<double>();
        matrix.ForEachElement(element => flattenMatrix.Add(element));
        return flattenMatrix.ToArray();
    }

    // enumeration of matrix elements
    private static void ForEachElement(this double[,] matrix, Action<double> onElementAction, Action onNewRowAction = null)
    {
        for (int y = 0; y < matrix.GetLength(1); y++)
        {
            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                onElementAction(matrix[x, y]);
            }
            onNewRowAction?.Invoke();
        }
    }
}