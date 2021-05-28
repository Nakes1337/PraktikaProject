
namespace WindowsFormsApp1
{
    partial class Form14
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
            System.Windows.Forms.Label код_Вида_ГрузаLabel;
            System.Windows.Forms.Label наименованиеLabel;
            System.Windows.Forms.Label код_Вида_Автомобиля_Для_ТранспортировкиLabel;
            System.Windows.Forms.Label описаниеLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form14));
            this.label1 = new System.Windows.Forms.Label();
            this.transportCompanyDataSet = new WindowsFormsApp1.TransportCompanyDataSet();
            this.вида_ГрузовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.вида_ГрузовTableAdapter = new WindowsFormsApp1.TransportCompanyDataSetTableAdapters.Вида_ГрузовTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.TransportCompanyDataSetTableAdapters.TableAdapterManager();
            this.вида_ГрузовBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.вида_ГрузовBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_Вида_ГрузаTextBox = new System.Windows.Forms.TextBox();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.код_Вида_Автомобиля_Для_ТранспортировкиTextBox = new System.Windows.Forms.TextBox();
            this.описаниеTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            код_Вида_ГрузаLabel = new System.Windows.Forms.Label();
            наименованиеLabel = new System.Windows.Forms.Label();
            код_Вида_Автомобиля_Для_ТранспортировкиLabel = new System.Windows.Forms.Label();
            описаниеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transportCompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вида_ГрузовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вида_ГрузовBindingNavigator)).BeginInit();
            this.вида_ГрузовBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // код_Вида_ГрузаLabel
            // 
            код_Вида_ГрузаLabel.AutoSize = true;
            код_Вида_ГрузаLabel.Location = new System.Drawing.Point(205, 112);
            код_Вида_ГрузаLabel.Name = "код_Вида_ГрузаLabel";
            код_Вида_ГрузаLabel.Size = new System.Drawing.Size(116, 17);
            код_Вида_ГрузаLabel.TabIndex = 2;
            код_Вида_ГрузаLabel.Text = "Код Вида Груза:";
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Location = new System.Drawing.Point(205, 155);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(110, 17);
            наименованиеLabel.TabIndex = 4;
            наименованиеLabel.Text = "Наименование:";
            // 
            // код_Вида_Автомобиля_Для_ТранспортировкиLabel
            // 
            код_Вида_Автомобиля_Для_ТранспортировкиLabel.Location = new System.Drawing.Point(205, 201);
            код_Вида_Автомобиля_Для_ТранспортировкиLabel.Name = "код_Вида_Автомобиля_Для_ТранспортировкиLabel";
            код_Вида_Автомобиля_Для_ТранспортировкиLabel.Size = new System.Drawing.Size(157, 19);
            код_Вида_Автомобиля_Для_ТранспортировкиLabel.TabIndex = 6;
            код_Вида_Автомобиля_Для_ТранспортировкиLabel.Text = "Код Вида Автомобиля Для Транспортировки:";
            // 
            // описаниеLabel
            // 
            описаниеLabel.AutoSize = true;
            описаниеLabel.Location = new System.Drawing.Point(205, 252);
            описаниеLabel.Name = "описаниеLabel";
            описаниеLabel.Size = new System.Drawing.Size(78, 17);
            описаниеLabel.TabIndex = 8;
            описаниеLabel.Text = "Описание:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(202, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Таблица \"Виды груза\"";
            // 
            // transportCompanyDataSet
            // 
            this.transportCompanyDataSet.DataSetName = "TransportCompanyDataSet";
            this.transportCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // вида_ГрузовBindingSource
            // 
            this.вида_ГрузовBindingSource.DataMember = "Вида_Грузов";
            this.вида_ГрузовBindingSource.DataSource = this.transportCompanyDataSet;
            // 
            // вида_ГрузовTableAdapter
            // 
            this.вида_ГрузовTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.TransportCompanyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобилиTableAdapter = null;
            this.tableAdapterManager.Вида_ГрузовTableAdapter = this.вида_ГрузовTableAdapter;
            this.tableAdapterManager.Виды_АвтомобилейTableAdapter = null;
            this.tableAdapterManager.ГрузыTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.Марки_АвтомобилейTableAdapter = null;
            this.tableAdapterManager.РейсыTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // вида_ГрузовBindingNavigator
            // 
            this.вида_ГрузовBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.вида_ГрузовBindingNavigator.BindingSource = this.вида_ГрузовBindingSource;
            this.вида_ГрузовBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.вида_ГрузовBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.вида_ГрузовBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.вида_ГрузовBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.вида_ГрузовBindingNavigatorSaveItem});
            this.вида_ГрузовBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.вида_ГрузовBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.вида_ГрузовBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.вида_ГрузовBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.вида_ГрузовBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.вида_ГрузовBindingNavigator.Name = "вида_ГрузовBindingNavigator";
            this.вида_ГрузовBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.вида_ГрузовBindingNavigator.Size = new System.Drawing.Size(668, 27);
            this.вида_ГрузовBindingNavigator.TabIndex = 2;
            this.вида_ГрузовBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // вида_ГрузовBindingNavigatorSaveItem
            // 
            this.вида_ГрузовBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.вида_ГрузовBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("вида_ГрузовBindingNavigatorSaveItem.Image")));
            this.вида_ГрузовBindingNavigatorSaveItem.Name = "вида_ГрузовBindingNavigatorSaveItem";
            this.вида_ГрузовBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.вида_ГрузовBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.вида_ГрузовBindingNavigatorSaveItem.Click += new System.EventHandler(this.вида_ГрузовBindingNavigatorSaveItem_Click);
            // 
            // код_Вида_ГрузаTextBox
            // 
            this.код_Вида_ГрузаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вида_ГрузовBindingSource, "Код_Вида_Груза", true));
            this.код_Вида_ГрузаTextBox.Location = new System.Drawing.Point(368, 109);
            this.код_Вида_ГрузаTextBox.Name = "код_Вида_ГрузаTextBox";
            this.код_Вида_ГрузаTextBox.Size = new System.Drawing.Size(100, 22);
            this.код_Вида_ГрузаTextBox.TabIndex = 3;
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вида_ГрузовBindingSource, "Наименование", true));
            this.наименованиеTextBox.Location = new System.Drawing.Point(368, 152);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(100, 22);
            this.наименованиеTextBox.TabIndex = 5;
            // 
            // код_Вида_Автомобиля_Для_ТранспортировкиTextBox
            // 
            this.код_Вида_Автомобиля_Для_ТранспортировкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вида_ГрузовBindingSource, "Код_Вида_Автомобиля_Для_Транспортировки", true));
            this.код_Вида_Автомобиля_Для_ТранспортировкиTextBox.Location = new System.Drawing.Point(368, 198);
            this.код_Вида_Автомобиля_Для_ТранспортировкиTextBox.Name = "код_Вида_Автомобиля_Для_ТранспортировкиTextBox";
            this.код_Вида_Автомобиля_Для_ТранспортировкиTextBox.Size = new System.Drawing.Size(100, 22);
            this.код_Вида_Автомобиля_Для_ТранспортировкиTextBox.TabIndex = 7;
            // 
            // описаниеTextBox
            // 
            this.описаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.вида_ГрузовBindingSource, "Описание", true));
            this.описаниеTextBox.Location = new System.Drawing.Point(368, 252);
            this.описаниеTextBox.Name = "описаниеTextBox";
            this.описаниеTextBox.Size = new System.Drawing.Size(100, 22);
            this.описаниеTextBox.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(431, 389);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(282, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(134, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(668, 510);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(описаниеLabel);
            this.Controls.Add(this.описаниеTextBox);
            this.Controls.Add(код_Вида_Автомобиля_Для_ТранспортировкиLabel);
            this.Controls.Add(this.код_Вида_Автомобиля_Для_ТранспортировкиTextBox);
            this.Controls.Add(наименованиеLabel);
            this.Controls.Add(this.наименованиеTextBox);
            this.Controls.Add(код_Вида_ГрузаLabel);
            this.Controls.Add(this.код_Вида_ГрузаTextBox);
            this.Controls.Add(this.вида_ГрузовBindingNavigator);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form14";
            this.Text = "Виды груза";
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transportCompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вида_ГрузовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вида_ГрузовBindingNavigator)).EndInit();
            this.вида_ГрузовBindingNavigator.ResumeLayout(false);
            this.вида_ГрузовBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private TransportCompanyDataSet transportCompanyDataSet;
        private System.Windows.Forms.BindingSource вида_ГрузовBindingSource;
        private TransportCompanyDataSetTableAdapters.Вида_ГрузовTableAdapter вида_ГрузовTableAdapter;
        private TransportCompanyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator вида_ГрузовBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton вида_ГрузовBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_Вида_ГрузаTextBox;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.TextBox код_Вида_Автомобиля_Для_ТранспортировкиTextBox;
        private System.Windows.Forms.TextBox описаниеTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}