namespace lab3
{
    partial class Form1
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
            this.btnCreateSignal = new System.Windows.Forms.Button();
            this.txtBoxB = new System.Windows.Forms.TextBox();
            this.txtBoxPhase = new System.Windows.Forms.TextBox();
            this.lblPhase = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.cmbBoxN = new System.Windows.Forms.ComboBox();
            this.lblN = new System.Windows.Forms.Label();
            this.btnRestoreSigWithSpectrum = new System.Windows.Forms.Button();
            this.chckBoxOpenGraphicsAfterSignalCreation = new System.Windows.Forms.CheckBox();
            this.chckBoxPoligarmonicMode = new System.Windows.Forms.CheckBox();
            this.chckBoxUseFi = new System.Windows.Forms.CheckBox();
            this.txtBoxFMin = new System.Windows.Forms.TextBox();
            this.txtBoxFMax = new System.Windows.Forms.TextBox();
            this.lblFMin = new System.Windows.Forms.Label();
            this.lblFmax = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateSignal
            // 
            this.btnCreateSignal.Location = new System.Drawing.Point(147, 13);
            this.btnCreateSignal.Name = "btnCreateSignal";
            this.btnCreateSignal.Size = new System.Drawing.Size(165, 144);
            this.btnCreateSignal.TabIndex = 0;
            this.btnCreateSignal.Text = "Create";
            this.btnCreateSignal.UseVisualStyleBackColor = true;
            this.btnCreateSignal.Click += new System.EventHandler(this.btnCreateSignal_Click);
            // 
            // txtBoxB
            // 
            this.txtBoxB.Location = new System.Drawing.Point(12, 81);
            this.txtBoxB.Name = "txtBoxB";
            this.txtBoxB.Size = new System.Drawing.Size(100, 20);
            this.txtBoxB.TabIndex = 1;
            this.txtBoxB.Text = "10";
            // 
            // txtBoxPhase
            // 
            this.txtBoxPhase.Location = new System.Drawing.Point(12, 29);
            this.txtBoxPhase.Name = "txtBoxPhase";
            this.txtBoxPhase.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPhase.TabIndex = 2;
            this.txtBoxPhase.Text = "0";
            // 
            // lblPhase
            // 
            this.lblPhase.AutoSize = true;
            this.lblPhase.Location = new System.Drawing.Point(9, 13);
            this.lblPhase.Name = "lblPhase";
            this.lblPhase.Size = new System.Drawing.Size(15, 13);
            this.lblPhase.TabIndex = 3;
            this.lblPhase.Text = "Fi";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(9, 65);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(14, 13);
            this.lblB.TabIndex = 4;
            this.lblB.Text = "B";
            // 
            // cmbBoxN
            // 
            this.cmbBoxN.FormattingEnabled = true;
            this.cmbBoxN.Items.AddRange(new object[] {
            "512",
            "1024",
            "2048",
            "4096"});
            this.cmbBoxN.Location = new System.Drawing.Point(12, 136);
            this.cmbBoxN.Name = "cmbBoxN";
            this.cmbBoxN.Size = new System.Drawing.Size(100, 21);
            this.cmbBoxN.TabIndex = 5;
            this.cmbBoxN.Text = "512";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(12, 120);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(15, 13);
            this.lblN.TabIndex = 6;
            this.lblN.Text = "N";
            // 
            // btnRestoreSigWithSpectrum
            // 
            this.btnRestoreSigWithSpectrum.Location = new System.Drawing.Point(12, 274);
            this.btnRestoreSigWithSpectrum.Name = "btnRestoreSigWithSpectrum";
            this.btnRestoreSigWithSpectrum.Size = new System.Drawing.Size(300, 170);
            this.btnRestoreSigWithSpectrum.TabIndex = 7;
            this.btnRestoreSigWithSpectrum.Text = "Restore signal with spectrum";
            this.btnRestoreSigWithSpectrum.UseVisualStyleBackColor = true;
            this.btnRestoreSigWithSpectrum.Click += new System.EventHandler(this.btnRestoreSigWithSpectrum_Click);
            // 
            // chckBoxOpenGraphicsAfterSignalCreation
            // 
            this.chckBoxOpenGraphicsAfterSignalCreation.AutoSize = true;
            this.chckBoxOpenGraphicsAfterSignalCreation.Location = new System.Drawing.Point(12, 183);
            this.chckBoxOpenGraphicsAfterSignalCreation.Name = "chckBoxOpenGraphicsAfterSignalCreation";
            this.chckBoxOpenGraphicsAfterSignalCreation.Size = new System.Drawing.Size(79, 17);
            this.chckBoxOpenGraphicsAfterSignalCreation.TabIndex = 8;
            this.chckBoxOpenGraphicsAfterSignalCreation.Text = "Open chart";
            this.chckBoxOpenGraphicsAfterSignalCreation.UseVisualStyleBackColor = true;
            this.chckBoxOpenGraphicsAfterSignalCreation.CheckedChanged += new System.EventHandler(this.chckBoxOpenGraphicsAfterSignalCreation_CheckedChanged);
            // 
            // chckBoxPoligarmonicMode
            // 
            this.chckBoxPoligarmonicMode.AutoSize = true;
            this.chckBoxPoligarmonicMode.Location = new System.Drawing.Point(12, 206);
            this.chckBoxPoligarmonicMode.Name = "chckBoxPoligarmonicMode";
            this.chckBoxPoligarmonicMode.Size = new System.Drawing.Size(115, 17);
            this.chckBoxPoligarmonicMode.TabIndex = 9;
            this.chckBoxPoligarmonicMode.Text = "Poligarmonic mode";
            this.chckBoxPoligarmonicMode.UseVisualStyleBackColor = true;
            this.chckBoxPoligarmonicMode.CheckedChanged += new System.EventHandler(this.chckBoxPoligarmonicMode_CheckedChanged);
            // 
            // chckBoxUseFi
            // 
            this.chckBoxUseFi.AutoSize = true;
            this.chckBoxUseFi.Location = new System.Drawing.Point(12, 229);
            this.chckBoxUseFi.Name = "chckBoxUseFi";
            this.chckBoxUseFi.Size = new System.Drawing.Size(118, 17);
            this.chckBoxUseFi.TabIndex = 10;
            this.chckBoxUseFi.Text = "Use fi in calculation";
            this.chckBoxUseFi.UseVisualStyleBackColor = true;
            this.chckBoxUseFi.CheckedChanged += new System.EventHandler(this.chckBoxUseFi_CheckedChanged);
            // 
            // txtBoxFMin
            // 
            this.txtBoxFMin.Location = new System.Drawing.Point(147, 226);
            this.txtBoxFMin.Name = "txtBoxFMin";
            this.txtBoxFMin.Size = new System.Drawing.Size(74, 20);
            this.txtBoxFMin.TabIndex = 11;
            this.txtBoxFMin.Text = "0";
            // 
            // txtBoxFMax
            // 
            this.txtBoxFMax.Location = new System.Drawing.Point(238, 226);
            this.txtBoxFMax.Name = "txtBoxFMax";
            this.txtBoxFMax.Size = new System.Drawing.Size(74, 20);
            this.txtBoxFMax.TabIndex = 12;
            this.txtBoxFMax.Text = "100";
            // 
            // lblFMin
            // 
            this.lblFMin.AutoSize = true;
            this.lblFMin.Location = new System.Drawing.Point(144, 207);
            this.lblFMin.Name = "lblFMin";
            this.lblFMin.Size = new System.Drawing.Size(29, 13);
            this.lblFMin.TabIndex = 13;
            this.lblFMin.Text = "Fmin";
            // 
            // lblFmax
            // 
            this.lblFmax.AutoSize = true;
            this.lblFmax.Location = new System.Drawing.Point(235, 206);
            this.lblFmax.Name = "lblFmax";
            this.lblFmax.Size = new System.Drawing.Size(32, 13);
            this.lblFmax.TabIndex = 14;
            this.lblFmax.Text = "Fmax";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 456);
            this.Controls.Add(this.lblFmax);
            this.Controls.Add(this.lblFMin);
            this.Controls.Add(this.txtBoxFMax);
            this.Controls.Add(this.txtBoxFMin);
            this.Controls.Add(this.chckBoxUseFi);
            this.Controls.Add(this.chckBoxPoligarmonicMode);
            this.Controls.Add(this.chckBoxOpenGraphicsAfterSignalCreation);
            this.Controls.Add(this.btnRestoreSigWithSpectrum);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.cmbBoxN);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblPhase);
            this.Controls.Add(this.txtBoxPhase);
            this.Controls.Add(this.txtBoxB);
            this.Controls.Add(this.btnCreateSignal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateSignal;
        private System.Windows.Forms.TextBox txtBoxB;
        private System.Windows.Forms.TextBox txtBoxPhase;
        private System.Windows.Forms.Label lblPhase;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.ComboBox cmbBoxN;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Button btnRestoreSigWithSpectrum;
        private System.Windows.Forms.CheckBox chckBoxOpenGraphicsAfterSignalCreation;
        private System.Windows.Forms.CheckBox chckBoxPoligarmonicMode;
        private System.Windows.Forms.CheckBox chckBoxUseFi;
        private System.Windows.Forms.TextBox txtBoxFMin;
        private System.Windows.Forms.TextBox txtBoxFMax;
        private System.Windows.Forms.Label lblFMin;
        private System.Windows.Forms.Label lblFmax;
    }
}

