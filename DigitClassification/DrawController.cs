using System.Drawing.Drawing2D;

namespace DigitClassification;

public class DrawController
{
    private PictureBox _picDigit;
    private Pen _drawingPen;
    private Point _lastPoint = Point.Empty;
    private bool _isMouseDown;
    private Bitmap _bitmap;
    
    public Bitmap Drawing
    {
        get => _bitmap;
        set { _bitmap = value; }
    }

    public DrawController(PictureBox picDigit)
    {
        _picDigit = picDigit;
        Clear();

        _drawingPen = new Pen(new SolidBrush(Color.Black), 12);

        _picDigit.MouseDown += _picDigit_MouseDown;
        _picDigit.MouseMove += _picDigit_MouseMove;
        _picDigit.MouseUp += _picDigit_MouseUp;
    }
        
    public void Clear()
    {
        _bitmap = new Bitmap("C:\\Users\\user\\RiderProjects\\DigitClassification\\DigitClassification\\blank495.png");
        _picDigit.Image = _bitmap;
    }

    public void SetLoadedImage(string imagePath)
    {
        _bitmap = new Bitmap(imagePath);
        _picDigit.Image = _bitmap;
    }

    // the mouse does not draw
    private void _picDigit_MouseUp(object sender, MouseEventArgs e)
    {
        _isMouseDown = false;
        _lastPoint = Point.Empty;
    }

    // the mouse is pressed and moves
    private void _picDigit_MouseMove(object sender, MouseEventArgs e)
    {
        if (_isMouseDown)
        {
            if (_lastPoint != null)
            {
                using (Graphics g = Graphics.FromImage(_picDigit.Image))
                {
                    g.DrawLine(_drawingPen, _lastPoint, e.Location);

                    _drawingPen.StartCap = LineCap.Round;
                    _drawingPen.EndCap = LineCap.Round;
                }
                _picDigit.Invalidate();
                _lastPoint = e.Location;
            }
        }
    }

    // the mouse is pressed
    private void _picDigit_MouseDown(object sender, MouseEventArgs e)
    {
        _lastPoint = e.Location;
        _isMouseDown = true;
    }
    
}