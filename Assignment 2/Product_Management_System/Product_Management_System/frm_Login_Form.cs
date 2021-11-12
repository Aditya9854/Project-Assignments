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
    public partial class frm_Login_Form : Form
    {
        public frm_Login_Form()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Product_Management_System_DB;Integrated Security=True");

        void Con_Open()
        {
            if(con.State != ConnectionState.Open)
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

        private void frm_Login_Form_Load(object sender, EventArgs e)
        {
            lbl_Note.Text = "Enter Username && Password";
            lbl_Note.ForeColor = Color.Red;
            lbl_Note.Visible = true;
            tb_Username.Focus();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            int Cnt = 0;

            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = con;
            Cmd.CommandText = "Select Count(*)From Login_Details where Username = @Uname And Password = @Pwd";

            Cmd.Parameters.Add("@Uname", SqlDbType.VarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("@Pwd", SqlDbType.NVarChar).Value = tb_Password.Text;

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                MessageBox.Show("Welcome", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_Add_New_Product ANP = new frm_Add_New_Product();
                ANP.Show();
                this.Hide();
            }
            else
            {
                lbl_Note.Text = "Invalid Username or Password";
                lbl_Note.ForeColor = Color.Red;
                           
            }

            tb_Username.Clear();
            tb_Password.Clear();
            tb_Username.Focus();

            Con_Close();
          
        }

    }
}
