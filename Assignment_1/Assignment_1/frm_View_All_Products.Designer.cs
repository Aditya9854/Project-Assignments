namespace Assignment_1
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
            this.lbl_View_All_Products = new System.Windows.Forms.Label();
            this.dgv_view_All_Products = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.assignment_1_DBDataSet = new Assignment_1.Assignment_1_DBDataSet();
            this.productDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btn_Add_New_Product = new System.Windows.Forms.Button();
            this.product_DetailsTableAdapter = new Assignment_1.Assignment_1_DBDataSetTableAdapters.Product_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_view_All_Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment_1_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_View_All_Products
            // 
            this.lbl_View_All_Products.AutoSize = true;
            this.lbl_View_All_Products.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_All_Products.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_View_All_Products.Location = new System.Drawing.Point(239, 9);
            this.lbl_View_All_Products.Name = "lbl_View_All_Products";
            this.lbl_View_All_Products.Size = new System.Drawing.Size(403, 56);
            this.lbl_View_All_Products.TabIndex = 2;
            this.lbl_View_All_Products.Text = "View All Products";
            // 
            // dgv_view_All_Products
            // 
            this.dgv_view_All_Products.AllowUserToAddRows = false;
            this.dgv_view_All_Products.AllowUserToDeleteRows = false;
            this.dgv_view_All_Products.AutoGenerateColumns = false;
            this.dgv_view_All_Products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_view_All_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_view_All_Products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgv_view_All_Products.DataSource = this.productDetailsBindingSource1;
            this.dgv_view_All_Products.Location = new System.Drawing.Point(24, 75);
            this.dgv_view_All_Products.Name = "dgv_view_All_Products";
            this.dgv_view_All_Products.ReadOnly = true;
            this.dgv_view_All_Products.Size = new System.Drawing.Size(805, 299);
            this.dgv_view_All_Products.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Product_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Product_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Product_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Product_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Purchase_Price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Purchase_Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Sales_Price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Sales_Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // productDetailsBindingSource1
            // 
            this.productDetailsBindingSource1.DataMember = "Product_Details";
            this.productDetailsBindingSource1.DataSource = this.assignment_1_DBDataSet;
            // 
            // assignment_1_DBDataSet
            // 
            this.assignment_1_DBDataSet.DataSetName = "Assignment_1_DBDataSet";
            this.assignment_1_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productDetailsBindingSource
            // 
            this.productDetailsBindingSource.DataMember = "Product_Details";
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LogOut.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.Red;
            this.btn_LogOut.Location = new System.Drawing.Point(770, 12);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(83, 31);
            this.btn_LogOut.TabIndex = 2;
            this.btn_LogOut.Text = "LogOut";
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // btn_Add_New_Product
            // 
            this.btn_Add_New_Product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add_New_Product.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Product.Location = new System.Drawing.Point(291, 393);
            this.btn_Add_New_Product.Name = "btn_Add_New_Product";
            this.btn_Add_New_Product.Size = new System.Drawing.Size(220, 44);
            this.btn_Add_New_Product.TabIndex = 1;
            this.btn_Add_New_Product.Text = "Add New Product";
            this.btn_Add_New_Product.UseVisualStyleBackColor = true;
            this.btn_Add_New_Product.Click += new System.EventHandler(this.btn_Add_New_Product_Click);
            // 
            // product_DetailsTableAdapter
            // 
            this.product_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_View_All_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 449);
            this.Controls.Add(this.btn_Add_New_Product);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.dgv_view_All_Products);
            this.Controls.Add(this.lbl_View_All_Products);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_All_Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Products";
            this.Load += new System.EventHandler(this.View_All_Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_view_All_Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment_1_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_All_Products;
        private System.Windows.Forms.DataGridView dgv_view_All_Products;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button btn_Add_New_Product;
        private System.Windows.Forms.BindingSource productDetailsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesPriceDataGridViewTextBoxColumn;
        private Assignment_1_DBDataSet assignment_1_DBDataSet;
        private System.Windows.Forms.BindingSource productDetailsBindingSource1;
        private Assignment_1_DBDataSetTableAdapters.Product_DetailsTableAdapter product_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}