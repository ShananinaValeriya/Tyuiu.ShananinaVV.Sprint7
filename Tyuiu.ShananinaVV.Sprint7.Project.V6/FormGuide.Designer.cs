
namespace Tyuiu.ShananinaVV.Sprint7.Project.V6
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            this.panelGuide_SVV = new System.Windows.Forms.Panel();
            this.groupBoxGuide_SVV = new System.Windows.Forms.GroupBox();
            this.textBoxGuide_SVV = new System.Windows.Forms.TextBox();
            this.buttonOK_SVV = new System.Windows.Forms.Button();
            this.panelGuide_SVV.SuspendLayout();
            this.groupBoxGuide_SVV.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGuide_SVV
            // 
            this.panelGuide_SVV.Controls.Add(this.groupBoxGuide_SVV);
            this.panelGuide_SVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGuide_SVV.Location = new System.Drawing.Point(0, 0);
            this.panelGuide_SVV.Name = "panelGuide_SVV";
            this.panelGuide_SVV.Size = new System.Drawing.Size(800, 450);
            this.panelGuide_SVV.TabIndex = 0;
            // 
            // groupBoxGuide_SVV
            // 
            this.groupBoxGuide_SVV.Controls.Add(this.buttonOK_SVV);
            this.groupBoxGuide_SVV.Controls.Add(this.textBoxGuide_SVV);
            this.groupBoxGuide_SVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxGuide_SVV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxGuide_SVV.Name = "groupBoxGuide_SVV";
            this.groupBoxGuide_SVV.Size = new System.Drawing.Size(800, 450);
            this.groupBoxGuide_SVV.TabIndex = 1;
            this.groupBoxGuide_SVV.TabStop = false;
            // 
            // textBoxGuide_SVV
            // 
            this.textBoxGuide_SVV.Location = new System.Drawing.Point(12, 12);
            this.textBoxGuide_SVV.Multiline = true;
            this.textBoxGuide_SVV.Name = "textBoxGuide_SVV";
            this.textBoxGuide_SVV.ReadOnly = true;
            this.textBoxGuide_SVV.Size = new System.Drawing.Size(776, 385);
            this.textBoxGuide_SVV.TabIndex = 0;
            this.textBoxGuide_SVV.TabStop = false;
            this.textBoxGuide_SVV.Text = resources.GetString("textBoxGuide_SVV.Text");
            // 
            // buttonOK_SVV
            // 
            this.buttonOK_SVV.Location = new System.Drawing.Point(661, 403);
            this.buttonOK_SVV.Name = "buttonOK_SVV";
            this.buttonOK_SVV.Size = new System.Drawing.Size(114, 35);
            this.buttonOK_SVV.TabIndex = 1;
            this.buttonOK_SVV.Text = "Oк";
            this.buttonOK_SVV.UseVisualStyleBackColor = true;
            this.buttonOK_SVV.Click += new System.EventHandler(this.buttonOK_SVV_Click);
            // 
            // FormGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelGuide_SVV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGuide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Руководство пользователя";
            this.panelGuide_SVV.ResumeLayout(false);
            this.groupBoxGuide_SVV.ResumeLayout(false);
            this.groupBoxGuide_SVV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGuide_SVV;
        private System.Windows.Forms.GroupBox groupBoxGuide_SVV;
        private System.Windows.Forms.TextBox textBoxGuide_SVV;
        private System.Windows.Forms.Button buttonOK_SVV;
    }
}