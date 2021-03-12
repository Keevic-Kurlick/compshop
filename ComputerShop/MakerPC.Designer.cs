namespace ComputerShop
{
    partial class MakerPC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakerPC));
            System.Windows.Forms.Label makerLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label speedLabel;
            System.Windows.Forms.Label ramLabel;
            System.Windows.Forms.Label hdLabel;
            System.Windows.Forms.Label cdLabel;
            System.Windows.Forms.Label priceLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.st02DataSet = new ComputerShop.St02DataSet();
            this.makerOfPcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.makerOfPcTableAdapter = new ComputerShop.St02DataSetTableAdapters.makerOfPcTableAdapter();
            this.tableAdapterManager = new ComputerShop.St02DataSetTableAdapters.TableAdapterManager();
            this.makerOfPcBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.makerOfPcBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.makerTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.ramTextBox = new System.Windows.Forms.TextBox();
            this.hdTextBox = new System.Windows.Forms.TextBox();
            this.cdTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            makerLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            speedLabel = new System.Windows.Forms.Label();
            ramLabel = new System.Windows.Forms.Label();
            hdLabel = new System.Windows.Forms.Label();
            cdLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.st02DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makerOfPcBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makerOfPcBindingNavigator)).BeginInit();
            this.makerOfPcBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(79, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Производители ПК";
            // 
            // st02DataSet
            // 
            this.st02DataSet.DataSetName = "St02DataSet";
            this.st02DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // makerOfPcBindingSource
            // 
            this.makerOfPcBindingSource.DataMember = "makerOfPc";
            this.makerOfPcBindingSource.DataSource = this.st02DataSet;
            // 
            // makerOfPcTableAdapter
            // 
            this.makerOfPcTableAdapter.ClearBeforeFill = true;
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
            // makerOfPcBindingNavigator
            // 
            this.makerOfPcBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.makerOfPcBindingNavigator.BindingSource = this.makerOfPcBindingSource;
            this.makerOfPcBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.makerOfPcBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.makerOfPcBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.makerOfPcBindingNavigatorSaveItem});
            this.makerOfPcBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.makerOfPcBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.makerOfPcBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.makerOfPcBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.makerOfPcBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.makerOfPcBindingNavigator.Name = "makerOfPcBindingNavigator";
            this.makerOfPcBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.makerOfPcBindingNavigator.Size = new System.Drawing.Size(338, 25);
            this.makerOfPcBindingNavigator.TabIndex = 1;
            this.makerOfPcBindingNavigator.Text = "bindingNavigator1";
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
            // makerOfPcBindingNavigatorSaveItem
            // 
            this.makerOfPcBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.makerOfPcBindingNavigatorSaveItem.Enabled = false;
            this.makerOfPcBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("makerOfPcBindingNavigatorSaveItem.Image")));
            this.makerOfPcBindingNavigatorSaveItem.Name = "makerOfPcBindingNavigatorSaveItem";
            this.makerOfPcBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.makerOfPcBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // makerLabel
            // 
            makerLabel.AutoSize = true;
            makerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            makerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            makerLabel.Location = new System.Drawing.Point(65, 99);
            makerLabel.Name = "makerLabel";
            makerLabel.Size = new System.Drawing.Size(57, 20);
            makerLabel.TabIndex = 2;
            makerLabel.Text = "maker:";
            // 
            // makerTextBox
            // 
            this.makerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makerOfPcBindingSource, "maker", true));
            this.makerTextBox.Location = new System.Drawing.Point(128, 101);
            this.makerTextBox.Name = "makerTextBox";
            this.makerTextBox.Size = new System.Drawing.Size(100, 20);
            this.makerTextBox.TabIndex = 3;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            typeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            typeLabel.Location = new System.Drawing.Point(79, 125);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(43, 20);
            typeLabel.TabIndex = 4;
            typeLabel.Text = "type:";
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makerOfPcBindingSource, "type", true));
            this.typeTextBox.Location = new System.Drawing.Point(128, 127);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.typeTextBox.TabIndex = 5;
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            modelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            modelLabel.Location = new System.Drawing.Point(66, 151);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(56, 20);
            modelLabel.TabIndex = 6;
            modelLabel.Text = "model:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makerOfPcBindingSource, "model", true));
            this.modelTextBox.Location = new System.Drawing.Point(128, 153);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 7;
            // 
            // speedLabel
            // 
            speedLabel.AutoSize = true;
            speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            speedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            speedLabel.Location = new System.Drawing.Point(65, 177);
            speedLabel.Name = "speedLabel";
            speedLabel.Size = new System.Drawing.Size(57, 20);
            speedLabel.TabIndex = 8;
            speedLabel.Text = "speed:";
            // 
            // speedTextBox
            // 
            this.speedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makerOfPcBindingSource, "speed", true));
            this.speedTextBox.Location = new System.Drawing.Point(128, 179);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(100, 20);
            this.speedTextBox.TabIndex = 9;
            // 
            // ramLabel
            // 
            ramLabel.AutoSize = true;
            ramLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ramLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            ramLabel.Location = new System.Drawing.Point(82, 203);
            ramLabel.Name = "ramLabel";
            ramLabel.Size = new System.Drawing.Size(40, 20);
            ramLabel.TabIndex = 10;
            ramLabel.Text = "ram:";
            // 
            // ramTextBox
            // 
            this.ramTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makerOfPcBindingSource, "ram", true));
            this.ramTextBox.Location = new System.Drawing.Point(128, 205);
            this.ramTextBox.Name = "ramTextBox";
            this.ramTextBox.Size = new System.Drawing.Size(100, 20);
            this.ramTextBox.TabIndex = 11;
            // 
            // hdLabel
            // 
            hdLabel.AutoSize = true;
            hdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            hdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            hdLabel.Location = new System.Drawing.Point(91, 229);
            hdLabel.Name = "hdLabel";
            hdLabel.Size = new System.Drawing.Size(31, 20);
            hdLabel.TabIndex = 12;
            hdLabel.Text = "hd:";
            // 
            // hdTextBox
            // 
            this.hdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makerOfPcBindingSource, "hd", true));
            this.hdTextBox.Location = new System.Drawing.Point(128, 231);
            this.hdTextBox.Name = "hdTextBox";
            this.hdTextBox.Size = new System.Drawing.Size(100, 20);
            this.hdTextBox.TabIndex = 13;
            // 
            // cdLabel
            // 
            cdLabel.AutoSize = true;
            cdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            cdLabel.Location = new System.Drawing.Point(92, 255);
            cdLabel.Name = "cdLabel";
            cdLabel.Size = new System.Drawing.Size(30, 20);
            cdLabel.TabIndex = 14;
            cdLabel.Text = "cd:";
            // 
            // cdTextBox
            // 
            this.cdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makerOfPcBindingSource, "cd", true));
            this.cdTextBox.Location = new System.Drawing.Point(128, 257);
            this.cdTextBox.Name = "cdTextBox";
            this.cdTextBox.Size = new System.Drawing.Size(100, 20);
            this.cdTextBox.TabIndex = 15;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            priceLabel.Location = new System.Drawing.Point(75, 281);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(47, 20);
            priceLabel.TabIndex = 16;
            priceLabel.Text = "price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makerOfPcBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(128, 283);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 17;
            // 
            // MakerPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 409);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(cdLabel);
            this.Controls.Add(this.cdTextBox);
            this.Controls.Add(hdLabel);
            this.Controls.Add(this.hdTextBox);
            this.Controls.Add(ramLabel);
            this.Controls.Add(this.ramTextBox);
            this.Controls.Add(speedLabel);
            this.Controls.Add(this.speedTextBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(makerLabel);
            this.Controls.Add(this.makerTextBox);
            this.Controls.Add(this.makerOfPcBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "MakerPC";
            this.Text = "MakerPC";
            this.Load += new System.EventHandler(this.MakerPC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.st02DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makerOfPcBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makerOfPcBindingNavigator)).EndInit();
            this.makerOfPcBindingNavigator.ResumeLayout(false);
            this.makerOfPcBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private St02DataSet st02DataSet;
        private System.Windows.Forms.BindingSource makerOfPcBindingSource;
        private St02DataSetTableAdapters.makerOfPcTableAdapter makerOfPcTableAdapter;
        private St02DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator makerOfPcBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton makerOfPcBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox makerTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.TextBox ramTextBox;
        private System.Windows.Forms.TextBox hdTextBox;
        private System.Windows.Forms.TextBox cdTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
    }
}