namespace ComputerShop
{
    partial class MakerPr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakerPr));
            System.Windows.Forms.Label makerLabel;
            System.Windows.Forms.Label expr1Label;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label codeLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.st02DataSet = new ComputerShop.St02DataSet();
            this.makerOfPrntBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.makerOfPrntTableAdapter = new ComputerShop.St02DataSetTableAdapters.makerOfPrntTableAdapter();
            this.tableAdapterManager = new ComputerShop.St02DataSetTableAdapters.TableAdapterManager();
            this.makerOfPrntBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.makerOfPrntBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.makerTextBox = new System.Windows.Forms.TextBox();
            this.expr1TextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            makerLabel = new System.Windows.Forms.Label();
            expr1Label = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.st02DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makerOfPrntBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makerOfPrntBindingNavigator)).BeginInit();
            this.makerOfPrntBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(68, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Производители принтеров";
            // 
            // st02DataSet
            // 
            this.st02DataSet.DataSetName = "St02DataSet";
            this.st02DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // makerOfPrntBindingSource
            // 
            this.makerOfPrntBindingSource.DataMember = "makerOfPrnt";
            this.makerOfPrntBindingSource.DataSource = this.st02DataSet;
            // 
            // makerOfPrntTableAdapter
            // 
            this.makerOfPrntTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.LaptopTableAdapter = null;
            this.tableAdapterManager.PCTableAdapter = null;
            this.tableAdapterManager.PrinterTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ComputerShop.St02DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // makerOfPrntBindingNavigator
            // 
            this.makerOfPrntBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.makerOfPrntBindingNavigator.BindingSource = this.makerOfPrntBindingSource;
            this.makerOfPrntBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.makerOfPrntBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.makerOfPrntBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.makerOfPrntBindingNavigatorSaveItem});
            this.makerOfPrntBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.makerOfPrntBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.makerOfPrntBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.makerOfPrntBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.makerOfPrntBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.makerOfPrntBindingNavigator.Name = "makerOfPrntBindingNavigator";
            this.makerOfPrntBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.makerOfPrntBindingNavigator.Size = new System.Drawing.Size(404, 25);
            this.makerOfPrntBindingNavigator.TabIndex = 2;
            this.makerOfPrntBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // makerOfPrntBindingNavigatorSaveItem
            // 
            this.makerOfPrntBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.makerOfPrntBindingNavigatorSaveItem.Enabled = false;
            this.makerOfPrntBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("makerOfPrntBindingNavigatorSaveItem.Image")));
            this.makerOfPrntBindingNavigatorSaveItem.Name = "makerOfPrntBindingNavigatorSaveItem";
            this.makerOfPrntBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.makerOfPrntBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // makerLabel
            // 
            makerLabel.AutoSize = true;
            makerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            makerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            makerLabel.Location = new System.Drawing.Point(75, 114);
            makerLabel.Name = "makerLabel";
            makerLabel.Size = new System.Drawing.Size(57, 20);
            makerLabel.TabIndex = 2;
            makerLabel.Text = "maker:";
            // 
            // makerTextBox
            // 
            this.makerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makerOfPrntBindingSource, "maker", true));
            this.makerTextBox.Location = new System.Drawing.Point(148, 116);
            this.makerTextBox.Name = "makerTextBox";
            this.makerTextBox.Size = new System.Drawing.Size(100, 20);
            this.makerTextBox.TabIndex = 3;
            // 
            // expr1Label
            // 
            expr1Label.AutoSize = true;
            expr1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            expr1Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            expr1Label.Location = new System.Drawing.Point(78, 150);
            expr1Label.Name = "expr1Label";
            expr1Label.Size = new System.Drawing.Size(54, 20);
            expr1Label.TabIndex = 4;
            expr1Label.Text = "Expr1:";
            // 
            // expr1TextBox
            // 
            this.expr1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makerOfPrntBindingSource, "Expr1", true));
            this.expr1TextBox.Location = new System.Drawing.Point(148, 152);
            this.expr1TextBox.Name = "expr1TextBox";
            this.expr1TextBox.Size = new System.Drawing.Size(100, 20);
            this.expr1TextBox.TabIndex = 5;
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            colorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            colorLabel.Location = new System.Drawing.Point(85, 186);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(47, 20);
            colorLabel.TabIndex = 6;
            colorLabel.Text = "color:";
            // 
            // colorTextBox
            // 
            this.colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makerOfPrntBindingSource, "color", true));
            this.colorTextBox.Location = new System.Drawing.Point(148, 188);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(100, 20);
            this.colorTextBox.TabIndex = 7;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            typeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            typeLabel.Location = new System.Drawing.Point(89, 225);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(43, 20);
            typeLabel.TabIndex = 8;
            typeLabel.Text = "type:";
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makerOfPrntBindingSource, "type", true));
            this.typeTextBox.Location = new System.Drawing.Point(148, 227);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.typeTextBox.TabIndex = 9;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            priceLabel.Location = new System.Drawing.Point(85, 265);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(47, 20);
            priceLabel.TabIndex = 10;
            priceLabel.Text = "price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makerOfPrntBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(148, 267);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 11;
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            codeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            codeLabel.Location = new System.Drawing.Point(84, 305);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(48, 20);
            codeLabel.TabIndex = 12;
            codeLabel.Text = "code:";
            // 
            // codeTextBox
            // 
            this.codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makerOfPrntBindingSource, "code", true));
            this.codeTextBox.Location = new System.Drawing.Point(148, 307);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(100, 20);
            this.codeTextBox.TabIndex = 13;
            // 
            // MakerPr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 495);
            this.Controls.Add(codeLabel);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(colorLabel);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(expr1Label);
            this.Controls.Add(this.expr1TextBox);
            this.Controls.Add(makerLabel);
            this.Controls.Add(this.makerTextBox);
            this.Controls.Add(this.makerOfPrntBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "MakerPr";
            this.Text = "MakerPr";
            this.Load += new System.EventHandler(this.MakerPr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.st02DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makerOfPrntBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makerOfPrntBindingNavigator)).EndInit();
            this.makerOfPrntBindingNavigator.ResumeLayout(false);
            this.makerOfPrntBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private St02DataSet st02DataSet;
        private System.Windows.Forms.BindingSource makerOfPrntBindingSource;
        private St02DataSetTableAdapters.makerOfPrntTableAdapter makerOfPrntTableAdapter;
        private St02DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator makerOfPrntBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton makerOfPrntBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox makerTextBox;
        private System.Windows.Forms.TextBox expr1TextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
    }
}