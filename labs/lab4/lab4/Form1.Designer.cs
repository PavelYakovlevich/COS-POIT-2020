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
            this.pictureBoxSource = new System.Windows.Forms.PictureBox();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.btnSobel = new System.Windows.Forms.Button();
            this.btnGauss = new System.Windows.Forms.Button();
            this.btnMedian = new System.Windows.Forms.Button();
            this.btnSlidingWindow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSource
            // 
            this.pictureBoxSource.Image = global::lab4.Properties.Resources.putin;
            this.pictureBoxSource.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxSource.Name = "pictureBoxSource";
            this.pictureBoxSource.Size = new System.Drawing.Size(590, 427);
            this.pictureBoxSource.TabIndex = 0;
            this.pictureBoxSource.TabStop = false;
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.Location = new System.Drawing.Point(757, 12);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(590, 427);
            this.pictureBoxResult.TabIndex = 1;
            this.pictureBoxResult.TabStop = false;
            // 
            // btnSobel
            // 
            this.btnSobel.Location = new System.Drawing.Point(626, 12);
            this.btnSobel.Name = "btnSobel";
            this.btnSobel.Size = new System.Drawing.Size(115, 88);
            this.btnSobel.TabIndex = 2;
            this.btnSobel.Text = "Sobel";
            this.btnSobel.UseVisualStyleBackColor = true;
            this.btnSobel.Click += new System.EventHandler(this.btnSobel_Click);
            // 
            // btnGauss
            // 
            this.btnGauss.Location = new System.Drawing.Point(626, 137);
            this.btnGauss.Name = "btnGauss";
            this.btnGauss.Size = new System.Drawing.Size(115, 70);
            this.btnGauss.TabIndex = 3;
            this.btnGauss.Text = "Gauss";
            this.btnGauss.UseVisualStyleBackColor = true;
            this.btnGauss.Click += new System.EventHandler(this.btnGauss_Click);
            // 
            // btnMedian
            // 
            this.btnMedian.Location = new System.Drawing.Point(626, 245);
            this.btnMedian.Name = "btnMedian";
            this.btnMedian.Size = new System.Drawing.Size(115, 74);
            this.btnMedian.TabIndex = 4;
            this.btnMedian.Text = "Median";
            this.btnMedian.UseVisualStyleBackColor = true;
            this.btnMedian.Click += new System.EventHandler(this.btnMedian_Click);
            // 
            // btnSlidingWindow
            // 
            this.btnSlidingWindow.Location = new System.Drawing.Point(626, 364);
            this.btnSlidingWindow.Name = "btnSlidingWindow";
            this.btnSlidingWindow.Size = new System.Drawing.Size(115, 74);
            this.btnSlidingWindow.TabIndex = 5;
            this.btnSlidingWindow.Text = "Sliding window";
            this.btnSlidingWindow.UseVisualStyleBackColor = true;
            this.btnSlidingWindow.Click += new System.EventHandler(this.btnSlidingWindow_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 450);
            this.Controls.Add(this.btnSlidingWindow);
            this.Controls.Add(this.btnMedian);
            this.Controls.Add(this.btnGauss);
            this.Controls.Add(this.btnSobel);
            this.Controls.Add(this.pictureBoxResult);
            this.Controls.Add(this.pictureBoxSource);
            this.Name = "formMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSource;
        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.Button btnSobel;
        private System.Windows.Forms.Button btnGauss;
        private System.Windows.Forms.Button btnMedian;
        private System.Windows.Forms.Button btnSlidingWindow;
    }
}

