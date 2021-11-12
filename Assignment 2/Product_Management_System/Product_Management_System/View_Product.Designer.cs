namespace Product_Management_System
{
    partial class frm_View_All_Products
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
            this.dgv_View_Products = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_Management_System_DBDataSet2 = new Product_Management_System.Product_Management_System_DBDataSet2();
            this.btn_Add_New_Product = new System.Windows.Forms.Button();
            this.lbl_View_All_Products = new System.Windows.Forms.Label();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.product_DetailsTableAdapter = new Product_Management_System.Product_Management_System_DBDataSet2TableAdapters.Product_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Management_System_DBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_View_Products
            // 
            this.dgv_View_Products.AllowUserToAddRows = false;
            this.dgv_View_Products.AllowUserToDeleteRows = false;
            this.dgv_View_Products.AutoGenerateColumns = false;
            this.dgv_View_Products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.purchasePriceDataGridViewTextBoxColumn,
            this.salesPriceDataGridViewTextBoxColumn});
            this.dgv_View_Products.DataSource = this.productDetailsBindingSource;
            this.dgv_View_Products.Location = new System.Drawing.Point(22, 95);
            this.dgv_View_Products.Name = "dgv_View_Products";
            this.dgv_View_Products.ReadOnly = true;
            this.dgv_View_Products.Size = new System.Drawing.Size(913, 325);
            this.dgv_View_Products.TabIndex = 0;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "Product_ID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Product_ID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product_Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchasePriceDataGridViewTextBoxColumn
            // 
            this.purchasePriceDataGridViewTextBoxColumn.DataPropertyName = "Purchase_Price";
            this.purchasePriceDataGridViewTextBoxColumn.HeaderText = "Purchase_Price";
            this.purchasePriceDataGridViewTextBoxColumn.Name = "purchasePriceDataGridViewTextBoxColumn";
            this.purchasePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesPriceDataGridViewTextBoxColumn
            // 
            this.salesPriceDataGridViewTextBoxColumn.DataPropertyName = "Sales_Price";
            this.salesPriceDataGridViewTextBoxColumn.HeaderText = "Sales_Price";
            this.salesPriceDataGridViewTextBoxColumn.Name = "salesPriceDataGridViewTextBoxColumn";
            this.salesPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productDetailsBindingSource
            // 
            this.productDetailsBindingSource.DataMember = "Product_Details";
            this.productDetailsBindingSource.DataSource = this.product_Management_System_DBDataSet2;
            // 
            // product_Management_System_DBDataSet2
            // 
            this.product_Management_System_DBDataSet2.DataSetName = "Product_Management_System_DBDataSet2";
            this.product_Management_System_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Add_New_Product
            // 
            this.btn_Add_New_Product.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Add_New_Product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add_New_Product.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Product.ForeColor = System.Drawing.Color.DarkViolet;
            this.btn_Add_New_Product.Location = new System.Drawing.Point(329, 436);
            this.btn_Add_New_Product.Name = "btn_Add_New_Product";
            this.btn_Add_New_Product.Size = new System.Drawing.Size(242, 46);
            this.btn_Add_New_Product.TabIndex = 1;
            this.btn_Add_New_Product.Text = "Add New Product";
            this.btn_Add_New_Product.UseVisualStyleBackColor = false;
            this.btn_Add_New_Product.Click += new System.EventHandler(this.btn_Add_New_Product_Click);
            // 
            // lbl_View_All_Products
            // 
            this.lbl_View_All_Products.AutoSize = true;
            this.lbl_View_All_Products.BackColor = System.Drawing.Color.BurlyWood;
            this.lbl_View_All_Products.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_All_Products.ForeColor = System.Drawing.Color.Navy;
            this.lbl_View_All_Products.Location = new System.Drawing.Point(278, 9);
            this.lbl_View_All_Products.Name = "lbl_View_All_Products";
            this.lbl_View_All_Products.Size = new System.Drawing.Size(403, 56);
            this.lbl_View_All_Products.TabIndex = 0;
            this.lbl_View_All_Products.Text = "View All Products";
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LogOut.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.Red;
            this.btn_LogOut.Location = new System.Drawing.Point(858, 9);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(90, 40);
            this.btn_LogOut.TabIndex = 2;
            this.btn_LogOut.Text = "Logout";
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // product_DetailsTableAdapter
            // 
            this.product_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_View_All_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(960, 507);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.lbl_View_All_Products);
            this.Controls.Add(this.btn_Add_New_Product);
            this.Controls.Add(this.dgv_View_Products);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_All_Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Product";
            this.Load += new System.EventHandler(this.frm_View_All_Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Management_System_DBDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_View_Products;
        private System.Windows.Forms.Button btn_Add_New_Product;
        private System.Windows.Forms.Label lbl_View_All_Products;
        private System.Windows.Forms.Button btn_LogOut;
        private Product_Management_System_DBDataSet2 product_Management_System_DBDataSet2;
        private System.Windows.Forms.BindingSource productDetailsBindingSource;
        private Product_Management_System_DBDataSet2TableAdapters.Product_DetailsTableAdapter product_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesPriceDataGridViewTextBoxColumn;
    }
}