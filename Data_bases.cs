using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Railways_Ticket_Reservation_System
{
    public partial class Data_bases : Form
    {
      
        public Data_bases()
        {
            InitializeComponent();
        }

        string con = "Data Source=DESKTOP-7IPHAO9;Initial Catalog=RTRS;Integrated Security=True";
        SqlCommand cmd = new SqlCommand();
        SqlConnection my_connection = new SqlConnection();
        Regstr reg = new Regstr();
        public static string u_name, u_email, u_pass;
        SqlDataAdapter adp = new SqlDataAdapter();
       public static  DataTable dt_info = new DataTable();


        private void con_fun()
        {
            dt_info.Rows.Clear();
            string qury = "select * from admin_info where Email='" + u_email + "' and Password='" + u_pass + "'";
            cmd.Connection = my_connection;
            cmd.CommandText = qury;
            adp = new SqlDataAdapter(cmd);
            adp.Fill(dt_info);

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            u_email = textBox1.Text;
            u_pass = textBox2.Text;
            con_fun();

            if (dt_info.Rows.Count > 0)
            {
                Admin_view a_v = new Admin_view();
                a_v.Show();

            }
            else
            {
                MessageBox.Show("Wrong User Name or Password", "Alert", MessageBoxButtons.RetryCancel);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Data_bases_Load(object sender, EventArgs e)
        {
            my_connection.ConnectionString = con;
            my_connection.Open();
            button2.Enabled = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reg.Show();
        }
    }
}
