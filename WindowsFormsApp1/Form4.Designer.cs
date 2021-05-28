
namespace WindowsFormsApp1
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодВидаАвтомобиляDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодАвтомобиляDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодМаркиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.регистрационныйНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерКузоваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерДвигателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годВыпускаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодCотрудникаводителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПоследнегоТОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСотрудникаМеханикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.автомобилиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportCompanyDataSet = new WindowsFormsApp1.TransportCompanyDataSet();
            this.автомобилиTableAdapter = new WindowsFormsApp1.TransportCompanyDataSetTableAdapters.АвтомобилиTableAdapter();
            this.автомобилиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportCompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(304, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Табличная форма \"Автомобили\"";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(767, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 380);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Код_Автомобиля",
            "Код_Марки",
            "Код_Вида_Автомобиля",
            "Регистрационный_Номер",
            "Номер_Кузова",
            "Номер_Двигателя",
            "Год_Выпуска",
            "Код_Сотрудника_водителя",
            "Дата_Последнего_ТО",
            "Код_Сотрудника_Механика"});
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(890, 523);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(774, 523);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Найти";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(774, 488);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(229, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Показать все";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодВидаАвтомобиляDataGridViewTextBoxColumn,
            this.кодАвтомобиляDataGridViewTextBoxColumn,
            this.кодМаркиDataGridViewTextBoxColumn,
            this.регистрационныйНомерDataGridViewTextBoxColumn,
            this.номерКузоваDataGridViewTextBoxColumn,
            this.номерДвигателяDataGridViewTextBoxColumn,
            this.годВыпускаDataGridViewTextBoxColumn,
            this.кодCотрудникаводителяDataGridViewTextBoxColumn,
            this.датаПоследнегоТОDataGridViewTextBoxColumn,
            this.кодСотрудникаМеханикаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.автомобилиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(738, 429);
            this.dataGridView1.TabIndex = 6;
            // 
            // кодВидаАвтомобиляDataGridViewTextBoxColumn
            // 
            this.кодВидаАвтомобиляDataGridViewTextBoxColumn.DataPropertyName = "Код_Вида_Автомобиля";
            this.кодВидаАвтомобиляDataGridViewTextBoxColumn.HeaderText = "Код_Вида_Автомобиля";
            this.кодВидаАвтомобиляDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодВидаАвтомобиляDataGridViewTextBoxColumn.Name = "кодВидаАвтомобиляDataGridViewTextBoxColumn";
            this.кодВидаАвтомобиляDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодАвтомобиляDataGridViewTextBoxColumn
            // 
            this.кодАвтомобиляDataGridViewTextBoxColumn.DataPropertyName = "Код_Автомобиля";
            this.кодАвтомобиляDataGridViewTextBoxColumn.HeaderText = "Код_Автомобиля";
            this.кодАвтомобиляDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодАвтомобиляDataGridViewTextBoxColumn.Name = "кодАвтомобиляDataGridViewTextBoxColumn";
            this.кодАвтомобиляDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодМаркиDataGridViewTextBoxColumn
            // 
            this.кодМаркиDataGridViewTextBoxColumn.DataPropertyName = "Код_Марки";
            this.кодМаркиDataGridViewTextBoxColumn.HeaderText = "Код_Марки";
            this.кодМаркиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодМаркиDataGridViewTextBoxColumn.Name = "кодМаркиDataGridViewTextBoxColumn";
            this.кодМаркиDataGridViewTextBoxColumn.Width = 125;
            // 
            // регистрационныйНомерDataGridViewTextBoxColumn
            // 
            this.регистрационныйНомерDataGridViewTextBoxColumn.DataPropertyName = "Регистрационный_Номер";
            this.регистрационныйНомерDataGridViewTextBoxColumn.HeaderText = "Регистрационный_Номер";
            this.регистрационныйНомерDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.регистрационныйНомерDataGridViewTextBoxColumn.Name = "регистрационныйНомерDataGridViewTextBoxColumn";
            this.регистрационныйНомерDataGridViewTextBoxColumn.Width = 125;
            // 
            // номерКузоваDataGridViewTextBoxColumn
            // 
            this.номерКузоваDataGridViewTextBoxColumn.DataPropertyName = "Номер_Кузова";
            this.номерКузоваDataGridViewTextBoxColumn.HeaderText = "Номер_Кузова";
            this.номерКузоваDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерКузоваDataGridViewTextBoxColumn.Name = "номерКузоваDataGridViewTextBoxColumn";
            this.номерКузоваDataGridViewTextBoxColumn.Width = 125;
            // 
            // номерДвигателяDataGridViewTextBoxColumn
            // 
            this.номерДвигателяDataGridViewTextBoxColumn.DataPropertyName = "Номер_Двигателя";
            this.номерДвигателяDataGridViewTextBoxColumn.HeaderText = "Номер_Двигателя";
            this.номерДвигателяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерДвигателяDataGridViewTextBoxColumn.Name = "номерДвигателяDataGridViewTextBoxColumn";
            this.номерДвигателяDataGridViewTextBoxColumn.Width = 125;
            // 
            // годВыпускаDataGridViewTextBoxColumn
            // 
            this.годВыпускаDataGridViewTextBoxColumn.DataPropertyName = "Год_Выпуска";
            this.годВыпускаDataGridViewTextBoxColumn.HeaderText = "Год_Выпуска";
            this.годВыпускаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.годВыпускаDataGridViewTextBoxColumn.Name = "годВыпускаDataGridViewTextBoxColumn";
            this.годВыпускаDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодCотрудникаводителяDataGridViewTextBoxColumn
            // 
            this.кодCотрудникаводителяDataGridViewTextBoxColumn.DataPropertyName = "Код_Cотрудника_водителя";
            this.кодCотрудникаводителяDataGridViewTextBoxColumn.HeaderText = "Код_Cотрудника_водителя";
            this.кодCотрудникаводителяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодCотрудникаводителяDataGridViewTextBoxColumn.Name = "кодCотрудникаводителяDataGridViewTextBoxColumn";
            this.кодCотрудникаводителяDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаПоследнегоТОDataGridViewTextBoxColumn
            // 
            this.датаПоследнегоТОDataGridViewTextBoxColumn.DataPropertyName = "Дата_Последнего_ТО";
            this.датаПоследнегоТОDataGridViewTextBoxColumn.HeaderText = "Дата_Последнего_ТО";
            this.датаПоследнегоТОDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаПоследнегоТОDataGridViewTextBoxColumn.Name = "датаПоследнегоТОDataGridViewTextBoxColumn";
            this.датаПоследнегоТОDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодСотрудникаМеханикаDataGridViewTextBoxColumn
            // 
            this.кодСотрудникаМеханикаDataGridViewTextBoxColumn.DataPropertyName = "Код_Сотрудника_Механика";
            this.кодСотрудникаМеханикаDataGridViewTextBoxColumn.HeaderText = "Код_Сотрудника_Механика";
            this.кодСотрудникаМеханикаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодСотрудникаМеханикаDataGridViewTextBoxColumn.Name = "кодСотрудникаМеханикаDataGridViewTextBoxColumn";
            this.кодСотрудникаМеханикаDataGridViewTextBoxColumn.Width = 125;
            // 
            // автомобилиBindingSource
            // 
            this.автомобилиBindingSource.DataMember = "Автомобили";
            this.автомобилиBindingSource.DataSource = this.transportCompanyDataSet;
            // 
            // transportCompanyDataSet
            // 
            this.transportCompanyDataSet.DataSetName = "TransportCompanyDataSet";
            this.transportCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // автомобилиTableAdapter
            // 
            this.автомобилиTableAdapter.ClearBeforeFill = true;
            // 
            // автомобилиBindingSource1
            // 
            this.автомобилиBindingSource1.DataMember = "Автомобили";
            this.автомобилиBindingSource1.DataSource = this.transportCompanyDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 523);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Критерий";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 523);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(677, 22);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form4
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
            this.Name = "Form4";
            this.Text = "Автомобили";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportCompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TransportCompanyDataSet transportCompanyDataSet;
        private System.Windows.Forms.BindingSource автомобилиBindingSource;
        private TransportCompanyDataSetTableAdapters.АвтомобилиTableAdapter автомобилиTableAdapter;
        private System.Windows.Forms.BindingSource автомобилиBindingSource1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодВидаАвтомобиляDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодАвтомобиляDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодМаркиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn регистрационныйНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерКузоваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерДвигателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годВыпускаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодCотрудникаводителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПоследнегоТОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСотрудникаМеханикаDataGridViewTextBoxColumn;
    }
}