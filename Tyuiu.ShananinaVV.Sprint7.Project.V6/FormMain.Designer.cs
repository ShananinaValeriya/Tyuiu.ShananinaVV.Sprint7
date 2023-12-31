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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonHelp_SVV = new System.Windows.Forms.Button();
            this.buttonPatients_SVV = new System.Windows.Forms.Button();
            this.buttonDoctors_SVV = new System.Windows.Forms.Button();
            this.buttonAll_SVV = new System.Windows.Forms.Button();
            this.buttonGuide_SVV = new System.Windows.Forms.Button();
            this.toolTipMain_SVV = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // buttonHelp_SVV
            // 
            this.buttonHelp_SVV.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonHelp_SVV.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_SVV.Image")));
            this.buttonHelp_SVV.Location = new System.Drawing.Point(726, 10);
            this.buttonHelp_SVV.Name = "buttonHelp_SVV";
            this.buttonHelp_SVV.Size = new System.Drawing.Size(44, 44);
            this.buttonHelp_SVV.TabIndex = 0;
            this.toolTipMain_SVV.SetToolTip(this.buttonHelp_SVV, "О программе");
            this.buttonHelp_SVV.UseVisualStyleBackColor = false;
            this.buttonHelp_SVV.Click += new System.EventHandler(this.buttonHelp_SVV_Click);
            this.buttonHelp_SVV.MouseEnter += new System.EventHandler(this.buttonHelp_SVV_MouseEnter);
            // 
            // buttonPatients_SVV
            // 
            this.buttonPatients_SVV.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonPatients_SVV.Location = new System.Drawing.Point(290, 214);
            this.buttonPatients_SVV.Name = "buttonPatients_SVV";
            this.buttonPatients_SVV.Size = new System.Drawing.Size(203, 54);
            this.buttonPatients_SVV.TabIndex = 4;
            this.buttonPatients_SVV.Text = "База пациентов";
            this.buttonPatients_SVV.UseVisualStyleBackColor = false;
            this.buttonPatients_SVV.Click += new System.EventHandler(this.buttonPatients_SVV_Click);
            // 
            // buttonDoctors_SVV
            // 
            this.buttonDoctors_SVV.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonDoctors_SVV.Location = new System.Drawing.Point(290, 274);
            this.buttonDoctors_SVV.Name = "buttonDoctors_SVV";
            this.buttonDoctors_SVV.Size = new System.Drawing.Size(203, 54);
            this.buttonDoctors_SVV.TabIndex = 5;
            this.buttonDoctors_SVV.Text = "База врачей";
            this.buttonDoctors_SVV.UseVisualStyleBackColor = false;
            this.buttonDoctors_SVV.Click += new System.EventHandler(this.buttonDoctors_SVV_Click);
            // 
            // buttonAll_SVV
            // 
            this.buttonAll_SVV.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonAll_SVV.Location = new System.Drawing.Point(290, 155);
            this.buttonAll_SVV.Name = "buttonAll_SVV";
            this.buttonAll_SVV.Size = new System.Drawing.Size(203, 54);
            this.buttonAll_SVV.TabIndex = 6;
            this.buttonAll_SVV.Text = "Общая база";
            this.buttonAll_SVV.UseVisualStyleBackColor = false;
            this.buttonAll_SVV.Click += new System.EventHandler(this.buttonAll_SVV_Click);
            // 
            // buttonGuide_SVV
            // 
            this.buttonGuide_SVV.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonGuide_SVV.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuide_SVV.Image")));
            this.buttonGuide_SVV.Location = new System.Drawing.Point(726, 60);
            this.buttonGuide_SVV.Name = "buttonGuide_SVV";
            this.buttonGuide_SVV.Size = new System.Drawing.Size(44, 44);
            this.buttonGuide_SVV.TabIndex = 7;
            this.toolTipMain_SVV.SetToolTip(this.buttonGuide_SVV, "Руководство пользователя");
            this.buttonGuide_SVV.UseVisualStyleBackColor = false;
            this.buttonGuide_SVV.Click += new System.EventHandler(this.buttonGuide_SVV_Click);
            this.buttonGuide_SVV.MouseEnter += new System.EventHandler(this.buttonGuide_SVV_MouseEnter);
            // 
            // toolTipMain_SVV
            // 
            this.toolTipMain_SVV.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipMain_SVV.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 445);
            this.Controls.Add(this.buttonGuide_SVV);
            this.Controls.Add(this.buttonAll_SVV);
            this.Controls.Add(this.buttonDoctors_SVV);
            this.Controls.Add(this.buttonPatients_SVV);
            this.Controls.Add(this.buttonHelp_SVV);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 492);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 492);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поликлиника";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHelp_SVV;
        private System.Windows.Forms.Button buttonPatients_SVV;
        private System.Windows.Forms.Button buttonDoctors_SVV;
        private System.Windows.Forms.Button buttonAll_SVV;
        private System.Windows.Forms.Button buttonGuide_SVV;
        private System.Windows.Forms.ToolTip toolTipMain_SVV;
    }
}

