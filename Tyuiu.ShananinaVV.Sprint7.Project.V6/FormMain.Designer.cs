
namespace Tyuiu.ShananinaVV.Sprint7.Project.V6
{
    partial class FormMain
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
            this.buttonHelp_SVV = new System.Windows.Forms.Button();
            this.dataGridViewPatients_SVV = new System.Windows.Forms.DataGridView();
            this.buttonDone_SVV = new System.Windows.Forms.Button();
            this.openFileDialog_SVV = new System.Windows.Forms.OpenFileDialog();
            this.buttonOpen_SVV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients_SVV)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHelp_SVV
            // 
            this.buttonHelp_SVV.Location = new System.Drawing.Point(319, 54);
            this.buttonHelp_SVV.Name = "buttonHelp_SVV";
            this.buttonHelp_SVV.Size = new System.Drawing.Size(79, 46);
            this.buttonHelp_SVV.TabIndex = 0;
            this.buttonHelp_SVV.Text = "Help";
            this.buttonHelp_SVV.UseVisualStyleBackColor = true;
            this.buttonHelp_SVV.Click += new System.EventHandler(this.buttonHelp_SVV_Click);
            // 
            // dataGridViewPatients_SVV
            // 
            this.dataGridViewPatients_SVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients_SVV.Location = new System.Drawing.Point(12, 177);
            this.dataGridViewPatients_SVV.Name = "dataGridViewPatients_SVV";
            this.dataGridViewPatients_SVV.RowHeadersWidth = 51;
            this.dataGridViewPatients_SVV.RowTemplate.Height = 24;
            this.dataGridViewPatients_SVV.Size = new System.Drawing.Size(489, 195);
            this.dataGridViewPatients_SVV.TabIndex = 1;
            this.dataGridViewPatients_SVV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatients_SVV_CellContentClick);
            // 
            // buttonDone_SVV
            // 
            this.buttonDone_SVV.Location = new System.Drawing.Point(171, 51);
            this.buttonDone_SVV.Name = "buttonDone_SVV";
            this.buttonDone_SVV.Size = new System.Drawing.Size(117, 49);
            this.buttonDone_SVV.TabIndex = 2;
            this.buttonDone_SVV.Text = "Выполнить ";
            this.buttonDone_SVV.UseVisualStyleBackColor = true;
            // 
            // openFileDialog_SVV
            // 
            this.openFileDialog_SVV.FileName = "openFileDialog1";
            // 
            // buttonOpen_SVV
            // 
            this.buttonOpen_SVV.Location = new System.Drawing.Point(13, 48);
            this.buttonOpen_SVV.Name = "buttonOpen_SVV";
            this.buttonOpen_SVV.Size = new System.Drawing.Size(116, 52);
            this.buttonOpen_SVV.TabIndex = 3;
            this.buttonOpen_SVV.Text = "button1";
            this.buttonOpen_SVV.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(513, 398);
            this.Controls.Add(this.buttonOpen_SVV);
            this.Controls.Add(this.buttonDone_SVV);
            this.Controls.Add(this.dataGridViewPatients_SVV);
            this.Controls.Add(this.buttonHelp_SVV);
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients_SVV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHelp_SVV;
        private System.Windows.Forms.DataGridView dataGridViewPatients_SVV;
        private System.Windows.Forms.Button buttonDone_SVV;
        private System.Windows.Forms.OpenFileDialog openFileDialog_SVV;
        private System.Windows.Forms.Button buttonOpen_SVV;
    }
}

