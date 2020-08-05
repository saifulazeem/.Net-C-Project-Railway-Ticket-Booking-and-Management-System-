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
    public partial class update_passengers : Form
    {
        string con_string = "Data Source=DESKTOP-7IPHAO9;Initial Catalog=RTRS;Integrated Security=True";
        string query;
        SqlCommand cmd = new SqlCommand();
        SqlConnection db_con = new SqlConnection();
        SqlDataAdapter adop = new SqlDataAdapter();
        DataTable dt_passengers_details = new DataTable();
        public update_passengers()
        {
            InitializeComponent();
        }

        private void update_passengers_Load(object sender, EventArgs e)
        {
            db_con.ConnectionString = con_string;
            db_con.Open();
            getting_passengers_details();
            dgv_passengers_details.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        private void getting_passengers_details()
        {
            query = "select * from only_passenger_data";
            cmd.Connection = db_con;
            cmd.CommandText = query;
            adop = new SqlDataAdapter(cmd);
            adop.Fill(dt_passengers_details);
            dgv_passengers_details.DataSource = dt_passengers_details;

        }
        private void modification()
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(adop);
            scb.ConflictOption = ConflictOption.OverwriteChanges;
            adop.Update(dt_passengers_details);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            modification();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_passengers_details_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
