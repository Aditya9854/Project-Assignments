namespace Product_Management_System
{
    partial class frm_Search_Product
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
            this.tb_Sales_Price = new System.Windows.Forms.TextBox();
            this.tb_Purchase_Price = new System.Windows.Forms.TextBox();
            this.tb_Product_Name = new System.Windows.Forms.TextBox();
            this.tb_Product_ID = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_View_Products = new System.Windows.Forms.Button();
            this.lbl_Product_ID = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.lbl_Search_Product = new System.Windows.Forms.Label();
            this.lbl_Purchase_Price = new System.Windows.Forms.Label();
            this.lbl_Sales_Price = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.btn_Add_New_Product = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Sales_Price
            // 
            this.tb_Sales_Price.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sales_Price.Location = new System.Drawing.Point(459, 349);
            this.tb_Sales_Price.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Sales_Price.MaxLength = 9;
            this.tb_Sales_Price.Name = "tb_Sales_Price";
            this.tb_Sales_Price.Size = new System.Drawing.Size(254, 33);
            this.tb_Sales_Price.TabIndex = 17;
            // 
            // tb_Purchase_Price
            // 
            this.tb_Purchase_Price.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Purchase_Price.Location = new System.Drawing.Point(459, 269);
            this.tb_Purchase_Price.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Purchase_Price.MaxLength = 9;
            this.tb_Purchase_Price.Name = "tb_Purchase_Price";
            this.tb_Purchase_Price.Size = new System.Drawing.Size(254, 33);
            this.tb_Purchase_Price.TabIndex = 16;
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Name.Location = new System.Drawing.Point(459, 203);
            this.tb_Product_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Product_Name.MaxLength = 60;
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(254, 33);
            this.tb_Product_Name.TabIndex = 15;
            // 
            // tb_Product_ID
            // 
            this.tb_Product_ID.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_ID.Location = new System.Drawing.Point(459, 124);
            this.tb_Product_ID.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Product_ID.MaxLength = 7;
            this.tb_Product_ID.Name = "tb_Product_ID";
            this.tb_Product_ID.Size = new System.Drawing.Size(254, 33);
            this.tb_Product_ID.TabIndex = 1;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.DarkViolet;
            this.btn_Refresh.Location = new System.Drawing.Point(72, 430);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(121, 46);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.DarkViolet;
            this.btn_Logout.Location = new System.Drawing.Point(765, 13);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(85, 38);
            this.btn_Logout.TabIndex = 6;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_View_Products
            // 
            this.btn_View_Products.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_View_Products.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_View_Products.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_Products.ForeColor = System.Drawing.Color.DarkViolet;
            this.btn_View_Products.Location = new System.Drawing.Point(617, 430);
            this.btn_View_Products.Margin = new System.Windows.Forms.Padding(4);
            this.btn_View_Products.Name = "btn_View_Products";
            this.btn_View_Products.Size = new System.Drawing.Size(223, 46);
            this.btn_View_Products.TabIndex = 5;
            this.btn_View_Products.Text = "View All Products";
            this.btn_View_Products.UseVisualStyleBackColor = false;
            this.btn_View_Products.Click += new System.EventHandler(this.btn_View_Products_Click);
            // 
            // lbl_Product_ID
            // 
            this.lbl_Product_ID.AutoSize = true;
            this.lbl_Product_ID.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_Product_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Product_ID.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Product_ID.Location = new System.Drawing.Point(104, 128);
            this.lbl_Product_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Product_ID.Name = "lbl_Product_ID";
            this.lbl_Product_ID.Size = new System.Drawing.Size(131, 29);
            this.lbl_Product_ID.TabIndex = 12;
            this.lbl_Product_ID.Text = "Product ID";
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Product_Name.Location = new System.Drawing.Point(104, 207);
            this.lbl_Product_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(167, 29);
            this.lbl_Product_Name.TabIndex = 11;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // lbl_Search_Product
            // 
            this.lbl_Search_Product.AutoSize = true;
            this.lbl_Search_Product.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_Search_Product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Search_Product.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search_Product.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbl_Search_Product.Location = new System.Drawing.Point(248, 13);
            this.lbl_Search_Product.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Search_Product.Name = "lbl_Search_Product";
            this.lbl_Search_Product.Size = new System.Drawing.Size(350, 56);
            this.lbl_Search_Product.TabIndex = 10;
            this.lbl_Search_Product.Text = "Search Product";
            // 
            // lbl_Purchase_Price
            // 
            this.lbl_Purchase_Price.AutoSize = true;
            this.lbl_Purchase_Price.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_Purchase_Price.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purchase_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Purchase_Price.Location = new System.Drawing.Point(104, 284);
            this.lbl_Purchase_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Purchase_Price.Name = "lbl_Purchase_Price";
            this.lbl_Purchase_Price.Size = new System.Drawing.Size(172, 29);
            this.lbl_Purchase_Price.TabIndex = 9;
            this.lbl_Purchase_Price.Text = "Purchase Price";
            // 
            // lbl_Sales_Price
            // 
            this.lbl_Sales_Price.AutoSize = true;
            this.lbl_Sales_Price.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_Sales_Price.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sales_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Sales_Price.Location = new System.Drawing.Point(104, 364);
            this.lbl_Sales_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Sales_Price.Name = "lbl_Sales_Price";
            this.lbl_Sales_Price.Size = new System.Drawing.Size(128, 29);
            this.lbl_Sales_Price.TabIndex = 13;
            this.lbl_Sales_Price.Text = "Sales Price";
            // 
            // btn_Search
            // 
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btn_Search.Location = new System.Drawing.Point(753, 122);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(87, 35);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.Location = new System.Drawing.Point(486, 161);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(44, 20);
            this.lbl_Error.TabIndex = 23;
            this.lbl_Error.Text = "Error";
            this.lbl_Error.Visible = false;
            // 
            // btn_Add_New_Product
            // 
            this.btn_Add_New_Product.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Add_New_Product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add_New_Product.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Product.ForeColor = System.Drawing.Color.DarkViolet;
            this.btn_Add_New_Product.Location = new System.Drawing.Point(299, 430);
            this.btn_Add_New_Product.Name = "btn_Add_New_Product";
            this.btn_Add_New_Product.Size = new System.Drawing.Size(242, 46);
            this.btn_Add_New_Product.TabIndex = 4;
            this.btn_Add_New_Product.Text = "Add New Product";
            this.btn_Add_New_Product.UseVisualStyleBackColor = false;
            this.btn_Add_New_Product.Click += new System.EventHandler(this.btn_Add_New_Product_Click);
            // 
            // frm_Search_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 514);
            this.Controls.Add(this.btn_Add_New_Product);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Sales_Price);
            this.Controls.Add(this.tb_Purchase_Price);
            this.Controls.Add(this.tb_Product_Name);
            this.Controls.Add(this.tb_Product_ID);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_View_Products);
            this.Controls.Add(this.lbl_Product_ID);
            this.Controls.Add(this.lbl_Product_Name);
            this.Controls.Add(this.lbl_Search_Product);
            this.Controls.Add(this.lbl_Purchase_Price);
            this.Controls.Add(this.lbl_Sales_Price);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Search_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Sales_Price;
        private System.Windows.Forms.TextBox tb_Purchase_Price;
        private System.Windows.Forms.TextBox tb_Product_Name;
        private System.Windows.Forms.TextBox tb_Product_ID;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_View_Products;
        private System.Windows.Forms.Label lbl_Product_ID;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Label lbl_Search_Product;
        private System.Windows.Forms.Label lbl_Purchase_Price;
        private System.Windows.Forms.Label lbl_Sales_Price;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.Button btn_Add_New_Product;
    }
}