
namespace WindowsFormsApp1
{
    partial class Form19
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
            System.Windows.Forms.Label заказчикLabel;
            System.Windows.Forms.Label откудаLabel;
            System.Windows.Forms.Label кудаLabel;
            System.Windows.Forms.Label дата_ОтправленияLabel;
            System.Windows.Forms.Label дата_ПрибытияLabel;
            System.Windows.Forms.Label код_ГрузаLabel;
            System.Windows.Forms.Label ценаLabel;
            System.Windows.Forms.Label отметка_Об_ОплатеLabel;
            System.Windows.Forms.Label отметка_О_ВозвращенииLabel;
            System.Windows.Forms.Label код_СотрудникаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form19));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.transportCompanyDataSet = new WindowsFormsApp1.TransportCompanyDataSet();
            this.рейсыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рейсыTableAdapter = new WindowsFormsApp1.TransportCompanyDataSetTableAdapters.РейсыTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.TransportCompanyDataSetTableAdapters.TableAdapterManager();
            this.рейсыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.рейсыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_АвтомобиляTextBox = new System.Windows.Forms.TextBox();
            this.заказчикTextBox = new System.Windows.Forms.TextBox();
            this.откудаTextBox = new System.Windows.Forms.TextBox();
            this.кудаTextBox = new System.Windows.Forms.TextBox();
            this.дата_ОтправленияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_ПрибытияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.код_ГрузаTextBox = new System.Windows.Forms.TextBox();
            this.ценаTextBox = new System.Windows.Forms.TextBox();
            this.отметка_Об_ОплатеTextBox = new System.Windows.Forms.TextBox();
            this.отметка_О_ВозвращенииTextBox = new System.Windows.Forms.TextBox();
            this.код_СотрудникаTextBox = new System.Windows.Forms.TextBox();
            код_АвтомобиляLabel = new System.Windows.Forms.Label();
            заказчикLabel = new System.Windows.Forms.Label();
            откудаLabel = new System.Windows.Forms.Label();
            кудаLabel = new System.Windows.Forms.Label();
            дата_ОтправленияLabel = new System.Windows.Forms.Label();
            дата_ПрибытияLabel = new System.Windows.Forms.Label();
            код_ГрузаLabel = new System.Windows.Forms.Label();
            ценаLabel = new System.Windows.Forms.Label();
            отметка_Об_ОплатеLabel = new System.Windows.Forms.Label();
            отметка_О_ВозвращенииLabel = new System.Windows.Forms.Label();
            код_СотрудникаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transportCompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсыBindingNavigator)).BeginInit();
            this.рейсыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // код_АвтомобиляLabel
            // 
            код_АвтомобиляLabel.AutoSize = true;
            код_АвтомобиляLabel.Location = new System.Drawing.Point(135, 71);
            код_АвтомобиляLabel.Name = "код_АвтомобиляLabel";
            код_АвтомобиляLabel.Size = new System.Drawing.Size(121, 17);
            код_АвтомобиляLabel.TabIndex = 38;
            код_АвтомобиляLabel.Text = "Код Автомобиля:";
            // 
            // заказчикLabel
            // 
            заказчикLabel.AutoSize = true;
            заказчикLabel.Location = new System.Drawing.Point(135, 99);
            заказчикLabel.Name = "заказчикLabel";
            заказчикLabel.Size = new System.Drawing.Size(74, 17);
            заказчикLabel.TabIndex = 39;
            заказчикLabel.Text = "Заказчик:";
            // 
            // откудаLabel
            // 
            откудаLabel.AutoSize = true;
            откудаLabel.Location = new System.Drawing.Point(135, 127);
            откудаLabel.Name = "откудаLabel";
            откудаLabel.Size = new System.Drawing.Size(60, 17);
            откудаLabel.TabIndex = 40;
            откудаLabel.Text = "Откуда:";
            // 
            // кудаLabel
            // 
            кудаLabel.AutoSize = true;
            кудаLabel.Location = new System.Drawing.Point(135, 155);
            кудаLabel.Name = "кудаLabel";
            кудаLabel.Size = new System.Drawing.Size(44, 17);
            кудаLabel.TabIndex = 41;
            кудаLabel.Text = "Куда:";
            // 
            // дата_ОтправленияLabel
            // 
            дата_ОтправленияLabel.AutoSize = true;
            дата_ОтправленияLabel.Location = new System.Drawing.Point(135, 185);
            дата_ОтправленияLabel.Name = "дата_ОтправленияLabel";
            дата_ОтправленияLabel.Size = new System.Drawing.Size(139, 17);
            дата_ОтправленияLabel.TabIndex = 42;
            дата_ОтправленияLabel.Text = "Дата Отправления:";
            // 
            // дата_ПрибытияLabel
            // 
            дата_ПрибытияLabel.AutoSize = true;
            дата_ПрибытияLabel.Location = new System.Drawing.Point(135, 213);
            дата_ПрибытияLabel.Name = "дата_ПрибытияLabel";
            дата_ПрибытияLabel.Size = new System.Drawing.Size(117, 17);
            дата_ПрибытияLabel.TabIndex = 43;
            дата_ПрибытияLabel.Text = "Дата Прибытия:";
            // 
            // код_ГрузаLabel
            // 
            код_ГрузаLabel.AutoSize = true;
            код_ГрузаLabel.Location = new System.Drawing.Point(135, 239);
            код_ГрузаLabel.Name = "код_ГрузаLabel";
            код_ГрузаLabel.Size = new System.Drawing.Size(79, 17);
            код_ГрузаLabel.TabIndex = 44;
            код_ГрузаLabel.Text = "Код Груза:";
            // 
            // ценаLabel
            // 
            ценаLabel.AutoSize = true;
            ценаLabel.Location = new System.Drawing.Point(135, 267);
            ценаLabel.Name = "ценаLabel";
            ценаLabel.Size = new System.Drawing.Size(47, 17);
            ценаLabel.TabIndex = 45;
            ценаLabel.Text = "Цена:";
            // 
            // отметка_Об_ОплатеLabel
            // 
            отметка_Об_ОплатеLabel.AutoSize = true;
            отметка_Об_ОплатеLabel.Location = new System.Drawing.Point(135, 295);
            отметка_Об_ОплатеLabel.Name = "отметка_Об_ОплатеLabel";
            отметка_Об_ОплатеLabel.Size = new System.Drawing.Size(146, 17);
            отметка_Об_ОплатеLabel.TabIndex = 46;
            отметка_Об_ОплатеLabel.Text = "Отметка Об Оплате:";
            // 
            // отметка_О_ВозвращенииLabel
            // 
            отметка_О_ВозвращенииLabel.AutoSize = true;
            отметка_О_ВозвращенииLabel.Location = new System.Drawing.Point(135, 323);
            отметка_О_ВозвращенииLabel.Name = "отметка_О_ВозвращенииLabel";
            отметка_О_ВозвращенииLabel.Size = new System.Drawing.Size(178, 17);
            отметка_О_ВозвращенииLabel.TabIndex = 47;
            отметка_О_ВозвращенииLabel.Text = "Отметка О Возвращении:";
            // 
            // код_СотрудникаLabel
            // 
            код_СотрудникаLabel.AutoSize = true;
            код_СотрудникаLabel.Location = new System.Drawing.Point(135, 351);
            код_СотрудникаLabel.Name = "код_СотрудникаLabel";
            код_СотрудникаLabel.Size = new System.Drawing.Size(119, 17);
            код_СотрудникаLabel.TabIndex = 48;
            код_СотрудникаLabel.Text = "Код Сотрудника:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(422, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 23);
            this.button3.TabIndex = 36;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(273, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(125, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(209, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 37;
            this.label1.Text = "Таблица \"Рейсы\"";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // transportCompanyDataSet
            // 
            this.transportCompanyDataSet.DataSetName = "TransportCompanyDataSet";
            this.transportCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // рейсыBindingSource
            // 
            this.рейсыBindingSource.DataMember = "Рейсы";
            this.рейсыBindingSource.DataSource = this.transportCompanyDataSet;
            // 
            // рейсыTableAdapter
            // 
            this.рейсыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.TransportCompanyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобилиTableAdapter = null;
            this.tableAdapterManager.Вида_ГрузовTableAdapter = null;
            this.tableAdapterManager.Виды_АвтомобилейTableAdapter = null;
            this.tableAdapterManager.ГрузыTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.Марки_АвтомобилейTableAdapter = null;
            this.tableAdapterManager.РейсыTableAdapter = this.рейсыTableAdapter;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // рейсыBindingNavigator
            // 
            this.рейсыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.рейсыBindingNavigator.BindingSource = this.рейсыBindingSource;
            this.рейсыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.рейсыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.рейсыBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.рейсыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.рейсыBindingNavigatorSaveItem});
            this.рейсыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.рейсыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.рейсыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.рейсыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.рейсыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.рейсыBindingNavigator.Name = "рейсыBindingNavigator";
            this.рейсыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.рейсыBindingNavigator.Size = new System.Drawing.Size(668, 27);
            this.рейсыBindingNavigator.TabIndex = 38;
            this.рейсыBindingNavigator.Text = "bindingNavigator1";
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
            // рейсыBindingNavigatorSaveItem
            // 
            this.рейсыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.рейсыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("рейсыBindingNavigatorSaveItem.Image")));
            this.рейсыBindingNavigatorSaveItem.Name = "рейсыBindingNavigatorSaveItem";
            this.рейсыBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.рейсыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.рейсыBindingNavigatorSaveItem.Click += new System.EventHandler(this.рейсыBindingNavigatorSaveItem_Click);
            // 
            // код_АвтомобиляTextBox
            // 
            this.код_АвтомобиляTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.рейсыBindingSource, "Код_Автомобиля", true));
            this.код_АвтомобиляTextBox.Location = new System.Drawing.Point(319, 68);
            this.код_АвтомобиляTextBox.Name = "код_АвтомобиляTextBox";
            this.код_АвтомобиляTextBox.Size = new System.Drawing.Size(200, 22);
            this.код_АвтомобиляTextBox.TabIndex = 39;
            // 
            // заказчикTextBox
            // 
            this.заказчикTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.рейсыBindingSource, "Заказчик", true));
            this.заказчикTextBox.Location = new System.Drawing.Point(319, 96);
            this.заказчикTextBox.Name = "заказчикTextBox";
            this.заказчикTextBox.Size = new System.Drawing.Size(200, 22);
            this.заказчикTextBox.TabIndex = 40;
            // 
            // откудаTextBox
            // 
            this.откудаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.рейсыBindingSource, "Откуда", true));
            this.откудаTextBox.Location = new System.Drawing.Point(319, 124);
            this.откудаTextBox.Name = "откудаTextBox";
            this.откудаTextBox.Size = new System.Drawing.Size(200, 22);
            this.откудаTextBox.TabIndex = 41;
            // 
            // кудаTextBox
            // 
            this.кудаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.рейсыBindingSource, "Куда", true));
            this.кудаTextBox.Location = new System.Drawing.Point(319, 152);
            this.кудаTextBox.Name = "кудаTextBox";
            this.кудаTextBox.Size = new System.Drawing.Size(200, 22);
            this.кудаTextBox.TabIndex = 42;
            // 
            // дата_ОтправленияDateTimePicker
            // 
            this.дата_ОтправленияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.рейсыBindingSource, "Дата_Отправления", true));
            this.дата_ОтправленияDateTimePicker.Location = new System.Drawing.Point(319, 180);
            this.дата_ОтправленияDateTimePicker.Name = "дата_ОтправленияDateTimePicker";
            this.дата_ОтправленияDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_ОтправленияDateTimePicker.TabIndex = 43;
            // 
            // дата_ПрибытияDateTimePicker
            // 
            this.дата_ПрибытияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.рейсыBindingSource, "Дата_Прибытия", true));
            this.дата_ПрибытияDateTimePicker.Location = new System.Drawing.Point(319, 208);
            this.дата_ПрибытияDateTimePicker.Name = "дата_ПрибытияDateTimePicker";
            this.дата_ПрибытияDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_ПрибытияDateTimePicker.TabIndex = 44;
            // 
            // код_ГрузаTextBox
            // 
            this.код_ГрузаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.рейсыBindingSource, "Код_Груза", true));
            this.код_ГрузаTextBox.Location = new System.Drawing.Point(319, 236);
            this.код_ГрузаTextBox.Name = "код_ГрузаTextBox";
            this.код_ГрузаTextBox.Size = new System.Drawing.Size(200, 22);
            this.код_ГрузаTextBox.TabIndex = 45;
            // 
            // ценаTextBox
            // 
            this.ценаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.рейсыBindingSource, "Цена", true));
            this.ценаTextBox.Location = new System.Drawing.Point(319, 264);
            this.ценаTextBox.Name = "ценаTextBox";
            this.ценаTextBox.Size = new System.Drawing.Size(200, 22);
            this.ценаTextBox.TabIndex = 46;
            // 
            // отметка_Об_ОплатеTextBox
            // 
            this.отметка_Об_ОплатеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.рейсыBindingSource, "Отметка_Об_Оплате", true));
            this.отметка_Об_ОплатеTextBox.Location = new System.Drawing.Point(319, 292);
            this.отметка_Об_ОплатеTextBox.Name = "отметка_Об_ОплатеTextBox";
            this.отметка_Об_ОплатеTextBox.Size = new System.Drawing.Size(200, 22);
            this.отметка_Об_ОплатеTextBox.TabIndex = 47;
            // 
            // отметка_О_ВозвращенииTextBox
            // 
            this.отметка_О_ВозвращенииTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.рейсыBindingSource, "Отметка_О_Возвращении", true));
            this.отметка_О_ВозвращенииTextBox.Location = new System.Drawing.Point(319, 320);
            this.отметка_О_ВозвращенииTextBox.Name = "отметка_О_ВозвращенииTextBox";
            this.отметка_О_ВозвращенииTextBox.Size = new System.Drawing.Size(200, 22);
            this.отметка_О_ВозвращенииTextBox.TabIndex = 48;
            // 
            // код_СотрудникаTextBox
            // 
            this.код_СотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.рейсыBindingSource, "Код_Сотрудника", true));
            this.код_СотрудникаTextBox.Location = new System.Drawing.Point(319, 348);
            this.код_СотрудникаTextBox.Name = "код_СотрудникаTextBox";
            this.код_СотрудникаTextBox.Size = new System.Drawing.Size(200, 22);
            this.код_СотрудникаTextBox.TabIndex = 49;
            // 
            // Form19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(668, 510);
            this.Controls.Add(код_СотрудникаLabel);
            this.Controls.Add(this.код_СотрудникаTextBox);
            this.Controls.Add(отметка_О_ВозвращенииLabel);
            this.Controls.Add(this.отметка_О_ВозвращенииTextBox);
            this.Controls.Add(отметка_Об_ОплатеLabel);
            this.Controls.Add(this.отметка_Об_ОплатеTextBox);
            this.Controls.Add(ценаLabel);
            this.Controls.Add(this.ценаTextBox);
            this.Controls.Add(код_ГрузаLabel);
            this.Controls.Add(this.код_ГрузаTextBox);
            this.Controls.Add(дата_ПрибытияLabel);
            this.Controls.Add(this.дата_ПрибытияDateTimePicker);
            this.Controls.Add(дата_ОтправленияLabel);
            this.Controls.Add(this.дата_ОтправленияDateTimePicker);
            this.Controls.Add(кудаLabel);
            this.Controls.Add(this.кудаTextBox);
            this.Controls.Add(откудаLabel);
            this.Controls.Add(this.откудаTextBox);
            this.Controls.Add(заказчикLabel);
            this.Controls.Add(this.заказчикTextBox);
            this.Controls.Add(код_АвтомобиляLabel);
            this.Controls.Add(this.код_АвтомобиляTextBox);
            this.Controls.Add(this.рейсыBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form19";
            this.Text = "Рейсы";
            this.Load += new System.EventHandler(this.Form19_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transportCompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсыBindingNavigator)).EndInit();
            this.рейсыBindingNavigator.ResumeLayout(false);
            this.рейсыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private TransportCompanyDataSet transportCompanyDataSet;
        private System.Windows.Forms.BindingSource рейсыBindingSource;
        private TransportCompanyDataSetTableAdapters.РейсыTableAdapter рейсыTableAdapter;
        private TransportCompanyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator рейсыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton рейсыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_АвтомобиляTextBox;
        private System.Windows.Forms.TextBox заказчикTextBox;
        private System.Windows.Forms.TextBox откудаTextBox;
        private System.Windows.Forms.TextBox кудаTextBox;
        private System.Windows.Forms.DateTimePicker дата_ОтправленияDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_ПрибытияDateTimePicker;
        private System.Windows.Forms.TextBox код_ГрузаTextBox;
        private System.Windows.Forms.TextBox ценаTextBox;
        private System.Windows.Forms.TextBox отметка_Об_ОплатеTextBox;
        private System.Windows.Forms.TextBox отметка_О_ВозвращенииTextBox;
        private System.Windows.Forms.TextBox код_СотрудникаTextBox;
    }
}