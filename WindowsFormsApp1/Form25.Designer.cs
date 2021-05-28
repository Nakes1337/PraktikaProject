
namespace WindowsFormsApp1
{
    partial class Form25
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
            System.Windows.Forms.Label наименованиеLabel;
            System.Windows.Forms.Label expr1Label;
            System.Windows.Forms.Label регистрационный_НомерLabel;
            System.Windows.Forms.Label номер_КузоваLabel;
            System.Windows.Forms.Label номер_ДвигателяLabel;
            System.Windows.Forms.Label год_ВыпускаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form25));
            this.transportCompanyDataSet = new WindowsFormsApp1.TransportCompanyDataSet();
            this.автопаркBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.автопаркTableAdapter = new WindowsFormsApp1.TransportCompanyDataSetTableAdapters.АвтопаркTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.TransportCompanyDataSetTableAdapters.TableAdapterManager();
            this.автопаркBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.автопаркBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.expr1TextBox = new System.Windows.Forms.TextBox();
            this.регистрационный_НомерTextBox = new System.Windows.Forms.TextBox();
            this.номер_КузоваTextBox = new System.Windows.Forms.TextBox();
            this.номер_ДвигателяTextBox = new System.Windows.Forms.TextBox();
            this.год_ВыпускаTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            наименованиеLabel = new System.Windows.Forms.Label();
            expr1Label = new System.Windows.Forms.Label();
            регистрационный_НомерLabel = new System.Windows.Forms.Label();
            номер_КузоваLabel = new System.Windows.Forms.Label();
            номер_ДвигателяLabel = new System.Windows.Forms.Label();
            год_ВыпускаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transportCompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автопаркBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автопаркBindingNavigator)).BeginInit();
            this.автопаркBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Location = new System.Drawing.Point(229, 94);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(137, 17);
            наименованиеLabel.TabIndex = 1;
            наименованиеLabel.Text = "Марка автомоблия:";
            // 
            // expr1Label
            // 
            expr1Label.AutoSize = true;
            expr1Label.Location = new System.Drawing.Point(229, 125);
            expr1Label.Name = "expr1Label";
            expr1Label.Size = new System.Drawing.Size(85, 17);
            expr1Label.TabIndex = 3;
            expr1Label.Text = "Тип кузова:";
            // 
            // регистрационный_НомерLabel
            // 
            регистрационный_НомерLabel.AutoSize = true;
            регистрационный_НомерLabel.Location = new System.Drawing.Point(229, 153);
            регистрационный_НомерLabel.Name = "регистрационный_НомерLabel";
            регистрационный_НомерLabel.Size = new System.Drawing.Size(177, 17);
            регистрационный_НомерLabel.TabIndex = 5;
            регистрационный_НомерLabel.Text = "Регистрационный Номер:";
            // 
            // номер_КузоваLabel
            // 
            номер_КузоваLabel.AutoSize = true;
            номер_КузоваLabel.Location = new System.Drawing.Point(229, 181);
            номер_КузоваLabel.Name = "номер_КузоваLabel";
            номер_КузоваLabel.Size = new System.Drawing.Size(105, 17);
            номер_КузоваLabel.TabIndex = 7;
            номер_КузоваLabel.Text = "Номер Кузова:";
            // 
            // номер_ДвигателяLabel
            // 
            номер_ДвигателяLabel.AutoSize = true;
            номер_ДвигателяLabel.Location = new System.Drawing.Point(229, 209);
            номер_ДвигателяLabel.Name = "номер_ДвигателяLabel";
            номер_ДвигателяLabel.Size = new System.Drawing.Size(129, 17);
            номер_ДвигателяLabel.TabIndex = 9;
            номер_ДвигателяLabel.Text = "Номер Двигателя:";
            // 
            // год_ВыпускаLabel
            // 
            год_ВыпускаLabel.AutoSize = true;
            год_ВыпускаLabel.Location = new System.Drawing.Point(229, 237);
            год_ВыпускаLabel.Name = "год_ВыпускаLabel";
            год_ВыпускаLabel.Size = new System.Drawing.Size(96, 17);
            год_ВыпускаLabel.TabIndex = 11;
            год_ВыпускаLabel.Text = "Год Выпуска:";
            // 
            // transportCompanyDataSet
            // 
            this.transportCompanyDataSet.DataSetName = "TransportCompanyDataSet";
            this.transportCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // автопаркBindingSource
            // 
            this.автопаркBindingSource.DataMember = "Автопарк";
            this.автопаркBindingSource.DataSource = this.transportCompanyDataSet;
            // 
            // автопаркTableAdapter
            // 
            this.автопаркTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.TransportCompanyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобилиTableAdapter = null;
            this.tableAdapterManager.Вида_ГрузовTableAdapter = null;
            this.tableAdapterManager.Виды_АвтомобилейTableAdapter = null;
            this.tableAdapterManager.ГрузыTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.Марки_АвтомобилейTableAdapter = null;
            this.tableAdapterManager.РейсыTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // автопаркBindingNavigator
            // 
            this.автопаркBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.автопаркBindingNavigator.BindingSource = this.автопаркBindingSource;
            this.автопаркBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.автопаркBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.автопаркBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.автопаркBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.автопаркBindingNavigatorSaveItem});
            this.автопаркBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.автопаркBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.автопаркBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.автопаркBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.автопаркBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.автопаркBindingNavigator.Name = "автопаркBindingNavigator";
            this.автопаркBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.автопаркBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.автопаркBindingNavigator.TabIndex = 0;
            this.автопаркBindingNavigator.Text = "bindingNavigator1";
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
            // автопаркBindingNavigatorSaveItem
            // 
            this.автопаркBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.автопаркBindingNavigatorSaveItem.Enabled = false;
            this.автопаркBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("автопаркBindingNavigatorSaveItem.Image")));
            this.автопаркBindingNavigatorSaveItem.Name = "автопаркBindingNavigatorSaveItem";
            this.автопаркBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.автопаркBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автопаркBindingSource, "Наименование", true));
            this.наименованиеTextBox.Location = new System.Drawing.Point(412, 91);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(100, 22);
            this.наименованиеTextBox.TabIndex = 2;
            // 
            // expr1TextBox
            // 
            this.expr1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автопаркBindingSource, "Expr1", true));
            this.expr1TextBox.Location = new System.Drawing.Point(412, 122);
            this.expr1TextBox.Name = "expr1TextBox";
            this.expr1TextBox.Size = new System.Drawing.Size(100, 22);
            this.expr1TextBox.TabIndex = 4;
            // 
            // регистрационный_НомерTextBox
            // 
            this.регистрационный_НомерTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автопаркBindingSource, "Регистрационный_Номер", true));
            this.регистрационный_НомерTextBox.Location = new System.Drawing.Point(412, 150);
            this.регистрационный_НомерTextBox.Name = "регистрационный_НомерTextBox";
            this.регистрационный_НомерTextBox.Size = new System.Drawing.Size(100, 22);
            this.регистрационный_НомерTextBox.TabIndex = 6;
            // 
            // номер_КузоваTextBox
            // 
            this.номер_КузоваTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автопаркBindingSource, "Номер_Кузова", true));
            this.номер_КузоваTextBox.Location = new System.Drawing.Point(412, 178);
            this.номер_КузоваTextBox.Name = "номер_КузоваTextBox";
            this.номер_КузоваTextBox.Size = new System.Drawing.Size(100, 22);
            this.номер_КузоваTextBox.TabIndex = 8;
            // 
            // номер_ДвигателяTextBox
            // 
            this.номер_ДвигателяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автопаркBindingSource, "Номер_Двигателя", true));
            this.номер_ДвигателяTextBox.Location = new System.Drawing.Point(412, 206);
            this.номер_ДвигателяTextBox.Name = "номер_ДвигателяTextBox";
            this.номер_ДвигателяTextBox.Size = new System.Drawing.Size(100, 22);
            this.номер_ДвигателяTextBox.TabIndex = 10;
            // 
            // год_ВыпускаTextBox
            // 
            this.год_ВыпускаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автопаркBindingSource, "Год_Выпуска", true));
            this.год_ВыпускаTextBox.Location = new System.Drawing.Point(412, 234);
            this.год_ВыпускаTextBox.Name = "год_ВыпускаTextBox";
            this.год_ВыпускаTextBox.Size = new System.Drawing.Size(100, 22);
            this.год_ВыпускаTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(259, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Запрос \"Автопарк\"";
            // 
            // Form25
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(год_ВыпускаLabel);
            this.Controls.Add(this.год_ВыпускаTextBox);
            this.Controls.Add(номер_ДвигателяLabel);
            this.Controls.Add(this.номер_ДвигателяTextBox);
            this.Controls.Add(номер_КузоваLabel);
            this.Controls.Add(this.номер_КузоваTextBox);
            this.Controls.Add(регистрационный_НомерLabel);
            this.Controls.Add(this.регистрационный_НомерTextBox);
            this.Controls.Add(expr1Label);
            this.Controls.Add(this.expr1TextBox);
            this.Controls.Add(наименованиеLabel);
            this.Controls.Add(this.наименованиеTextBox);
            this.Controls.Add(this.автопаркBindingNavigator);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form25";
            this.Text = "Автопарк";
            this.Load += new System.EventHandler(this.Form25_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transportCompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автопаркBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автопаркBindingNavigator)).EndInit();
            this.автопаркBindingNavigator.ResumeLayout(false);
            this.автопаркBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TransportCompanyDataSet transportCompanyDataSet;
        private System.Windows.Forms.BindingSource автопаркBindingSource;
        private TransportCompanyDataSetTableAdapters.АвтопаркTableAdapter автопаркTableAdapter;
        private TransportCompanyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator автопаркBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton автопаркBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.TextBox expr1TextBox;
        private System.Windows.Forms.TextBox регистрационный_НомерTextBox;
        private System.Windows.Forms.TextBox номер_КузоваTextBox;
        private System.Windows.Forms.TextBox номер_ДвигателяTextBox;
        private System.Windows.Forms.TextBox год_ВыпускаTextBox;
        private System.Windows.Forms.Label label1;
    }
}