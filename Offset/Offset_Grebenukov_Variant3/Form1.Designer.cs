
namespace Offset_Grebenukov_Variant3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if ( disposing && (components != null) )
            {
                components.Dispose( );
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBoxFindMaxScore = new System.Windows.Forms.ListBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonNewStudent = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownId = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.numericUpDownDis3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDis2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDis1 = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDis3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDis2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDis1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите дисциплину по которой надо найти n-й максимальный балл";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1264, 450);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxFindMaxScore);
            this.tabPage1.Controls.Add(this.buttonFind);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.dataGridViewData);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1256, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Основной экран";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBoxFindMaxScore
            // 
            this.listBoxFindMaxScore.FormattingEnabled = true;
            this.listBoxFindMaxScore.ItemHeight = 15;
            this.listBoxFindMaxScore.Location = new System.Drawing.Point(441, 7);
            this.listBoxFindMaxScore.Name = "listBoxFindMaxScore";
            this.listBoxFindMaxScore.Size = new System.Drawing.Size(513, 94);
            this.listBoxFindMaxScore.TabIndex = 5;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(9, 65);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(400, 23);
            this.buttonFind.TabIndex = 4;
            this.buttonFind.Text = "Найти";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox1.Location = new System.Drawing.Point(9, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(400, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewData.Location = new System.Drawing.Point(3, 137);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.RowTemplate.Height = 25;
            this.dataGridViewData.Size = new System.Drawing.Size(1250, 282);
            this.dataGridViewData.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonNewStudent);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.numericUpDownId);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBoxFIO);
            this.tabPage2.Controls.Add(this.numericUpDownDis3);
            this.tabPage2.Controls.Add(this.numericUpDownDis2);
            this.tabPage2.Controls.Add(this.numericUpDownDis1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавление нового студента";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonNewStudent
            // 
            this.buttonNewStudent.Location = new System.Drawing.Point(16, 299);
            this.buttonNewStudent.Name = "buttonNewStudent";
            this.buttonNewStudent.Size = new System.Drawing.Size(120, 23);
            this.buttonNewStudent.TabIndex = 10;
            this.buttonNewStudent.Text = "Добавить студента";
            this.buttonNewStudent.UseVisualStyleBackColor = true;
            this.buttonNewStudent.Click += new System.EventHandler(this.buttonNewStudent_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Выберите балл за дисциплину 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Выберите балл за дисциплину 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Выберите балл за дисциплину 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введите Имя и фамилию";
            // 
            // numericUpDownId
            // 
            this.numericUpDownId.Location = new System.Drawing.Point(16, 35);
            this.numericUpDownId.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownId.Name = "numericUpDownId";
            this.numericUpDownId.Size = new System.Drawing.Size(199, 23);
            this.numericUpDownId.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Выберите идентификатор";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(16, 79);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(199, 23);
            this.textBoxFIO.TabIndex = 3;
            this.textBoxFIO.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // numericUpDownDis3
            // 
            this.numericUpDownDis3.Location = new System.Drawing.Point(16, 259);
            this.numericUpDownDis3.Name = "numericUpDownDis3";
            this.numericUpDownDis3.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownDis3.TabIndex = 2;
            // 
            // numericUpDownDis2
            // 
            this.numericUpDownDis2.Location = new System.Drawing.Point(16, 196);
            this.numericUpDownDis2.Name = "numericUpDownDis2";
            this.numericUpDownDis2.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownDis2.TabIndex = 1;
            // 
            // numericUpDownDis1
            // 
            this.numericUpDownDis1.Location = new System.Drawing.Point(16, 136);
            this.numericUpDownDis1.Name = "numericUpDownDis1";
            this.numericUpDownDis1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownDis1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDis3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDis2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDis1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.NumericUpDown numericUpDownDis3;
        private System.Windows.Forms.NumericUpDown numericUpDownDis2;
        private System.Windows.Forms.NumericUpDown numericUpDownDis1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonNewStudent;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBoxFindMaxScore;
        private System.Windows.Forms.Button buttonFind;
    }
}

