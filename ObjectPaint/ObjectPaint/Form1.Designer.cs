﻿namespace ObjectPaint
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
            this.pencilButton = new System.Windows.Forms.CheckBox();
            this.widthTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.shapePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // shapePictureBox
            // 
            this.shapePictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.shapePictureBox.Location = new System.Drawing.Point(12, 12);
            this.shapePictureBox.Name = "shapePictureBox";
            this.shapePictureBox.Size = new System.Drawing.Size(604, 231);
            this.shapePictureBox.TabIndex = 6;
            this.shapePictureBox.TabStop = false;
            this.shapePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.shapePictureBox_Paint);
            this.shapePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.shapePictureBox_MouseDown);
            this.shapePictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.shapePictureBox_MouseMove);
            this.shapePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.shapePictureBox_MouseUp);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(539, 249);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // pencilButton
            // 
            this.pencilButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.pencilButton.Location = new System.Drawing.Point(12, 249);
            this.pencilButton.Name = "pencilButton";
            this.pencilButton.Size = new System.Drawing.Size(44, 24);
            this.pencilButton.TabIndex = 0;
            this.pencilButton.Text = "Pencil";
            this.pencilButton.Click += new System.EventHandler(this.lineButton_Click);
            // 
            // widthTrackBar
            // 
            this.widthTrackBar.AutoSize = false;
            this.widthTrackBar.Location = new System.Drawing.Point(429, 249);
            this.widthTrackBar.Minimum = 1;
            this.widthTrackBar.Name = "widthTrackBar";
            this.widthTrackBar.Size = new System.Drawing.Size(104, 24);
            this.widthTrackBar.TabIndex = 7;
            this.widthTrackBar.Value = 1;
            this.widthTrackBar.Scroll += new System.EventHandler(this.widthTrackBar_Scroll);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 280);
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

        }

        #endregion
        private System.Windows.Forms.PictureBox shapePictureBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.CheckBox pencilButton;
        private System.Windows.Forms.TrackBar widthTrackBar;
    }
}

