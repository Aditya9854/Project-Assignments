using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class frm_View_All_Products : Form
    {
        public frm_View_All_Products()
        {
            InitializeComponent();
        }

        private void View_All_Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assignment_1_DBDataSet.Product_Details' table. You can move, or remove it, as needed.
            this.product_DetailsTableAdapter.Fill(this.assignment_1_DBDataSet.Product_Details);
            // TODO: This line of code loads data into the 'assignment_1_DBDataSet.Product_Details' table. You can move, or remove it, as needed.
           

        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            frm_Login Obj = new frm_Login();

            Obj.Show();
            this.Hide();
        }

        private void btn_Add_New_Product_Click(object sender, EventArgs e)
        {
            frm_Add_Product AP = new frm_Add_Product();

            AP.Show();
            this.Hide();

        }
    }
}
