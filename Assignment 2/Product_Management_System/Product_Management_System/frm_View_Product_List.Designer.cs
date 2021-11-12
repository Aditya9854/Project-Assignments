namespace Product_Management_System
{
    partial class frm_View_Product_List
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
            this.lbl_View_Product_List = new System.Windows.Forms.Label();
            this.btn_Add_New_Product = new System.Windows.Forms.Button();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_View_Product_List
            // 
            this.lbl_View_Product_List.AutoSize = true;
            this.lbl_View_Product_List.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_View_Product_List.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Product_List.ForeColor = System.Drawing.Color.Red;
            this.lbl_View_Product_List.Location = new System.Drawing.Point(213, 19);
            this.lbl_View_Product_List.Name = "lbl_View_Product_List";
            this.lbl_View_Product_List.Size = new System.Drawing.Size(403, 56);
            this.lbl_View_Product_List.TabIndex = 0;
            this.lbl_View_Product_List.Text = "View Product List";
            // 
            // btn_Add_New_Product
            // 
            this.btn_Add_New_Product.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Add_New_Product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add_New_Product.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Product.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Add_New_Product.Location = new System.Drawing.Point(312, 409);
            this.btn_Add_New_Product.Name = "btn_Add_New_Product";
            this.btn_Add_New_Product.Size = new System.Drawing.Size(213, 45);
            this.btn_Add_New_Product.TabIndex = 1;
            this.btn_Add_New_Product.Text = "Add New Product";
            this.btn_Add_New_Product.UseVisualStyleBackColor = false;
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Log_Out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Log_Out.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Red;
            this.btn_Log_Out.Location = new System.Drawing.Point(765, 12);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(86, 33);
            this.btn_Log_Out.TabIndex = 2;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(83, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // frm_View_Product_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 478);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.btn_Add_New_Product);
            this.Controls.Add(this.lbl_View_Product_List);
            this.Name = "frm_View_Product_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Product List";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_Product_List;
        private System.Windows.Forms.Button btn_Add_New_Product;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}