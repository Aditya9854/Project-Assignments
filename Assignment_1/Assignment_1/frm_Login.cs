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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {

            if (tb_Username.Text == "Admin" && tb_Password.Text == "A123")
            {
                MessageBox.Show("Login Successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_Add_Product obj = new frm_Add_Product();

                obj.Show();
                this.Hide();

            }
            else
            {
                lbl_Note.Text = "Invalid Username or Password";
                lbl_Note.Visible = true;
                lbl_Note.ForeColor = Color.Red;
            }
            tb_Username.Clear();
            tb_Password.Clear();
            tb_Username.Focus();
        }

    }
}
