using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Assignment_1
{
    public partial class frm_Add_Product : Form
    {
        public frm_Add_Product()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Assignment_1_DB;Integrated Security=True;Pooling=False");

        void Con_Open()
        {
           if(Con.State != ConnectionState.Open)
           {
               Con.Open();
           }
           
        }
        void Con_Close()
        {
            if(Con.State != ConnectionState.Closed)
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
        
            Con_Open();

            if(tb_Product_ID.Text != "" && tb_Product_Name.Text != "" && tb_Purchase_Price.Text != "" && tb_Sales_Price.Text != "" )
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "Insert Into Product_Details values(@PID,@PName,@PPrice,@SPrice)";
                cmd.Connection = Con;

                cmd.Parameters.Add("PID",SqlDbType.Int).Value= tb_Product_ID.Text;
                cmd.Parameters.Add("PName",SqlDbType.VarChar).Value =tb_Product_Name.Text;
                cmd.Parameters.Add("PPrice",SqlDbType.Money).Value = tb_Purchase_Price.Text;
                cmd.Parameters.Add("SPrice",SqlDbType.Money).Value = tb_Sales_Price.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("First Fill All Fields","Incomplete Info",MessageBoxButtons.OK,MessageBoxIcon.Error);            
            }
            Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_View_All_Products_Click(object sender, EventArgs e)
        {
        
            frm_View_All_Products VAP = new frm_View_All_Products();

            VAP.Show();
            this.Hide();

        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
        
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();

        }

       


 
    }
}
