﻿
namespace Tyuiu.ShananinaVV.Sprint7.Project.V6
{
    partial class FormChart
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
            this.panelUsl_SVV = new System.Windows.Forms.Panel();
            this.labelOlder_SVV = new System.Windows.Forms.Label();
            this.labelYounger_SVV = new System.Windows.Forms.Label();
            this.splitterOne_SVV = new System.Windows.Forms.Splitter();
            this.panelChart_SVV = new System.Windows.Forms.Panel();
            this.chartDoctors_SVV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelUsl_SVV.SuspendLayout();
            this.panelChart_SVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoctors_SVV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUsl_SVV
            // 
            this.panelUsl_SVV.Controls.Add(this.labelOlder_SVV);
            this.panelUsl_SVV.Controls.Add(this.labelYounger_SVV);
            this.panelUsl_SVV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelUsl_SVV.Location = new System.Drawing.Point(0, 0);
            this.panelUsl_SVV.Name = "panelUsl_SVV";
            this.panelUsl_SVV.Size = new System.Drawing.Size(272, 450);
            this.panelUsl_SVV.TabIndex = 0;
            // 
            // labelOlder_SVV
            // 
            this.labelOlder_SVV.AutoSize = true;
            this.labelOlder_SVV.Location = new System.Drawing.Point(12, 104);
            this.labelOlder_SVV.Name = "labelOlder_SVV";
            this.labelOlder_SVV.Size = new System.Drawing.Size(40, 17);
            this.labelOlder_SVV.TabIndex = 2;
            this.labelOlder_SVV.Text = "older";
            // 
            // labelYounger_SVV
            // 
            this.labelYounger_SVV.AutoSize = true;
            this.labelYounger_SVV.Location = new System.Drawing.Point(12, 45);
            this.labelYounger_SVV.Name = "labelYounger_SVV";
            this.labelYounger_SVV.Size = new System.Drawing.Size(47, 17);
            this.labelYounger_SVV.TabIndex = 1;
            this.labelYounger_SVV.Text = "young";
            // 
            // splitterOne_SVV
            // 
            this.splitterOne_SVV.Location = new System.Drawing.Point(272, 0);
            this.splitterOne_SVV.Name = "splitterOne_SVV";
            this.splitterOne_SVV.Size = new System.Drawing.Size(3, 450);
            this.splitterOne_SVV.TabIndex = 2;
            this.splitterOne_SVV.TabStop = false;
            // 
            // panelChart_SVV
            // 
            this.panelChart_SVV.Controls.Add(this.chartDoctors_SVV);
            this.panelChart_SVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChart_SVV.Location = new System.Drawing.Point(275, 0);
            this.panelChart_SVV.Name = "panelChart_SVV";
            this.panelChart_SVV.Size = new System.Drawing.Size(525, 450);
            this.panelChart_SVV.TabIndex = 3;
            // 
            // chartDoctors_SVV
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDoctors_SVV.ChartAreas.Add(chartArea1);
            this.chartDoctors_SVV.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartDoctors_SVV.Legends.Add(legend1);
            this.chartDoctors_SVV.Location = new System.Drawing.Point(0, 0);
            this.chartDoctors_SVV.Name = "chartDoctors_SVV";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 3;
            this.chartDoctors_SVV.Series.Add(series1);
            this.chartDoctors_SVV.Size = new System.Drawing.Size(525, 450);
            this.chartDoctors_SVV.TabIndex = 0;
            
            // 
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelChart_SVV);
            this.Controls.Add(this.splitterOne_SVV);
            this.Controls.Add(this.panelUsl_SVV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "График-статистика";
            this.panelUsl_SVV.ResumeLayout(false);
            this.panelUsl_SVV.PerformLayout();
            this.panelChart_SVV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoctors_SVV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUsl_SVV;
        private System.Windows.Forms.Splitter splitterOne_SVV;
        private System.Windows.Forms.Panel panelChart_SVV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoctors_SVV;
        private System.Windows.Forms.Label labelOlder_SVV;
        private System.Windows.Forms.Label labelYounger_SVV;
    }
}