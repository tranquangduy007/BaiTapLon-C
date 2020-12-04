using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;


namespace GiaoDienCafe_New
{
    public partial class FormPaint : Form
    {
        private static readonly Color DefPenColor = Color.Black;
        private static readonly Color DefBrushColor = Color.Black;
        private static readonly Font DefTextFont = new Font("Times New Roman", 12);
        private static readonly Color DefTextBrush = Color.Black;
        public Pen MyPen;
        private Bitmap _bitmap;
        private SolidBrush _brush;
        private Color _brushColor;
        private Bitmap _curBitmap;
        private int _dx, _dy;
        private string _fileName = "";
        private Size _fullSize;
        private Graphics _g;
        private bool _isBeginDraw;
        private bool _isNeedSave;
        private Color _penColor;
        private decimal _penWidth;
        private RichTextBox _rich;
        private int _shape = 1;
        private SolidBrush _textBrush;
        private Font _textFont;
        private int _x1;
        private int _x2;
        private int _y1;
        private int _y2;

        private bool _menuExitClicked;
        public FormPaint()
        {
            InitializeComponent();
            EnableDoubleBuffering();
            CreateToolTips();
        }


        private void CreateToolTips()
        {
            var listCaptions = new List<string>
                                   {
                                       "Draw Line",
                                       "Draw Ellipse",
                                       "Draw Rectangle",
                                       "Fill Rectangle",
                                       "Fill Ellipse",
                                       "Draw Text",
                                       "Eraser",
                                       "Reset",
                                       "Pen Setting",
                                       "Brush Setting",
                                       "Font Setting"
                                   };

            var tools = new ToolTip[12];
            for (var j = 0; j < 11; j++)
            {
                tools[j] = new ToolTip();
            }
            var i = 0;
            tools[i].SetToolTip(DrawLine, listCaptions[i]);
            i++;
            tools[i].SetToolTip(DrawRect, listCaptions[i]);
            i++;
            tools[i].SetToolTip(DrawEllipse, listCaptions[i]);
            i++;
            tools[i].SetToolTip(FilledRect, listCaptions[i]);
            i++;
            tools[i].SetToolTip(FilledEllipse, listCaptions[i]);
            i++;
            tools[i].SetToolTip(btnText, listCaptions[i]);
           /* i++;
            tools[i].SetToolTip(btnClear, listCaptions[i]);*/
            i++;
            tools[i].SetToolTip(btnReset, listCaptions[i]);
            i++;
            tools[i].SetToolTip(btnPen, listCaptions[i]);
            i++;
            tools[i].SetToolTip(btnBrush, listCaptions[i]);
            i++;
            tools[i].SetToolTip(btnFont, listCaptions[i]);
        }

        private void EnableDoubleBuffering()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            UpdateStyles();
        }

        private void InitGraphicsObjects()
        {
            MyPen = new Pen(_penColor, (float)_penWidth);
            _brush = new SolidBrush(_brushColor);
            _textBrush = new SolidBrush(DefTextBrush);
        }

        private void RefreshFormBackground()
        {
            _curBitmap = _bitmap.Clone(new Rectangle(0, 0, Width, Height), _bitmap.PixelFormat);
            BackgroundImage = _curBitmap;
        }

        private void ResetAll()
        {
            _isNeedSave = false;
            _fileName = "";
            NumPenWidth.Value = NumPenWidth.Minimum;
            _penColor = DefPenColor;
            _brushColor = DefBrushColor;
            _shape = 1;
            _textFont = DefTextFont;
            _g.Clear(BackColor);
            RefreshFormBackground();
        }

        private void OpenImage()
        {
            var openDlg = new OpenFileDialog
            {
                Filter = @"Image files (*.bmp)|*.bmp|All files (*.*)|*.*"
            };
            switch (openDlg.ShowDialog())
            {
                case DialogResult.OK:
                    try
                    {
                        var img = Image.FromFile(openDlg.FileName);
                        _g.DrawImage(img, 0, 0, img.Width, img.Height);
                        RefreshFormBackground();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(@"Error: " + e.Message);
                    }
                    break;
            }
        }

        private void SaveImage()
        {
            var tmpBitmap = _bitmap.Clone(new Rectangle(0, 0, Width, Height), _bitmap.PixelFormat);
            switch (_fileName)
            {
                case "":
                    {
                        var saveFileDlg = new SaveFileDialog
                        {
                            Filter = @"Image files (*.bmp)|*.bmp|All files (*.*)|*.*",
                            FileName = "MyPicture.bmp"
                        };
                        if (saveFileDlg.ShowDialog() != DialogResult.OK) return;
                        _fileName = saveFileDlg.FileName;
                        tmpBitmap.Save(saveFileDlg.FileName, ImageFormat.Bmp);
                    }
                    break;
                default:
                    {
                        tmpBitmap.Save(_fileName, ImageFormat.Bmp);
                    }
                    break;
            }
        }

        private bool FormNeedClose()
        {
            var isNeed = false;
            switch (_isNeedSave)
            {
                case true:
                    {
                        var result = MessageBox.Show(@"Do you want to Save this Image?", @"Save",
                                                     MessageBoxButtons.YesNoCancel,
                                                     MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        switch (result)
                        {
                            case DialogResult.Yes:
                                SaveImage();
                                isNeed = true;
                                break;
                            case DialogResult.No:
                                isNeed = true;
                                break;
                            case DialogResult.Cancel:
                                break;
                        }
                    }
                    break;
                case false:
                    isNeed = true;
                    break;
            }
            return isNeed;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_isNeedSave)
            {
                var result = MessageBox.Show(@"Do you want to Save this Image?", @"Save",
                                                              MessageBoxButtons.YesNoCancel,
                                                              MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                switch (result)
                {
                    case DialogResult.Yes:
                        SaveImage();
                        break;
                }
            }
            _isNeedSave = true;
            OpenImage();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveImage();
        }

        private void DrawLine_Click(object sender, EventArgs e)
        {
            _shape = 1;
        }

        private void DrawEllipse_Click(object sender, EventArgs e)
        {
            _shape = 2;
        }

        private void DrawRect_Click(object sender, EventArgs e)
        {
            _shape = 3;
        }

        private void FilledRect_Click(object sender, EventArgs e)
        {
            _shape = 4;
        }

        private void FilledEllipse_Click(object sender, EventArgs e)
        {
            _shape = 5;
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            _shape = 6;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void NumPenWidth_ValueChanged(object sender, EventArgs e)
        {
            _penWidth = NumPenWidth.Value;
        }

        private void btnPen_Click(object sender, EventArgs e)
        {

            var clrDlg = new ColorDialog { Color = _penColor };
            if (clrDlg.ShowDialog() == DialogResult.OK)
            {
                _penColor = clrDlg.Color;
            }
        }

        private void btnBrush_Click(object sender, EventArgs e)
        {
            var clrDlg = new ColorDialog { Color = _brushColor };
            if (clrDlg.ShowDialog() == DialogResult.OK)
            {
                _brushColor = clrDlg.Color;
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            var fontDlg = new FontDialog { Font = _textFont, ShowColor = true };
            switch (fontDlg.ShowDialog())
            {
                case DialogResult.OK:
                    _textFont = fontDlg.Font;
                    _textBrush = new SolidBrush(fontDlg.Color);
                    _rich.ForeColor = fontDlg.Color;
                    _rich.Font = fontDlg.Font;
                    break;
            }
        }

        private void FormPaint_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormGiaodien fm = new FormGiaodien();
            this.Hide();
            fm.ShowDialog();
           /* switch (_menuExitClicked)
            {
                case false:
                    e.Cancel = !FormNeedClose();
                    break;
            }*/
        }

        private void FormPaint_Load(object sender, EventArgs e)
        {
            _fullSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            _bitmap = new Bitmap(_fullSize.Width, _fullSize.Height);
            _g = Graphics.FromImage(_bitmap);
            //AntiLiasing
            _g.SmoothingMode = SmoothingMode.AntiAlias;
            _g.Clear(BackColor);
            _penColor = DefPenColor;
            _brushColor = DefBrushColor;
            _penWidth = NumPenWidth.Value;
            _textFont = DefTextFont;
            _rich = new RichTextBox();
            InitGraphicsObjects();
        }

        private void FormPaint_MouseDown(object sender, MouseEventArgs e)
        {
            _x1 = e.X;
            _y1 = e.Y;
            _g.DrawString(_rich.Text, _textFont, _textBrush, _rich.Location.X, _rich.Location.Y);
            Controls.Remove(_rich);
            _isBeginDraw = true;
        }

        private void FormPaint_MouseMove(object sender, MouseEventArgs e)
        {
            _x2 = e.X;
            _y2 = e.Y;
            _dx = e.X - _x1;
            _dy = e.Y - _y1;
            if (_isBeginDraw)
            {
                Refresh();
            }
        }

        private void FormPaint_MouseUp(object sender, MouseEventArgs e)
        {
            _isNeedSave = true;
            _dx = _x2 - _x1;
            _dy = _y2 - _y1;
            InitGraphicsObjects();
            switch (_shape)
            {
                case 1:
                    // Draw a line
                    _g.DrawLine(MyPen, _x1, _y1, _x2, _y2);
                    break;

                case 2:
                    // Draw an ellipse
                    _g.DrawEllipse(MyPen, _x1, _y1, _dx, _dy);
                    break;

                case 3:
                    // Draw rectangle
                    _g.DrawRectangle(MyPen, _x1, _y1, _dx, _dy);
                    break;

                case 4:
                    // Fill rectangle
                    _g.FillRectangle(_brush, _x1, _y1, _dx, _dy);
                    break;

                case 5:
                    // Fill ellipse
                    _g.FillEllipse(_brush, _x1, _y1, _dx, _dy);
                    break;

                case 6:
                    _rich = new RichTextBox
                    {
                        Location = new Point(_x1, _y1),
                        Size = new Size(_dx, _dy),
                        Font = _textFont,
                        ForeColor = _textBrush.Color
                    };
                    Controls.Add(_rich);
                    break;

                case 7:
                    _isNeedSave = false;
                    _g.Clear(BackColor);
                    break;
            }
            RefreshFormBackground();
            _isBeginDraw = false;
        }

        private void FormPaint_Paint(object sender, PaintEventArgs e)
        {
            if (!_isBeginDraw) return;
            var g = e.Graphics;
            InitGraphicsObjects();
            switch (_shape)
            {
                case 1:
                    // Draw a line
                    g.DrawLine(MyPen, _x1, _y1, _x2, _y2);
                    break;

                case 2:
                    // Draw an ellipse
                    g.DrawEllipse(MyPen, _x1, _y1, _dx, _dy);
                    break;

                case 3:
                    // Draw rectangle
                    g.DrawRectangle(MyPen, _x1, _y1, _dx, _dy);
                    break;

                case 4:
                    // Fill rectangle
                    g.FillRectangle(_brush, _x1, _y1, _dx, _dy);
                    break;

                case 5:
                    // Fill ellipse
                    g.FillEllipse(_brush, _x1, _y1, _dx, _dy);
                    break;
            }
        }

        private void FormPaint_Resize(object sender, EventArgs e)
        {
            RefreshFormBackground();
        }

        private void CreateNewFile()
        {
            ResetAll();
        }




    }
}
