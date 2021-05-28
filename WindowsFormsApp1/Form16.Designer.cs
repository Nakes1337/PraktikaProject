
namespace WindowsFormsApp1
{
    partial class Form16
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
            System.Windows.Forms.Label код_ГрузаLabel;
            System.Windows.Forms.Label наименованиеLabel;
            System.Windows.Forms.Label код_Вида_ГрузаLabel;
            System.Windows.Forms.Label срок_ГодностиLabel;
            System.Windows.Forms.Label особенностиLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form16));
            this.label1 = new System.Windows.Forms.Label();
            this.transportCompanyDataSet = new WindowsFormsApp1.TransportCompanyDataSet();
            this.грузыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.грузыTableAdapter = new WindowsFormsApp1.TransportCompanyDataSetTableAdapters.ГрузыTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.TransportCompanyDataSetTableAdapters.TableAdapterManager();
            this.грузыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.грузыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_ГрузаTextBox = new System.Windows.Forms.TextBox();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.код_Вида_ГрузаTextBox = new System.Windows.Forms.TextBox();
            this.срок_ГодностиTextBox = new System.Windows.Forms.TextBox();
            this.особенностиTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            код_ГрузаLabel = new System.Windows.Forms.Label();
            наименованиеLabel = new System.Windows.Forms.Label();
            код_Вида_ГрузаLabel = new System.Windows.Forms.Label();
            срок_ГодностиLabel = new System.Windows.Forms.Label();
            особенностиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transportCompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.грузыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.грузыBindingNavigator)).BeginInit();
            this.грузыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // код_ГрузаLabel
            // 
            код_ГрузаLabel.AutoSize = true;
            код_ГрузаLabel.Location = new System.Drawing.Point(221, 131);
            код_ГрузаLabel.Name = "код_ГрузаLabel";
            код_ГрузаLabel.Size = new System.Drawing.Size(79, 17);
            код_ГрузаLabel.TabIndex = 3;
            код_ГрузаLabel.Text = "Код Груза:";
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Location = new System.Drawing.Point(221, 161);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(110, 17);
            наименованиеLabel.TabIndex = 4;
            наименованиеLabel.Text = "Наименование:";
            // 
            // код_Вида_ГрузаLabel
            // 
            код_Вида_ГрузаLabel.AutoSize = true;
            код_Вида_ГрузаLabel.Location = new System.Drawing.Point(221, 187);
            код_Вида_ГрузаLabel.Name = "код_Вида_ГрузаLabel";
            код_Вида_ГрузаLabel.Size = new System.Drawing.Size(116, 17);
            код_Вида_ГрузаLabel.TabIndex = 6;
            код_Вида_ГрузаLabel.Text = "Код Вида Груза:";
            // 
            // срок_ГодностиLabel
            // 
            срок_ГодностиLabel.AutoSize = true;
            срок_ГодностиLabel.Location = new System.Drawing.Point(221, 215);
            срок_ГодностиLabel.Name = "срок_ГодностиLabel";
            срок_ГодностиLabel.Size = new System.Drawing.Size(110, 17);
            срок_ГодностиLabel.TabIndex = 8;
            срок_ГодностиLabel.Text = "Срок Годности:";
            // 
            // особенностиLabel
            // 
            особенностиLabel.AutoSize = true;
            особенностиLabel.Location = new System.Drawing.Point(221, 243);
            особенностиLabel.Name = "особенностиLabel";
            особенностиLabel.Size = new System.Drawing.Size(100, 17);
            особенностиLabel.TabIndex = 10;
            особенностиLabel.Text = "Особенности:";
            особенностиLabel.Click += new System.EventHandler(this.особенностиLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(219, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Таблица \"Грузы\"";
            // 
            // transportCompanyDataSet
            // 
            this.transportCompanyDataSet.DataSetName = "TransportCompanyDataSet";
            this.transportCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // грузыBindingSource
            // 
            this.грузыBindingSource.DataMember = "Грузы";
            this.грузыBindingSource.DataSource = this.transportCompanyDataSet;
            // 
            // грузыTableAdapter
            // 
            this.грузыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.TransportCompanyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобилиTableAdapter = null;
            this.tableAdapterManager.Вида_ГрузовTableAdapter = null;
            this.tableAdapterManager.Виды_АвтомобилейTableAdapter = null;
            this.tableAdapterManager.ГрузыTableAdapter = this.грузыTableAdapter;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.Марки_АвтомобилейTableAdapter = null;
            this.tableAdapterManager.РейсыTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // грузыBindingNavigator
            // 
            this.грузыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.грузыBindingNavigator.BindingSource = this.грузыBindingSource;
            this.грузыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.грузыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.грузыBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.грузыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.грузыBindingNavigatorSaveItem});
            this.грузыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.грузыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.грузыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.грузыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.грузыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.грузыBindingNavigator.Name = "грузыBindingNavigator";
            this.грузыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.грузыBindingNavigator.Size = new System.Drawing.Size(668, 27);
            this.грузыBindingNavigator.TabIndex = 3;
            this.грузыBindingNavigator.Text = "bindingNavigator1";
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
            // грузыBindingNavigatorSaveItem
            // 
            this.грузыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.грузыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("грузыBindingNavigatorSaveItem.Image")));
            this.грузыBindingNavigatorSaveItem.Name = "грузыBindingNavigatorSaveItem";
            this.грузыBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.грузыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.грузыBindingNavigatorSaveItem.Click += new System.EventHandler(this.грузыBindingNavigatorSaveItem_Click);
            // 
            // код_ГрузаTextBox
            // 
            this.код_ГрузаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.грузыBindingSource, "Код_Груза", true));
            this.код_ГрузаTextBox.Location = new System.Drawing.Point(343, 128);
            this.код_ГрузаTextBox.Name = "код_ГрузаTextBox";
            this.код_ГрузаTextBox.Size = new System.Drawing.Size(100, 22);
            this.код_ГрузаTextBox.TabIndex = 4;
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.грузыBindingSource, "Наименование", true));
            this.наименованиеTextBox.Location = new System.Drawing.Point(343, 156);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(100, 22);
            this.наименованиеTextBox.TabIndex = 5;
            // 
            // код_Вида_ГрузаTextBox
            // 
            this.код_Вида_ГрузаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.грузыBindingSource, "Код_Вида_Груза", true));
            this.код_Вида_ГрузаTextBox.Location = new System.Drawing.Point(343, 184);
            this.код_Вида_ГрузаTextBox.Name = "код_Вида_ГрузаTextBox";
            this.код_Вида_ГрузаTextBox.Size = new System.Drawing.Size(100, 22);
            this.код_Вида_ГрузаTextBox.TabIndex = 7;
            // 
            // срок_ГодностиTextBox
            // 
            this.срок_ГодностиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.грузыBindingSource, "Срок_Годности", true));
            this.срок_ГодностиTextBox.Location = new System.Drawing.Point(343, 212);
            this.срок_ГодностиTextBox.Name = "срок_ГодностиTextBox";
            this.срок_ГодностиTextBox.Size = new System.Drawing.Size(100, 22);
            this.срок_ГодностиTextBox.TabIndex = 9;
            // 
            // особенностиTextBox
            // 
            this.особенностиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.грузыBindingSource, "Особенности", true));
            this.особенностиTextBox.Location = new System.Drawing.Point(343, 240);
            this.особенностиTextBox.Name = "особенностиTextBox";
            this.особенностиTextBox.Size = new System.Drawing.Size(100, 22);
            this.особенностиTextBox.TabIndex = 11;
            this.особенностиTextBox.TextChanged += new System.EventHandler(this.особенностиTextBox_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(436, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 23);
            this.button3.TabIndex = 33;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(287, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 32;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(139, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(668, 510);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(особенностиLabel);
            this.Controls.Add(this.особенностиTextBox);
            this.Controls.Add(срок_ГодностиLabel);
            this.Controls.Add(this.срок_ГодностиTextBox);
            this.Controls.Add(код_Вида_ГрузаLabel);
            this.Controls.Add(this.код_Вида_ГрузаTextBox);
            this.Controls.Add(наименованиеLabel);
            this.Controls.Add(this.наименованиеTextBox);
            this.Controls.Add(код_ГрузаLabel);
            this.Controls.Add(this.код_ГрузаTextBox);
            this.Controls.Add(this.грузыBindingNavigator);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form16";
            this.Text = "Грузы";
            this.Load += new System.EventHandler(this.Form16_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transportCompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.грузыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.грузыBindingNavigator)).EndInit();
            this.грузыBindingNavigator.ResumeLayout(false);
            this.грузыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private TransportCompanyDataSet transportCompanyDataSet;
        private System.Windows.Forms.BindingSource грузыBindingSource;
        private TransportCompanyDataSetTableAdapters.ГрузыTableAdapter грузыTableAdapter;
        private TransportCompanyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator грузыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton грузыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_ГрузаTextBox;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.TextBox код_Вида_ГрузаTextBox;
        private System.Windows.Forms.TextBox срок_ГодностиTextBox;
        private System.Windows.Forms.TextBox особенностиTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}