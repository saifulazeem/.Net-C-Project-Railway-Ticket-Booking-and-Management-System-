using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Railways_Ticket_Reservation_System
{
    public partial class passenger_login : Form
    {
        string con_string = "Data Source=DESKTOP-7IPHAO9;Initial Catalog=RTRS;Integrated Security=True";
        string query;
        SqlCommand cmd = new SqlCommand();
        SqlConnection db_con = new SqlConnection();
        SqlDataAdapter adop = new SqlDataAdapter();
        DataTable dt_ticket = new DataTable();
        public passenger_login()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            dt_ticket.Rows.Clear();
            dataGridView1.DataSource = dt_ticket;
            string cnic = textBox1.Text;
            query = "select * from passenger_info where p_cnic=@cnic";
            cmd.CommandText = query;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@cnic",cnic);
            adop = new SqlDataAdapter(cmd);
            adop.Fill(dt_ticket);
            dataGridView1.DataSource = dt_ticket;
        }

        private void passenger_login_Load(object sender, EventArgs e)
        {
            db_con.ConnectionString = con_string;
            db_con.Open();
            cmd.Connection = db_con;
            dataGridView1.DataSource = dt_ticket;

        }
    }
}
