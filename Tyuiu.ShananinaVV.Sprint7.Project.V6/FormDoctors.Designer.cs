
namespace Tyuiu.ShananinaVV.Sprint7.Project.V6
{
    partial class FormDoctors
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
            this.dataGridViewDoctors_SVV = new System.Windows.Forms.DataGridView();
            this.buttonDoctors_SVV = new System.Windows.Forms.Button();
            this.panelOneDoc_SVV = new System.Windows.Forms.Panel();
            this.panelTwoDoc_SVV = new System.Windows.Forms.Panel();
            this.groupBoxOneDoc_SVV = new System.Windows.Forms.GroupBox();
            this.buttonBackDoc_SVV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors_SVV)).BeginInit();
            this.panelOneDoc_SVV.SuspendLayout();
            this.panelTwoDoc_SVV.SuspendLayout();
            this.groupBoxOneDoc_SVV.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDoctors_SVV
            // 
            this.dataGridViewDoctors_SVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctors_SVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDoctors_SVV.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDoctors_SVV.Name = "dataGridViewDoctors_SVV";
            this.dataGridViewDoctors_SVV.RowHeadersVisible = false;
            this.dataGridViewDoctors_SVV.RowHeadersWidth = 51;
            this.dataGridViewDoctors_SVV.RowTemplate.Height = 24;
            this.dataGridViewDoctors_SVV.Size = new System.Drawing.Size(722, 298);
            this.dataGridViewDoctors_SVV.TabIndex = 0;
            // 
            // buttonDoctors_SVV
            // 
            this.buttonDoctors_SVV.Location = new System.Drawing.Point(12, 66);
            this.buttonDoctors_SVV.Name = "buttonDoctors_SVV";
            this.buttonDoctors_SVV.Size = new System.Drawing.Size(124, 60);
            this.buttonDoctors_SVV.TabIndex = 1;
            this.buttonDoctors_SVV.Text = "Открыть базу";
            this.buttonDoctors_SVV.UseVisualStyleBackColor = true;
            this.buttonDoctors_SVV.Click += new System.EventHandler(this.buttonDoctors_SVV_Click);
            // 
            // panelOneDoc_SVV
            // 
            this.panelOneDoc_SVV.Controls.Add(this.groupBoxOneDoc_SVV);
            this.panelOneDoc_SVV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOneDoc_SVV.Location = new System.Drawing.Point(0, 0);
            this.panelOneDoc_SVV.Name = "panelOneDoc_SVV";
            this.panelOneDoc_SVV.Size = new System.Drawing.Size(722, 132);
            this.panelOneDoc_SVV.TabIndex = 2;
            // 
            // panelTwoDoc_SVV
            // 
            this.panelTwoDoc_SVV.Controls.Add(this.dataGridViewDoctors_SVV);
            this.panelTwoDoc_SVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTwoDoc_SVV.Location = new System.Drawing.Point(0, 132);
            this.panelTwoDoc_SVV.Name = "panelTwoDoc_SVV";
            this.panelTwoDoc_SVV.Size = new System.Drawing.Size(722, 298);
            this.panelTwoDoc_SVV.TabIndex = 2;
            // 
            // groupBoxOneDoc_SVV
            // 
            this.groupBoxOneDoc_SVV.Controls.Add(this.buttonBackDoc_SVV);
            this.groupBoxOneDoc_SVV.Controls.Add(this.buttonDoctors_SVV);
            this.groupBoxOneDoc_SVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOneDoc_SVV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOneDoc_SVV.Name = "groupBoxOneDoc_SVV";
            this.groupBoxOneDoc_SVV.Size = new System.Drawing.Size(722, 132);
            this.groupBoxOneDoc_SVV.TabIndex = 0;
            this.groupBoxOneDoc_SVV.TabStop = false;
            this.groupBoxOneDoc_SVV.Text = "Инструменты";
            // 
            // buttonBackDoc_SVV
            // 
            this.buttonBackDoc_SVV.Location = new System.Drawing.Point(12, 21);
            this.buttonBackDoc_SVV.Name = "buttonBackDoc_SVV";
            this.buttonBackDoc_SVV.Size = new System.Drawing.Size(124, 39);
            this.buttonBackDoc_SVV.TabIndex = 2;
            this.buttonBackDoc_SVV.Text = "Назад";
            this.buttonBackDoc_SVV.UseVisualStyleBackColor = true;
            this.buttonBackDoc_SVV.Click += new System.EventHandler(this.buttonBackDoc_SVV_Click);
            // 
            // FormDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 430);
            this.Controls.Add(this.panelTwoDoc_SVV);
            this.Controls.Add(this.panelOneDoc_SVV);
            this.Name = "FormDoctors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База врачей";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors_SVV)).EndInit();
            this.panelOneDoc_SVV.ResumeLayout(false);
            this.panelTwoDoc_SVV.ResumeLayout(false);
            this.groupBoxOneDoc_SVV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDoctors_SVV;
        private System.Windows.Forms.Button buttonDoctors_SVV;
        private System.Windows.Forms.Panel panelOneDoc_SVV;
        private System.Windows.Forms.Panel panelTwoDoc_SVV;
        private System.Windows.Forms.GroupBox groupBoxOneDoc_SVV;
        private System.Windows.Forms.Button buttonBackDoc_SVV;
    }
}