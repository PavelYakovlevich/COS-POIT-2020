namespace lab2
{
    partial class Main
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
            this.cmbBoxN = new System.Windows.Forms.ComboBox();
            this.lblA = new System.Windows.Forms.Label();
            this.picBoxKFormula = new System.Windows.Forms.PictureBox();
            this.btnNextK = new System.Windows.Forms.Button();
            this.btnGenerateValues = new System.Windows.Forms.Button();
            this.txtBoxFi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxnMulCoef = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKFormula)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBoxN
            // 
            this.cmbBoxN.FormattingEnabled = true;
            this.cmbBoxN.Items.AddRange(new object[] {
            "64",
            "128",
            "256",
            "512",
            "1024",
            "2048",
            "4096"});
            this.cmbBoxN.Location = new System.Drawing.Point(12, 37);
            this.cmbBoxN.Name = "cmbBoxN";
            this.cmbBoxN.Size = new System.Drawing.Size(158, 21);
            this.cmbBoxN.TabIndex = 0;
            this.cmbBoxN.Text = "512";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(12, 21);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(14, 13);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "A";
            // 
            // picBoxKFormula
            // 
            this.picBoxKFormula.Location = new System.Drawing.Point(12, 207);
            this.picBoxKFormula.Name = "picBoxKFormula";
            this.picBoxKFormula.Size = new System.Drawing.Size(158, 80);
            this.picBoxKFormula.TabIndex = 2;
            this.picBoxKFormula.TabStop = false;
            // 
            // btnNextK
            // 
            this.btnNextK.Location = new System.Drawing.Point(12, 165);
            this.btnNextK.Name = "btnNextK";
            this.btnNextK.Size = new System.Drawing.Size(158, 36);
            this.btnNextK.TabIndex = 3;
            this.btnNextK.Text = "Next";
            this.btnNextK.UseVisualStyleBackColor = true;
            this.btnNextK.BackgroundImageLayoutChanged += new System.EventHandler(this.Main_Load);
            this.btnNextK.Click += new System.EventHandler(this.btnNextK_Click);
            // 
            // btnGenerateValues
            // 
            this.btnGenerateValues.Location = new System.Drawing.Point(199, 37);
            this.btnGenerateValues.Name = "btnGenerateValues";
            this.btnGenerateValues.Size = new System.Drawing.Size(199, 250);
            this.btnGenerateValues.TabIndex = 4;
            this.btnGenerateValues.Text = "Generate";
            this.btnGenerateValues.UseVisualStyleBackColor = true;
            this.btnGenerateValues.Click += new System.EventHandler(this.btnGenerateValues_Click);
            // 
            // txtBoxFi
            // 
            this.txtBoxFi.Location = new System.Drawing.Point(12, 84);
            this.txtBoxFi.Name = "txtBoxFi";
            this.txtBoxFi.Size = new System.Drawing.Size(158, 20);
            this.txtBoxFi.TabIndex = 5;
            this.txtBoxFi.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fi";
            // 
            // txtBoxnMulCoef
            // 
            this.txtBoxnMulCoef.Location = new System.Drawing.Point(12, 125);
            this.txtBoxnMulCoef.Name = "txtBoxnMulCoef";
            this.txtBoxnMulCoef.Size = new System.Drawing.Size(100, 20);
            this.txtBoxnMulCoef.TabIndex = 7;
            this.txtBoxnMulCoef.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Multiplier";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 313);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxnMulCoef);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxFi);
            this.Controls.Add(this.btnGenerateValues);
            this.Controls.Add(this.btnNextK);
            this.Controls.Add(this.picBoxKFormula);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.cmbBoxN);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKFormula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxN;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.PictureBox picBoxKFormula;
        private System.Windows.Forms.Button btnNextK;
        private System.Windows.Forms.Button btnGenerateValues;
        private System.Windows.Forms.TextBox txtBoxFi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxnMulCoef;
        private System.Windows.Forms.Label label2;
    }
}

