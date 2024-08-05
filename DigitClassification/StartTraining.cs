namespace DigitClassification;

public class StartTraining
{
    private BinaryMatrix _currentBinaryMatrix = BinaryMatrix.Empty();

    // general method
    public void Train(DataSet dataSet)
    {
        LoadDigits(dataSet, "C:\\Users\\user\\RiderProjects\\DigitClassification\\DigitClassification\\mnist_images");
        LoadLetters(dataSet, "C:\\Users\\user\\RiderProjects\\DigitClassification\\DigitClassification\\Letters");
    }

    // loading digits
    private void LoadDigits(DataSet dataSet, string path)
    {
        if (Directory.Exists(path))
        {
            string[] files = Directory.GetFiles(path);

            foreach (string file in files)
            {
                _currentBinaryMatrix = CreateMatrix(new Bitmap(file));
                _currentBinaryMatrix.Flatten(vector => dataSet.Add(DataPoint.Create(vector, file[^5].ToString())));
            }
        }
    }

    // loading letters
    private void LoadLetters(DataSet dataSet, string path)
    {
        if (Directory.Exists(path))
        {
            // in the Letters folder, images are stored in subfolders whose name is the letter number in the alphabet
            // example: letter A is stored in subfolder "1"
            
            var abc = "0abcdefghijklmnopqrstuvwxyz".ToCharArray();
            string[] subFolders = Directory.GetDirectories(path);
            foreach (string subFolder in subFolders)
            {
                string[] files = Directory.GetFiles(subFolder);
                foreach (var file in files)
                {
                    _currentBinaryMatrix = CreateMatrix(new Bitmap(file));

                    var folderNameInt = Convert.ToInt16(new DirectoryInfo(subFolder).Name);
                    var label = abc[folderNameInt].ToString();
                    _currentBinaryMatrix.Flatten(vector => dataSet.Add(DataPoint.Create(vector, label)));
                }
            }
        }
    }

    // сcreating matrix
    public BinaryMatrix CreateMatrix(Bitmap source)
    {
        var matrix = BinaryMatrix.Create(new ImageProcessing(source)
                .Grayscale()
                .CropBlob()
                .Resize(Form1.Scale, Form1.Scale)
                .Binarize(Form1.BinaryzeThreshold)
                .Image,
            0.5f);

        return matrix;
    }
}