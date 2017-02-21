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
            this.circleButton = new System.Windows.Forms.Button();
            this.squareButton = new System.Windows.Forms.Button();
            this.triangleButton = new System.Windows.Forms.Button();
            this.lineButton = new System.Windows.Forms.Button();
            this.pentagonButton = new System.Windows.Forms.Button();
            this.hexagonButton = new System.Windows.Forms.Button();
            this.shapePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.shapePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // circleButton
            // 
            this.circleButton.Location = new System.Drawing.Point(12, 93);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(75, 23);
            this.circleButton.TabIndex = 0;
            this.circleButton.Text = "Circle";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // squareButton
            // 
            this.squareButton.Location = new System.Drawing.Point(12, 122);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(75, 23);
            this.squareButton.TabIndex = 1;
            this.squareButton.Text = "Square";
            this.squareButton.UseVisualStyleBackColor = true;
            this.squareButton.Click += new System.EventHandler(this.squareButton_Click);
            // 
            // triangleButton
            // 
            this.triangleButton.Location = new System.Drawing.Point(12, 151);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(75, 23);
            this.triangleButton.TabIndex = 2;
            this.triangleButton.Text = "Triangle";
            this.triangleButton.UseVisualStyleBackColor = true;
            this.triangleButton.Click += new System.EventHandler(this.triangleButton_Click);
            // 
            // lineButton
            // 
            this.lineButton.Location = new System.Drawing.Point(12, 64);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(75, 23);
            this.lineButton.TabIndex = 3;
            this.lineButton.Text = "Line";
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.Click += new System.EventHandler(this.lineButton_Click);
            // 
            // pentagonButton
            // 
            this.pentagonButton.Location = new System.Drawing.Point(12, 180);
            this.pentagonButton.Name = "pentagonButton";
            this.pentagonButton.Size = new System.Drawing.Size(75, 23);
            this.pentagonButton.TabIndex = 4;
            this.pentagonButton.Text = "Pentagon";
            this.pentagonButton.UseVisualStyleBackColor = true;
            this.pentagonButton.Click += new System.EventHandler(this.pentagonButton_Click);
            // 
            // hexagonButton
            // 
            this.hexagonButton.Location = new System.Drawing.Point(12, 209);
            this.hexagonButton.Name = "hexagonButton";
            this.hexagonButton.Size = new System.Drawing.Size(75, 23);
            this.hexagonButton.TabIndex = 5;
            this.hexagonButton.Text = "Hexagon";
            this.hexagonButton.UseVisualStyleBackColor = true;
            this.hexagonButton.Click += new System.EventHandler(this.hexagonButton_Click);
            // 
            // shapePictureBox
            // 
            this.shapePictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.shapePictureBox.Location = new System.Drawing.Point(93, 12);
            this.shapePictureBox.Name = "shapePictureBox";
            this.shapePictureBox.Size = new System.Drawing.Size(604, 283);
            this.shapePictureBox.TabIndex = 6;
            this.shapePictureBox.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 307);
            this.Controls.Add(this.shapePictureBox);
            this.Controls.Add(this.hexagonButton);
            this.Controls.Add(this.pentagonButton);
            this.Controls.Add(this.lineButton);
            this.Controls.Add(this.triangleButton);
            this.Controls.Add(this.squareButton);
            this.Controls.Add(this.circleButton);
            this.Name = "mainForm";
            this.Text = "Lab1";
            ((System.ComponentModel.ISupportInitialize)(this.shapePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.Button squareButton;
        private System.Windows.Forms.Button triangleButton;
        private System.Windows.Forms.Button lineButton;
        private System.Windows.Forms.Button pentagonButton;
        private System.Windows.Forms.Button hexagonButton;
        private System.Windows.Forms.PictureBox shapePictureBox;
    }
}

