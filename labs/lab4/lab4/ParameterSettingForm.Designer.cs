namespace lab4
{
    partial class ParameterSettingForm
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
            this.txtBoxLimitSobel = new System.Windows.Forms.TextBox();
            this.lblSobelParam = new System.Windows.Forms.Label();
            this.txtBoxSigma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxWindowSize = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxLimitSobel
            // 
            this.txtBoxLimitSobel.Location = new System.Drawing.Point(9, 45);
            this.txtBoxLimitSobel.Name = "txtBoxLimitSobel";
            this.txtBoxLimitSobel.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLimitSobel.TabIndex = 0;
            this.txtBoxLimitSobel.Text = "16384";
            // 
            // lblSobelParam
            // 
            this.lblSobelParam.AutoSize = true;
            this.lblSobelParam.Location = new System.Drawing.Point(9, 29);
            this.lblSobelParam.Name = "lblSobelParam";
            this.lblSobelParam.Size = new System.Drawing.Size(83, 13);
            this.lblSobelParam.TabIndex = 1;
            this.lblSobelParam.Text = "Лимит(Собель)";
            // 
            // txtBoxSigma
            // 
            this.txtBoxSigma.Location = new System.Drawing.Point(9, 92);
            this.txtBoxSigma.Name = "txtBoxSigma";
            this.txtBoxSigma.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSigma.TabIndex = 2;
            this.txtBoxSigma.Text = "0.88";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сигма(Гаусс)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Размер Окна";
            // 
            // txtBoxWindowSize
            // 
            this.txtBoxWindowSize.Location = new System.Drawing.Point(9, 149);
            this.txtBoxWindowSize.Name = "txtBoxWindowSize";
            this.txtBoxWindowSize.Size = new System.Drawing.Size(100, 20);
            this.txtBoxWindowSize.TabIndex = 4;
            this.txtBoxWindowSize.Text = "3";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(135, 45);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 124);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ParameterSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 202);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxWindowSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxSigma);
            this.Controls.Add(this.lblSobelParam);
            this.Controls.Add(this.txtBoxLimitSobel);
            this.Name = "ParameterSettingForm";
            this.Text = "ParameterSettingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxLimitSobel;
        private System.Windows.Forms.Label lblSobelParam;
        private System.Windows.Forms.TextBox txtBoxSigma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxWindowSize;
        private System.Windows.Forms.Button btnSave;
    }
}