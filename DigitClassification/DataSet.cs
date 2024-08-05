using System.Text;

namespace DigitClassification;

public class DataSet
{
    private List<DataPoint> _dataSet = new();

    public int Count => _dataSet.Count;

    internal void Add(DataPoint dataPoint)
    {
        _dataSet.Add(dataPoint);
    }

    public (string Label, double Accuracy) Predict(double[] vector, Func<double[], double[], double> distanceFunction)
    {
        // distances storage
        List<KeyValuePair<double, string>> distances = new List<KeyValuePair<double, string>>();

        for (int i = 0; i < Count; i++)
        {
            var distance = distanceFunction(_dataSet[i].Point, vector);
            distances.Add(new KeyValuePair<double, string>(distance, _dataSet[i].Label));
        }

        // sorting in ascending order (from smaller to larger)
        distances.Sort((x, y) => x.Key.CompareTo(y.Key));

        // the number of smallest distances from which the accuracy and result are calculated
        const int accuracyPoints = 20;
        distances = distances.Take(accuracyPoints).ToList();

        Dictionary<string, int> labelCounts = new Dictionary<string, int>(); // dictionary "symbol" - "number of meetings"

        foreach (var pair in distances)
        {
            if (labelCounts.ContainsKey(pair.Value))
            {
                labelCounts[pair.Value]++;
            }
            else
            {
                labelCounts[pair.Value] = 1;
            }
        }

        string mostFrequentLabel = labelCounts.MaxBy(x => x.Value).Key;
        int counter = labelCounts[mostFrequentLabel];
        int accuracy = (int)((double)counter / accuracyPoints * 100);

        return (mostFrequentLabel, accuracy);
    }

    // method created to partition the DataSet for multi-threaded processing
    public List<DataSet> Split(int number)
    {
        var res = new List<DataSet>();
        var sizeOfBlock = Count / number;
        for (int i = 0; i < number - 1; i++)
        {
            res.Add(Slice(_dataSet, i * sizeOfBlock, (i + 1) * sizeOfBlock));
        }

        res.Add(Slice(_dataSet, (number - 1) * sizeOfBlock, Count));

        return res;
    }

    // slices the desired amount of information from the DataSet
    private DataSet Slice(List<DataPoint> dataSet, int startIndex, int endIndex)
    {
        var res = new DataSet();
        for (int i = startIndex; i < endIndex; i++)
        {
            res.Add(dataSet[i]);
        }

        return res;
    }

    public override string ToString()
    {
        StringBuilder res = new StringBuilder();
        foreach (var el in _dataSet)
        {
            res.Append(el.Label);
            res.Append(",");

            foreach (var el2 in el.Point)
            {
                res.Append(el2);
            }

            res.Append("\r");
        }
        
        return res.ToString();
    }
}