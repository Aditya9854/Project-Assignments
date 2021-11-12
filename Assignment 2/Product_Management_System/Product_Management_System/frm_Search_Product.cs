using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Product_Management_System
{
    public partial class frm_Search_Product : Form
    {
        public frm_Search_Product()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Product_Management_System_DB;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }
        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }
        void Clear_Controls()
        {
            tb_Product_ID.Clear();
            tb_Product_Name.Clear();
            tb_Purchase_Price.Clear();
            tb_Sales_Price.Clear();

            tb_Product_ID.Focus();

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            Con_Open();

            if (tb_Product_ID.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Select * From Product_Details Where Product_ID = @PID";

                Cmd.Parameters.Add("PID", SqlDbType.Int).Value = tb_Product_ID.Text;

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Product_Name.Text = Dr.GetString(Dr.GetOrdinal("Product_Name"));
                    tb_Purchase_Price.Text = (Dr["Purchase_Price"].ToString());
                    tb_Sales_Price.Text = (Dr["Sales_Price"].ToString());

                }
                else
                {
                    MessageBox.Show("Invalid Product ID ", "No Record Found ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    tb_Product_ID.Clear();
                    tb_Product_ID.Focus();
                }

                lbl_Error.Visible = false;
            }
            else
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "First Fill Product ID";
                lbl_Error.ForeColor = Color.Red;

                tb_Product_ID.Focus();

            }
            Con_Close();
        }
       

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login_Form Obj = new frm_Login_Form();

            Obj.Show();
            this.Hide();

        }

        private void btn_View_Products_Click(object sender, EventArgs e)
        {
            frm_View_All_Products VAP = new frm_View_All_Products();

            VAP.Show();
            this.Hide();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Add_New_Product_Click(object sender, EventArgs e)
        {
            frm_Add_New_Product ANP = new frm_Add_New_Product();

            ANP.Show();
            this.Hide();
        }


    }
}
