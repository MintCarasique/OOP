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
            this.pencilButton = new System.Windows.Forms.CheckBox();
            this.LineButton = new System.Windows.Forms.CheckBox();
            this.rectangleButton = new System.Windows.Forms.CheckBox();
            this.circleButton = new System.Windows.Forms.Button();
            this.triangleButton = new System.Windows.Forms.Button();
            this.curveButton = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.shapePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // shapePictureBox
            // 
            this.shapePictureBox.BackColor = System.Drawing.SystemColors.Window;
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
            // pencilButton
            // 
            this.pencilButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.pencilButton.Location = new System.Drawing.Point(13, 368);
            this.pencilButton.Name = "pencilButton";
            this.pencilButton.Size = new System.Drawing.Size(44, 24);
            this.pencilButton.TabIndex = 0;
            this.pencilButton.Text = "Pencil";
            this.pencilButton.Click += new System.EventHandler(this.pencilButton_Click);
            // 
            // LineButton
            // 
            this.LineButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.LineButton.AutoSize = true;
            this.LineButton.Location = new System.Drawing.Point(63, 369);
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(37, 23);
            this.LineButton.TabIndex = 8;
            this.LineButton.Text = "Line";
            this.LineButton.Click += new System.EventHandler(this.lineButton_Click_1);
            // 
            // rectangleButton
            // 
            this.rectangleButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.rectangleButton.AutoSize = true;
            this.rectangleButton.Location = new System.Drawing.Point(106, 369);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(66, 23);
            this.rectangleButton.TabIndex = 9;
            this.rectangleButton.Text = "Rectangle";
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
            // 
            // circleButton
            // 
            this.circleButton.Location = new System.Drawing.Point(178, 369);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(48, 23);
            this.circleButton.TabIndex = 10;
            this.circleButton.Text = "Circle";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // triangleButton
            // 
            this.triangleButton.Location = new System.Drawing.Point(232, 369);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(53, 23);
            this.triangleButton.TabIndex = 11;
            this.triangleButton.Text = "Triangle";
            this.triangleButton.UseVisualStyleBackColor = true;
            this.triangleButton.Click += new System.EventHandler(this.triangleButton_Click);
            // 
            // curveButton
            // 
            this.curveButton.Location = new System.Drawing.Point(291, 369);
            this.curveButton.Name = "curveButton";
            this.curveButton.Size = new System.Drawing.Size(44, 23);
            this.curveButton.TabIndex = 12;
            this.curveButton.Text = "Curve";
            this.curveButton.UseVisualStyleBackColor = true;
            this.curveButton.Click += new System.EventHandler(this.curveButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 403);
            this.Controls.Add(this.curveButton);
            this.Controls.Add(this.triangleButton);
            this.Controls.Add(this.circleButton);
            this.Controls.Add(this.rectangleButton);
            this.Controls.Add(this.LineButton);
            this.Controls.Add(this.widthTrackBar);
            this.Controls.Add(this.pencilButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.shapePictureBox);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Lab1";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shapePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox shapePictureBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TrackBar widthTrackBar;
        private System.Windows.Forms.CheckBox pencilButton;
        private System.Windows.Forms.CheckBox LineButton;
        private System.Windows.Forms.CheckBox rectangleButton;
        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.Button triangleButton;
        private System.Windows.Forms.Button curveButton;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}

