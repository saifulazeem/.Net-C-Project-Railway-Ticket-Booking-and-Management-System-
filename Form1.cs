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
    public partial class Form1 : Form
    {


        string con_string = "Data Source=DESKTOP-7IPHAO9;Initial Catalog=RTRS;Integrated Security=True";

        SqlCommand cmd = new SqlCommand();
        SqlConnection db_con = new SqlConnection();
        SqlDataAdapter adop = new SqlDataAdapter();
        DataTable dt_schedual = new DataTable();
        


        public Form1()
        {
            InitializeComponent();
        }

        public static string cbx_from, cbx_to, cbxx_class, dept_date, return_date, oneway_chk, round_chk;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            cbx_from = cbx_from_city.Text;
            cbx_to = cbx_to_city.Text;
            cbxx_class = cbx_class.Text;
            dept_date = Dept_dt_pick.Value.ToString("dd-MMM-yy");
            return_date = Return_dt_pick.Value.ToString("dd-MMM-yy");
            search_results srch_rslt = new search_results();
            srch_rslt.Show();

        }

        private void chk_round_CheckedChanged(object sender, EventArgs e)
        {
            Return_dt_pick.Enabled = true;
        }

        private void chk_oneway_CheckedChanged(object sender, EventArgs e)
        {
            Return_dt_pick.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db_con.ConnectionString = con_string;
            db_con.Open();

            
            
            if(chk_oneway.Checked)
            {
               
                chk_oneway.Text = "Oneway";
            }
            
            if(chk_round.Checked)
            {
                chk_round.Text = "Round";
                Return_dt_pick.Enabled = true;
            }

            string qury1= "select * from schedule ";
            cmd.CommandText = qury1;
            cmd.Connection = db_con;
            adop = new SqlDataAdapter(cmd);
            adop.Fill(dt_schedual);

            if (dt_schedual.Rows.Count > 0)

            {
              
                cbx_from_city.DataSource = dt_schedual;

                cbx_from_city.DisplayMember = "from_city";

                cbx_to_city.DataSource = dt_schedual;
                cbx_to_city.DisplayMember = "to_city";

                cbx_class.DataSource = dt_schedual;
                cbx_class.DisplayMember = "Classes";

            }

        }
    }
}
