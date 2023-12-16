
namespace Tyuiu.ShananinaVV.Sprint7.Project.V6
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelAbout_SVV = new System.Windows.Forms.Label();
            this.buttonOk_SVV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAbout_SVV
            // 
            this.labelAbout_SVV.AutoSize = true;
            this.labelAbout_SVV.Location = new System.Drawing.Point(12, 9);
            this.labelAbout_SVV.Name = "labelAbout_SVV";
            this.labelAbout_SVV.Size = new System.Drawing.Size(367, 170);
            this.labelAbout_SVV.TabIndex = 0;
            this.labelAbout_SVV.Text = resources.GetString("labelAbout_SVV.Text");
            // 
            // buttonOk_SVV
            // 
            this.buttonOk_SVV.Location = new System.Drawing.Point(276, 171);
            this.buttonOk_SVV.Name = "buttonOk_SVV";
            this.buttonOk_SVV.Size = new System.Drawing.Size(103, 31);
            this.buttonOk_SVV.TabIndex = 1;
            this.buttonOk_SVV.Text = "Ок";
            this.buttonOk_SVV.UseVisualStyleBackColor = true;
            this.buttonOk_SVV.Click += new System.EventHandler(this.buttonOk_SVV_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 214);
            this.Controls.Add(this.buttonOk_SVV);
            this.Controls.Add(this.labelAbout_SVV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAbout_SVV;
        private System.Windows.Forms.Button buttonOk_SVV;
    }
}