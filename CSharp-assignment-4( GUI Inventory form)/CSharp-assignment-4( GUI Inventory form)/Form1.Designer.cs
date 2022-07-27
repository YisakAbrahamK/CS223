namespace CSharp_assignment_4__GUI_Inventory_form_
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_inventory_number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_number = new System.Windows.Forms.Label();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_object_name = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.isAvailable = new System.Windows.Forms.CheckBox();
            this.clbCatagory = new System.Windows.Forms.CheckedListBox();
            this.rbSimple = new System.Windows.Forms.RadioButton();
            this.rbVariable = new System.Windows.Forms.RadioButton();
            this.gbProductType = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.currentUser = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.catagory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.variableProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbProductType.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_date
            // 
            this.dtp_date.AllowDrop = true;
            this.dtp_date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(417, 176);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(343, 40);
            this.dtp_date.TabIndex = 23;
            this.dtp_date.Value = new System.DateTime(2022, 7, 5, 14, 52, 25, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(411, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 33);
            this.label4.TabIndex = 22;
            this.label4.Text = "Count";
            // 
            // txt_count
            // 
            this.txt_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_count.Location = new System.Drawing.Point(417, 331);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(139, 40);
            this.txt_count.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 33);
            this.label2.TabIndex = 20;
            this.label2.Text = "Inventory Number";
            // 
            // txt_inventory_number
            // 
            this.txt_inventory_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inventory_number.Location = new System.Drawing.Point(45, 331);
            this.txt_inventory_number.Name = "txt_inventory_number";
            this.txt_inventory_number.Size = new System.Drawing.Size(308, 40);
            this.txt_inventory_number.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Date";
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_number.Location = new System.Drawing.Point(39, 125);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(119, 33);
            this.lbl_number.TabIndex = 17;
            this.lbl_number.Text = "Number";
            // 
            // txt_number
            // 
            this.txt_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_number.Location = new System.Drawing.Point(45, 179);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(308, 40);
            this.txt_number.TabIndex = 16;
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(417, 743);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 49);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(602, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 33);
            this.label5.TabIndex = 28;
            this.label5.Text = "Price";
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(608, 331);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(152, 40);
            this.txt_price.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 33);
            this.label3.TabIndex = 26;
            this.label3.Text = "Object Name";
            // 
            // txt_object_name
            // 
            this.txt_object_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_object_name.Location = new System.Drawing.Point(45, 489);
            this.txt_object_name.Name = "txt_object_name";
            this.txt_object_name.Size = new System.Drawing.Size(308, 40);
            this.txt_object_name.TabIndex = 25;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(220, 743);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(133, 49);
            this.btnSubmit.TabIndex = 24;
            this.btnSubmit.Text = "Add";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.inventoryNumberDataGridViewTextBoxColumn,
            this.objectNameDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.Column1,
            this.catagory,
            this.variableProduct});
            this.dgvProducts.DataSource = this.productBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.Location = new System.Drawing.Point(817, 37);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(714, 752);
            this.dgvProducts.TabIndex = 30;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // isAvailable
            // 
            this.isAvailable.AutoSize = true;
            this.isAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isAvailable.Location = new System.Drawing.Point(9, 52);
            this.isAvailable.Name = "isAvailable";
            this.isAvailable.Size = new System.Drawing.Size(141, 29);
            this.isAvailable.TabIndex = 31;
            this.isAvailable.Text = "Is Available";
            this.isAvailable.UseVisualStyleBackColor = true;
            this.isAvailable.CheckedChanged += new System.EventHandler(this.isAvailable_CheckedChanged);
            // 
            // clbCatagory
            // 
            this.clbCatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbCatagory.FormattingEnabled = true;
            this.clbCatagory.Items.AddRange(new object[] {
            "Food",
            "Electronic",
            "Children",
            "Women",
            "Male"});
            this.clbCatagory.Location = new System.Drawing.Point(417, 489);
            this.clbCatagory.Name = "clbCatagory";
            this.clbCatagory.Size = new System.Drawing.Size(343, 74);
            this.clbCatagory.TabIndex = 32;
            this.clbCatagory.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // rbSimple
            // 
            this.rbSimple.AutoSize = true;
            this.rbSimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSimple.Location = new System.Drawing.Point(226, 52);
            this.rbSimple.Name = "rbSimple";
            this.rbSimple.Size = new System.Drawing.Size(95, 29);
            this.rbSimple.TabIndex = 33;
            this.rbSimple.TabStop = true;
            this.rbSimple.Text = "Simple";
            this.rbSimple.UseVisualStyleBackColor = true;
            // 
            // rbVariable
            // 
            this.rbVariable.AutoSize = true;
            this.rbVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVariable.Location = new System.Drawing.Point(20, 52);
            this.rbVariable.Name = "rbVariable";
            this.rbVariable.Size = new System.Drawing.Size(109, 29);
            this.rbVariable.TabIndex = 34;
            this.rbVariable.TabStop = true;
            this.rbVariable.Text = "Variable";
            this.rbVariable.UseVisualStyleBackColor = true;
            // 
            // gbProductType
            // 
            this.gbProductType.Controls.Add(this.rbVariable);
            this.gbProductType.Controls.Add(this.rbSimple);
            this.gbProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProductType.Location = new System.Drawing.Point(417, 590);
            this.gbProductType.Name = "gbProductType";
            this.gbProductType.Size = new System.Drawing.Size(343, 108);
            this.gbProductType.TabIndex = 37;
            this.gbProductType.TabStop = false;
            this.gbProductType.Text = "Product Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.isAvailable);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(45, 590);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 108);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Avilability";
            // 
            // currentUser
            // 
            this.currentUser.AutoSize = true;
            this.currentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUser.Location = new System.Drawing.Point(39, 49);
            this.currentUser.Name = "currentUser";
            this.currentUser.Size = new System.Drawing.Size(227, 37);
            this.currentUser.TabIndex = 39;
            this.currentUser.Text = "Current user: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(411, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 33);
            this.label6.TabIndex = 40;
            this.label6.Text = "Product Catagory";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(WindowsFormsApp2.Model.Product);
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberDataGridViewTextBoxColumn.Width = 110;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 77;
            // 
            // inventoryNumberDataGridViewTextBoxColumn
            // 
            this.inventoryNumberDataGridViewTextBoxColumn.DataPropertyName = "inventoryNumber";
            this.inventoryNumberDataGridViewTextBoxColumn.HeaderText = "Inventory Number";
            this.inventoryNumberDataGridViewTextBoxColumn.Name = "inventoryNumberDataGridViewTextBoxColumn";
            this.inventoryNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.inventoryNumberDataGridViewTextBoxColumn.Width = 183;
            // 
            // objectNameDataGridViewTextBoxColumn
            // 
            this.objectNameDataGridViewTextBoxColumn.DataPropertyName = "objectName";
            this.objectNameDataGridViewTextBoxColumn.HeaderText = "Object Name";
            this.objectNameDataGridViewTextBoxColumn.Name = "objectNameDataGridViewTextBoxColumn";
            this.objectNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.objectNameDataGridViewTextBoxColumn.Width = 143;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            this.countDataGridViewTextBoxColumn.Width = 90;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 83;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "isAvailable";
            this.Column1.HeaderText = "Is Available";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 110;
            // 
            // catagory
            // 
            this.catagory.DataPropertyName = "catagory";
            this.catagory.HeaderText = "Catagory";
            this.catagory.Name = "catagory";
            this.catagory.Width = 117;
            // 
            // variableProduct
            // 
            this.variableProduct.DataPropertyName = "productType";
            this.variableProduct.HeaderText = "Product Type";
            this.variableProduct.Name = "variableProduct";
            this.variableProduct.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.variableProduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.variableProduct.Width = 127;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 830);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.currentUser);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbProductType);
            this.Controls.Add(this.clbCatagory);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_object_name);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_inventory_number);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_number);
            this.Controls.Add(this.txt_number);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbProductType.ResumeLayout(false);
            this.gbProductType.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_inventory_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_number;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_object_name;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.CheckBox isAvailable;
        private System.Windows.Forms.CheckedListBox clbCatagory;
        private System.Windows.Forms.RadioButton rbVariable;
        private System.Windows.Forms.RadioButton rbSimple;
        private System.Windows.Forms.GroupBox gbProductType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label currentUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn catagory;
        private System.Windows.Forms.DataGridViewTextBoxColumn variableProduct;
    }
}

