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
    public partial class ticket_info : Form
    {
        string con_string = "Data Source=DESKTOP-7IPHAO9;Initial Catalog=RTRS;Integrated Security=True";
        string query;
        SqlCommand cmd = new SqlCommand();
        SqlConnection db_con = new SqlConnection();
        SqlDataAdapter adop = new SqlDataAdapter();
        DataTable dt_ticket = new DataTable();
        public ticket_info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            modification();
            this.Close();
        }
        private void modification()
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(adop);
            scb.ConflictOption = ConflictOption.OverwriteChanges;
            adop.Update(dt_ticket);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int click;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            click = e.RowIndex;
        }

        private void ticket_info_Load(object sender, EventArgs e)
        {
            db_con.ConnectionString = con_string;
            db_con.Open();
            getting_ticket_details();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DataSource = dt_ticket;
        }
        private void getting_ticket_details()
        {
            query = "select * from passenger_info";
            cmd.Connection = db_con;
            cmd.CommandText = query;
            adop = new SqlDataAdapter(cmd);
            adop.Fill(dt_ticket);
            dataGridView1.DataSource = dt_ticket;

        }
    }
}
