
namespace WindowsFormsApp1
{
    partial class Form8
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодДолжностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеДолжностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.окладDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.обязанностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.требованияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportCompanyDataSet = new WindowsFormsApp1.TransportCompanyDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.должностиTableAdapter = new WindowsFormsApp1.TransportCompanyDataSetTableAdapters.ДолжностиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportCompanyDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 517);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(677, 22);
            this.textBox1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 517);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Критерий";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодДолжностиDataGridViewTextBoxColumn,
            this.наименованиеДолжностиDataGridViewTextBoxColumn,
            this.окладDataGridViewTextBoxColumn,
            this.обязанностиDataGridViewTextBoxColumn,
            this.требованияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.должностиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(738, 429);
            this.dataGridView1.TabIndex = 15;
            // 
            // кодДолжностиDataGridViewTextBoxColumn
            // 
            this.кодДолжностиDataGridViewTextBoxColumn.DataPropertyName = "Код_Должности";
            this.кодДолжностиDataGridViewTextBoxColumn.HeaderText = "Код_Должности";
            this.кодДолжностиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодДолжностиDataGridViewTextBoxColumn.Name = "кодДолжностиDataGridViewTextBoxColumn";
            this.кодДолжностиDataGridViewTextBoxColumn.Width = 125;
            // 
            // наименованиеДолжностиDataGridViewTextBoxColumn
            // 
            this.наименованиеДолжностиDataGridViewTextBoxColumn.DataPropertyName = "Наименование_Должности";
            this.наименованиеДолжностиDataGridViewTextBoxColumn.HeaderText = "Наименование_Должности";
            this.наименованиеДолжностиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наименованиеДолжностиDataGridViewTextBoxColumn.Name = "наименованиеДолжностиDataGridViewTextBoxColumn";
            this.наименованиеДолжностиDataGridViewTextBoxColumn.Width = 125;
            // 
            // окладDataGridViewTextBoxColumn
            // 
            this.окладDataGridViewTextBoxColumn.DataPropertyName = "Оклад";
            this.окладDataGridViewTextBoxColumn.HeaderText = "Оклад";
            this.окладDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.окладDataGridViewTextBoxColumn.Name = "окладDataGridViewTextBoxColumn";
            this.окладDataGridViewTextBoxColumn.Width = 125;
            // 
            // обязанностиDataGridViewTextBoxColumn
            // 
            this.обязанностиDataGridViewTextBoxColumn.DataPropertyName = "Обязанности";
            this.обязанностиDataGridViewTextBoxColumn.HeaderText = "Обязанности";
            this.обязанностиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.обязанностиDataGridViewTextBoxColumn.Name = "обязанностиDataGridViewTextBoxColumn";
            this.обязанностиDataGridViewTextBoxColumn.Width = 125;
            // 
            // требованияDataGridViewTextBoxColumn
            // 
            this.требованияDataGridViewTextBoxColumn.DataPropertyName = "Требования";
            this.требованияDataGridViewTextBoxColumn.HeaderText = "Требования";
            this.требованияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.требованияDataGridViewTextBoxColumn.Name = "требованияDataGridViewTextBoxColumn";
            this.требованияDataGridViewTextBoxColumn.Width = 125;
            // 
            // должностиBindingSource
            // 
            this.должностиBindingSource.DataMember = "Должности";
            this.должностиBindingSource.DataSource = this.transportCompanyDataSet;
            // 
            // transportCompanyDataSet
            // 
            this.transportCompanyDataSet.DataSetName = "TransportCompanyDataSet";
            this.transportCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(890, 517);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(774, 517);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Найти";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(774, 482);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(229, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Показать все";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(767, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 380);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Код_Должности",
            "Наименование_Должности",
            "Оклад",
            "Обязанности",
            "Требования"});
            this.listBox1.Location = new System.Drawing.Point(9, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(215, 228);
            this.listBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Поле";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(7, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сортировать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 315);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(117, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "По убыванию";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 288);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(137, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "По возрастанию";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(304, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Табличная форма \"Должности\"";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // должностиTableAdapter
            // 
            this.должностиTableAdapter.ClearBeforeFill = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1021, 575);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form8";
            this.Text = "Должности";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportCompanyDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private TransportCompanyDataSet transportCompanyDataSet;
        private System.Windows.Forms.BindingSource должностиBindingSource;
        private TransportCompanyDataSetTableAdapters.ДолжностиTableAdapter должностиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодДолжностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеДолжностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn окладDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn обязанностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn требованияDataGridViewTextBoxColumn;
    }
}