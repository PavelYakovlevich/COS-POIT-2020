namespace lab1
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
            this.btnRecord = new System.Windows.Forms.Button();
            this.txtBoxAmplitude = new System.Windows.Forms.TextBox();
            this.txtFrequence = new System.Windows.Forms.TextBox();
            this.txtBoxStartPhase = new System.Windows.Forms.TextBox();
            this.cmdBoxHarmonicsCount = new System.Windows.Forms.ComboBox();
            this.lblN = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
            this.lblSP = new System.Windows.Forms.Label();
            this.rBtnSinusoidal = new System.Windows.Forms.RadioButton();
            this.rBtnImpulse = new System.Windows.Forms.RadioButton();
            this.txtBoxImpulseTime = new System.Windows.Forms.TextBox();
            this.lblImpulseLength = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(292, 347);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(121, 48);
            this.btnRecord.TabIndex = 0;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // txtBoxAmplitude
            // 
            this.txtBoxAmplitude.Location = new System.Drawing.Point(12, 121);
            this.txtBoxAmplitude.Name = "txtBoxAmplitude";
            this.txtBoxAmplitude.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAmplitude.TabIndex = 2;
            this.txtBoxAmplitude.Text = "10000";
            // 
            // txtFrequence
            // 
            this.txtFrequence.Location = new System.Drawing.Point(12, 171);
            this.txtFrequence.Name = "txtFrequence";
            this.txtFrequence.Size = new System.Drawing.Size(100, 20);
            this.txtFrequence.TabIndex = 3;
            this.txtFrequence.Text = "1000";
            // 
            // txtBoxStartPhase
            // 
            this.txtBoxStartPhase.Location = new System.Drawing.Point(12, 222);
            this.txtBoxStartPhase.Name = "txtBoxStartPhase";
            this.txtBoxStartPhase.Size = new System.Drawing.Size(100, 20);
            this.txtBoxStartPhase.TabIndex = 4;
            this.txtBoxStartPhase.Text = "2";
            // 
            // cmdBoxHarmonicsCount
            // 
            this.cmdBoxHarmonicsCount.FormattingEnabled = true;
            this.cmdBoxHarmonicsCount.Items.AddRange(new object[] {
            "1024",
            "2048",
            "4096",
            "512"});
            this.cmdBoxHarmonicsCount.Location = new System.Drawing.Point(12, 69);
            this.cmdBoxHarmonicsCount.Name = "cmdBoxHarmonicsCount";
            this.cmdBoxHarmonicsCount.Size = new System.Drawing.Size(121, 21);
            this.cmdBoxHarmonicsCount.Sorted = true;
            this.cmdBoxHarmonicsCount.TabIndex = 5;
            this.cmdBoxHarmonicsCount.Text = "512";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(13, 53);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(15, 13);
            this.lblN.TabIndex = 6;
            this.lblN.Text = "N";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(13, 105);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(14, 13);
            this.lblA.TabIndex = 7;
            this.lblA.Text = "A";
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Location = new System.Drawing.Point(13, 155);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(10, 13);
            this.lblF.TabIndex = 8;
            this.lblF.Text = "f";
            // 
            // lblSP
            // 
            this.lblSP.AutoSize = true;
            this.lblSP.Location = new System.Drawing.Point(13, 206);
            this.lblSP.Name = "lblSP";
            this.lblSP.Size = new System.Drawing.Size(61, 13);
            this.lblSP.TabIndex = 9;
            this.lblSP.Text = "Start phase";
            // 
            // rBtnSinusoidal
            // 
            this.rBtnSinusoidal.AutoSize = true;
            this.rBtnSinusoidal.Checked = true;
            this.rBtnSinusoidal.Location = new System.Drawing.Point(12, 12);
            this.rBtnSinusoidal.Name = "rBtnSinusoidal";
            this.rBtnSinusoidal.Size = new System.Drawing.Size(73, 17);
            this.rBtnSinusoidal.TabIndex = 10;
            this.rBtnSinusoidal.TabStop = true;
            this.rBtnSinusoidal.Text = "Sinusoidal";
            this.rBtnSinusoidal.UseVisualStyleBackColor = true;
            this.rBtnSinusoidal.CheckedChanged += new System.EventHandler(this.rBtnSinusoidal_CheckedChanged);
            // 
            // rBtnImpulse
            // 
            this.rBtnImpulse.AutoSize = true;
            this.rBtnImpulse.Location = new System.Drawing.Point(102, 12);
            this.rBtnImpulse.Name = "rBtnImpulse";
            this.rBtnImpulse.Size = new System.Drawing.Size(61, 17);
            this.rBtnImpulse.TabIndex = 11;
            this.rBtnImpulse.Text = "Impulse";
            this.rBtnImpulse.UseVisualStyleBackColor = true;
            this.rBtnImpulse.CheckedChanged += new System.EventHandler(this.rBtnImpulse_CheckedChanged);
            // 
            // txtBoxImpulseTime
            // 
            this.txtBoxImpulseTime.Location = new System.Drawing.Point(12, 269);
            this.txtBoxImpulseTime.Name = "txtBoxImpulseTime";
            this.txtBoxImpulseTime.Size = new System.Drawing.Size(100, 20);
            this.txtBoxImpulseTime.TabIndex = 12;
            this.txtBoxImpulseTime.Text = "100";
            // 
            // lblImpulseLength
            // 
            this.lblImpulseLength.AutoSize = true;
            this.lblImpulseLength.Location = new System.Drawing.Point(13, 253);
            this.lblImpulseLength.Name = "lblImpulseLength";
            this.lblImpulseLength.Size = new System.Drawing.Size(79, 13);
            this.lblImpulseLength.TabIndex = 13;
            this.lblImpulseLength.Text = "Impulse Length";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblImpulseLength);
            this.Controls.Add(this.txtBoxImpulseTime);
            this.Controls.Add(this.rBtnImpulse);
            this.Controls.Add(this.rBtnSinusoidal);
            this.Controls.Add(this.lblSP);
            this.Controls.Add(this.lblF);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.cmdBoxHarmonicsCount);
            this.Controls.Add(this.txtBoxStartPhase);
            this.Controls.Add(this.txtFrequence);
            this.Controls.Add(this.txtBoxAmplitude);
            this.Controls.Add(this.btnRecord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.TextBox txtBoxAmplitude;
        private System.Windows.Forms.TextBox txtFrequence;
        private System.Windows.Forms.TextBox txtBoxStartPhase;
        private System.Windows.Forms.ComboBox cmdBoxHarmonicsCount;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.Label lblSP;
        private System.Windows.Forms.RadioButton rBtnSinusoidal;
        private System.Windows.Forms.RadioButton rBtnImpulse;
        private System.Windows.Forms.TextBox txtBoxImpulseTime;
        private System.Windows.Forms.Label lblImpulseLength;
    }
}

