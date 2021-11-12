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
    public partial class frm_Add_New_Product : Form
    {
        public frm_Add_New_Product()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Product_Management_System_DB;Integrated Security=True");

        void Con_Open()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }
        void Con_Close()
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
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
        void Auto_Increment()
        {
            Con_Open();
            int Cnt = -1;

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con;

            Cmd.CommandText = "Select Count(*) From Product_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = con;
                Cmd.CommandText = "Select Max(Product_ID) From Product_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;

            }
            else
            {
                Cnt = 100;

            }
            Con_Close();

        }
        private void frm_Add_New_Product_Load(object sender, EventArgs e)
        {
            Auto_Increment();
        }

        private void btn_View_Products_Click(object sender, EventArgs e)
        {
            frm_View_All_Products VAP = new frm_View_All_Products();
            VAP.Show();
            this.Hide();
        }
        
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login_Form obj = new frm_Login_Form();
            obj.Show();
            this.Hide();
        }
        private void btn_Search_Products_Click(object sender, EventArgs e)
        {
            frm_Search_Product SP = new frm_Search_Product();
            SP.Show();
            this.Hide();

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Product_ID.Text != "" && tb_Product_Name.Text != "" && tb_Purchase_Price.Text != "" && tb_Sales_Price.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.CommandText = "Insert Into Product_Details values(@PID,@PName,@PPrice,@SPrice)";

                Cmd.Connection = con;

                Cmd.Parameters.Add("PID", SqlDbType.Int).Value = tb_Product_ID.Text;
                Cmd.Parameters.Add("PName", SqlDbType.VarChar).Value = tb_Product_Name.Text;
                Cmd.Parameters.Add("PPrice", SqlDbType.Money).Value = tb_Purchase_Price.Text;
                Cmd.Parameters.Add("SPrice", SqlDbType.Money).Value = tb_Sales_Price.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Rrecord Inserted Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();

            }
            else
            {
                MessageBox.Show("First Fill All Fields ", "incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con_Close();

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();

        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Is_Letter(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void Is_Amount(object sender, KeyPressEventArgs e)
        {

            if(!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.'))) 
            {

                e.Handled = true;

            }
            
         }

       
    }
}
