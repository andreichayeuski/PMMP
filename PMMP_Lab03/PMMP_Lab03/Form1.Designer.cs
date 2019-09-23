namespace PMMP_Lab03
{
    partial class Form1
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
            this.Cam_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Camera_Selection = new System.Windows.Forms.ComboBox();
            this.captureButton = new System.Windows.Forms.Button();
            this.RetrieveGrayFrame = new System.Windows.Forms.CheckBox();
            this.RetrieveBgrFrame = new System.Windows.Forms.CheckBox();
            this.captureBox = new System.Windows.Forms.PictureBox();
            this.RetrieveLaplas = new System.Windows.Forms.CheckBox();
            this.RetrieveSobel = new System.Windows.Forms.CheckBox();
            this.RetrieveKanny = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.captureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Cam_lbl
            // 
            this.Cam_lbl.AutoSize = true;
            this.Cam_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cam_lbl.Location = new System.Drawing.Point(13, 28);
            this.Cam_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cam_lbl.Name = "Cam_lbl";
            this.Cam_lbl.Size = new System.Drawing.Size(120, 20);
            this.Cam_lbl.TabIndex = 5;
            this.Cam_lbl.Text = "Camera View";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(940, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Camera";
            // 
            // Camera_Selection
            // 
            this.Camera_Selection.FormattingEnabled = true;
            this.Camera_Selection.Location = new System.Drawing.Point(944, 69);
            this.Camera_Selection.Margin = new System.Windows.Forms.Padding(4);
            this.Camera_Selection.Name = "Camera_Selection";
            this.Camera_Selection.Size = new System.Drawing.Size(305, 24);
            this.Camera_Selection.TabIndex = 6;
            // 
            // captureButton
            // 
            this.captureButton.Enabled = false;
            this.captureButton.Location = new System.Drawing.Point(1279, 69);
            this.captureButton.Margin = new System.Windows.Forms.Padding(4);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(136, 35);
            this.captureButton.TabIndex = 8;
            this.captureButton.Text = "Start Capture";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.CaptureButton_Click);
            // 
            // RetrieveGrayFrame
            // 
            this.RetrieveGrayFrame.AutoSize = true;
            this.RetrieveGrayFrame.Location = new System.Drawing.Point(944, 157);
            this.RetrieveGrayFrame.Margin = new System.Windows.Forms.Padding(4);
            this.RetrieveGrayFrame.Name = "RetrieveGrayFrame";
            this.RetrieveGrayFrame.Size = new System.Drawing.Size(162, 21);
            this.RetrieveGrayFrame.TabIndex = 11;
            this.RetrieveGrayFrame.Text = "Retrieve Gray Frame";
            this.RetrieveGrayFrame.UseVisualStyleBackColor = true;
            // 
            // RetrieveBgrFrame
            // 
            this.RetrieveBgrFrame.AutoSize = true;
            this.RetrieveBgrFrame.Checked = true;
            this.RetrieveBgrFrame.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RetrieveBgrFrame.Location = new System.Drawing.Point(944, 129);
            this.RetrieveBgrFrame.Margin = new System.Windows.Forms.Padding(4);
            this.RetrieveBgrFrame.Name = "RetrieveBgrFrame";
            this.RetrieveBgrFrame.Size = new System.Drawing.Size(153, 21);
            this.RetrieveBgrFrame.TabIndex = 10;
            this.RetrieveBgrFrame.Text = "Retrieve Bgr Frame";
            this.RetrieveBgrFrame.UseVisualStyleBackColor = true;
            // 
            // captureBox
            // 
            this.captureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.captureBox.Location = new System.Drawing.Point(17, 52);
            this.captureBox.Margin = new System.Windows.Forms.Padding(4);
            this.captureBox.Name = "captureBox";
            this.captureBox.Size = new System.Drawing.Size(537, 893);
            this.captureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.captureBox.TabIndex = 13;
            this.captureBox.TabStop = false;
            // 
            // RetrieveLaplas
            // 
            this.RetrieveLaplas.AutoSize = true;
            this.RetrieveLaplas.Location = new System.Drawing.Point(944, 231);
            this.RetrieveLaplas.Margin = new System.Windows.Forms.Padding(4);
            this.RetrieveLaplas.Name = "RetrieveLaplas";
            this.RetrieveLaplas.Size = new System.Drawing.Size(129, 21);
            this.RetrieveLaplas.TabIndex = 15;
            this.RetrieveLaplas.Text = "Retrieve Laplas";
            this.RetrieveLaplas.UseVisualStyleBackColor = true;
            // 
            // RetrieveSobel
            // 
            this.RetrieveSobel.AutoSize = true;
            this.RetrieveSobel.Location = new System.Drawing.Point(944, 203);
            this.RetrieveSobel.Margin = new System.Windows.Forms.Padding(4);
            this.RetrieveSobel.Name = "RetrieveSobel";
            this.RetrieveSobel.Size = new System.Drawing.Size(123, 21);
            this.RetrieveSobel.TabIndex = 14;
            this.RetrieveSobel.Text = "Retrieve Sobel";
            this.RetrieveSobel.UseVisualStyleBackColor = true;
            // 
            // RetrieveKanny
            // 
            this.RetrieveKanny.AutoSize = true;
            this.RetrieveKanny.Location = new System.Drawing.Point(944, 276);
            this.RetrieveKanny.Margin = new System.Windows.Forms.Padding(4);
            this.RetrieveKanny.Name = "RetrieveKanny";
            this.RetrieveKanny.Size = new System.Drawing.Size(127, 21);
            this.RetrieveKanny.TabIndex = 16;
            this.RetrieveKanny.Text = "Retrieve Kanny";
            this.RetrieveKanny.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 1055);
            this.Controls.Add(this.RetrieveKanny);
            this.Controls.Add(this.RetrieveLaplas);
            this.Controls.Add(this.RetrieveSobel);
            this.Controls.Add(this.captureBox);
            this.Controls.Add(this.RetrieveGrayFrame);
            this.Controls.Add(this.RetrieveBgrFrame);
            this.Controls.Add(this.captureButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Camera_Selection);
            this.Controls.Add(this.Cam_lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.captureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Cam_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Camera_Selection;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.CheckBox RetrieveGrayFrame;
        private System.Windows.Forms.CheckBox RetrieveBgrFrame;
        private System.Windows.Forms.PictureBox captureBox;
        private System.Windows.Forms.CheckBox RetrieveLaplas;
        private System.Windows.Forms.CheckBox RetrieveSobel;
        private System.Windows.Forms.CheckBox RetrieveKanny;
    }
}

