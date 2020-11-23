namespace lab1
{
    partial class frmMain
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
            this.rBtnTriangle = new System.Windows.Forms.RadioButton();
            this.rBtnSawtooth = new System.Windows.Forms.RadioButton();
            this.rBtnNoise = new System.Windows.Forms.RadioButton();
            this.chckBoxPoligarmonicMode = new System.Windows.Forms.CheckBox();
            this.btnCreateSignal = new System.Windows.Forms.Button();
            this.chckBoxModulationMode = new System.Windows.Forms.CheckBox();
            this.grpBoxModulationTypes = new System.Windows.Forms.GroupBox();
            this.btnFM = new System.Windows.Forms.Button();
            this.btnAM = new System.Windows.Forms.Button();
            this.grpBoxModulationTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(316, 14);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(246, 281);
            this.btnRecord.TabIndex = 0;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // txtBoxAmplitude
            // 
            this.txtBoxAmplitude.Location = new System.Drawing.Point(12, 82);
            this.txtBoxAmplitude.Name = "txtBoxAmplitude";
            this.txtBoxAmplitude.Size = new System.Drawing.Size(121, 20);
            this.txtBoxAmplitude.TabIndex = 2;
            this.txtBoxAmplitude.Text = "0.1";
            // 
            // txtFrequence
            // 
            this.txtFrequence.Location = new System.Drawing.Point(12, 132);
            this.txtFrequence.Name = "txtFrequence";
            this.txtFrequence.Size = new System.Drawing.Size(121, 20);
            this.txtFrequence.TabIndex = 3;
            this.txtFrequence.Text = "1000";
            // 
            // txtBoxStartPhase
            // 
            this.txtBoxStartPhase.Location = new System.Drawing.Point(12, 183);
            this.txtBoxStartPhase.Name = "txtBoxStartPhase";
            this.txtBoxStartPhase.Size = new System.Drawing.Size(121, 20);
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
            this.cmdBoxHarmonicsCount.Location = new System.Drawing.Point(12, 30);
            this.cmdBoxHarmonicsCount.Name = "cmdBoxHarmonicsCount";
            this.cmdBoxHarmonicsCount.Size = new System.Drawing.Size(121, 21);
            this.cmdBoxHarmonicsCount.Sorted = true;
            this.cmdBoxHarmonicsCount.TabIndex = 5;
            this.cmdBoxHarmonicsCount.Text = "512";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(13, 14);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(15, 13);
            this.lblN.TabIndex = 6;
            this.lblN.Text = "N";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(13, 66);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(14, 13);
            this.lblA.TabIndex = 7;
            this.lblA.Text = "A";
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Location = new System.Drawing.Point(13, 116);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(10, 13);
            this.lblF.TabIndex = 8;
            this.lblF.Text = "f";
            // 
            // lblSP
            // 
            this.lblSP.AutoSize = true;
            this.lblSP.Location = new System.Drawing.Point(13, 167);
            this.lblSP.Name = "lblSP";
            this.lblSP.Size = new System.Drawing.Size(61, 13);
            this.lblSP.TabIndex = 9;
            this.lblSP.Text = "Start phase";
            // 
            // rBtnSinusoidal
            // 
            this.rBtnSinusoidal.AutoSize = true;
            this.rBtnSinusoidal.Location = new System.Drawing.Point(221, 30);
            this.rBtnSinusoidal.Name = "rBtnSinusoidal";
            this.rBtnSinusoidal.Size = new System.Drawing.Size(73, 17);
            this.rBtnSinusoidal.TabIndex = 10;
            this.rBtnSinusoidal.Tag = "2";
            this.rBtnSinusoidal.Text = "Sinusoidal";
            this.rBtnSinusoidal.UseVisualStyleBackColor = true;
            this.rBtnSinusoidal.CheckedChanged += new System.EventHandler(this.SignalRadioButtonStateChanged);
            // 
            // rBtnImpulse
            // 
            this.rBtnImpulse.AutoSize = true;
            this.rBtnImpulse.Checked = true;
            this.rBtnImpulse.Location = new System.Drawing.Point(154, 30);
            this.rBtnImpulse.Name = "rBtnImpulse";
            this.rBtnImpulse.Size = new System.Drawing.Size(61, 17);
            this.rBtnImpulse.TabIndex = 11;
            this.rBtnImpulse.TabStop = true;
            this.rBtnImpulse.Tag = "1";
            this.rBtnImpulse.Text = "Impulse";
            this.rBtnImpulse.UseVisualStyleBackColor = true;
            this.rBtnImpulse.CheckedChanged += new System.EventHandler(this.SignalRadioButtonStateChanged);
            // 
            // txtBoxImpulseTime
            // 
            this.txtBoxImpulseTime.Location = new System.Drawing.Point(12, 230);
            this.txtBoxImpulseTime.Name = "txtBoxImpulseTime";
            this.txtBoxImpulseTime.Size = new System.Drawing.Size(121, 20);
            this.txtBoxImpulseTime.TabIndex = 12;
            this.txtBoxImpulseTime.Text = "0.5";
            // 
            // lblImpulseLength
            // 
            this.lblImpulseLength.AutoSize = true;
            this.lblImpulseLength.Location = new System.Drawing.Point(13, 214);
            this.lblImpulseLength.Name = "lblImpulseLength";
            this.lblImpulseLength.Size = new System.Drawing.Size(79, 13);
            this.lblImpulseLength.TabIndex = 13;
            this.lblImpulseLength.Text = "Impulse Length";
            // 
            // rBtnTriangle
            // 
            this.rBtnTriangle.AutoSize = true;
            this.rBtnTriangle.Location = new System.Drawing.Point(154, 62);
            this.rBtnTriangle.Name = "rBtnTriangle";
            this.rBtnTriangle.Size = new System.Drawing.Size(63, 17);
            this.rBtnTriangle.TabIndex = 14;
            this.rBtnTriangle.Tag = "3";
            this.rBtnTriangle.Text = "Triangle";
            this.rBtnTriangle.UseVisualStyleBackColor = true;
            this.rBtnTriangle.CheckedChanged += new System.EventHandler(this.SignalRadioButtonStateChanged);
            // 
            // rBtnSawtooth
            // 
            this.rBtnSawtooth.AutoSize = true;
            this.rBtnSawtooth.Location = new System.Drawing.Point(221, 62);
            this.rBtnSawtooth.Name = "rBtnSawtooth";
            this.rBtnSawtooth.Size = new System.Drawing.Size(70, 17);
            this.rBtnSawtooth.TabIndex = 15;
            this.rBtnSawtooth.Tag = "4";
            this.rBtnSawtooth.Text = "Sawtooth";
            this.rBtnSawtooth.UseVisualStyleBackColor = true;
            this.rBtnSawtooth.CheckedChanged += new System.EventHandler(this.SignalRadioButtonStateChanged);
            // 
            // rBtnNoise
            // 
            this.rBtnNoise.AutoSize = true;
            this.rBtnNoise.Location = new System.Drawing.Point(154, 94);
            this.rBtnNoise.Name = "rBtnNoise";
            this.rBtnNoise.Size = new System.Drawing.Size(52, 17);
            this.rBtnNoise.TabIndex = 16;
            this.rBtnNoise.Tag = "5";
            this.rBtnNoise.Text = "Noise";
            this.rBtnNoise.UseVisualStyleBackColor = true;
            this.rBtnNoise.CheckedChanged += new System.EventHandler(this.SignalRadioButtonStateChanged);
            // 
            // chckBoxPoligarmonicMode
            // 
            this.chckBoxPoligarmonicMode.AutoSize = true;
            this.chckBoxPoligarmonicMode.Location = new System.Drawing.Point(154, 210);
            this.chckBoxPoligarmonicMode.Name = "chckBoxPoligarmonicMode";
            this.chckBoxPoligarmonicMode.Size = new System.Drawing.Size(115, 17);
            this.chckBoxPoligarmonicMode.TabIndex = 17;
            this.chckBoxPoligarmonicMode.Text = "Poligarmonic mode";
            this.chckBoxPoligarmonicMode.UseVisualStyleBackColor = true;
            this.chckBoxPoligarmonicMode.CheckedChanged += new System.EventHandler(this.chckBoxPoligarmonicMode_CheckedChanged);
            // 
            // btnCreateSignal
            // 
            this.btnCreateSignal.Location = new System.Drawing.Point(154, 119);
            this.btnCreateSignal.Name = "btnCreateSignal";
            this.btnCreateSignal.Size = new System.Drawing.Size(137, 70);
            this.btnCreateSignal.TabIndex = 18;
            this.btnCreateSignal.Text = "Create signal";
            this.btnCreateSignal.UseVisualStyleBackColor = true;
            this.btnCreateSignal.Click += new System.EventHandler(this.btnCreateSignal_Click);
            // 
            // chckBoxModulationMode
            // 
            this.chckBoxModulationMode.AutoSize = true;
            this.chckBoxModulationMode.Enabled = false;
            this.chckBoxModulationMode.Location = new System.Drawing.Point(12, 267);
            this.chckBoxModulationMode.Name = "chckBoxModulationMode";
            this.chckBoxModulationMode.Size = new System.Drawing.Size(107, 17);
            this.chckBoxModulationMode.TabIndex = 19;
            this.chckBoxModulationMode.Text = "Modulation mode";
            this.chckBoxModulationMode.UseVisualStyleBackColor = true;
            this.chckBoxModulationMode.CheckedChanged += new System.EventHandler(this.chckBoxModulationMode_CheckedChanged);
            // 
            // grpBoxModulationTypes
            // 
            this.grpBoxModulationTypes.Controls.Add(this.btnFM);
            this.grpBoxModulationTypes.Controls.Add(this.btnAM);
            this.grpBoxModulationTypes.Enabled = false;
            this.grpBoxModulationTypes.Location = new System.Drawing.Point(154, 230);
            this.grpBoxModulationTypes.Name = "grpBoxModulationTypes";
            this.grpBoxModulationTypes.Size = new System.Drawing.Size(137, 65);
            this.grpBoxModulationTypes.TabIndex = 20;
            this.grpBoxModulationTypes.TabStop = false;
            // 
            // btnFM
            // 
            this.btnFM.Location = new System.Drawing.Point(6, 37);
            this.btnFM.Name = "btnFM";
            this.btnFM.Size = new System.Drawing.Size(125, 23);
            this.btnFM.TabIndex = 1;
            this.btnFM.Tag = "FM";
            this.btnFM.Text = "Frequence modulation";
            this.btnFM.UseVisualStyleBackColor = true;
            this.btnFM.Click += new System.EventHandler(this.btnCreateSignal_Click);
            // 
            // btnAM
            // 
            this.btnAM.Location = new System.Drawing.Point(6, 10);
            this.btnAM.Name = "btnAM";
            this.btnAM.Size = new System.Drawing.Size(125, 23);
            this.btnAM.TabIndex = 0;
            this.btnAM.Tag = "AM";
            this.btnAM.Text = "Amplitude modulation";
            this.btnAM.UseVisualStyleBackColor = true;
            this.btnAM.Click += new System.EventHandler(this.btnCreateSignal_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 300);
            this.Controls.Add(this.grpBoxModulationTypes);
            this.Controls.Add(this.chckBoxModulationMode);
            this.Controls.Add(this.btnCreateSignal);
            this.Controls.Add(this.chckBoxPoligarmonicMode);
            this.Controls.Add(this.rBtnNoise);
            this.Controls.Add(this.rBtnSawtooth);
            this.Controls.Add(this.rBtnTriangle);
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
            this.Name = "frmMain";
            this.Text = "lab1";
            this.grpBoxModulationTypes.ResumeLayout(false);
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
        private System.Windows.Forms.RadioButton rBtnTriangle;
        private System.Windows.Forms.RadioButton rBtnSawtooth;
        private System.Windows.Forms.RadioButton rBtnNoise;
        private System.Windows.Forms.CheckBox chckBoxPoligarmonicMode;
        private System.Windows.Forms.Button btnCreateSignal;
        private System.Windows.Forms.CheckBox chckBoxModulationMode;
        private System.Windows.Forms.GroupBox grpBoxModulationTypes;
        private System.Windows.Forms.Button btnFM;
        private System.Windows.Forms.Button btnAM;
    }
}

