using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Product_Management_System
{
    public partial class frm_View_All_Products : Form
    {
        public frm_View_All_Products()
        {
            InitializeComponent();
        }

        private void btn_Add_New_Product_Click(object sender, EventArgs e)
        {
            frm_Add_New_Product ANP = new frm_Add_New_Product();
            ANP.Show();
            this.Hide();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            frm_Login_Form Obj = new frm_Login_Form();
            Obj.Show();
            this.Hide();

        }

        private void frm_View_All_Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'product_Management_System_DBDataSet2.Product_Details' table. You can move, or remove it, as needed.
            this.product_DetailsTableAdapter.Fill(this.product_Management_System_DBDataSet2.Product_Details);

        }

       
    }
}
