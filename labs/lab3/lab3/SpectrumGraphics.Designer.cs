namespace lab3
{
    partial class SpectrumGraphics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartASpectrum = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPhaseSpectrum = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartASpectrum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPhaseSpectrum)).BeginInit();
            this.SuspendLayout();
            // 
            // chartASpectrum
            // 
            chartArea1.Name = "ChartArea1";
            this.chartASpectrum.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartASpectrum.Legends.Add(legend1);
            this.chartASpectrum.Location = new System.Drawing.Point(12, 3);
            this.chartASpectrum.Name = "chartASpectrum";
            this.chartASpectrum.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Amplitude Spectrum";
            series1.YValuesPerPoint = 3;
            this.chartASpectrum.Series.Add(series1);
            this.chartASpectrum.Size = new System.Drawing.Size(784, 282);
            this.chartASpectrum.TabIndex = 0;
            // 
            // chartPhaseSpectrum
            // 
            chartArea2.Name = "ChartArea1";
            this.chartPhaseSpectrum.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPhaseSpectrum.Legends.Add(legend2);
            this.chartPhaseSpectrum.Location = new System.Drawing.Point(12, 290);
            this.chartPhaseSpectrum.Name = "chartPhaseSpectrum";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "Phase Spectrum";
            this.chartPhaseSpectrum.Series.Add(series2);
            this.chartPhaseSpectrum.Size = new System.Drawing.Size(784, 282);
            this.chartPhaseSpectrum.TabIndex = 1;
            // 
            // SpectrumGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 584);
            this.Controls.Add(this.chartPhaseSpectrum);
            this.Controls.Add(this.chartASpectrum);
            this.Name = "SpectrumGraphics";
            this.Text = "SpectrumGraphics";
            ((System.ComponentModel.ISupportInitialize)(this.chartASpectrum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPhaseSpectrum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartASpectrum;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPhaseSpectrum;
    }
}