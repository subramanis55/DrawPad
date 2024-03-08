namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MainFillPanel = new CustomPanel();
            SVGImagePanel = new FlowLayoutPanel();
            ButtonPanel = new CustomPanel();
            customPanel8 = new CustomPanel();
            PaintBtn = new EllipseButton();
            customPanel5 = new CustomPanel();
            SizeBtn = new EllipseButton();
            customPanel1 = new CustomPanel();
            DeleteImageBtn = new EllipseButton();
            customPanel6 = new CustomPanel();
            HorizonalFlipBtn = new EllipseButton();
            customPanel7 = new CustomPanel();
            AddIconBtn = new EllipseButton();
            customPanel4 = new CustomPanel();
            VerticalFlipBtn = new EllipseButton();
            customPanel3 = new CustomPanel();
            LeftRotateBtn = new EllipseButton();
            customPanel2 = new CustomPanel();
            RightRotateBtn = new EllipseButton();
            ImagesPanelBtn = new EllipseButton();
            DrawingPanel = new Panel();
            TopPanel = new CustomPanel();
            RedoBtn = new EllipseButton();
            UndoBtn = new EllipseButton();
            customPanel9 = new CustomPanel();
            customPanel11 = new CustomPanel();
            label1 = new Label();
            SelectedColorP = new CustomPanel();
            customPanel10 = new CustomPanel();
            SizeComboBox = new ComboBox();
            PenSizeLB = new Label();
            ColorPanel = new ColorPanel();
            SaveBtn = new EllipseButton();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            MainFillPanel.SuspendLayout();
            ButtonPanel.SuspendLayout();
            customPanel8.SuspendLayout();
            customPanel5.SuspendLayout();
            customPanel1.SuspendLayout();
            customPanel6.SuspendLayout();
            customPanel7.SuspendLayout();
            customPanel4.SuspendLayout();
            customPanel3.SuspendLayout();
            customPanel2.SuspendLayout();
            TopPanel.SuspendLayout();
            customPanel9.SuspendLayout();
            customPanel11.SuspendLayout();
            customPanel10.SuspendLayout();
            SuspendLayout();
            // 
            // MainFillPanel
            // 
            MainFillPanel.AllBorderRadius = 20;
            MainFillPanel.AutoScroll = true;
            MainFillPanel.BackColor = Color.FromArgb(234, 234, 234);
            MainFillPanel.BorderColor = Color.Transparent;
            MainFillPanel.BorderMarginSize = 0;
            MainFillPanel.BottomLeftRadius = 20;
            MainFillPanel.BottomRight = 20;
            MainFillPanel.Controls.Add(SVGImagePanel);
            MainFillPanel.Controls.Add(ButtonPanel);
            MainFillPanel.Controls.Add(DrawingPanel);
            MainFillPanel.Controls.Add(TopPanel);
            MainFillPanel.Dock = DockStyle.Fill;
            MainFillPanel.Location = new Point(8, 2);
            MainFillPanel.Margin = new Padding(3, 2, 3, 2);
            MainFillPanel.Name = "MainFillPanel";
            MainFillPanel.Padding = new Padding(2);
            MainFillPanel.Size = new Size(1169, 594);
            MainFillPanel.TabIndex = 0;
            MainFillPanel.TopLeftRadius = 20;
            MainFillPanel.TopRightRadius = 20;
            MainFillPanel.Visible = false;
            // 
            // SVGImagePanel
            // 
            SVGImagePanel.BackColor = Color.LightSlateGray;
            SVGImagePanel.Cursor = Cursors.Hand;
            SVGImagePanel.Dock = DockStyle.Right;
            SVGImagePanel.Location = new Point(1095, 80);
            SVGImagePanel.Margin = new Padding(3, 2, 3, 2);
            SVGImagePanel.MaximumSize = new Size(220, 0);
            SVGImagePanel.Name = "SVGImagePanel";
            SVGImagePanel.Padding = new Padding(4);
            SVGImagePanel.Size = new Size(2, 512);
            SVGImagePanel.TabIndex = 1;
            SVGImagePanel.Paint += SVGImagePanel_Paint;
            // 
            // ButtonPanel
            // 
            ButtonPanel.AllBorderRadius = 15;
            ButtonPanel.AutoScroll = true;
            ButtonPanel.BackColor = Color.White;
            ButtonPanel.BorderColor = Color.Transparent;
            ButtonPanel.BorderMarginSize = 0;
            ButtonPanel.BottomLeftRadius = 15;
            ButtonPanel.BottomRight = 15;
            ButtonPanel.Controls.Add(customPanel8);
            ButtonPanel.Controls.Add(customPanel5);
            ButtonPanel.Controls.Add(customPanel1);
            ButtonPanel.Controls.Add(customPanel6);
            ButtonPanel.Controls.Add(customPanel7);
            ButtonPanel.Controls.Add(customPanel4);
            ButtonPanel.Controls.Add(customPanel3);
            ButtonPanel.Controls.Add(customPanel2);
            ButtonPanel.Controls.Add(ImagesPanelBtn);
            ButtonPanel.Dock = DockStyle.Right;
            ButtonPanel.Location = new Point(1097, 80);
            ButtonPanel.Margin = new Padding(3, 2, 3, 2);
            ButtonPanel.MinimumSize = new Size(70, 0);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Padding = new Padding(0, 3, 3, 3);
            ButtonPanel.Size = new Size(70, 512);
            ButtonPanel.TabIndex = 2;
            ButtonPanel.TopLeftRadius = 15;
            ButtonPanel.TopRightRadius = 15;
            // 
            // customPanel8
            // 
            customPanel8.AllBorderRadius = 1;
            customPanel8.BorderColor = Color.Transparent;
            customPanel8.BorderMarginSize = 0;
            customPanel8.BottomLeftRadius = 1;
            customPanel8.BottomRight = 1;
            customPanel8.Controls.Add(PaintBtn);
            customPanel8.Dock = DockStyle.Top;
            customPanel8.Location = new Point(0, 390);
            customPanel8.Margin = new Padding(3, 2, 3, 2);
            customPanel8.Name = "customPanel8";
            customPanel8.Padding = new Padding(4);
            customPanel8.Size = new Size(67, 58);
            customPanel8.TabIndex = 8;
            customPanel8.TopLeftRadius = 1;
            customPanel8.TopRightRadius = 1;
            // 
            // PaintBtn
            // 
            PaintBtn.BackColor = Color.White;
            PaintBtn.BackgroudColor = Color.White;
            PaintBtn.BorderColor = Color.PaleVioletRed;
            PaintBtn.BorderRadius1 = 20;
            PaintBtn.BorderSize1 = 0;
            PaintBtn.Dock = DockStyle.Fill;
            PaintBtn.FlatAppearance.BorderSize = 0;
            PaintBtn.FlatStyle = FlatStyle.Flat;
            PaintBtn.ForeColor = Color.White;
            PaintBtn.Image = Properties.Resources.icons8_paint_brush_50;
            PaintBtn.Location = new Point(4, 4);
            PaintBtn.Margin = new Padding(3, 2, 3, 2);
            PaintBtn.Name = "PaintBtn";
            PaintBtn.Size = new Size(59, 50);
            PaintBtn.TabIndex = 0;
            PaintBtn.TextColor = Color.White;
            PaintBtn.UseVisualStyleBackColor = false;
            // 
            // customPanel5
            // 
            customPanel5.AllBorderRadius = 1;
            customPanel5.BorderColor = Color.Transparent;
            customPanel5.BorderMarginSize = 0;
            customPanel5.BottomLeftRadius = 1;
            customPanel5.BottomRight = 1;
            customPanel5.Controls.Add(SizeBtn);
            customPanel5.Dock = DockStyle.Top;
            customPanel5.Location = new Point(0, 338);
            customPanel5.Margin = new Padding(3, 2, 3, 2);
            customPanel5.Name = "customPanel5";
            customPanel5.Padding = new Padding(4);
            customPanel5.Size = new Size(67, 52);
            customPanel5.TabIndex = 4;
            customPanel5.TopLeftRadius = 1;
            customPanel5.TopRightRadius = 1;
            // 
            // SizeBtn
            // 
            SizeBtn.BackColor = Color.White;
            SizeBtn.BackgroudColor = Color.White;
            SizeBtn.BorderColor = Color.PaleVioletRed;
            SizeBtn.BorderRadius1 = 20;
            SizeBtn.BorderSize1 = 0;
            SizeBtn.Dock = DockStyle.Fill;
            SizeBtn.FlatAppearance.BorderSize = 0;
            SizeBtn.FlatStyle = FlatStyle.Flat;
            SizeBtn.ForeColor = Color.White;
            SizeBtn.Image = Properties.Resources.icons8_page_size_50;
            SizeBtn.Location = new Point(4, 4);
            SizeBtn.Margin = new Padding(3, 2, 3, 2);
            SizeBtn.Name = "SizeBtn";
            SizeBtn.Size = new Size(59, 44);
            SizeBtn.TabIndex = 0;
            SizeBtn.TextColor = Color.White;
            SizeBtn.UseVisualStyleBackColor = false;
            // 
            // customPanel1
            // 
            customPanel1.AllBorderRadius = 1;
            customPanel1.BorderColor = Color.Transparent;
            customPanel1.BorderMarginSize = 0;
            customPanel1.BottomLeftRadius = 1;
            customPanel1.BottomRight = 1;
            customPanel1.Controls.Add(DeleteImageBtn);
            customPanel1.Dock = DockStyle.Top;
            customPanel1.Location = new Point(0, 285);
            customPanel1.Margin = new Padding(3, 2, 3, 2);
            customPanel1.Name = "customPanel1";
            customPanel1.Padding = new Padding(4);
            customPanel1.Size = new Size(67, 53);
            customPanel1.TabIndex = 10;
            customPanel1.TopLeftRadius = 1;
            customPanel1.TopRightRadius = 1;
            // 
            // DeleteImageBtn
            // 
            DeleteImageBtn.BackColor = Color.White;
            DeleteImageBtn.BackgroudColor = Color.White;
            DeleteImageBtn.BorderColor = Color.PaleVioletRed;
            DeleteImageBtn.BorderRadius1 = 20;
            DeleteImageBtn.BorderSize1 = 0;
            DeleteImageBtn.Dock = DockStyle.Fill;
            DeleteImageBtn.FlatAppearance.BorderSize = 0;
            DeleteImageBtn.FlatStyle = FlatStyle.Flat;
            DeleteImageBtn.ForeColor = Color.White;
            DeleteImageBtn.Image = Properties.Resources.icons8_delete_50;
            DeleteImageBtn.Location = new Point(4, 4);
            DeleteImageBtn.Margin = new Padding(3, 2, 3, 2);
            DeleteImageBtn.Name = "DeleteImageBtn";
            DeleteImageBtn.Size = new Size(59, 45);
            DeleteImageBtn.TabIndex = 7;
            DeleteImageBtn.TextColor = Color.White;
            DeleteImageBtn.UseVisualStyleBackColor = false;
            // 
            // customPanel6
            // 
            customPanel6.AllBorderRadius = 1;
            customPanel6.BorderColor = Color.Transparent;
            customPanel6.BorderMarginSize = 0;
            customPanel6.BottomLeftRadius = 1;
            customPanel6.BottomRight = 1;
            customPanel6.Controls.Add(HorizonalFlipBtn);
            customPanel6.Dock = DockStyle.Top;
            customPanel6.Location = new Point(0, 231);
            customPanel6.Margin = new Padding(3, 2, 3, 2);
            customPanel6.Name = "customPanel6";
            customPanel6.Padding = new Padding(4);
            customPanel6.Size = new Size(67, 54);
            customPanel6.TabIndex = 5;
            customPanel6.TopLeftRadius = 1;
            customPanel6.TopRightRadius = 1;
            // 
            // HorizonalFlipBtn
            // 
            HorizonalFlipBtn.BackColor = Color.White;
            HorizonalFlipBtn.BackgroudColor = Color.White;
            HorizonalFlipBtn.BorderColor = Color.PaleVioletRed;
            HorizonalFlipBtn.BorderRadius1 = 20;
            HorizonalFlipBtn.BorderSize1 = 0;
            HorizonalFlipBtn.Dock = DockStyle.Fill;
            HorizonalFlipBtn.FlatAppearance.BorderSize = 0;
            HorizonalFlipBtn.FlatStyle = FlatStyle.Flat;
            HorizonalFlipBtn.ForeColor = Color.White;
            HorizonalFlipBtn.Image = Properties.Resources.icons8_flip_vertical_50;
            HorizonalFlipBtn.Location = new Point(4, 4);
            HorizonalFlipBtn.Margin = new Padding(3, 2, 3, 2);
            HorizonalFlipBtn.Name = "HorizonalFlipBtn";
            HorizonalFlipBtn.Size = new Size(59, 46);
            HorizonalFlipBtn.TabIndex = 0;
            HorizonalFlipBtn.TextColor = Color.White;
            HorizonalFlipBtn.UseVisualStyleBackColor = false;
            // 
            // customPanel7
            // 
            customPanel7.AllBorderRadius = 1;
            customPanel7.BorderColor = Color.Transparent;
            customPanel7.BorderMarginSize = 0;
            customPanel7.BottomLeftRadius = 1;
            customPanel7.BottomRight = 1;
            customPanel7.Controls.Add(AddIconBtn);
            customPanel7.Dock = DockStyle.Bottom;
            customPanel7.Location = new Point(0, 448);
            customPanel7.Margin = new Padding(3, 2, 3, 2);
            customPanel7.Name = "customPanel7";
            customPanel7.Padding = new Padding(4);
            customPanel7.Size = new Size(67, 61);
            customPanel7.TabIndex = 6;
            customPanel7.TopLeftRadius = 1;
            customPanel7.TopRightRadius = 1;
            // 
            // AddIconBtn
            // 
            AddIconBtn.BackColor = Color.FromArgb(244, 244, 244);
            AddIconBtn.BackgroudColor = Color.FromArgb(244, 244, 244);
            AddIconBtn.BorderColor = Color.PaleVioletRed;
            AddIconBtn.BorderRadius1 = 20;
            AddIconBtn.BorderSize1 = 0;
            AddIconBtn.Dock = DockStyle.Fill;
            AddIconBtn.FlatAppearance.BorderSize = 0;
            AddIconBtn.FlatStyle = FlatStyle.Flat;
            AddIconBtn.ForeColor = Color.White;
            AddIconBtn.Image = Properties.Resources.icons8_add_image_50;
            AddIconBtn.Location = new Point(4, 4);
            AddIconBtn.Margin = new Padding(3, 2, 3, 2);
            AddIconBtn.Name = "AddIconBtn";
            AddIconBtn.Size = new Size(59, 53);
            AddIconBtn.TabIndex = 0;
            AddIconBtn.TextColor = Color.White;
            AddIconBtn.UseVisualStyleBackColor = false;
            // 
            // customPanel4
            // 
            customPanel4.AllBorderRadius = 1;
            customPanel4.BorderColor = Color.Transparent;
            customPanel4.BorderMarginSize = 0;
            customPanel4.BottomLeftRadius = 1;
            customPanel4.BottomRight = 1;
            customPanel4.Controls.Add(VerticalFlipBtn);
            customPanel4.Dock = DockStyle.Top;
            customPanel4.Location = new Point(0, 178);
            customPanel4.Margin = new Padding(3, 2, 3, 2);
            customPanel4.Name = "customPanel4";
            customPanel4.Padding = new Padding(4);
            customPanel4.Size = new Size(67, 53);
            customPanel4.TabIndex = 3;
            customPanel4.TopLeftRadius = 1;
            customPanel4.TopRightRadius = 1;
            // 
            // VerticalFlipBtn
            // 
            VerticalFlipBtn.BackColor = Color.White;
            VerticalFlipBtn.BackgroudColor = Color.White;
            VerticalFlipBtn.BorderColor = Color.PaleVioletRed;
            VerticalFlipBtn.BorderRadius1 = 20;
            VerticalFlipBtn.BorderSize1 = 0;
            VerticalFlipBtn.Dock = DockStyle.Fill;
            VerticalFlipBtn.FlatAppearance.BorderSize = 0;
            VerticalFlipBtn.FlatStyle = FlatStyle.Flat;
            VerticalFlipBtn.ForeColor = Color.White;
            VerticalFlipBtn.Image = Properties.Resources.icons8_flip_horizontal_50;
            VerticalFlipBtn.Location = new Point(4, 4);
            VerticalFlipBtn.Margin = new Padding(3, 2, 3, 2);
            VerticalFlipBtn.Name = "VerticalFlipBtn";
            VerticalFlipBtn.Size = new Size(59, 45);
            VerticalFlipBtn.TabIndex = 0;
            VerticalFlipBtn.TextColor = Color.White;
            VerticalFlipBtn.UseVisualStyleBackColor = false;
            // 
            // customPanel3
            // 
            customPanel3.AllBorderRadius = 1;
            customPanel3.BorderColor = Color.Transparent;
            customPanel3.BorderMarginSize = 0;
            customPanel3.BottomLeftRadius = 1;
            customPanel3.BottomRight = 1;
            customPanel3.Controls.Add(LeftRotateBtn);
            customPanel3.Dock = DockStyle.Top;
            customPanel3.Location = new Point(0, 120);
            customPanel3.Margin = new Padding(3, 2, 3, 2);
            customPanel3.Name = "customPanel3";
            customPanel3.Padding = new Padding(4);
            customPanel3.Size = new Size(67, 58);
            customPanel3.TabIndex = 2;
            customPanel3.TopLeftRadius = 1;
            customPanel3.TopRightRadius = 1;
            // 
            // LeftRotateBtn
            // 
            LeftRotateBtn.BackColor = Color.White;
            LeftRotateBtn.BackgroudColor = Color.White;
            LeftRotateBtn.BorderColor = Color.PaleVioletRed;
            LeftRotateBtn.BorderRadius1 = 20;
            LeftRotateBtn.BorderSize1 = 0;
            LeftRotateBtn.Dock = DockStyle.Fill;
            LeftRotateBtn.FlatAppearance.BorderSize = 0;
            LeftRotateBtn.FlatStyle = FlatStyle.Flat;
            LeftRotateBtn.ForeColor = Color.White;
            LeftRotateBtn.Image = Properties.Resources.icons8_rotate_left_50;
            LeftRotateBtn.Location = new Point(4, 4);
            LeftRotateBtn.Margin = new Padding(3, 2, 3, 2);
            LeftRotateBtn.Name = "LeftRotateBtn";
            LeftRotateBtn.Size = new Size(59, 50);
            LeftRotateBtn.TabIndex = 0;
            LeftRotateBtn.TextColor = Color.White;
            LeftRotateBtn.UseVisualStyleBackColor = false;
            // 
            // customPanel2
            // 
            customPanel2.AllBorderRadius = 1;
            customPanel2.BorderColor = Color.Transparent;
            customPanel2.BorderMarginSize = 0;
            customPanel2.BottomLeftRadius = 1;
            customPanel2.BottomRight = 1;
            customPanel2.Controls.Add(RightRotateBtn);
            customPanel2.Dock = DockStyle.Top;
            customPanel2.Location = new Point(0, 61);
            customPanel2.Margin = new Padding(3, 2, 3, 2);
            customPanel2.Name = "customPanel2";
            customPanel2.Padding = new Padding(4);
            customPanel2.Size = new Size(67, 59);
            customPanel2.TabIndex = 1;
            customPanel2.TopLeftRadius = 1;
            customPanel2.TopRightRadius = 1;
            // 
            // RightRotateBtn
            // 
            RightRotateBtn.BackColor = Color.White;
            RightRotateBtn.BackgroudColor = Color.White;
            RightRotateBtn.BorderColor = Color.PaleVioletRed;
            RightRotateBtn.BorderRadius1 = 20;
            RightRotateBtn.BorderSize1 = 0;
            RightRotateBtn.Dock = DockStyle.Fill;
            RightRotateBtn.FlatAppearance.BorderSize = 0;
            RightRotateBtn.FlatStyle = FlatStyle.Flat;
            RightRotateBtn.ForeColor = Color.White;
            RightRotateBtn.Image = (Image)resources.GetObject("RightRotateBtn.Image");
            RightRotateBtn.Location = new Point(4, 4);
            RightRotateBtn.Margin = new Padding(3, 2, 3, 2);
            RightRotateBtn.Name = "RightRotateBtn";
            RightRotateBtn.Size = new Size(59, 51);
            RightRotateBtn.TabIndex = 0;
            RightRotateBtn.TextColor = Color.White;
            RightRotateBtn.UseVisualStyleBackColor = false;
            // 
            // ImagesPanelBtn
            // 
            ImagesPanelBtn.BackColor = Color.White;
            ImagesPanelBtn.BackgroudColor = Color.White;
            ImagesPanelBtn.BorderColor = Color.PaleVioletRed;
            ImagesPanelBtn.BorderRadius1 = 20;
            ImagesPanelBtn.BorderSize1 = 0;
            ImagesPanelBtn.Dock = DockStyle.Top;
            ImagesPanelBtn.FlatAppearance.BorderSize = 0;
            ImagesPanelBtn.FlatStyle = FlatStyle.Flat;
            ImagesPanelBtn.ForeColor = Color.White;
            ImagesPanelBtn.Image = Properties.Resources.icons8_medium_icons_50;
            ImagesPanelBtn.Location = new Point(0, 3);
            ImagesPanelBtn.Margin = new Padding(3, 2, 3, 2);
            ImagesPanelBtn.Name = "ImagesPanelBtn";
            ImagesPanelBtn.Size = new Size(67, 58);
            ImagesPanelBtn.TabIndex = 8;
            ImagesPanelBtn.TextColor = Color.White;
            ImagesPanelBtn.UseVisualStyleBackColor = false;
            // 
            // DrawingPanel
            // 
            DrawingPanel.BackColor = Color.White;
            DrawingPanel.BackgroundImageLayout = ImageLayout.Zoom;
            DrawingPanel.BorderStyle = BorderStyle.FixedSingle;
            DrawingPanel.ForeColor = SystemColors.ControlText;
            DrawingPanel.Location = new Point(3, 93);
            DrawingPanel.Margin = new Padding(3, 2, 3, 2);
            DrawingPanel.MinimumSize = new Size(50, 50);
            DrawingPanel.Name = "DrawingPanel";
            DrawingPanel.Size = new Size(824, 492);
            DrawingPanel.TabIndex = 3;
            // 
            // TopPanel
            // 
            TopPanel.AllBorderRadius = 10;
            TopPanel.BackColor = Color.FromArgb(10, 21, 47);
            TopPanel.BorderColor = Color.Transparent;
            TopPanel.BorderMarginSize = 0;
            TopPanel.BottomLeftRadius = 10;
            TopPanel.BottomRight = 10;
            TopPanel.Controls.Add(RedoBtn);
            TopPanel.Controls.Add(UndoBtn);
            TopPanel.Controls.Add(customPanel9);
            TopPanel.Controls.Add(ColorPanel);
            TopPanel.Controls.Add(SaveBtn);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(2, 2);
            TopPanel.Margin = new Padding(3, 2, 3, 2);
            TopPanel.Name = "TopPanel";
            TopPanel.Padding = new Padding(18, 6, 13, 6);
            TopPanel.Size = new Size(1165, 78);
            TopPanel.TabIndex = 0;
            TopPanel.TopLeftRadius = 10;
            TopPanel.TopRightRadius = 10;
            // 
            // RedoBtn
            // 
            RedoBtn.BackColor = Color.White;
            RedoBtn.BackgroudColor = Color.White;
            RedoBtn.BorderColor = Color.PaleVioletRed;
            RedoBtn.BorderRadius1 = 10;
            RedoBtn.BorderSize1 = 0;
            RedoBtn.FlatAppearance.BorderSize = 0;
            RedoBtn.FlatStyle = FlatStyle.Flat;
            RedoBtn.ForeColor = Color.Turquoise;
            RedoBtn.Image = Properties.Resources.icons8_redo_48;
            RedoBtn.Location = new Point(176, 7);
            RedoBtn.Margin = new Padding(3, 2, 3, 2);
            RedoBtn.Name = "RedoBtn";
            RedoBtn.Size = new Size(44, 30);
            RedoBtn.TabIndex = 6;
            RedoBtn.TextColor = Color.Turquoise;
            RedoBtn.UseVisualStyleBackColor = false;
            // 
            // UndoBtn
            // 
            UndoBtn.BackColor = Color.White;
            UndoBtn.BackgroudColor = Color.White;
            UndoBtn.BorderColor = Color.PaleVioletRed;
            UndoBtn.BorderRadius1 = 10;
            UndoBtn.BorderSize1 = 0;
            UndoBtn.FlatAppearance.BorderSize = 0;
            UndoBtn.FlatStyle = FlatStyle.Flat;
            UndoBtn.ForeColor = Color.Turquoise;
            UndoBtn.Image = Properties.Resources.icons8_undo_48;
            UndoBtn.Location = new Point(123, 6);
            UndoBtn.Margin = new Padding(3, 2, 3, 2);
            UndoBtn.Name = "UndoBtn";
            UndoBtn.Size = new Size(47, 30);
            UndoBtn.TabIndex = 5;
            UndoBtn.TextColor = Color.Turquoise;
            UndoBtn.UseVisualStyleBackColor = false;
            // 
            // customPanel9
            // 
            customPanel9.AllBorderRadius = 1;
            customPanel9.BackColor = Color.White;
            customPanel9.BorderColor = Color.Transparent;
            customPanel9.BorderMarginSize = 0;
            customPanel9.BottomLeftRadius = 1;
            customPanel9.BottomRight = 1;
            customPanel9.Controls.Add(customPanel11);
            customPanel9.Controls.Add(customPanel10);
            customPanel9.Dock = DockStyle.Right;
            customPanel9.Location = new Point(777, 6);
            customPanel9.Margin = new Padding(3, 2, 3, 2);
            customPanel9.Name = "customPanel9";
            customPanel9.Padding = new Padding(4, 3, 4, 3);
            customPanel9.Size = new Size(156, 66);
            customPanel9.TabIndex = 3;
            customPanel9.TopLeftRadius = 20;
            customPanel9.TopRightRadius = 1;
            // 
            // customPanel11
            // 
            customPanel11.AllBorderRadius = 1;
            customPanel11.BackColor = Color.White;
            customPanel11.BorderColor = Color.Transparent;
            customPanel11.BorderMarginSize = 0;
            customPanel11.BottomLeftRadius = 1;
            customPanel11.BottomRight = 1;
            customPanel11.Controls.Add(label1);
            customPanel11.Controls.Add(SelectedColorP);
            customPanel11.Dock = DockStyle.Top;
            customPanel11.Location = new Point(4, 3);
            customPanel11.Margin = new Padding(3, 2, 3, 2);
            customPanel11.Name = "customPanel11";
            customPanel11.Padding = new Padding(4, 3, 4, 3);
            customPanel11.Size = new Size(148, 23);
            customPanel11.TabIndex = 6;
            customPanel11.TopLeftRadius = 1;
            customPanel11.TopRightRadius = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(4, 3);
            label1.Name = "label1";
            label1.Size = new Size(115, 23);
            label1.TabIndex = 2;
            label1.Text = "SelectedColor";
            label1.Click += label1_Click;
            // 
            // SelectedColorP
            // 
            SelectedColorP.AllBorderRadius = 1;
            SelectedColorP.BackColor = SystemColors.ActiveBorder;
            SelectedColorP.BorderColor = Color.Transparent;
            SelectedColorP.BorderMarginSize = 0;
            SelectedColorP.BottomLeftRadius = 1;
            SelectedColorP.BottomRight = 1;
            SelectedColorP.Dock = DockStyle.Right;
            SelectedColorP.Location = new Point(122, 3);
            SelectedColorP.Margin = new Padding(3, 2, 3, 2);
            SelectedColorP.MaximumSize = new Size(22, 19);
            SelectedColorP.Name = "SelectedColorP";
            SelectedColorP.Size = new Size(22, 17);
            SelectedColorP.TabIndex = 3;
            SelectedColorP.TopLeftRadius = 1;
            SelectedColorP.TopRightRadius = 1;
            SelectedColorP.Paint += SelectedColorP_Paint;
            // 
            // customPanel10
            // 
            customPanel10.AllBorderRadius = 1;
            customPanel10.BorderColor = Color.Transparent;
            customPanel10.BorderMarginSize = 0;
            customPanel10.BottomLeftRadius = 1;
            customPanel10.BottomRight = 1;
            customPanel10.Controls.Add(SizeComboBox);
            customPanel10.Controls.Add(PenSizeLB);
            customPanel10.Dock = DockStyle.Bottom;
            customPanel10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customPanel10.Location = new Point(4, 39);
            customPanel10.Margin = new Padding(3, 2, 3, 2);
            customPanel10.Name = "customPanel10";
            customPanel10.Padding = new Padding(4, 3, 4, 3);
            customPanel10.Size = new Size(148, 24);
            customPanel10.TabIndex = 5;
            customPanel10.TopLeftRadius = 1;
            customPanel10.TopRightRadius = 1;
            customPanel10.Paint += customPanel10_Paint;
            // 
            // SizeComboBox
            // 
            SizeComboBox.BackColor = SystemColors.HighlightText;
            SizeComboBox.Dock = DockStyle.Right;
            SizeComboBox.FormattingEnabled = true;
            SizeComboBox.Items.AddRange(new object[] { "2", "4", "6", "8", "10", "12", "14", "16", "18", "20", "22", "24", "26", "28", "30", "36" });
            SizeComboBox.Location = new Point(99, 3);
            SizeComboBox.Margin = new Padding(3, 2, 3, 2);
            SizeComboBox.Name = "SizeComboBox";
            SizeComboBox.Size = new Size(45, 29);
            SizeComboBox.TabIndex = 5;
            // 
            // PenSizeLB
            // 
            PenSizeLB.AutoSize = true;
            PenSizeLB.Dock = DockStyle.Left;
            PenSizeLB.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PenSizeLB.ForeColor = Color.Black;
            PenSizeLB.Location = new Point(4, 3);
            PenSizeLB.Name = "PenSizeLB";
            PenSizeLB.Size = new Size(40, 23);
            PenSizeLB.TabIndex = 4;
            PenSizeLB.Text = "Size";
            // 
            // ColorPanel
            // 
            ColorPanel.BackColor = Color.White;
            ColorPanel.Cursor = Cursors.Hand;
            ColorPanel.Dock = DockStyle.Right;
            ColorPanel.Location = new Point(933, 6);
            ColorPanel.Margin = new Padding(3, 2, 3, 2);
            ColorPanel.Name = "ColorPanel";
            ColorPanel.Size = new Size(219, 66);
            ColorPanel.TabIndex = 4;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.MintCream;
            SaveBtn.BackgroudColor = Color.MintCream;
            SaveBtn.BorderColor = Color.PaleVioletRed;
            SaveBtn.BorderRadius1 = 22;
            SaveBtn.BorderSize1 = 0;
            SaveBtn.Dock = DockStyle.Left;
            SaveBtn.FlatAppearance.BorderSize = 0;
            SaveBtn.FlatStyle = FlatStyle.Flat;
            SaveBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveBtn.ForeColor = Color.Black;
            SaveBtn.Location = new Point(18, 6);
            SaveBtn.Margin = new Padding(3, 2, 3, 2);
            SaveBtn.MaximumSize = new Size(0, 30);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(87, 30);
            SaveBtn.TabIndex = 0;
            SaveBtn.Text = "Save";
            SaveBtn.TextColor = Color.Black;
            SaveBtn.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.paint_palette;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1185, 604);
            Controls.Add(MainFillPanel);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(300, 300);
            Name = "Form1";
            Padding = new Padding(8, 2, 8, 8);
            Text = "DrawPad";
            MainFillPanel.ResumeLayout(false);
            ButtonPanel.ResumeLayout(false);
            customPanel8.ResumeLayout(false);
            customPanel5.ResumeLayout(false);
            customPanel1.ResumeLayout(false);
            customPanel6.ResumeLayout(false);
            customPanel7.ResumeLayout(false);
            customPanel4.ResumeLayout(false);
            customPanel3.ResumeLayout(false);
            customPanel2.ResumeLayout(false);
            TopPanel.ResumeLayout(false);
            customPanel9.ResumeLayout(false);
            customPanel11.ResumeLayout(false);
            customPanel11.PerformLayout();
            customPanel10.ResumeLayout(false);
            customPanel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CustomPanel MainFillPanel;
        private CustomPanel TopPanel;
        private CustomPanel ButtonPanel;
        private EllipseButton RightRotateBtn;
        private FlowLayoutPanel SVGImagePanel;
        private CustomPanel customPanel7;
        private EllipseButton AddIconBtn;
        private CustomPanel customPanel6;
        private EllipseButton PaintBtn;
        private CustomPanel customPanel5;
        private EllipseButton SizeBtn;
        private CustomPanel customPanel4;
        private EllipseButton VerticalFlipBtn;
        private CustomPanel customPanel3;
        private EllipseButton LeftRotateBtn;
        private CustomPanel customPanel2;
        private EllipseButton SaveBtn;
        private CustomPanel customPanel9;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private CustomPanel SelectedColorP;
        private CustomPanel customPanel11;
        private Label PenSizeLB;
        private CustomPanel customPanel10;
        private ComboBox SizeComboBox;
        private EllipseButton DeleteImageBtn;
        private ColorPanel ColorPanel;
        private EllipseButton ImagesPanelBtn;
        private Panel DrawingPanel;
        private EllipseButton RedoBtn;
        private EllipseButton UndoBtn;
        private CustomPanel customPanel1;
        private EllipseButton HorizonalFlipBtn;
        private CustomPanel customPanel8;
    }
}
