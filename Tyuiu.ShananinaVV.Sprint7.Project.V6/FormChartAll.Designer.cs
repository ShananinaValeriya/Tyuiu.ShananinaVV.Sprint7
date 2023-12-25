
namespace Tyuiu.ShananinaVV.Sprint7.Project.V6
{
    partial class FormChartAll
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
            this.panelOne_SVV = new System.Windows.Forms.Panel();
            this.panelTwo_SVV = new System.Windows.Forms.Panel();
            this.labelYes_SVV = new System.Windows.Forms.Label();
            this.labelNo_SVV = new System.Windows.Forms.Label();
            this.chartAllAmbDisp_SVV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitterOne_SVV = new System.Windows.Forms.Splitter();
            this.panelOne_SVV.SuspendLayout();
            this.panelTwo_SVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAllAmbDisp_SVV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOne_SVV
            // 
            this.panelOne_SVV.Controls.Add(this.labelNo_SVV);
            this.panelOne_SVV.Controls.Add(this.labelYes_SVV);
            this.panelOne_SVV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOne_SVV.Location = new System.Drawing.Point(0, 0);
            this.panelOne_SVV.Name = "panelOne_SVV";
            this.panelOne_SVV.Size = new System.Drawing.Size(252, 450);
            this.panelOne_SVV.TabIndex = 0;
            // 
            // panelTwo_SVV
            // 
            this.panelTwo_SVV.Controls.Add(this.splitterOne_SVV);
            this.panelTwo_SVV.Controls.Add(this.chartAllAmbDisp_SVV);
            this.panelTwo_SVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTwo_SVV.Location = new System.Drawing.Point(252, 0);
            this.panelTwo_SVV.Name = "panelTwo_SVV";
            this.panelTwo_SVV.Size = new System.Drawing.Size(548, 450);
            this.panelTwo_SVV.TabIndex = 0;
            // 
            // labelYes_SVV
            // 
            this.labelYes_SVV.AutoSize = true;
            this.labelYes_SVV.Location = new System.Drawing.Point(12, 53);
            this.labelYes_SVV.Name = "labelYes_SVV";
            this.labelYes_SVV.Size = new System.Drawing.Size(30, 17);
            this.labelYes_SVV.TabIndex = 0;
            this.labelYes_SVV.Text = "yes";
            // 
            // labelNo_SVV
            // 
            this.labelNo_SVV.AutoSize = true;
            this.labelNo_SVV.Location = new System.Drawing.Point(12, 129);
            this.labelNo_SVV.Name = "labelNo_SVV";
            this.labelNo_SVV.Size = new System.Drawing.Size(24, 17);
            this.labelNo_SVV.TabIndex = 1;
            this.labelNo_SVV.Text = "no";
            // 
            // chartAllAmbDisp_SVV
            // 
            chartArea1.Name = "ChartArea1";
            this.chartAllAmbDisp_SVV.ChartAreas.Add(chartArea1);
            this.chartAllAmbDisp_SVV.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartAllAmbDisp_SVV.Legends.Add(legend1);
            this.chartAllAmbDisp_SVV.Location = new System.Drawing.Point(0, 0);
            this.chartAllAmbDisp_SVV.Name = "chartAllAmbDisp_SVV";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartAllAmbDisp_SVV.Series.Add(series1);
            this.chartAllAmbDisp_SVV.Size = new System.Drawing.Size(548, 450);
            this.chartAllAmbDisp_SVV.TabIndex = 0;
            // 
            // splitterOne_SVV
            // 
            this.splitterOne_SVV.Location = new System.Drawing.Point(0, 0);
            this.splitterOne_SVV.Name = "splitterOne_SVV";
            this.splitterOne_SVV.Size = new System.Drawing.Size(3, 450);
            this.splitterOne_SVV.TabIndex = 1;
            this.splitterOne_SVV.TabStop = false;
            // 
            // FormChartAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelTwo_SVV);
            this.Controls.Add(this.panelOne_SVV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChartAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "График-статистика";
            this.panelOne_SVV.ResumeLayout(false);
            this.panelOne_SVV.PerformLayout();
            this.panelTwo_SVV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartAllAmbDisp_SVV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOne_SVV;
        private System.Windows.Forms.Panel panelTwo_SVV;
        private System.Windows.Forms.Label labelNo_SVV;
        private System.Windows.Forms.Label labelYes_SVV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAllAmbDisp_SVV;
        private System.Windows.Forms.Splitter splitterOne_SVV;
    }
}