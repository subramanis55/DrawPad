using Svg;
using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using WinFormsApp2;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;
using Timer = System.Windows.Forms.Timer;
namespace WinFormsApp2
{
    enum ResizeMode
    {
        None, Top, TopRight, Right, RightBottom, Bottom, BottomLeft, Left, LeftTop

    }
    enum OperationType
    {
        Paint, ImageAdd, ImageDelete, ImageResize, ImageFormationChange
    }
    public partial class Form1 : Form
    {
        private string addImagePath;
        private Color imageHoverColor = Color.FromArgb(245, 245, 245);
        private Color imageSelectedColor = Color.FromArgb(230, 230, 230);
        private CustomPictureBox selectedItem;
        private PictureBox drawPanelSelectedItem;
        private bool isSizeChange;
        private bool isPaintBtnSelected;
        List<Byte[]> IconsList;
        private Pen Drawpen;
        private Color penColor = Color.Black;
        private ResizeMode resizeMode = ResizeMode.None;
        private int penSize = 8;
        private bool isResizeBtnSelected;
        System.Windows.Forms.Timer applicationStartTimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer svgImagePanelTimer = new System.Windows.Forms.Timer();
        private bool isSvgImagePanelVisible;
        private Stack<List<Point>> undoPoints = new Stack<List<Point>>();
        private Stack<Tuple<Color, int>> undoPointsColorandSize;
        private Stack<List<Point>> redoPoints;
        private Stack<Tuple<Color, int>> redoPointsColorandSize;
        private List<Point> tempPointList;
        private Stack<PictureBox> undoControls = new Stack<PictureBox>();
        private Stack<PictureBox> redoControls = new Stack<PictureBox>();
        private Stack<OperationType> undoOperationStack = new Stack<OperationType>();
        private Stack<OperationType> redoOperationStack = new Stack<OperationType>();
        private int imageNumber = 0;
        private ResizeMode drawingpanelResize = ResizeMode.None;
        public int PenSize
        {
            set
            {
                penSize = value;
                Drawpen = new Pen(penColor, penSize);
                Drawpen.StartCap = LineCap.Round;
                Drawpen.EndCap = LineCap.Round;
            }
            get
            {
                return penSize;
            }
        }
        public Color PenColor
        {
            set
            {
                penColor = value;
                Drawpen = new Pen(penColor, penSize);
                Drawpen.StartCap = LineCap.Round;
                Drawpen.EndCap = LineCap.Round;
                SelectedColorP.BackColor = penColor;
            }
            get
            {
                return penColor;
            }
        }

        public bool IsPaintBtnSelected { get
            {
                return isPaintBtnSelected;
            }
            set 
            {
                isPaintBtnSelected = value;
            }  
        }

        public Form1()
        {
            InitializeComponent();
            this.Load += DrawPadLoad;
            AddIconBtn.Click += AddImageBtnClick;
            SaveBtn.Click += SaveBtnClick;
            DrawingPanel.MouseClick += DrawingPanelOnClick;
            SizeBtn.Click += ResizeBtnSelected;
            PaintBtn.Click += PaintBtnSelected;
            RightRotateBtn.Click += RotateRightClick;
            LeftRotateBtn.Click += LeftRotateClick;
            VerticalFlipBtn.Click += VerticalFlipBtnClick;
            HorizonalFlipBtn.Click += HorizonalFlipBtnClick;
            SizeBtn.Click += SizeBtnClick;
            DrawingPanel.MouseDown += DrawingPanelMouseDown;
            DrawingPanel.MouseMove += DrawingPanelMouseMove;
            DrawingPanel.MouseUp += DrawingPanelMouseUp;
           DrawingPanel.Paint += DrawingPanel_Paint;
            DeleteImageBtn.Click += DeleteImageClick;
            SizeComboBox.SelectedIndexChanged += SizeComboBoxIndexChanged;
            SizeComboBox.TextChanged += SizeComboBoxTextChanged;
            ColorPanel.Click += ColorPanelClick;
            DrawingPanel.MouseDown += DrawingPanelDownToResize;
            DrawingPanel.MouseMove += DrawingPanelMoveToResize;
            DrawingPanel.MouseUp += DrawingPanelUpToResize;
            ImagesPanelBtn.Click += ImagesPanelBtnClick;
             DrawingPanel.Resize += OnResize;

            Drawpen = new Pen(penColor, penSize);
            Drawpen.StartCap = LineCap.Round;
            Drawpen.EndCap = LineCap.Round;
            SelectedColorP.BackColor = penColor;
            SizeComboBox.SelectedItem = "" + penSize;

            applicationStartTimer.Interval = 2000;
            applicationStartTimer.Tick += ApplicationStart;

            svgImagePanelTimer.Interval = 15;
            svgImagePanelTimer.Tick += ImagesPanelShowOrHide;


            redoPoints = new Stack<List<Point>>();
            undoPointsColorandSize = new Stack<Tuple<Color, int>>();
            redoPointsColorandSize = new Stack<Tuple<Color, int>>();
            UndoBtn.Click += UndoBtnClick;
            RedoBtn.Click += RedoBtnClick;
            DoubleBuffered = true;
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, DrawingPanel, new object[] { true });
            typeof(FlowLayoutPanel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, SVGImagePanel, new object[] { true });
        }

        public void RedoUndoReduce()
        {
            if (redoPoints.Count > 20)
            {

            }
            if (undoPoints.Count > 20)
            {

            }
        }
        private void RedoBtnClick(object? sender, EventArgs e)
        {
            if (redoOperationStack.Count > 0)
            {

                var type = redoOperationStack.Pop();
                switch (type)
                {
                    case OperationType.Paint:
                        if (redoPoints.Count > 0)
                        {
                            List<Point> temp = redoPoints.Pop();
                            var temp2 = redoPointsColorandSize.Pop();
                            Pen erasePen = new Pen(temp2.Item1, temp2.Item2);
                            erasePen.StartCap = LineCap.Round;
                            erasePen.EndCap = LineCap.Round;
                            using (Graphics g = DrawingPanel.CreateGraphics())
                            {
                                g.SmoothingMode = SmoothingMode.AntiAlias;
                                for (int i = 0; i < temp.Count - 1; i++)
                                {

                                    g.DrawLine(erasePen, temp[i], temp[i + 1]);
                                }
                            }
                            undoPoints.Push(temp);
                            undoPointsColorandSize.Push(temp2);
                            undoOperationStack.Push(type);
                        }
                        break;
                    case OperationType.ImageAdd:
                        PictureBox controlAdd = redoControls.Pop();
                        DrawingPanel.Controls.Add(controlAdd);
                        undoControls.Push(controlAdd);
                        undoOperationStack.Push(type);
                        break;
                    case OperationType.ImageDelete:
                        PictureBox controlDel = undoControls.Pop();
                        DrawingPanel.Controls.Remove(controlDel);
                        undoControls.Push(controlDel);
                        undoOperationStack.Push(type);
                        break;
                    case OperationType.ImageResize:
                        PictureBox pictureSizeChange = redoControls.Pop();
                        for (int i = 0; i < DrawingPanel.Controls.Count; i++)
                        {
                            if (pictureSizeChange.Name == DrawingPanel.Controls[i].Name)
                            {
                                DrawingPanel.Controls[i].Location = pictureSizeChange.Location;
                                DrawingPanel.Controls[i].Size = pictureSizeChange.Size;
                            }
                        }
                        undoControls.Push(pictureSizeChange);
                        undoOperationStack.Push(type);
                        break;
                    case OperationType.ImageFormationChange:
                        PictureBox FormatChange = redoControls.Pop();
                        for (int i = 0; i < DrawingPanel.Controls.Count; i++)
                        {
                            if (FormatChange.Name == DrawingPanel.Controls[i].Name)
                            {
                                ((PictureBox)DrawingPanel.Controls[i]).Image = FormatChange.Image;
                            }
                        }
                        undoControls.Push(FormatChange);
                        undoOperationStack.Push(type);
                        break;
                    default: break;
                }
                DrawingPanel.Invalidate();
            }

        }

        private void UndoBtnClick(object? sender, EventArgs e)
        {
            if (undoOperationStack.Count > 0)
            {
                var type = undoOperationStack.Pop();
                switch (type)
                {
                    case OperationType.Paint:
                        if (undoPoints.Count > 0)
                        {
                            List<Point> temp = undoPoints.Pop();
                            var temp2 = undoPointsColorandSize.Pop();
                            Pen erasePen = new Pen(Color.White, temp2.Item2 + 1);
                            erasePen.StartCap = LineCap.Round;
                            erasePen.EndCap = LineCap.Round;

                            using (Graphics g = DrawingPanel.CreateGraphics())
                            {
                                g.SmoothingMode = SmoothingMode.AntiAlias;
                                for (int i = 0; i < temp.Count - 1; i++)
                                {

                                    g.DrawLine(erasePen, temp[i], temp[i + 1]);
                                }
                            }
                            redoPoints.Push(temp);
                            redoPointsColorandSize.Push(temp2);
                            redoOperationStack.Push(type);

                        }
                        break;
                    case OperationType.ImageAdd:
                        PictureBox controlAdd = undoControls.Pop();
                        DrawingPanel.Controls.Remove(controlAdd);
                        redoControls.Push(controlAdd);
                        redoOperationStack.Push(type);
                        break;
                    case OperationType.ImageDelete:
                        PictureBox controlDel = undoControls.Pop();
                        DrawingPanel.Controls.Add(controlDel);
                        redoControls.Push(controlDel);
                        redoOperationStack.Push(type);
                        break;
                    case OperationType.ImageResize:
                        PictureBox sizeChange = undoControls.Pop();
                        for (int i = 0; i < DrawingPanel.Controls.Count; i++)
                        {
                            if (sizeChange.Name == DrawingPanel.Controls[i].Name)
                            {
                                DrawingPanel.Controls[i].Location = sizeChange.Location;
                                DrawingPanel.Controls[i].Size = sizeChange.Size;
                            }
                        }
                        redoControls.Push(sizeChange);
                        redoOperationStack.Push(type);
                        break;
                    case OperationType.ImageFormationChange:
                        PictureBox FormatChange = undoControls.Pop();
                        for (int i = 0; i < DrawingPanel.Controls.Count; i++)
                        {
                            if (FormatChange.Name == DrawingPanel.Controls[i].Name)
                            {
                                ((PictureBox)DrawingPanel.Controls[i]).Image = FormatChange.Image;
                            }
                        }
                        redoControls.Push(FormatChange);
                        redoOperationStack.Push(type);
                        break;
                    default: break;
                }
                DrawingPanel.Invalidate();
            }
        }

        private void ImagesPanelShowOrHide(object sender, EventArgs e)
        {
            if (isSvgImagePanelVisible)
            {
                if (SVGImagePanel.Width < 220)
                {
                    SVGImagePanel.Width += 10;
                }
                else
                {
                    SVGImagePanel.Width = 220;
                    ((Timer)sender).Stop();
                }
            }
            else
            {
                if (SVGImagePanel.Width > 0)
                {
                    SVGImagePanel.Width -= 10;
                }
                else
                {
                    SVGImagePanel.Width = 1;
                    ((Timer)sender).Stop();
                }
            }

        }
        private void ImagesPanelBtnClick(object? sender, EventArgs e)
        {
            if (!isSvgImagePanelVisible)
            {
                isSvgImagePanelVisible = true;
            }
            else
            {
                isSvgImagePanelVisible = false;
            }
            svgImagePanelTimer.Start();
            if (redoOperationStack.Count > 0)
            {
                RedoClear();
            }
        }
        private void RedoClear()
        {
            redoPointsColorandSize.Clear();
            redoControls.Clear();
            redoOperationStack.Clear();
            redoPoints.Clear();
        } 
        private void ColorPanelClick(object? sender, EventArgs e)
        {
            Point point = Cursor.Position;
            Bitmap bmp = new Bitmap(1, 1);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(point, new Point(0, 0), new Size(1, 1));
            }
            PenColor = bmp.GetPixel(0, 0);
           
        }

        private void SizeComboBoxTextChanged(object? sender, EventArgs e)
        {
            if (SizeComboBox.Text != "" && SizeComboBox.Text != null)
            {
                PenSize = int.Parse("" + SizeComboBox.Text);
            }
           
        }

        private void SizeComboBoxIndexChanged(object? sender, EventArgs e)
        {
            PenSize = int.Parse("" + SizeComboBox.SelectedItem);

        }

        private void DeleteImageClick(object? sender, EventArgs e)
        {
            if (drawPanelSelectedItem != null)
            {
                undoControls.Push(drawPanelSelectedItem);
                undoOperationStack.Push(OperationType.ImageDelete);
                DrawingPanel.Controls.Remove(drawPanelSelectedItem);
            }
            if (redoOperationStack.Count > 0)
            {
                redoPointsColorandSize.Clear();
                redoControls.Clear();
                redoOperationStack.Clear();
                redoPoints.Clear();
            }
        }

        private Point drawPrevPoint;
        private bool isDrawOn;
        private void DrawingPanelMouseUp(object? sender, MouseEventArgs e)
        {
            if (IsPaintBtnSelected&&isImageDowntheMouse!=true)
            {
                tempPointList.Add(drawPrevPoint);
                undoPoints.Push(tempPointList);
                redoPoints.Clear();
                redoPointsColorandSize.Clear();
                isDrawOn = false;
                undoOperationStack.Push(OperationType.Paint);
            }
        }

        private void DrawingPanelMouseMove(object? sender, MouseEventArgs e)
        {
            if (isDrawOn && IsPaintBtnSelected&& isImageDowntheMouse != true)
            {

                using (Graphics g = ((Control)sender).CreateGraphics())
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.DrawLine(Drawpen, drawPrevPoint, new Point(e.X, e.Y));
                }
                tempPointList.Add(drawPrevPoint);
                drawPrevPoint = new Point(e.X, e.Y);
            }
        }

        private void DrawingPanelMouseDown(object? sender, MouseEventArgs e)
        {
            if (IsPaintBtnSelected&&isImageDowntheMouse != true)
            {
                drawPrevPoint = new Point(e.X, e.Y);
                isDrawOn = true;
                tempPointList = new List<Point>();
                undoPointsColorandSize.Push(new Tuple<Color, int>(PenColor, PenSize));
            }
            if (redoOperationStack.Count > 0)
            {
                RedoClear();
            }

        }

        private void ApplicationStart(object sender, EventArgs e)
        {
            MainFillPanel.Visible = true;
            applicationStartTimer.Stop();
        }
        private void PaintBtnSelected(object sender, EventArgs e)
        {
            if (!IsPaintBtnSelected)
            {
                ((Control)sender).BackColor = imageSelectedColor;
                IsPaintBtnSelected = true;
            }
            else
            {
                ((Control)sender).BackColor = Color.Transparent;
                IsPaintBtnSelected = false;
            }
            if (redoOperationStack.Count > 0)
            {
                RedoClear();
            }
        }

        private void AddImageBtnClick(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "SVG|*.svg|ALL FILES|*.*";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                addImagePath = openFileDialog1.FileName;

                SvgDocument Svgfile = SvgDocument.Open(addImagePath);
                Bitmap bit = Svgfile.Draw();
                PictureBox picObj = new CustomPictureBox() { Image = bit, SizeMode = PictureBoxSizeMode.Zoom, Size = new Size(80, 80), BackColor = Color.Transparent };
                picObj.MouseEnter += ImageMousehover;
                picObj.MouseLeave += ImageMouseLeave;
                picObj.MouseClick += ImageMouseClick;
                SVGImagePanel.Controls.Add(picObj);
            }
            if (redoOperationStack.Count > 0)
            {
                redoPointsColorandSize.Clear();
                redoControls.Clear();
                redoOperationStack.Clear();
                redoPoints.Clear();
            }
        }

        private void ImageMouseClick(object? sender, MouseEventArgs e)
        {

            if (selectedItem == sender)
            {
                selectedItem.BackColor = Color.Transparent;
                selectedItem = null;
            }
            else
            {
                if (selectedItem != null)
                {
                    selectedItem.BackColor = Color.Transparent;
                }
                CustomPictureBox obj = (CustomPictureBox)sender;
                typeof(CustomPictureBox).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, obj, new object[] { true });
                obj.BackColor = imageSelectedColor;
                selectedItem = obj;
            }
            if (redoOperationStack.Count > 0)
            {
                redoPointsColorandSize.Clear();
                redoControls.Clear();
                redoOperationStack.Clear();
                redoPoints.Clear();
            }

        }

        private void ImageMousehover(object sender, EventArgs args)
        {
            if (sender != selectedItem)
            {
                Control control = (Control)sender;
                control.BackColor = imageHoverColor;
            }
        }
        private void ImageMouseLeave(object sender, EventArgs args)
        {
            if (sender != selectedItem)
            {
                Control control = (Control)sender;
                control.BackColor = Color.Transparent;
            }
        }
        private void ResizeBtnSelected(object sender, EventArgs args)
        {
            if (!isResizeBtnSelected)
            {
                ((Control)sender).BackColor = imageSelectedColor;
                isResizeBtnSelected = true;
            }
            else
            {
                ((Control)sender).BackColor = Color.Transparent;
                isResizeBtnSelected = false;
            }
            if (redoOperationStack.Count > 0)
            {
                redoPointsColorandSize.Clear();
                redoControls.Clear();
                redoOperationStack.Clear();
                redoPoints.Clear();
            }
        }
        private void DrawingPanelOnClick(object sender, MouseEventArgs e)
        {
            if (selectedItem != null)
            {
                imageNumber++;
                SVGPB P = new SVGPB() { Image = selectedItem.Image, Size = new Size(100, 100), Location = new Point(e.X - 50, e.Y - 50), BackColor = Color.Transparent, SizeMode = PictureBoxSizeMode.Zoom, MinimumSize = new Size(5, 5), Name = "Image" + imageNumber };
                P.BringToFront();
                P.Click += DrawPanelItemFocus;
                P.MouseDown += MouseDownPictureBox;
                P.MouseUp += MouseUpPictureBox;
                P.MouseMove += MouseMovePictureBox;
                P.MouseMove += DrawingPanelMouseMove;
                //  typeof(SVGPB).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, P, new object[] { true });
                DrawingPanel.Controls.Add(P);
                undoControls.Push(P);
                undoOperationStack.Push(OperationType.ImageAdd);
               
            }
            if (redoOperationStack.Count > 0)
            {
                RedoClear();
            }
        }

        private void DrawPanelItemFocus(object sender, EventArgs e)
        {
            if (drawPanelSelectedItem == sender)
            {
                drawPanelSelectedItem.BorderStyle = BorderStyle.None;
                drawPanelSelectedItem = null;
            }
            else
            {
                PictureBox obj = (PictureBox)sender;
                if (drawPanelSelectedItem != null)
                {

                    drawPanelSelectedItem.BorderStyle = BorderStyle.None;
                }
                obj.BorderStyle = BorderStyle.FixedSingle;
                drawPanelSelectedItem = obj;
            }
            if (redoOperationStack.Count > 0)
            {
                RedoClear();
            }
        }

        private void RotateRightClick(object sender, EventArgs e)
        {

            if (drawPanelSelectedItem != null)
            {
                undoControls.Push(new PictureBox() { Image = new Bitmap(drawPanelSelectedItem.Image), Name = drawPanelSelectedItem.Name });
                undoOperationStack.Push(OperationType.ImageFormationChange);
                Bitmap bitImage = new Bitmap(drawPanelSelectedItem.Image);
                bitImage.RotateFlip(RotateFlipType.Rotate270FlipXY);
                drawPanelSelectedItem.Image = bitImage;

            }
            if (redoOperationStack.Count > 0)
            {
                RedoClear();
            }
        }

        private void LeftRotateClick(object sender, EventArgs e)
        {
            if (drawPanelSelectedItem != null)
            {
                undoControls.Push(new PictureBox() { Image = new Bitmap(drawPanelSelectedItem.Image), Name = drawPanelSelectedItem.Name });
                undoOperationStack.Push(OperationType.ImageFormationChange);
                Bitmap bitImage = new Bitmap(drawPanelSelectedItem.Image);
                bitImage.RotateFlip(RotateFlipType.Rotate90FlipXY);
                drawPanelSelectedItem.Image = bitImage;
            }
            if (redoOperationStack.Count > 0)
            {
                redoPointsColorandSize.Clear();
                redoControls.Clear();
                redoOperationStack.Clear();
                redoPoints.Clear();
            }
        }

        private void VerticalFlipBtnClick(object? sender, EventArgs e)
        {
            if (drawPanelSelectedItem != null)

            {
                undoControls.Push(new PictureBox() { Image = new Bitmap(drawPanelSelectedItem.Image), Name = drawPanelSelectedItem.Name });
                undoOperationStack.Push(OperationType.ImageFormationChange);
                Bitmap bitImage = new Bitmap(drawPanelSelectedItem.Image);
                bitImage.RotateFlip(RotateFlipType.RotateNoneFlipY);
                drawPanelSelectedItem.Image = bitImage;
            }
            if (redoOperationStack.Count > 0)
            {
                redoPointsColorandSize.Clear();
                redoControls.Clear();
                redoOperationStack.Clear();
                redoPoints.Clear();
            }
        }
        private void HorizonalFlipBtnClick(object? sender, EventArgs e)
        {
            if (drawPanelSelectedItem != null)
            {
                undoControls.Push(new PictureBox() { Image = new Bitmap(drawPanelSelectedItem.Image), Name = drawPanelSelectedItem.Name });
                undoOperationStack.Push(OperationType.ImageFormationChange);
                Bitmap bitImage = new Bitmap(drawPanelSelectedItem.Image);
                bitImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
                drawPanelSelectedItem.Image = bitImage;
            }
            if (redoOperationStack.Count > 0)
            {
                redoPointsColorandSize.Clear();
                redoControls.Clear();
                redoOperationStack.Clear();
                redoPoints.Clear();
            }
        }
        private bool isImageDowntheMouse;
        private Point prevPoint;
        private void MouseUpPictureBox(object sender, MouseEventArgs e)
        {
            if (!(sender is Panel))
            {
                Control control = (Control)sender;
                undoControls.Push(new PictureBox() { Location = control.Location, Width = control.Width, Height = control.Height, Name = control.Name });
                undoOperationStack.Push(OperationType.ImageResize);
            }

            isImageDowntheMouse = false;
        }
        private void MouseMovePictureBox(object sender, MouseEventArgs e)
        {
            if (isSizeChange && !isImageDowntheMouse)
            {
                Control control = (Control)sender;
                int a = control.Height;
                int b = control.Width;
                Point temp = control.PointToClient(Cursor.Position);
                if ((b - 6 <= temp.X && temp.X <= b) && (a - 6 <= temp.Y && temp.Y <= a))  //rightbottom
                {
                    resizeMode = ResizeMode.RightBottom;
                    control.Cursor = Cursors.SizeNWSE;
                }

                else if ((b - 6 <= temp.X && temp.X <= b) && (0 <= temp.Y && temp.Y <= 6))  //rightTop
                {
                    resizeMode = ResizeMode.TopRight;
                    control.Cursor = Cursors.SizeNESW;


                }
                else if ((a - 6 <= temp.Y && temp.Y <= a) && (0 <= temp.X && temp.X <= 6))  //leftBottom
                {
                    resizeMode = ResizeMode.BottomLeft;
                    control.Cursor = Cursors.SizeNESW;
                }
                else if ((0 <= temp.Y && temp.Y <= 6) && (0 <= temp.X && temp.X <= 6))  //LeftTop
                {
                    resizeMode = ResizeMode.LeftTop;
                    control.Cursor = Cursors.SizeNWSE;

                }
                else if ((0 <= temp.X && temp.X <= 6))  //left
                {
                    resizeMode = ResizeMode.Left;
                    control.Cursor = Cursors.SizeWE;
                }
                else if ((0 <= temp.Y && temp.Y <= 6))
                {
                    resizeMode = ResizeMode.Top;
                    control.Cursor = Cursors.SizeNS;

                }
                else if ((b - 6 <= temp.X && temp.X <= b))
                {
                    resizeMode = ResizeMode.Right;
                    control.Cursor = Cursors.SizeWE;

                }
                else if ((a - 6 <= temp.Y && temp.Y <= a))
                {
                    resizeMode = ResizeMode.Bottom;
                    control.Cursor = Cursors.SizeNS;
                }
                else
                {
                    control.Cursor = Cursors.Default;
                    resizeMode = ResizeMode.None;
                }
            }

            if (isImageDowntheMouse)
            {
                Control control = (Control)sender;

                int ValueX = e.X - prevPoint.X;
                int ValueY = e.Y - prevPoint.Y;
                Point temp = DrawingPanel.PointToClient(Cursor.Position);
                switch ((int)resizeMode)
                {
                    case 0:
                        if (!(control is Panel))
                        {
                            control.Location = new Point(control.Location.X + (e.X - prevPoint.X), control.Location.Y + (e.Y - prevPoint.Y));
                        }
                        break;
                    case 1:
                        control.Height += (control.Location.Y - temp.Y);
                        control.Location = new Point(control.Location.X, temp.Y);
                        break;
                    case 2:
                        control.Width = temp.X - control.Location.X;
                        control.Height += control.Location.Y - temp.Y;
                        control.Location = new Point(control.Location.X, temp.Y);
                        break;
                    case 3:
                        control.Width = temp.X - control.Location.X;
                        break;
                    case 4:
                        control.Width = temp.X - control.Location.X;
                        control.Height = temp.Y - control.Location.Y;
                        break;
                    case 5:
                        control.Height = temp.Y - control.Location.Y;
                        break;
                    case 6:
                        control.Width += control.Location.X - temp.X;
                        control.Height = temp.Y - control.Location.Y;

                        control.Location = new Point(temp.X, control.Location.Y);
                        break;
                    case 7:
                        control.Width += (control.Location.X - temp.X);
                        control.Location = new Point(temp.X, control.Location.Y);
                        break;
                    case 8:
                        control.Width += control.Location.X - temp.X;
                        control.Height += control.Location.Y - temp.Y;
                        control.Location = new Point(temp.X, temp.Y);
                        break;
                    default: break;

                }
                //  DrawingPanel.Invalidate();
                control.BringToFront();

            }

        }
        private void MouseDownPictureBox(object sender, MouseEventArgs e)
        {
            //if (resizeMode != ResizeMode.None)
            //{

            //    undoControls.Add(new Control(drawPanelSelectedItem, "1"));
            //    undoOperationStack.Push(OperationType.ImageResize);
            //}
            if (!(sender is Panel))
            {
                Control control = (Control)sender;
                undoControls.Push(new PictureBox() { Location = control.Location, Width = control.Width, Height = control.Height, Name = control.Name });
                undoOperationStack.Push(OperationType.ImageResize);
            }
            if (!isImageDowntheMouse)
            {
                Control control = (Control)sender;
               

                isImageDowntheMouse = true;

                prevPoint = new Point(e.X, e.Y);

            }
            if (redoOperationStack.Count > 0)
            {
                RedoClear();
            }
        }
        private bool isDrawPanelResizeDown;
        private Point drawPanelResizePrevPoint;
        private void DrawingPanelDownToResize(object sender, MouseEventArgs e)
        {
            isDrawPanelResizeDown = true;
            drawPanelResizePrevPoint = new Point(e.X, e.Y);


        }
        private void DrawingPanelUpToResize(object sender, MouseEventArgs e)
        {
            isDrawPanelResizeDown = false;
            drawingpanelResize = ResizeMode.None;
        }
        private void DrawingPanelMoveToResize(object sender, MouseEventArgs e)
        {

            Control control = (Control)sender;
            int a = control.Height;
            int b = control.Width;
            Point temp2 = MainFillPanel.PointToClient(Cursor.Position);
            Point temp = DrawingPanel.PointToClient(Cursor.Position);
            if ((b - 8 <= temp.X && temp.X <= b) && (a - 8<= temp.Y && temp.Y <= a))  //leftBottom
            {
                if (isDrawPanelResizeDown == true)
                    drawingpanelResize = ResizeMode.RightBottom;
                control.Cursor = Cursors.SizeNWSE;
            }
            else
            {
                if (isDrawPanelResizeDown == false)
                {
                    control.Cursor = Cursors.Default;
                    drawingpanelResize = ResizeMode.None;
                }
            }

            if (isDrawPanelResizeDown && drawingpanelResize == ResizeMode.RightBottom)
            {
                control.MaximumSize = new Size(MainFillPanel.Width - (220 + 80) - control.Location.X, MainFillPanel.Height - control.Location.Y);
                control.Width = temp2.X - control.Location.X;
                control.Height = temp2.Y - control.Location.Y;
                if (control.Width + control.Location.X > (MainFillPanel.Width - (220 + 80)))
                {
                    control.Width = MainFillPanel.Width - (220 + 80) - control.Location.X;
                }
                if (control.Height + control.Location.Y > MainFillPanel.Height)
                    control.Height = MainFillPanel.Height - control.Location.Y;
            }

        }
        private void SizeBtnClick(object sender, EventArgs e)
        {
            isSizeChange = !isSizeChange;
            resizeMode = ResizeMode.None;

        }



        private void DrawPadLoad(object sender, EventArgs e)
        {
            applicationStartTimer.Start();

            // SVGImagePanel.Width = 1;
            //  IconsList = new List<Byte[]> { Properties.Resources.luigi, Properties.Resources.jake_1600, Properties.Resources.twitter, Properties.Resources.super_mario_1600, Properties.Resources.bmo, Properties.Resources.cheburashka };
        }

        private void SaveBtnClick(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";

            saveFileDialog1.Title = "Save tha draw file";
            DialogResult result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(DrawingPanel.Width, DrawingPanel.Height);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    // Draw the panel content onto the Bitmap
                    DrawingPanel.DrawToBitmap(bmp, DrawingPanel.ClientRectangle);
                }
                bmp.Save(saveFileDialog1.FileName);
            }
            if (redoOperationStack.Count > 0)
            {
                redoPointsColorandSize.Clear();
                redoControls.Clear();
                redoOperationStack.Clear();
                redoPoints.Clear();
            }
        }
        private void OnResize(object sender, EventArgs e)
        {

            DrawingPanel.Invalidate();
         
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SelectedColorP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customPanel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        Timer painttimer;
        private void DrawingPanel_Paint(object sender,PaintEventArgs e)
        {
            //  DrawingPanel.SuspendLayout();
            List<List<Point>> l1 = undoPoints.ToList();
            var l2 = undoPointsColorandSize.ToList();
            
            var g = e.Graphics;
           // using (Graphics g = DrawingPanel.CreateGraphics())
           // {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                for (int j = 0; j < l1.Count; j++)
                {
                    var p = l1[j];
                    var temp = l2[j];
                    Pen erasePen = new Pen(temp.Item1, temp.Item2);
                    erasePen.StartCap = LineCap.Round;
                    erasePen.EndCap = LineCap.Round;
                    for (int i = 0; i < p.Count - 1; i++)
                    {
                        g.DrawLine(erasePen, p[i], p[i + 1]);
                    }
                }
            //}
            //   DrawingPanel.ResumeLayout();
        }

        public void method(object sender, EventArgs e)
        {
        }

        private void SVGImagePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
