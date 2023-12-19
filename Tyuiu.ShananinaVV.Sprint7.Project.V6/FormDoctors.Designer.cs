
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
            this.panelOneDoc_SVV = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCbros_SVV = new System.Windows.Forms.Button();
            this.labelFour_SVV = new System.Windows.Forms.Label();
            this.textBoxSear_SVV = new System.Windows.Forms.TextBox();
            this.buttonSear_SVV = new System.Windows.Forms.Button();
            this.groupBoxOneDoc_SVV = new System.Windows.Forms.GroupBox();
            this.buttonDel_SVV = new System.Windows.Forms.Button();
            this.buttonSave_SVV = new System.Windows.Forms.Button();
            this.buttonClose_SVV = new System.Windows.Forms.Button();
            this.labelThree_SVV = new System.Windows.Forms.Label();
            this.labelTwo_SVV = new System.Windows.Forms.Label();
            this.labelOne_SVV = new System.Windows.Forms.Label();
            this.buttonNew_SVV = new System.Windows.Forms.Button();
            this.buttonChange_SVV = new System.Windows.Forms.Button();
            this.textBoxSpec_SVV = new System.Windows.Forms.TextBox();
            this.textBoxPosit_SVV = new System.Windows.Forms.TextBox();
            this.textBoxName_SVV = new System.Windows.Forms.TextBox();
            this.buttonAdd_SVV = new System.Windows.Forms.Button();
            this.buttonBackDoc_SVV = new System.Windows.Forms.Button();
            this.buttonDoctors_SVV = new System.Windows.Forms.Button();
            this.panelTwoDoc_SVV = new System.Windows.Forms.Panel();
            this.buttonSort_SVV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors_SVV)).BeginInit();
            this.panelOneDoc_SVV.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxOneDoc_SVV.SuspendLayout();
            this.panelTwoDoc_SVV.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDoctors_SVV
            // 
            this.dataGridViewDoctors_SVV.AllowUserToAddRows = false;
            this.dataGridViewDoctors_SVV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDoctors_SVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctors_SVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDoctors_SVV.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDoctors_SVV.Name = "dataGridViewDoctors_SVV";
            this.dataGridViewDoctors_SVV.RowHeadersWidth = 51;
            this.dataGridViewDoctors_SVV.RowTemplate.Height = 24;
            this.dataGridViewDoctors_SVV.Size = new System.Drawing.Size(817, 335);
            this.dataGridViewDoctors_SVV.TabIndex = 0;
            this.dataGridViewDoctors_SVV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDoctors_SVV_CellClick);
            this.dataGridViewDoctors_SVV.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewDoctors_SVV_ColumnHeaderMouseClick);
            // 
            // panelOneDoc_SVV
            // 
            this.panelOneDoc_SVV.Controls.Add(this.splitter1);
            this.panelOneDoc_SVV.Controls.Add(this.groupBox1);
            this.panelOneDoc_SVV.Controls.Add(this.groupBoxOneDoc_SVV);
            this.panelOneDoc_SVV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOneDoc_SVV.Location = new System.Drawing.Point(0, 0);
            this.panelOneDoc_SVV.Name = "panelOneDoc_SVV";
            this.panelOneDoc_SVV.Size = new System.Drawing.Size(817, 185);
            this.panelOneDoc_SVV.TabIndex = 2;
            this.panelOneDoc_SVV.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOneDoc_SVV_Paint);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(540, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 185);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCbros_SVV);
            this.groupBox1.Controls.Add(this.labelFour_SVV);
            this.groupBox1.Controls.Add(this.textBoxSear_SVV);
            this.groupBox1.Controls.Add(this.buttonSear_SVV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(540, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 185);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonCbros_SVV
            // 
            this.buttonCbros_SVV.Enabled = false;
            this.buttonCbros_SVV.Location = new System.Drawing.Point(27, 116);
            this.buttonCbros_SVV.Name = "buttonCbros_SVV";
            this.buttonCbros_SVV.Size = new System.Drawing.Size(80, 38);
            this.buttonCbros_SVV.TabIndex = 19;
            this.buttonCbros_SVV.Text = "Сброс";
            this.buttonCbros_SVV.UseVisualStyleBackColor = true;
            this.buttonCbros_SVV.Click += new System.EventHandler(this.buttonCbros_SVV_Click);
            // 
            // labelFour_SVV
            // 
            this.labelFour_SVV.AutoSize = true;
            this.labelFour_SVV.Location = new System.Drawing.Point(34, 58);
            this.labelFour_SVV.Name = "labelFour_SVV";
            this.labelFour_SVV.Size = new System.Drawing.Size(195, 17);
            this.labelFour_SVV.TabIndex = 17;
            this.labelFour_SVV.Text = "Введите данные для поиска";
            // 
            // textBoxSear_SVV
            // 
            this.textBoxSear_SVV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSear_SVV.Enabled = false;
            this.textBoxSear_SVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSear_SVV.Location = new System.Drawing.Point(27, 86);
            this.textBoxSear_SVV.Name = "textBoxSear_SVV";
            this.textBoxSear_SVV.Size = new System.Drawing.Size(217, 24);
            this.textBoxSear_SVV.TabIndex = 8;
            // 
            // buttonSear_SVV
            // 
            this.buttonSear_SVV.Enabled = false;
            this.buttonSear_SVV.Location = new System.Drawing.Point(113, 116);
            this.buttonSear_SVV.Name = "buttonSear_SVV";
            this.buttonSear_SVV.Size = new System.Drawing.Size(131, 38);
            this.buttonSear_SVV.TabIndex = 5;
            this.buttonSear_SVV.Text = "Искать";
            this.buttonSear_SVV.UseVisualStyleBackColor = true;
            this.buttonSear_SVV.Click += new System.EventHandler(this.buttonSear_SVV_Click);
            // 
            // groupBoxOneDoc_SVV
            // 
            this.groupBoxOneDoc_SVV.Controls.Add(this.buttonSort_SVV);
            this.groupBoxOneDoc_SVV.Controls.Add(this.buttonDel_SVV);
            this.groupBoxOneDoc_SVV.Controls.Add(this.buttonSave_SVV);
            this.groupBoxOneDoc_SVV.Controls.Add(this.buttonClose_SVV);
            this.groupBoxOneDoc_SVV.Controls.Add(this.labelThree_SVV);
            this.groupBoxOneDoc_SVV.Controls.Add(this.labelTwo_SVV);
            this.groupBoxOneDoc_SVV.Controls.Add(this.labelOne_SVV);
            this.groupBoxOneDoc_SVV.Controls.Add(this.buttonNew_SVV);
            this.groupBoxOneDoc_SVV.Controls.Add(this.buttonChange_SVV);
            this.groupBoxOneDoc_SVV.Controls.Add(this.textBoxSpec_SVV);
            this.groupBoxOneDoc_SVV.Controls.Add(this.textBoxPosit_SVV);
            this.groupBoxOneDoc_SVV.Controls.Add(this.textBoxName_SVV);
            this.groupBoxOneDoc_SVV.Controls.Add(this.buttonAdd_SVV);
            this.groupBoxOneDoc_SVV.Controls.Add(this.buttonBackDoc_SVV);
            this.groupBoxOneDoc_SVV.Controls.Add(this.buttonDoctors_SVV);
            this.groupBoxOneDoc_SVV.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxOneDoc_SVV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOneDoc_SVV.MinimumSize = new System.Drawing.Size(540, 185);
            this.groupBoxOneDoc_SVV.Name = "groupBoxOneDoc_SVV";
            this.groupBoxOneDoc_SVV.Size = new System.Drawing.Size(540, 185);
            this.groupBoxOneDoc_SVV.TabIndex = 0;
            this.groupBoxOneDoc_SVV.TabStop = false;
            this.groupBoxOneDoc_SVV.Text = "Инструменты";
            this.groupBoxOneDoc_SVV.Enter += new System.EventHandler(this.groupBoxOneDoc_SVV_Enter);
            // 
            // buttonDel_SVV
            // 
            this.buttonDel_SVV.Enabled = false;
            this.buttonDel_SVV.Location = new System.Drawing.Point(432, 73);
            this.buttonDel_SVV.Name = "buttonDel_SVV";
            this.buttonDel_SVV.Size = new System.Drawing.Size(96, 46);
            this.buttonDel_SVV.TabIndex = 4;
            this.buttonDel_SVV.Text = "Удалить";
            this.buttonDel_SVV.UseVisualStyleBackColor = true;
            this.buttonDel_SVV.Click += new System.EventHandler(this.buttonDel_SVV_Click);
            // 
            // buttonSave_SVV
            // 
            this.buttonSave_SVV.Enabled = false;
            this.buttonSave_SVV.Location = new System.Drawing.Point(432, 21);
            this.buttonSave_SVV.Name = "buttonSave_SVV";
            this.buttonSave_SVV.Size = new System.Drawing.Size(96, 46);
            this.buttonSave_SVV.TabIndex = 6;
            this.buttonSave_SVV.Text = "Сохранить";
            this.buttonSave_SVV.UseVisualStyleBackColor = true;
            this.buttonSave_SVV.Click += new System.EventHandler(this.buttonSave_SVV_Click);
            // 
            // buttonClose_SVV
            // 
            this.buttonClose_SVV.Enabled = false;
            this.buttonClose_SVV.Location = new System.Drawing.Point(6, 21);
            this.buttonClose_SVV.Name = "buttonClose_SVV";
            this.buttonClose_SVV.Size = new System.Drawing.Size(114, 46);
            this.buttonClose_SVV.TabIndex = 18;
            this.buttonClose_SVV.Text = "Закрыть";
            this.buttonClose_SVV.UseVisualStyleBackColor = true;
            this.buttonClose_SVV.Click += new System.EventHandler(this.buttonClose_SVV_Click);
            // 
            // labelThree_SVV
            // 
            this.labelThree_SVV.AutoSize = true;
            this.labelThree_SVV.Location = new System.Drawing.Point(138, 118);
            this.labelThree_SVV.Name = "labelThree_SVV";
            this.labelThree_SVV.Size = new System.Drawing.Size(112, 17);
            this.labelThree_SVV.TabIndex = 16;
            this.labelThree_SVV.Text = "Специализация";
            // 
            // labelTwo_SVV
            // 
            this.labelTwo_SVV.AutoSize = true;
            this.labelTwo_SVV.Location = new System.Drawing.Point(138, 68);
            this.labelTwo_SVV.Name = "labelTwo_SVV";
            this.labelTwo_SVV.Size = new System.Drawing.Size(81, 17);
            this.labelTwo_SVV.TabIndex = 15;
            this.labelTwo_SVV.Text = "Должность";
            // 
            // labelOne_SVV
            // 
            this.labelOne_SVV.AutoSize = true;
            this.labelOne_SVV.Location = new System.Drawing.Point(138, 18);
            this.labelOne_SVV.Name = "labelOne_SVV";
            this.labelOne_SVV.Size = new System.Drawing.Size(42, 17);
            this.labelOne_SVV.TabIndex = 14;
            this.labelOne_SVV.Text = "ФИО";
            // 
            // buttonNew_SVV
            // 
            this.buttonNew_SVV.Enabled = false;
            this.buttonNew_SVV.Location = new System.Drawing.Point(329, 125);
            this.buttonNew_SVV.Name = "buttonNew_SVV";
            this.buttonNew_SVV.Size = new System.Drawing.Size(97, 46);
            this.buttonNew_SVV.TabIndex = 13;
            this.buttonNew_SVV.Text = "Сбросить";
            this.buttonNew_SVV.UseVisualStyleBackColor = true;
            this.buttonNew_SVV.Click += new System.EventHandler(this.buttonNew_SVV_Click);
            // 
            // buttonChange_SVV
            // 
            this.buttonChange_SVV.Enabled = false;
            this.buttonChange_SVV.Location = new System.Drawing.Point(329, 73);
            this.buttonChange_SVV.Name = "buttonChange_SVV";
            this.buttonChange_SVV.Size = new System.Drawing.Size(97, 46);
            this.buttonChange_SVV.TabIndex = 12;
            this.buttonChange_SVV.Text = "Изменить";
            this.buttonChange_SVV.UseVisualStyleBackColor = true;
            this.buttonChange_SVV.Click += new System.EventHandler(this.buttonChange_SVV_Click);
            // 
            // textBoxSpec_SVV
            // 
            this.textBoxSpec_SVV.Enabled = false;
            this.textBoxSpec_SVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSpec_SVV.Location = new System.Drawing.Point(136, 138);
            this.textBoxSpec_SVV.Name = "textBoxSpec_SVV";
            this.textBoxSpec_SVV.Size = new System.Drawing.Size(175, 24);
            this.textBoxSpec_SVV.TabIndex = 11;
            // 
            // textBoxPosit_SVV
            // 
            this.textBoxPosit_SVV.Enabled = false;
            this.textBoxPosit_SVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPosit_SVV.Location = new System.Drawing.Point(136, 88);
            this.textBoxPosit_SVV.Name = "textBoxPosit_SVV";
            this.textBoxPosit_SVV.Size = new System.Drawing.Size(175, 24);
            this.textBoxPosit_SVV.TabIndex = 10;
            // 
            // textBoxName_SVV
            // 
            this.textBoxName_SVV.Enabled = false;
            this.textBoxName_SVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName_SVV.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxName_SVV.Location = new System.Drawing.Point(136, 38);
            this.textBoxName_SVV.Name = "textBoxName_SVV";
            this.textBoxName_SVV.Size = new System.Drawing.Size(175, 24);
            this.textBoxName_SVV.TabIndex = 9;
            // 
            // buttonAdd_SVV
            // 
            this.buttonAdd_SVV.Enabled = false;
            this.buttonAdd_SVV.Location = new System.Drawing.Point(329, 21);
            this.buttonAdd_SVV.Name = "buttonAdd_SVV";
            this.buttonAdd_SVV.Size = new System.Drawing.Size(97, 46);
            this.buttonAdd_SVV.TabIndex = 3;
            this.buttonAdd_SVV.Text = "Добавить";
            this.buttonAdd_SVV.UseVisualStyleBackColor = true;
            this.buttonAdd_SVV.Click += new System.EventHandler(this.buttonAdd_SVV_Click);
            // 
            // buttonBackDoc_SVV
            // 
            this.buttonBackDoc_SVV.Location = new System.Drawing.Point(6, 70);
            this.buttonBackDoc_SVV.Name = "buttonBackDoc_SVV";
            this.buttonBackDoc_SVV.Size = new System.Drawing.Size(114, 40);
            this.buttonBackDoc_SVV.TabIndex = 2;
            this.buttonBackDoc_SVV.Text = "Назад";
            this.buttonBackDoc_SVV.UseVisualStyleBackColor = true;
            this.buttonBackDoc_SVV.Click += new System.EventHandler(this.buttonBackDoc_SVV_Click);
            // 
            // buttonDoctors_SVV
            // 
            this.buttonDoctors_SVV.Location = new System.Drawing.Point(6, 114);
            this.buttonDoctors_SVV.Name = "buttonDoctors_SVV";
            this.buttonDoctors_SVV.Size = new System.Drawing.Size(114, 65);
            this.buttonDoctors_SVV.TabIndex = 1;
            this.buttonDoctors_SVV.Text = "Открыть базу";
            this.buttonDoctors_SVV.UseVisualStyleBackColor = true;
            this.buttonDoctors_SVV.Click += new System.EventHandler(this.buttonDoctors_SVV_Click);
            // 
            // panelTwoDoc_SVV
            // 
            this.panelTwoDoc_SVV.Controls.Add(this.dataGridViewDoctors_SVV);
            this.panelTwoDoc_SVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTwoDoc_SVV.Location = new System.Drawing.Point(0, 185);
            this.panelTwoDoc_SVV.Name = "panelTwoDoc_SVV";
            this.panelTwoDoc_SVV.Size = new System.Drawing.Size(817, 335);
            this.panelTwoDoc_SVV.TabIndex = 2;
            // 
            // buttonSort_SVV
            // 
            this.buttonSort_SVV.Location = new System.Drawing.Point(432, 131);
            this.buttonSort_SVV.Name = "buttonSort_SVV";
            this.buttonSort_SVV.Size = new System.Drawing.Size(75, 23);
            this.buttonSort_SVV.TabIndex = 19;
            this.buttonSort_SVV.Text = "button1";
            this.buttonSort_SVV.UseVisualStyleBackColor = true;
            this.buttonSort_SVV.Click += new System.EventHandler(this.buttonSort_SVV_Click);
            // 
            // FormDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 520);
            this.Controls.Add(this.panelTwoDoc_SVV);
            this.Controls.Add(this.panelOneDoc_SVV);
            this.MinimumSize = new System.Drawing.Size(835, 567);
            this.Name = "FormDoctors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База врачей";
            this.Load += new System.EventHandler(this.FormDoctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors_SVV)).EndInit();
            this.panelOneDoc_SVV.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxOneDoc_SVV.ResumeLayout(false);
            this.groupBoxOneDoc_SVV.PerformLayout();
            this.panelTwoDoc_SVV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDoctors_SVV;
        private System.Windows.Forms.Panel panelOneDoc_SVV;
        private System.Windows.Forms.Panel panelTwoDoc_SVV;
        private System.Windows.Forms.Button buttonDel_SVV;
        private System.Windows.Forms.Button buttonSave_SVV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxOneDoc_SVV;
        private System.Windows.Forms.Button buttonCbros_SVV;
        private System.Windows.Forms.Button buttonClose_SVV;
        private System.Windows.Forms.Label labelFour_SVV;
        private System.Windows.Forms.Label labelThree_SVV;
        private System.Windows.Forms.Label labelTwo_SVV;
        private System.Windows.Forms.Label labelOne_SVV;
        private System.Windows.Forms.Button buttonNew_SVV;
        private System.Windows.Forms.Button buttonChange_SVV;
        private System.Windows.Forms.TextBox textBoxSpec_SVV;
        private System.Windows.Forms.TextBox textBoxPosit_SVV;
        private System.Windows.Forms.TextBox textBoxName_SVV;
        private System.Windows.Forms.TextBox textBoxSear_SVV;
        private System.Windows.Forms.Button buttonSear_SVV;
        private System.Windows.Forms.Button buttonAdd_SVV;
        private System.Windows.Forms.Button buttonBackDoc_SVV;
        private System.Windows.Forms.Button buttonDoctors_SVV;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button buttonSort_SVV;
    }
}