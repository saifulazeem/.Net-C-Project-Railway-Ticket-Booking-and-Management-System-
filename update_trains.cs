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
    public partial class update_trains : Form
        
    {
        string con_string = "Data Source=DESKTOP-7IPHAO9;Initial Catalog=RTRS;Integrated Security=True";
        string query;
        SqlCommand cmd = new SqlCommand();
        SqlConnection db_con = new SqlConnection();
        SqlDataAdapter adop = new SqlDataAdapter();
        DataTable dt_train_details = new DataTable();
        public update_trains()
        {
            InitializeComponent();
        }

        private void update_trains_Load(object sender, EventArgs e)
        {
            db_con.ConnectionString = con_string;
            db_con.Open();
            getting_train_details();
            dgv_train_details.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        private void getting_train_details()
        {
            query = "select * from schedule";
            cmd.Connection = db_con;
            cmd.CommandText = query;
            adop = new SqlDataAdapter(cmd);
            adop.Fill(dt_train_details);
            dgv_train_details.DataSource = dt_train_details;
            
        }
        private void modification()
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(adop);
            scb.ConflictOption = ConflictOption.OverwriteChanges;
            adop.Update(dt_train_details);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            modification();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_train_details_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
