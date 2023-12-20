
namespace Tyuiu.ShananinaVV.Sprint7.Project.V6
{
    partial class FormAll
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
            this.panelOne_SVV = new System.Windows.Forms.Panel();
            this.splitterOne_SVV = new System.Windows.Forms.Splitter();
            this.groupBoxSear_SVV = new System.Windows.Forms.GroupBox();
            this.groupBoxInst_SVV = new System.Windows.Forms.GroupBox();
            this.panelTwo_SVV = new System.Windows.Forms.Panel();
            this.dataGridViewAll_SVV = new System.Windows.Forms.DataGridView();
            this.panelOne_SVV.SuspendLayout();
            this.panelTwo_SVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll_SVV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOne_SVV
            // 
            this.panelOne_SVV.Controls.Add(this.splitterOne_SVV);
            this.panelOne_SVV.Controls.Add(this.groupBoxSear_SVV);
            this.panelOne_SVV.Controls.Add(this.groupBoxInst_SVV);
            this.panelOne_SVV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOne_SVV.Location = new System.Drawing.Point(0, 0);
            this.panelOne_SVV.Name = "panelOne_SVV";
            this.panelOne_SVV.Size = new System.Drawing.Size(918, 193);
            this.panelOne_SVV.TabIndex = 0;
            this.panelOne_SVV.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // splitterOne_SVV
            // 
            this.splitterOne_SVV.Location = new System.Drawing.Point(692, 0);
            this.splitterOne_SVV.Name = "splitterOne_SVV";
            this.splitterOne_SVV.Size = new System.Drawing.Size(3, 193);
            this.splitterOne_SVV.TabIndex = 2;
            this.splitterOne_SVV.TabStop = false;
            // 
            // groupBoxSear_SVV
            // 
            this.groupBoxSear_SVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSear_SVV.Location = new System.Drawing.Point(692, 0);
            this.groupBoxSear_SVV.Name = "groupBoxSear_SVV";
            this.groupBoxSear_SVV.Size = new System.Drawing.Size(226, 193);
            this.groupBoxSear_SVV.TabIndex = 1;
            this.groupBoxSear_SVV.TabStop = false;
            this.groupBoxSear_SVV.Text = "Поиск";
            // 
            // groupBoxInst_SVV
            // 
            this.groupBoxInst_SVV.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxInst_SVV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInst_SVV.Name = "groupBoxInst_SVV";
            this.groupBoxInst_SVV.Size = new System.Drawing.Size(692, 193);
            this.groupBoxInst_SVV.TabIndex = 0;
            this.groupBoxInst_SVV.TabStop = false;
            this.groupBoxInst_SVV.Text = "Инструменты";
            // 
            // panelTwo_SVV
            // 
            this.panelTwo_SVV.Controls.Add(this.dataGridViewAll_SVV);
            this.panelTwo_SVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTwo_SVV.Location = new System.Drawing.Point(0, 193);
            this.panelTwo_SVV.Name = "panelTwo_SVV";
            this.panelTwo_SVV.Size = new System.Drawing.Size(918, 343);
            this.panelTwo_SVV.TabIndex = 0;
            this.panelTwo_SVV.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridViewAll_SVV
            // 
            this.dataGridViewAll_SVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAll_SVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAll_SVV.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAll_SVV.Name = "dataGridViewAll_SVV";
            this.dataGridViewAll_SVV.RowHeadersWidth = 51;
            this.dataGridViewAll_SVV.RowTemplate.Height = 24;
            this.dataGridViewAll_SVV.Size = new System.Drawing.Size(918, 343);
            this.dataGridViewAll_SVV.TabIndex = 0;
            // 
            // FormAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 536);
            this.Controls.Add(this.panelTwo_SVV);
            this.Controls.Add(this.panelOne_SVV);
            this.Name = "FormAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Общая база";
            this.panelOne_SVV.ResumeLayout(false);
            this.panelTwo_SVV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll_SVV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOne_SVV;
        private System.Windows.Forms.Splitter splitterOne_SVV;
        private System.Windows.Forms.GroupBox groupBoxSear_SVV;
        private System.Windows.Forms.GroupBox groupBoxInst_SVV;
        private System.Windows.Forms.Panel panelTwo_SVV;
        private System.Windows.Forms.DataGridView dataGridViewAll_SVV;
    }
}