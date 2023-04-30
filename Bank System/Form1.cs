using System;
using System.Data;
using System.Data.SqlClient;


namespace Bank_System

{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\querc\source\repos\Bank System\Bank System\Database1.mdf"";Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Bank", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Bank "
                + "values(" + txtId.Text + " , '" + txtName.Text + "','" + txtAddress.Text + "' , " + txtBalance.Text + ")", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Bank SET [Customer Name] = '" + txtName.Text + "', " +
                " Balance =  " + txtBalance.Text + " WHERE [Customer ID] = " + txtId.Text, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Bank WHERE [Customer ID] = " + txtId.Text, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}