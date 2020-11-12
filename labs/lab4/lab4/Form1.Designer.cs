namespace lab4
{
    partial class formMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.cmbBox = new System.Windows.Forms.ComboBox();
            this.lblAlgorythm = new System.Windows.Forms.Label();
            this.openFileDlgLoadPicture = new System.Windows.Forms.OpenFileDialog();
            this.btnProcessImage = new System.Windows.Forms.Button();
            this.btnParamsSetting = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(640, 367);
            this.pictureBoxResult.TabIndex = 1;
            this.pictureBoxResult.TabStop = false;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(12, 392);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(108, 87);
            this.btnLoadImage.TabIndex = 2;
            this.btnLoadImage.Text = "Загрузить картинку";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // cmbBox
            // 
            this.cmbBox.FormattingEnabled = true;
            this.cmbBox.Location = new System.Drawing.Point(330, 400);
            this.cmbBox.Name = "cmbBox";
            this.cmbBox.Size = new System.Drawing.Size(195, 21);
            this.cmbBox.TabIndex = 3;
            // 
            // lblAlgorythm
            // 
            this.lblAlgorythm.AutoSize = true;
            this.lblAlgorythm.Location = new System.Drawing.Point(254, 403);
            this.lblAlgorythm.Name = "lblAlgorythm";
            this.lblAlgorythm.Size = new System.Drawing.Size(56, 13);
            this.lblAlgorythm.TabIndex = 4;
            this.lblAlgorythm.Text = "Алгоритм";
            // 
            // openFileDlgLoadPicture
            // 
            this.openFileDlgLoadPicture.FileName = "openFileDialog1";
            // 
            // btnProcessImage
            // 
            this.btnProcessImage.Location = new System.Drawing.Point(531, 392);
            this.btnProcessImage.Name = "btnProcessImage";
            this.btnProcessImage.Size = new System.Drawing.Size(108, 87);
            this.btnProcessImage.TabIndex = 5;
            this.btnProcessImage.Text = "Обработать картинку";
            this.btnProcessImage.UseVisualStyleBackColor = true;
            this.btnProcessImage.Click += new System.EventHandler(this.btnProcessImage_Click);
            // 
            // btnParamsSetting
            // 
            this.btnParamsSetting.Location = new System.Drawing.Point(126, 392);
            this.btnParamsSetting.Name = "btnParamsSetting";
            this.btnParamsSetting.Size = new System.Drawing.Size(122, 84);
            this.btnParamsSetting.TabIndex = 6;
            this.btnParamsSetting.Text = "Параметры";
            this.btnParamsSetting.UseVisualStyleBackColor = true;
            this.btnParamsSetting.Click += new System.EventHandler(this.btnParamsSetting_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 488);
            this.Controls.Add(this.btnParamsSetting);
            this.Controls.Add(this.btnProcessImage);
            this.Controls.Add(this.lblAlgorythm);
            this.Controls.Add(this.cmbBox);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.pictureBoxResult);
            this.Name = "formMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.ComboBox cmbBox;
        private System.Windows.Forms.Label lblAlgorythm;
        private System.Windows.Forms.OpenFileDialog openFileDlgLoadPicture;
        private System.Windows.Forms.Button btnProcessImage;
        private System.Windows.Forms.Button btnParamsSetting;
    }
}

