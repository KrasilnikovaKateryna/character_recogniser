using Accord.Math;

namespace DigitClassification;

public partial class Form1 : Form
{
    private DrawController _drawController;
    private DataSet _dataSet = new();

    public const int Scale = 50;
    private BinaryMatrix _currentBinaryMatrix = BinaryMatrix.Empty();
    public const int BinaryzeThreshold = 100;

    public Form1()
    {
        InitializeComponent();
        InitializeWatermark();
        LoadData();

        _drawController = new DrawController(picChar);
    }

    // button "Choose"
    private void btnChoose_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();

        openFileDialog.Filter = "Images (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            string selectedFile = openFileDialog.FileName;

            _drawController.Drawing = new Bitmap(selectedFile);
            _drawController.SetLoadedImage(selectedFile);
        }
    }

    // button "Clear"
    private void btnClear_Click(object sender, EventArgs e) => _drawController.Clear();

    // method that processes the image and transforms it into a matrix
    private void Scaling()
    {
        _currentBinaryMatrix = BinaryMatrix.Create(new ImageProcessing(_drawController.Drawing)
                .Grayscale()
                .Binarize(BinaryzeThreshold)
                .Invert()
                .CropBlob()
                .Resize(Scale, Scale)
                .Binarize(BinaryzeThreshold)
                .Image,
            0.5f);
    }

    // button "Train"
    private void btnTrain_Click(object sender, EventArgs e)
    {
        Scaling();
        _currentBinaryMatrix.Flatten(vector => _dataSet.Add(DataPoint.Create(vector, textBox1.Text)));
    }
    
    // button "Predict"
    private void btnPredict_Click(object sender, EventArgs e)
    {
        Scaling();
        (string Label, double Accuracy) result = (default, default)!;
        _currentBinaryMatrix.Flatten(vector => result = _dataSet.Predict(vector, Distance.Euclidean));
        label4.Text = result.Label;
        lblAccuracy.Text = $"Точність: {result.Accuracy}%";
    }

    // Watermark on TextBox 
    private void InitializeWatermark()
    {
        SetWatermark(textBox1, "Введіть символ");

        textBox1.Enter += (sender, e) => RemoveWatermark((TextBox)sender, "Введіть символ");
        textBox1.Leave += (sender, e) => SetWatermark((TextBox)sender, "Введіть символ");
    }

    private void SetWatermark(TextBox textBox, string watermark)
    {
        if (string.IsNullOrWhiteSpace(textBox.Text))
        {
            textBox.Text = watermark;
            textBox.ForeColor = Color.Gray;
        }
    }

    private void RemoveWatermark(TextBox textBox, string watermark)
    {
        if (textBox.Text == watermark)
        {
            textBox.Text = string.Empty;
            textBox.ForeColor = Color.Black;
        }
    }


    // loading data into the program (either training or reading from a file)
    private void LoadData()
    {
        const int NumberOfFiles = 10;

        var datasFiles = new List<string>();
        for (int i = 1; i <= NumberOfFiles; i++)
        {
            datasFiles.Add($@"C:\Users\user\Desktop\Datas\datas{i}.txt");
        }

        if (!File.Exists(datasFiles[0])) // check if these files exist
        {
            StartTraining train = new StartTraining();
            train.Train(_dataSet);

            var blocks = _dataSet.Split(NumberOfFiles);

            string directPath = @"C:\Users\user\Desktop\Datas";

            try
            {
                Directory.CreateDirectory(directPath);
                
                // creating threads
                for (int i = 0; i < datasFiles.Count; i++)
                {
                    var iconst = i;
                    Thread thread = new Thread(() => WriteToFile(datasFiles[iconst], blocks[iconst].ToString()));
                    thread.Start();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
        else
        {
            // creating threads
            foreach (var filePath in datasFiles)
            {
                Thread thread = new Thread(() => LoadFromFile(filePath));
                thread.Start();
            }
        }
    }

    // writing to a file
    private void WriteToFile(string path, string data)
    {
        try
        {
            using StreamWriter writer = new StreamWriter(path);
            writer.WriteLine(data);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.StackTrace);
        }
    }

    // reading from a file
    private void LoadFromFile(string path)
    {
        try
        {
            var lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length - 1; i++)
            {
                // DataPoints are stored in the file as "symbol","vector0011101001010101"
                // example: 6,000010101110101010010101
                // so the vector starts with index 2 (0 is a character, 1 is a comma)
                var charsVector = lines[i].Substring(2).ToCharArray();
                double[] vector = new double[charsVector.Length];
                for (int j = 0; j < vector.Length; j++)
                {
                    vector[j] = Convert.ToDouble(charsVector[j].ToString());
                }

                _dataSet.Add(DataPoint.Create(vector, lines[i].Substring(0, 1)));
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.StackTrace);
        }
    }
}