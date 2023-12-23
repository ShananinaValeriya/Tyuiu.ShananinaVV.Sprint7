
namespace Tyuiu.ShananinaVV.Sprint7.Project.V6
{
    partial class FormStatistics
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
            this.buttonDone_SVV = new System.Windows.Forms.Button();
            this.labelSum_SVV = new System.Windows.Forms.Label();
            this.labelAver_SVV = new System.Windows.Forms.Label();
            this.labelMin_SVV = new System.Windows.Forms.Label();
            this.labelMax_SVV = new System.Windows.Forms.Label();
            this.labelCount_SVV = new System.Windows.Forms.Label();
            this.panelOne_SVV.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOne_SVV
            // 
            this.panelOne_SVV.Controls.Add(this.labelCount_SVV);
            this.panelOne_SVV.Controls.Add(this.labelMax_SVV);
            this.panelOne_SVV.Controls.Add(this.labelMin_SVV);
            this.panelOne_SVV.Controls.Add(this.labelAver_SVV);
            this.panelOne_SVV.Controls.Add(this.labelSum_SVV);
            this.panelOne_SVV.Controls.Add(this.buttonDone_SVV);
            this.panelOne_SVV.Location = new System.Drawing.Point(76, 74);
            this.panelOne_SVV.Name = "panelOne_SVV";
            this.panelOne_SVV.Size = new System.Drawing.Size(559, 304);
            this.panelOne_SVV.TabIndex = 0;
            // 
            // buttonDone_SVV
            // 
            this.buttonDone_SVV.Location = new System.Drawing.Point(174, 117);
            this.buttonDone_SVV.Name = "buttonDone_SVV";
            this.buttonDone_SVV.Size = new System.Drawing.Size(102, 66);
            this.buttonDone_SVV.TabIndex = 0;
            this.buttonDone_SVV.Text = "button1";
            this.buttonDone_SVV.UseVisualStyleBackColor = true;
            this.buttonDone_SVV.Click += new System.EventHandler(this.buttonDone_SVV_Click);
            // 
            // labelSum_SVV
            // 
            this.labelSum_SVV.AutoSize = true;
            this.labelSum_SVV.Location = new System.Drawing.Point(82, 49);
            this.labelSum_SVV.Name = "labelSum_SVV";
            this.labelSum_SVV.Size = new System.Drawing.Size(46, 17);
            this.labelSum_SVV.TabIndex = 1;
            this.labelSum_SVV.Text = "label1";
            // 
            // labelAver_SVV
            // 
            this.labelAver_SVV.AutoSize = true;
            this.labelAver_SVV.Location = new System.Drawing.Point(81, 109);
            this.labelAver_SVV.Name = "labelAver_SVV";
            this.labelAver_SVV.Size = new System.Drawing.Size(46, 17);
            this.labelAver_SVV.TabIndex = 2;
            this.labelAver_SVV.Text = "label2";
            // 
            // labelMin_SVV
            // 
            this.labelMin_SVV.AutoSize = true;
            this.labelMin_SVV.Location = new System.Drawing.Point(84, 171);
            this.labelMin_SVV.Name = "labelMin_SVV";
            this.labelMin_SVV.Size = new System.Drawing.Size(46, 17);
            this.labelMin_SVV.TabIndex = 3;
            this.labelMin_SVV.Text = "label3";
            // 
            // labelMax_SVV
            // 
            this.labelMax_SVV.AutoSize = true;
            this.labelMax_SVV.Location = new System.Drawing.Point(87, 217);
            this.labelMax_SVV.Name = "labelMax_SVV";
            this.labelMax_SVV.Size = new System.Drawing.Size(46, 17);
            this.labelMax_SVV.TabIndex = 4;
            this.labelMax_SVV.Text = "label4";
            // 
            // labelCount_SVV
            // 
            this.labelCount_SVV.AutoSize = true;
            this.labelCount_SVV.Location = new System.Drawing.Point(182, 31);
            this.labelCount_SVV.Name = "labelCount_SVV";
            this.labelCount_SVV.Size = new System.Drawing.Size(46, 17);
            this.labelCount_SVV.TabIndex = 5;
            this.labelCount_SVV.Text = "label5";
            this.labelCount_SVV.Click += new System.EventHandler(this.labelCount_SVV_Click);
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelOne_SVV);
            this.Name = "FormStatistics";
            this.Text = "FormStatistics";
            this.Load += new System.EventHandler(this.FormStatistics_Load);
            this.panelOne_SVV.ResumeLayout(false);
            this.panelOne_SVV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOne_SVV;
        private System.Windows.Forms.Button buttonDone_SVV;
        private System.Windows.Forms.Label labelCount_SVV;
        private System.Windows.Forms.Label labelMax_SVV;
        private System.Windows.Forms.Label labelMin_SVV;
        private System.Windows.Forms.Label labelAver_SVV;
        private System.Windows.Forms.Label labelSum_SVV;
    }
}