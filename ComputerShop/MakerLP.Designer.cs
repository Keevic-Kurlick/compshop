namespace ComputerShop
{
    partial class MakerLP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakerLP));
            System.Windows.Forms.Label makerLabel;
            System.Windows.Forms.Label codeLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label speedLabel;
            System.Windows.Forms.Label ramLabel;
            System.Windows.Forms.Label hdLabel;
            System.Windows.Forms.Label screenLabel;
            System.Windows.Forms.Label priceLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.st02DataSet = new ComputerShop.St02DataSet();
            this.makerOfLaptopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.makerOfLaptopTableAdapter = new ComputerShop.St02DataSetTableAdapters.makerOfLaptopTableAdapter();
            this.tableAdapterManager = new ComputerShop.St02DataSetTableAdapters.TableAdapterManager();
            this.makerOfLaptopBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.makerOfLaptopBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.makerTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.ramTextBox = new System.Windows.Forms.TextBox();
            this.hdTextBox = new System.Windows.Forms.TextBox();
            this.screenTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            makerLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            speedLabel = new System.Windows.Forms.Label();
            ramLabel = new System.Windows.Forms.Label();
            hdLabel = new System.Windows.Forms.Label();
            screenLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.st02DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makerOfLaptopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makerOfLaptopBindingNavigator)).BeginInit();
            this.makerOfLaptopBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(51, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Производители ноутбуков";
            // 
            // st02DataSet
            // 
            this.st02DataSet.DataSetName = "St02DataSet";
            this.st02DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // makerOfLaptopBindingSource
            // 
            this.makerOfLaptopBindingSource.DataMember = "makerOfLaptop";
            this.makerOfLaptopBindingSource.DataSource = this.st02DataSet;
            // 
            // makerOfLaptopTableAdapter
            // 
            this.makerOfLaptopTableAdapter.ClearBeforeFill = true;
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
            // makerOfLaptopBindingNavigator
            // 
            this.makerOfLaptopBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.makerOfLaptopBindingNavigator.BindingSource = this.makerOfLaptopBindingSource;
            this.makerOfLaptopBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.makerOfLaptopBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.makerOfLaptopBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.makerOfLaptopBindingNavigatorSaveItem});
            this.makerOfLaptopBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.makerOfLaptopBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.makerOfLaptopBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.makerOfLaptopBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.makerOfLaptopBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.makerOfLaptopBindingNavigator.Name = "makerOfLaptopBindingNavigator";
            this.makerOfLaptopBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.makerOfLaptopBindingNavigator.Size = new System.Drawing.Size(352, 25);
            this.makerOfLaptopBindingNavigator.TabIndex = 2;
            this.makerOfLaptopBindingNavigator.Text = "bindingNavigator1";
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
            // makerOfLaptopBindingNavigatorSaveItem
            // 
            this.makerOfLaptopBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.makerOfLaptopBindingNavigatorSaveItem.Enabled = false;
            this.makerOfLaptopBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("makerOfLaptopBindingNavigatorSaveItem.Image")));
            this.makerOfLaptopBindingNavigatorSaveItem.Name = "makerOfLaptopBindingNavigatorSaveItem";
            this.makerOfLaptopBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.makerOfLaptopBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // makerLabel
            // 
            makerLabel.AutoSize = true;
            makerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            makerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            makerLabel.Location = new System.Drawing.Point(55, 71);
            makerLabel.Name = "makerLabel";
            makerLabel.Size = new System.Drawing.Size(57, 20);
            makerLabel.TabIndex = 2;
            makerLabel.Text = "maker:";
            // 
            // makerTextBox
            // 
            this.makerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makerOfLaptopBindingSource, "maker", true));
            this.makerTextBox.Location = new System.Drawing.Point(131, 73);
            this.makerTextBox.Name = "makerTextBox";
            this.makerTextBox.Size = new System.Drawing.Size(100, 20);
            this.makerTextBox.TabIndex = 3;
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            codeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            codeLabel.Location = new System.Drawing.Point(64, 101);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(48, 20);
            codeLabel.TabIndex = 4;
            codeLabel.Text = "code:";
            // 
            // codeTextBox
            // 
            this.codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makerOfLaptopBindingSource, "code", true));
            this.codeTextBox.Location = new System.Drawing.Point(131, 103);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(100, 20);
            this.codeTextBox.TabIndex = 5;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            typeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            typeLabel.Location = new System.Drawing.Point(69, 133);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(43, 20);
            typeLabel.TabIndex = 6;
            typeLabel.Text = "type:";
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makerOfLaptopBindingSource, "type", true));
            this.typeTextBox.Location = new System.Drawing.Point(131, 135);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.typeTextBox.TabIndex = 7;
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            modelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            modelLabel.Location = new System.Drawing.Point(56, 165);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(56, 20);
            modelLabel.TabIndex = 8;
            modelLabel.Text = "model:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makerOfLaptopBindingSource, "model", true));
            this.modelTextBox.Location = new System.Drawing.Point(131, 167);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 9;
            // 
            // speedLabel
            // 
            speedLabel.AutoSize = true;
            speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            speedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            speedLabel.Location = new System.Drawing.Point(55, 199);
            speedLabel.Name = "speedLabel";
            speedLabel.Size = new System.Drawing.Size(57, 20);
            speedLabel.TabIndex = 10;
            speedLabel.Text = "speed:";
            // 
            // speedTextBox
            // 
            this.speedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makerOfLaptopBindingSource, "speed", true));
            this.speedTextBox.Location = new System.Drawing.Point(131, 201);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(100, 20);
            this.speedTextBox.TabIndex = 11;
            // 
            // ramLabel
            // 
            ramLabel.AutoSize = true;
            ramLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            ramLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            ramLabel.Location = new System.Drawing.Point(72, 234);
            ramLabel.Name = "ramLabel";
            ramLabel.Size = new System.Drawing.Size(40, 20);
            ramLabel.TabIndex = 12;
            ramLabel.Text = "ram:";
            // 
            // ramTextBox
            // 
            this.ramTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makerOfLaptopBindingSource, "ram", true));
            this.ramTextBox.Location = new System.Drawing.Point(131, 236);
            this.ramTextBox.Name = "ramTextBox";
            this.ramTextBox.Size = new System.Drawing.Size(100, 20);
            this.ramTextBox.TabIndex = 13;
            // 
            // hdLabel
            // 
            hdLabel.AutoSize = true;
            hdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            hdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            hdLabel.Location = new System.Drawing.Point(81, 269);
            hdLabel.Name = "hdLabel";
            hdLabel.Size = new System.Drawing.Size(31, 20);
            hdLabel.TabIndex = 14;
            hdLabel.Text = "hd:";
            // 
            // hdTextBox
            // 
            this.hdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makerOfLaptopBindingSource, "hd", true));
            this.hdTextBox.Location = new System.Drawing.Point(131, 271);
            this.hdTextBox.Name = "hdTextBox";
            this.hdTextBox.Size = new System.Drawing.Size(100, 20);
            this.hdTextBox.TabIndex = 15;
            // 
            // screenLabel
            // 
            screenLabel.AutoSize = true;
            screenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            screenLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            screenLabel.Location = new System.Drawing.Point(51, 306);
            screenLabel.Name = "screenLabel";
            screenLabel.Size = new System.Drawing.Size(61, 20);
            screenLabel.TabIndex = 16;
            screenLabel.Text = "screen:";
            // 
            // screenTextBox
            // 
            this.screenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makerOfLaptopBindingSource, "screen", true));
            this.screenTextBox.Location = new System.Drawing.Point(131, 308);
            this.screenTextBox.Name = "screenTextBox";
            this.screenTextBox.Size = new System.Drawing.Size(100, 20);
            this.screenTextBox.TabIndex = 17;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            priceLabel.Location = new System.Drawing.Point(65, 343);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(47, 20);
            priceLabel.TabIndex = 18;
            priceLabel.Text = "price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makerOfLaptopBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(131, 345);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 19;
            // 
            // MakerLP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 414);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(screenLabel);
            this.Controls.Add(this.screenTextBox);
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
            this.Controls.Add(codeLabel);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(makerLabel);
            this.Controls.Add(this.makerTextBox);
            this.Controls.Add(this.makerOfLaptopBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "MakerLP";
            this.Text = "MakerLP";
            this.Load += new System.EventHandler(this.MakerLP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.st02DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makerOfLaptopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makerOfLaptopBindingNavigator)).EndInit();
            this.makerOfLaptopBindingNavigator.ResumeLayout(false);
            this.makerOfLaptopBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private St02DataSet st02DataSet;
        private System.Windows.Forms.BindingSource makerOfLaptopBindingSource;
        private St02DataSetTableAdapters.makerOfLaptopTableAdapter makerOfLaptopTableAdapter;
        private St02DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator makerOfLaptopBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton makerOfLaptopBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox makerTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.TextBox ramTextBox;
        private System.Windows.Forms.TextBox hdTextBox;
        private System.Windows.Forms.TextBox screenTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
    }
}