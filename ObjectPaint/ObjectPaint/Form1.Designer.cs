namespace ObjectPaint
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.shapePictureBox = new System.Windows.Forms.PictureBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.widthTrackBar = new System.Windows.Forms.TrackBar();
            this.circleButton = new System.Windows.Forms.Button();
            this.triangleButton = new System.Windows.Forms.Button();
            this.curveButton = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.pencilButton = new System.Windows.Forms.Button();
            this.lineButton = new System.Windows.Forms.Button();
            this.rectangleButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.shapePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // shapePictureBox
            // 
            this.shapePictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.shapePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.shapePictureBox.Location = new System.Drawing.Point(12, 12);
            this.shapePictureBox.Name = "shapePictureBox";
            this.shapePictureBox.Size = new System.Drawing.Size(604, 350);
            this.shapePictureBox.TabIndex = 6;
            this.shapePictureBox.TabStop = false;
            this.shapePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.shapePictureBox_Paint);
            this.shapePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.shapePictureBox_MouseDown);
            this.shapePictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.shapePictureBox_MouseMove);
            this.shapePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.shapePictureBox_MouseUp);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(540, 368);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // widthTrackBar
            // 
            this.widthTrackBar.AutoSize = false;
            this.widthTrackBar.Location = new System.Drawing.Point(430, 368);
            this.widthTrackBar.Minimum = 1;
            this.widthTrackBar.Name = "widthTrackBar";
            this.widthTrackBar.Size = new System.Drawing.Size(104, 24);
            this.widthTrackBar.TabIndex = 7;
            this.widthTrackBar.Value = 1;
            this.widthTrackBar.Scroll += new System.EventHandler(this.widthTrackBar_Scroll);
            // 
            // circleButton
            // 
            this.circleButton.Location = new System.Drawing.Point(184, 369);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(48, 23);
            this.circleButton.TabIndex = 10;
            this.circleButton.Text = "Circle";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // triangleButton
            // 
            this.triangleButton.Location = new System.Drawing.Point(238, 369);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(53, 23);
            this.triangleButton.TabIndex = 11;
            this.triangleButton.Text = "Triangle";
            this.triangleButton.UseVisualStyleBackColor = true;
            this.triangleButton.Click += new System.EventHandler(this.triangleButton_Click);
            // 
            // curveButton
            // 
            this.curveButton.Location = new System.Drawing.Point(297, 369);
            this.curveButton.Name = "curveButton";
            this.curveButton.Size = new System.Drawing.Size(44, 23);
            this.curveButton.TabIndex = 12;
            this.curveButton.Text = "Curve";
            this.curveButton.UseVisualStyleBackColor = true;
            this.curveButton.Click += new System.EventHandler(this.curveButton_Click);
            // 
            // pencilButton
            // 
            this.pencilButton.Location = new System.Drawing.Point(12, 369);
            this.pencilButton.Name = "pencilButton";
            this.pencilButton.Size = new System.Drawing.Size(51, 23);
            this.pencilButton.TabIndex = 13;
            this.pencilButton.Text = "Pencil";
            this.pencilButton.UseVisualStyleBackColor = true;
            this.pencilButton.Click += new System.EventHandler(this.pencilButton_Click);
            // 
            // lineButton
            // 
            this.lineButton.Location = new System.Drawing.Point(69, 369);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(35, 23);
            this.lineButton.TabIndex = 14;
            this.lineButton.Text = "Line";
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.Click += new System.EventHandler(this.lineButton_Click_1);
            // 
            // rectangleButton
            // 
            this.rectangleButton.Location = new System.Drawing.Point(110, 369);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(66, 23);
            this.rectangleButton.TabIndex = 15;
            this.rectangleButton.Text = "Rectangle";
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 403);
            this.Controls.Add(this.rectangleButton);
            this.Controls.Add(this.lineButton);
            this.Controls.Add(this.pencilButton);
            this.Controls.Add(this.curveButton);
            this.Controls.Add(this.triangleButton);
            this.Controls.Add(this.circleButton);
            this.Controls.Add(this.widthTrackBar);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.shapePictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Lab1";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shapePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox shapePictureBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TrackBar widthTrackBar;
        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.Button triangleButton;
        private System.Windows.Forms.Button curveButton;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button pencilButton;
        private System.Windows.Forms.Button lineButton;
        private System.Windows.Forms.Button rectangleButton;
    }
}

