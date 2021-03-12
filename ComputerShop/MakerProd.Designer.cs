namespace ComputerShop
{
    partial class MakerProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakerProd));
            System.Windows.Forms.Label makerLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label mProdLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label mPCLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label pPrntLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.st02DataSet = new ComputerShop.St02DataSet();
            this.makerProdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.makerProdTableAdapter = new ComputerShop.St02DataSetTableAdapters.makerProdTableAdapter();
            this.tableAdapterManager = new ComputerShop.St02DataSetTableAdapters.TableAdapterManager();
            this.makerProdBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.makerProdBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.makerTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.mProdTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.mPCTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.pPrntTextBox = new System.Windows.Forms.TextBox();
            makerLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            mProdLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            mPCLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            pPrntLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.st02DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makerProdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makerProdBindingNavigator)).BeginInit();
            this.makerProdBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(78, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Производители товаров";
            // 
            // st02DataSet
            // 
            this.st02DataSet.DataSetName = "St02DataSet";
            this.st02DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // makerProdBindingSource
            // 
            this.makerProdBindingSource.DataMember = "makerProd";
            this.makerProdBindingSource.DataSource = this.st02DataSet;
            // 
            // makerProdTableAdapter
            // 
            this.makerProdTableAdapter.ClearBeforeFill = true;
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
            // makerProdBindingNavigator
            // 
            this.makerProdBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.makerProdBindingNavigator.BindingSource = this.makerProdBindingSource;
            this.makerProdBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.makerProdBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.makerProdBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.makerProdBindingNavigatorSaveItem});
            this.makerProdBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.makerProdBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.makerProdBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.makerProdBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.makerProdBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.makerProdBindingNavigator.Name = "makerProdBindingNavigator";
            this.makerProdBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.makerProdBindingNavigator.Size = new System.Drawing.Size(401, 25);
            this.makerProdBindingNavigator.TabIndex = 2;
            this.makerProdBindingNavigator.Text = "bindingNavigator1";
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
            // makerProdBindingNavigatorSaveItem
            // 
            this.makerProdBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.makerProdBindingNavigatorSaveItem.Enabled = false;
            this.makerProdBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("makerProdBindingNavigatorSaveItem.Image")));
            this.makerProdBindingNavigatorSaveItem.Name = "makerProdBindingNavigatorSaveItem";
            this.makerProdBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.makerProdBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // makerLabel
            // 
            makerLabel.AutoSize = true;
            makerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            makerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            makerLabel.Location = new System.Drawing.Point(84, 87);
            makerLabel.Name = "makerLabel";
            makerLabel.Size = new System.Drawing.Size(57, 20);
            makerLabel.TabIndex = 2;
            makerLabel.Text = "maker:";
            // 
            // makerTextBox
            // 
            this.makerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makerProdBindingSource, "maker", true));
            this.makerTextBox.Location = new System.Drawing.Point(156, 89);
            this.makerTextBox.Name = "makerTextBox";
            this.makerTextBox.Size = new System.Drawing.Size(100, 20);
            this.makerTextBox.TabIndex = 3;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            typeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            typeLabel.Location = new System.Drawing.Point(98, 120);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(43, 20);
            typeLabel.TabIndex = 4;
            typeLabel.Text = "type:";
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makerProdBindingSource, "type", true));
            this.typeTextBox.Location = new System.Drawing.Point(156, 122);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.typeTextBox.TabIndex = 5;
            // 
            // mProdLabel
            // 
            mProdLabel.AutoSize = true;
            mProdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            mProdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            mProdLabel.Location = new System.Drawing.Point(78, 156);
            mProdLabel.Name = "mProdLabel";
            mProdLabel.Size = new System.Drawing.Size(63, 20);
            mProdLabel.TabIndex = 6;
            mProdLabel.Text = "m Prod:";
            // 
            // mProdTextBox
            // 
            this.mProdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makerProdBindingSource, "mProd", true));
            this.mProdTextBox.Location = new System.Drawing.Point(156, 158);
            this.mProdTextBox.Name = "mProdTextBox";
            this.mProdTextBox.Size = new System.Drawing.Size(100, 20);
            this.mProdTextBox.TabIndex = 7;
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            modelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            modelLabel.Location = new System.Drawing.Point(85, 194);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(56, 20);
            modelLabel.TabIndex = 8;
            modelLabel.Text = "model:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makerProdBindingSource, "model", true));
            this.modelTextBox.Location = new System.Drawing.Point(156, 196);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 9;
            // 
            // mPCLabel
            // 
            mPCLabel.AutoSize = true;
            mPCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            mPCLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            mPCLabel.Location = new System.Drawing.Point(90, 232);
            mPCLabel.Name = "mPCLabel";
            mPCLabel.Size = new System.Drawing.Size(51, 20);
            mPCLabel.TabIndex = 10;
            mPCLabel.Text = "m PC:";
            // 
            // mPCTextBox
            // 
            this.mPCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makerProdBindingSource, "mPC", true));
            this.mPCTextBox.Location = new System.Drawing.Point(156, 234);
            this.mPCTextBox.Name = "mPCTextBox";
            this.mPCTextBox.Size = new System.Drawing.Size(100, 20);
            this.mPCTextBox.TabIndex = 11;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            priceLabel.Location = new System.Drawing.Point(94, 274);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(47, 20);
            priceLabel.TabIndex = 12;
            priceLabel.Text = "price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makerProdBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(156, 276);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 13;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // pPrntLabel
            // 
            pPrntLabel.AutoSize = true;
            pPrntLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            pPrntLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            pPrntLabel.Location = new System.Drawing.Point(86, 314);
            pPrntLabel.Name = "pPrntLabel";
            pPrntLabel.Size = new System.Drawing.Size(55, 20);
            pPrntLabel.TabIndex = 14;
            pPrntLabel.Text = "p Prnt:";
            // 
            // pPrntTextBox
            // 
            this.pPrntTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makerProdBindingSource, "pPrnt", true));
            this.pPrntTextBox.Location = new System.Drawing.Point(156, 316);
            this.pPrntTextBox.Name = "pPrntTextBox";
            this.pPrntTextBox.Size = new System.Drawing.Size(100, 20);
            this.pPrntTextBox.TabIndex = 15;
            // 
            // MakerProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 415);
            this.Controls.Add(pPrntLabel);
            this.Controls.Add(this.pPrntTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(mPCLabel);
            this.Controls.Add(this.mPCTextBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(mProdLabel);
            this.Controls.Add(this.mProdTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(makerLabel);
            this.Controls.Add(this.makerTextBox);
            this.Controls.Add(this.makerProdBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "MakerProd";
            this.Text = "MakerProd";
            this.Load += new System.EventHandler(this.MakerProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.st02DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makerProdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makerProdBindingNavigator)).EndInit();
            this.makerProdBindingNavigator.ResumeLayout(false);
            this.makerProdBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private St02DataSet st02DataSet;
        private System.Windows.Forms.BindingSource makerProdBindingSource;
        private St02DataSetTableAdapters.makerProdTableAdapter makerProdTableAdapter;
        private St02DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator makerProdBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton makerProdBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox makerTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox mProdTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox mPCTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox pPrntTextBox;
    }
}