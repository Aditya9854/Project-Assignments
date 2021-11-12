namespace Assignment_1
{
    partial class frm_Add_Product
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
            this.lbl_Add_New_Product = new System.Windows.Forms.Label();
            this.tb_Purchase_Price = new System.Windows.Forms.TextBox();
            this.tb_Product_ID = new System.Windows.Forms.TextBox();
            this.lbl_Purchase_Price = new System.Windows.Forms.Label();
            this.lbl_Product_ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Product_Name = new System.Windows.Forms.TextBox();
            this.lbl_Sales_Price = new System.Windows.Forms.Label();
            this.tb_Sales_Price = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_View_All_Products = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Add_New_Product
            // 
            this.lbl_Add_New_Product.AutoSize = true;
            this.lbl_Add_New_Product.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Product.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Add_New_Product.Location = new System.Drawing.Point(184, 12);
            this.lbl_Add_New_Product.Name = "lbl_Add_New_Product";
            this.lbl_Add_New_Product.Size = new System.Drawing.Size(401, 56);
            this.lbl_Add_New_Product.TabIndex = 1;
            this.lbl_Add_New_Product.Text = "Add New Product";
            // 
            // tb_Purchase_Price
            // 
            this.tb_Purchase_Price.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Purchase_Price.Location = new System.Drawing.Point(421, 205);
            this.tb_Purchase_Price.MaxLength = 9;
            this.tb_Purchase_Price.Name = "tb_Purchase_Price";
            this.tb_Purchase_Price.Size = new System.Drawing.Size(231, 29);
            this.tb_Purchase_Price.TabIndex = 3;
            // 
            // tb_Product_ID
            // 
            this.tb_Product_ID.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_ID.Location = new System.Drawing.Point(421, 93);
            this.tb_Product_ID.MaxLength = 9;
            this.tb_Product_ID.Name = "tb_Product_ID";
            this.tb_Product_ID.Size = new System.Drawing.Size(231, 29);
            this.tb_Product_ID.TabIndex = 1;
            this.tb_Product_ID.Tag = "";
            // 
            // lbl_Purchase_Price
            // 
            this.lbl_Purchase_Price.AutoSize = true;
            this.lbl_Purchase_Price.BackColor = System.Drawing.Color.White;
            this.lbl_Purchase_Price.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purchase_Price.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Purchase_Price.Location = new System.Drawing.Point(94, 206);
            this.lbl_Purchase_Price.Name = "lbl_Purchase_Price";
            this.lbl_Purchase_Price.Size = new System.Drawing.Size(172, 29);
            this.lbl_Purchase_Price.TabIndex = 3;
            this.lbl_Purchase_Price.Text = "Purchase Price";
            // 
            // lbl_Product_ID
            // 
            this.lbl_Product_ID.AutoSize = true;
            this.lbl_Product_ID.BackColor = System.Drawing.Color.White;
            this.lbl_Product_ID.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_ID.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Product_ID.Location = new System.Drawing.Point(94, 93);
            this.lbl_Product_ID.Name = "lbl_Product_ID";
            this.lbl_Product_ID.Size = new System.Drawing.Size(131, 29);
            this.lbl_Product_ID.TabIndex = 4;
            this.lbl_Product_ID.Text = "Product ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(94, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product Name";
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Name.Location = new System.Drawing.Point(421, 152);
            this.tb_Product_Name.MaxLength = 120;
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(231, 29);
            this.tb_Product_Name.TabIndex = 2;
            // 
            // lbl_Sales_Price
            // 
            this.lbl_Sales_Price.AutoSize = true;
            this.lbl_Sales_Price.BackColor = System.Drawing.Color.White;
            this.lbl_Sales_Price.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sales_Price.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Sales_Price.Location = new System.Drawing.Point(94, 264);
            this.lbl_Sales_Price.Name = "lbl_Sales_Price";
            this.lbl_Sales_Price.Size = new System.Drawing.Size(128, 29);
            this.lbl_Sales_Price.TabIndex = 3;
            this.lbl_Sales_Price.Text = "Sales Price";
            // 
            // tb_Sales_Price
            // 
            this.tb_Sales_Price.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sales_Price.Location = new System.Drawing.Point(419, 263);
            this.tb_Sales_Price.MaxLength = 9;
            this.tb_Sales_Price.Name = "tb_Sales_Price";
            this.tb_Sales_Price.Size = new System.Drawing.Size(231, 29);
            this.tb_Sales_Price.TabIndex = 4;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Black;
            this.btn_Save.Location = new System.Drawing.Point(308, 356);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(89, 44);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LogOut.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.Red;
            this.btn_LogOut.Location = new System.Drawing.Point(674, 12);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(75, 29);
            this.btn_LogOut.TabIndex = 7;
            this.btn_LogOut.Text = "LogOut";
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Black;
            this.btn_Refresh.Location = new System.Drawing.Point(64, 356);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(102, 44);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_View_All_Products
            // 
            this.btn_View_All_Products.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_View_All_Products.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_View_All_Products.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_All_Products.ForeColor = System.Drawing.Color.Black;
            this.btn_View_All_Products.Location = new System.Drawing.Point(499, 356);
            this.btn_View_All_Products.Name = "btn_View_All_Products";
            this.btn_View_All_Products.Size = new System.Drawing.Size(208, 44);
            this.btn_View_All_Products.TabIndex = 7;
            this.btn_View_All_Products.Text = "View All Products";
            this.btn_View_All_Products.UseVisualStyleBackColor = false;
            this.btn_View_All_Products.Click += new System.EventHandler(this.btn_View_All_Products_Click);
            // 
            // frm_Add_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 425);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_View_All_Products);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Product_Name);
            this.Controls.Add(this.tb_Sales_Price);
            this.Controls.Add(this.tb_Purchase_Price);
            this.Controls.Add(this.tb_Product_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Sales_Price);
            this.Controls.Add(this.lbl_Purchase_Price);
            this.Controls.Add(this.lbl_Product_ID);
            this.Controls.Add(this.lbl_Add_New_Product);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_New_Product;
        private System.Windows.Forms.TextBox tb_Purchase_Price;
        private System.Windows.Forms.TextBox tb_Product_ID;
        private System.Windows.Forms.Label lbl_Purchase_Price;
        private System.Windows.Forms.Label lbl_Product_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Product_Name;
        private System.Windows.Forms.Label lbl_Sales_Price;
        private System.Windows.Forms.TextBox tb_Sales_Price;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_View_All_Products;
    }
}