﻿
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
            this.openFileDialog_SVV = new System.Windows.Forms.OpenFileDialog();
            this.buttonPatients_SVV = new System.Windows.Forms.Button();
            this.buttonDoctors_SVV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonHelp_SVV
            // 
            this.buttonHelp_SVV.Location = new System.Drawing.Point(666, 12);
            this.buttonHelp_SVV.Name = "buttonHelp_SVV";
            this.buttonHelp_SVV.Size = new System.Drawing.Size(95, 46);
            this.buttonHelp_SVV.TabIndex = 0;
            this.buttonHelp_SVV.Text = "Help";
            this.buttonHelp_SVV.UseVisualStyleBackColor = true;
            this.buttonHelp_SVV.Click += new System.EventHandler(this.buttonHelp_SVV_Click);
            // 
            // openFileDialog_SVV
            // 
            this.openFileDialog_SVV.FileName = "openFileDialog1";
            // 
            // buttonPatients_SVV
            // 
            this.buttonPatients_SVV.Location = new System.Drawing.Point(306, 180);
            this.buttonPatients_SVV.Name = "buttonPatients_SVV";
            this.buttonPatients_SVV.Size = new System.Drawing.Size(147, 54);
            this.buttonPatients_SVV.TabIndex = 4;
            this.buttonPatients_SVV.Text = "База пациентов";
            this.buttonPatients_SVV.UseVisualStyleBackColor = true;
            this.buttonPatients_SVV.Click += new System.EventHandler(this.buttonPatients_SVV_Click);
            // 
            // buttonDoctors_SVV
            // 
            this.buttonDoctors_SVV.Location = new System.Drawing.Point(306, 240);
            this.buttonDoctors_SVV.Name = "buttonDoctors_SVV";
            this.buttonDoctors_SVV.Size = new System.Drawing.Size(147, 53);
            this.buttonDoctors_SVV.TabIndex = 5;
            this.buttonDoctors_SVV.Text = "База врачей";
            this.buttonDoctors_SVV.UseVisualStyleBackColor = true;
            this.buttonDoctors_SVV.Click += new System.EventHandler(this.buttonDoctors_SVV_Click);
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(782, 445);
            this.Controls.Add(this.buttonDoctors_SVV);
            this.Controls.Add(this.buttonPatients_SVV);
            this.Controls.Add(this.buttonHelp_SVV);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поликлиника";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHelp_SVV;
        private System.Windows.Forms.OpenFileDialog openFileDialog_SVV;
        private System.Windows.Forms.Button buttonPatients_SVV;
        private System.Windows.Forms.Button buttonDoctors_SVV;
    }
}

