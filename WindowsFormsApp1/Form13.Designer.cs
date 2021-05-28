
namespace WindowsFormsApp1
{
    partial class Form13
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
            System.Windows.Forms.Label код_АвтомобиляLabel;
            System.Windows.Forms.Label код_МаркиLabel;
            System.Windows.Forms.Label код_Вида_АвтомобиляLabel;
            System.Windows.Forms.Label регистрационный_НомерLabel;
            System.Windows.Forms.Label номер_КузоваLabel;
            System.Windows.Forms.Label номер_ДвигателяLabel;
            System.Windows.Forms.Label год_ВыпускаLabel;
            System.Windows.Forms.Label код_Cотрудника_водителяLabel;
            System.Windows.Forms.Label дата_Последнего_ТОLabel;
            System.Windows.Forms.Label код_Сотрудника_МеханикаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            this.label1 = new System.Windows.Forms.Label();
            this.transportCompanyDataSet = new WindowsFormsApp1.TransportCompanyDataSet();
            this.автомобилиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.автомобилиTableAdapter = new WindowsFormsApp1.TransportCompanyDataSetTableAdapters.АвтомобилиTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.TransportCompanyDataSetTableAdapters.TableAdapterManager();
            this.автомобилиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.автомобилиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_АвтомобиляTextBox = new System.Windows.Forms.TextBox();
            this.код_МаркиTextBox = new System.Windows.Forms.TextBox();
            this.код_Вида_АвтомобиляTextBox = new System.Windows.Forms.TextBox();
            this.регистрационный_НомерTextBox = new System.Windows.Forms.TextBox();
            this.номер_КузоваTextBox = new System.Windows.Forms.TextBox();
            this.номер_ДвигателяTextBox = new System.Windows.Forms.TextBox();
            this.год_ВыпускаTextBox = new System.Windows.Forms.TextBox();
            this.код_Cотрудника_водителяTextBox = new System.Windows.Forms.TextBox();
            this.дата_Последнего_ТОDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.код_Сотрудника_МеханикаTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            код_АвтомобиляLabel = new System.Windows.Forms.Label();
            код_МаркиLabel = new System.Windows.Forms.Label();
            код_Вида_АвтомобиляLabel = new System.Windows.Forms.Label();
            регистрационный_НомерLabel = new System.Windows.Forms.Label();
            номер_КузоваLabel = new System.Windows.Forms.Label();
            номер_ДвигателяLabel = new System.Windows.Forms.Label();
            год_ВыпускаLabel = new System.Windows.Forms.Label();
            код_Cотрудника_водителяLabel = new System.Windows.Forms.Label();
            дата_Последнего_ТОLabel = new System.Windows.Forms.Label();
            код_Сотрудника_МеханикаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transportCompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingNavigator)).BeginInit();
            this.автомобилиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // код_АвтомобиляLabel
            // 
            код_АвтомобиляLabel.AutoSize = true;
            код_АвтомобиляLabel.Location = new System.Drawing.Point(149, 81);
            код_АвтомобиляLabel.Name = "код_АвтомобиляLabel";
            код_АвтомобиляLabel.Size = new System.Drawing.Size(121, 17);
            код_АвтомобиляLabel.TabIndex = 2;
            код_АвтомобиляLabel.Text = "Код Автомобиля:";
            // 
            // код_МаркиLabel
            // 
            код_МаркиLabel.AutoSize = true;
            код_МаркиLabel.Location = new System.Drawing.Point(149, 109);
            код_МаркиLabel.Name = "код_МаркиLabel";
            код_МаркиLabel.Size = new System.Drawing.Size(83, 17);
            код_МаркиLabel.TabIndex = 4;
            код_МаркиLabel.Text = "Код Марки:";
            // 
            // код_Вида_АвтомобиляLabel
            // 
            код_Вида_АвтомобиляLabel.AutoSize = true;
            код_Вида_АвтомобиляLabel.Location = new System.Drawing.Point(149, 137);
            код_Вида_АвтомобиляLabel.Name = "код_Вида_АвтомобиляLabel";
            код_Вида_АвтомобиляLabel.Size = new System.Drawing.Size(158, 17);
            код_Вида_АвтомобиляLabel.TabIndex = 6;
            код_Вида_АвтомобиляLabel.Text = "Код Вида Автомобиля:";
            // 
            // регистрационный_НомерLabel
            // 
            регистрационный_НомерLabel.AutoSize = true;
            регистрационный_НомерLabel.Location = new System.Drawing.Point(149, 165);
            регистрационный_НомерLabel.Name = "регистрационный_НомерLabel";
            регистрационный_НомерLabel.Size = new System.Drawing.Size(177, 17);
            регистрационный_НомерLabel.TabIndex = 8;
            регистрационный_НомерLabel.Text = "Регистрационный Номер:";
            // 
            // номер_КузоваLabel
            // 
            номер_КузоваLabel.AutoSize = true;
            номер_КузоваLabel.Location = new System.Drawing.Point(149, 193);
            номер_КузоваLabel.Name = "номер_КузоваLabel";
            номер_КузоваLabel.Size = new System.Drawing.Size(105, 17);
            номер_КузоваLabel.TabIndex = 10;
            номер_КузоваLabel.Text = "Номер Кузова:";
            // 
            // номер_ДвигателяLabel
            // 
            номер_ДвигателяLabel.AutoSize = true;
            номер_ДвигателяLabel.Location = new System.Drawing.Point(149, 221);
            номер_ДвигателяLabel.Name = "номер_ДвигателяLabel";
            номер_ДвигателяLabel.Size = new System.Drawing.Size(129, 17);
            номер_ДвигателяLabel.TabIndex = 12;
            номер_ДвигателяLabel.Text = "Номер Двигателя:";
            // 
            // год_ВыпускаLabel
            // 
            год_ВыпускаLabel.AutoSize = true;
            год_ВыпускаLabel.Location = new System.Drawing.Point(149, 249);
            год_ВыпускаLabel.Name = "год_ВыпускаLabel";
            год_ВыпускаLabel.Size = new System.Drawing.Size(96, 17);
            год_ВыпускаLabel.TabIndex = 14;
            год_ВыпускаLabel.Text = "Год Выпуска:";
            // 
            // код_Cотрудника_водителяLabel
            // 
            код_Cотрудника_водителяLabel.AutoSize = true;
            код_Cотрудника_водителяLabel.Location = new System.Drawing.Point(149, 279);
            код_Cотрудника_водителяLabel.Name = "код_Cотрудника_водителяLabel";
            код_Cотрудника_водителяLabel.Size = new System.Drawing.Size(185, 17);
            код_Cотрудника_водителяLabel.TabIndex = 16;
            код_Cотрудника_водителяLabel.Text = "Код Cотрудника водителя:";
            // 
            // дата_Последнего_ТОLabel
            // 
            дата_Последнего_ТОLabel.AutoSize = true;
            дата_Последнего_ТОLabel.Location = new System.Drawing.Point(149, 307);
            дата_Последнего_ТОLabel.Name = "дата_Последнего_ТОLabel";
            дата_Последнего_ТОLabel.Size = new System.Drawing.Size(152, 17);
            дата_Последнего_ТОLabel.TabIndex = 18;
            дата_Последнего_ТОLabel.Text = "Дата Последнего ТО:";
            дата_Последнего_ТОLabel.Click += new System.EventHandler(this.дата_Последнего_ТОLabel_Click);
            // 
            // код_Сотрудника_МеханикаLabel
            // 
            код_Сотрудника_МеханикаLabel.AutoSize = true;
            код_Сотрудника_МеханикаLabel.Location = new System.Drawing.Point(149, 333);
            код_Сотрудника_МеханикаLabel.Name = "код_Сотрудника_МеханикаLabel";
            код_Сотрудника_МеханикаLabel.Size = new System.Drawing.Size(187, 17);
            код_Сотрудника_МеханикаLabel.TabIndex = 20;
            код_Сотрудника_МеханикаLabel.Text = "Код Сотрудника Механика:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(187, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица \"Автомобили\"";
            // 
            // transportCompanyDataSet
            // 
            this.transportCompanyDataSet.DataSetName = "TransportCompanyDataSet";
            this.transportCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // автомобилиBindingSource
            // 
            this.автомобилиBindingSource.DataMember = "Автомобили";
            this.автомобилиBindingSource.DataSource = this.transportCompanyDataSet;
            // 
            // автомобилиTableAdapter
            // 
            this.автомобилиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.TransportCompanyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобилиTableAdapter = this.автомобилиTableAdapter;
            this.tableAdapterManager.Вида_ГрузовTableAdapter = null;
            this.tableAdapterManager.Виды_АвтомобилейTableAdapter = null;
            this.tableAdapterManager.ГрузыTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.Марки_АвтомобилейTableAdapter = null;
            this.tableAdapterManager.РейсыTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // автомобилиBindingNavigator
            // 
            this.автомобилиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.автомобилиBindingNavigator.BindingSource = this.автомобилиBindingSource;
            this.автомобилиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.автомобилиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.автомобилиBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.автомобилиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.автомобилиBindingNavigatorSaveItem});
            this.автомобилиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.автомобилиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.автомобилиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.автомобилиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.автомобилиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.автомобилиBindingNavigator.Name = "автомобилиBindingNavigator";
            this.автомобилиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.автомобилиBindingNavigator.Size = new System.Drawing.Size(668, 27);
            this.автомобилиBindingNavigator.TabIndex = 1;
            this.автомобилиBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // автомобилиBindingNavigatorSaveItem
            // 
            this.автомобилиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.автомобилиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("автомобилиBindingNavigatorSaveItem.Image")));
            this.автомобилиBindingNavigatorSaveItem.Name = "автомобилиBindingNavigatorSaveItem";
            this.автомобилиBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.автомобилиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.автомобилиBindingNavigatorSaveItem.Click += new System.EventHandler(this.автомобилиBindingNavigatorSaveItem_Click);
            // 
            // код_АвтомобиляTextBox
            // 
            this.код_АвтомобиляTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобилиBindingSource, "Код_Автомобиля", true));
            this.код_АвтомобиляTextBox.Location = new System.Drawing.Point(342, 78);
            this.код_АвтомобиляTextBox.Name = "код_АвтомобиляTextBox";
            this.код_АвтомобиляTextBox.Size = new System.Drawing.Size(200, 22);
            this.код_АвтомобиляTextBox.TabIndex = 3;
            // 
            // код_МаркиTextBox
            // 
            this.код_МаркиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобилиBindingSource, "Код_Марки", true));
            this.код_МаркиTextBox.Location = new System.Drawing.Point(342, 106);
            this.код_МаркиTextBox.Name = "код_МаркиTextBox";
            this.код_МаркиTextBox.Size = new System.Drawing.Size(200, 22);
            this.код_МаркиTextBox.TabIndex = 5;
            // 
            // код_Вида_АвтомобиляTextBox
            // 
            this.код_Вида_АвтомобиляTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобилиBindingSource, "Код_Вида_Автомобиля", true));
            this.код_Вида_АвтомобиляTextBox.Location = new System.Drawing.Point(342, 134);
            this.код_Вида_АвтомобиляTextBox.Name = "код_Вида_АвтомобиляTextBox";
            this.код_Вида_АвтомобиляTextBox.Size = new System.Drawing.Size(200, 22);
            this.код_Вида_АвтомобиляTextBox.TabIndex = 7;
            // 
            // регистрационный_НомерTextBox
            // 
            this.регистрационный_НомерTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобилиBindingSource, "Регистрационный_Номер", true));
            this.регистрационный_НомерTextBox.Location = new System.Drawing.Point(342, 162);
            this.регистрационный_НомерTextBox.Name = "регистрационный_НомерTextBox";
            this.регистрационный_НомерTextBox.Size = new System.Drawing.Size(200, 22);
            this.регистрационный_НомерTextBox.TabIndex = 9;
            // 
            // номер_КузоваTextBox
            // 
            this.номер_КузоваTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобилиBindingSource, "Номер_Кузова", true));
            this.номер_КузоваTextBox.Location = new System.Drawing.Point(342, 190);
            this.номер_КузоваTextBox.Name = "номер_КузоваTextBox";
            this.номер_КузоваTextBox.Size = new System.Drawing.Size(200, 22);
            this.номер_КузоваTextBox.TabIndex = 11;
            // 
            // номер_ДвигателяTextBox
            // 
            this.номер_ДвигателяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобилиBindingSource, "Номер_Двигателя", true));
            this.номер_ДвигателяTextBox.Location = new System.Drawing.Point(342, 218);
            this.номер_ДвигателяTextBox.Name = "номер_ДвигателяTextBox";
            this.номер_ДвигателяTextBox.Size = new System.Drawing.Size(200, 22);
            this.номер_ДвигателяTextBox.TabIndex = 13;
            // 
            // год_ВыпускаTextBox
            // 
            this.год_ВыпускаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобилиBindingSource, "Год_Выпуска", true));
            this.год_ВыпускаTextBox.Location = new System.Drawing.Point(342, 246);
            this.год_ВыпускаTextBox.Name = "год_ВыпускаTextBox";
            this.год_ВыпускаTextBox.Size = new System.Drawing.Size(200, 22);
            this.год_ВыпускаTextBox.TabIndex = 15;
            // 
            // код_Cотрудника_водителяTextBox
            // 
            this.код_Cотрудника_водителяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобилиBindingSource, "Код_Cотрудника_водителя", true));
            this.код_Cотрудника_водителяTextBox.Location = new System.Drawing.Point(342, 274);
            this.код_Cотрудника_водителяTextBox.Name = "код_Cотрудника_водителяTextBox";
            this.код_Cотрудника_водителяTextBox.Size = new System.Drawing.Size(200, 22);
            this.код_Cотрудника_водителяTextBox.TabIndex = 17;
            // 
            // дата_Последнего_ТОDateTimePicker
            // 
            this.дата_Последнего_ТОDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.автомобилиBindingSource, "Дата_Последнего_ТО", true));
            this.дата_Последнего_ТОDateTimePicker.Location = new System.Drawing.Point(342, 302);
            this.дата_Последнего_ТОDateTimePicker.Name = "дата_Последнего_ТОDateTimePicker";
            this.дата_Последнего_ТОDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_Последнего_ТОDateTimePicker.TabIndex = 19;
            // 
            // код_Сотрудника_МеханикаTextBox
            // 
            this.код_Сотрудника_МеханикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобилиBindingSource, "Код_Сотрудника_Механика", true));
            this.код_Сотрудника_МеханикаTextBox.Location = new System.Drawing.Point(342, 330);
            this.код_Сотрудника_МеханикаTextBox.Name = "код_Сотрудника_МеханикаTextBox";
            this.код_Сотрудника_МеханикаTextBox.Size = new System.Drawing.Size(200, 22);
            this.код_Сотрудника_МеханикаTextBox.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(152, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(300, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(449, 420);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(668, 510);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(код_Сотрудника_МеханикаLabel);
            this.Controls.Add(this.код_Сотрудника_МеханикаTextBox);
            this.Controls.Add(дата_Последнего_ТОLabel);
            this.Controls.Add(this.дата_Последнего_ТОDateTimePicker);
            this.Controls.Add(код_Cотрудника_водителяLabel);
            this.Controls.Add(this.код_Cотрудника_водителяTextBox);
            this.Controls.Add(год_ВыпускаLabel);
            this.Controls.Add(this.год_ВыпускаTextBox);
            this.Controls.Add(номер_ДвигателяLabel);
            this.Controls.Add(this.номер_ДвигателяTextBox);
            this.Controls.Add(номер_КузоваLabel);
            this.Controls.Add(this.номер_КузоваTextBox);
            this.Controls.Add(регистрационный_НомерLabel);
            this.Controls.Add(this.регистрационный_НомерTextBox);
            this.Controls.Add(код_Вида_АвтомобиляLabel);
            this.Controls.Add(this.код_Вида_АвтомобиляTextBox);
            this.Controls.Add(код_МаркиLabel);
            this.Controls.Add(this.код_МаркиTextBox);
            this.Controls.Add(код_АвтомобиляLabel);
            this.Controls.Add(this.код_АвтомобиляTextBox);
            this.Controls.Add(this.автомобилиBindingNavigator);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form13";
            this.Text = "Автомобили";
            this.Load += new System.EventHandler(this.Form13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transportCompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingNavigator)).EndInit();
            this.автомобилиBindingNavigator.ResumeLayout(false);
            this.автомобилиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private TransportCompanyDataSet transportCompanyDataSet;
        private System.Windows.Forms.BindingSource автомобилиBindingSource;
        private TransportCompanyDataSetTableAdapters.АвтомобилиTableAdapter автомобилиTableAdapter;
        private TransportCompanyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator автомобилиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton автомобилиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_АвтомобиляTextBox;
        private System.Windows.Forms.TextBox код_МаркиTextBox;
        private System.Windows.Forms.TextBox код_Вида_АвтомобиляTextBox;
        private System.Windows.Forms.TextBox регистрационный_НомерTextBox;
        private System.Windows.Forms.TextBox номер_КузоваTextBox;
        private System.Windows.Forms.TextBox номер_ДвигателяTextBox;
        private System.Windows.Forms.TextBox год_ВыпускаTextBox;
        private System.Windows.Forms.TextBox код_Cотрудника_водителяTextBox;
        private System.Windows.Forms.DateTimePicker дата_Последнего_ТОDateTimePicker;
        private System.Windows.Forms.TextBox код_Сотрудника_МеханикаTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}