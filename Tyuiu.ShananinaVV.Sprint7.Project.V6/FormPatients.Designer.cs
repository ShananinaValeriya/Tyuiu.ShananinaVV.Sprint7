
namespace Tyuiu.ShananinaVV.Sprint7.Project.V6
{
    partial class FormPatients
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
            this.panelTwoPat_SVV = new System.Windows.Forms.Panel();
            this.dataGridViewPatients_SVV = new System.Windows.Forms.DataGridView();
            this.buttonDonePat_SVV = new System.Windows.Forms.Button();
            this.buttonBackPat_SVV = new System.Windows.Forms.Button();
            this.groupBoxPat_SVV = new System.Windows.Forms.GroupBox();
            this.panelOne_SVV.SuspendLayout();
            this.panelTwoPat_SVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients_SVV)).BeginInit();
            this.groupBoxPat_SVV.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOne_SVV
            // 
            this.panelOne_SVV.Controls.Add(this.groupBoxPat_SVV);
            this.panelOne_SVV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOne_SVV.Location = new System.Drawing.Point(0, 0);
            this.panelOne_SVV.Name = "panelOne_SVV";
            this.panelOne_SVV.Size = new System.Drawing.Size(800, 135);
            this.panelOne_SVV.TabIndex = 2;
            // 
            // panelTwoPat_SVV
            // 
            this.panelTwoPat_SVV.Controls.Add(this.dataGridViewPatients_SVV);
            this.panelTwoPat_SVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTwoPat_SVV.Location = new System.Drawing.Point(0, 135);
            this.panelTwoPat_SVV.Name = "panelTwoPat_SVV";
            this.panelTwoPat_SVV.Size = new System.Drawing.Size(800, 315);
            this.panelTwoPat_SVV.TabIndex = 2;
            // 
            // dataGridViewPatients_SVV
            // 
            this.dataGridViewPatients_SVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients_SVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPatients_SVV.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPatients_SVV.Name = "dataGridViewPatients_SVV";
            this.dataGridViewPatients_SVV.RowHeadersVisible = false;
            this.dataGridViewPatients_SVV.RowHeadersWidth = 51;
            this.dataGridViewPatients_SVV.RowTemplate.Height = 24;
            this.dataGridViewPatients_SVV.Size = new System.Drawing.Size(800, 315);
            this.dataGridViewPatients_SVV.TabIndex = 0;
            // 
            // buttonDonePat_SVV
            // 
            this.buttonDonePat_SVV.Location = new System.Drawing.Point(12, 63);
            this.buttonDonePat_SVV.Name = "buttonDonePat_SVV";
            this.buttonDonePat_SVV.Size = new System.Drawing.Size(124, 66);
            this.buttonDonePat_SVV.TabIndex = 0;
            this.buttonDonePat_SVV.Text = "Открыть базу";
            this.buttonDonePat_SVV.UseVisualStyleBackColor = true;
            this.buttonDonePat_SVV.Click += new System.EventHandler(this.buttonDonePat_SVV_Click);
            // 
            // buttonBackPat_SVV
            // 
            this.buttonBackPat_SVV.Location = new System.Drawing.Point(12, 21);
            this.buttonBackPat_SVV.Name = "buttonBackPat_SVV";
            this.buttonBackPat_SVV.Size = new System.Drawing.Size(124, 36);
            this.buttonBackPat_SVV.TabIndex = 1;
            this.buttonBackPat_SVV.Text = "Назад";
            this.buttonBackPat_SVV.UseVisualStyleBackColor = true;
            this.buttonBackPat_SVV.Click += new System.EventHandler(this.buttonBackPat_SVV_Click);
            // 
            // groupBoxPat_SVV
            // 
            this.groupBoxPat_SVV.Controls.Add(this.buttonBackPat_SVV);
            this.groupBoxPat_SVV.Controls.Add(this.buttonDonePat_SVV);
            this.groupBoxPat_SVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPat_SVV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPat_SVV.Name = "groupBoxPat_SVV";
            this.groupBoxPat_SVV.Size = new System.Drawing.Size(800, 135);
            this.groupBoxPat_SVV.TabIndex = 2;
            this.groupBoxPat_SVV.TabStop = false;
            this.groupBoxPat_SVV.Text = "Инструменты";
            // 
            // FormPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelTwoPat_SVV);
            this.Controls.Add(this.panelOne_SVV);
            this.Name = "FormPatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База пациентов";
            this.panelOne_SVV.ResumeLayout(false);
            this.panelTwoPat_SVV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients_SVV)).EndInit();
            this.groupBoxPat_SVV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelOne_SVV;
        private System.Windows.Forms.Panel panelTwoPat_SVV;
        private System.Windows.Forms.Button buttonDonePat_SVV;
        private System.Windows.Forms.DataGridView dataGridViewPatients_SVV;
        private System.Windows.Forms.Button buttonBackPat_SVV;
        private System.Windows.Forms.GroupBox groupBoxPat_SVV;
    }
}