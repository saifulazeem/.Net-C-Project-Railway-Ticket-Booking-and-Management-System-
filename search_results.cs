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
    public partial class search_results : Form
    {

        DataTable dt_search_rslt = new DataTable();
        string con_string = "Data Source=DESKTOP-7IPHAO9;Initial Catalog=RTRS;Integrated Security=True";
        SqlCommand cmd = new SqlCommand();
        SqlConnection db_con = new SqlConnection();
        SqlDataAdapter adop = new SqlDataAdapter();

        public search_results()
        {
            InitializeComponent();
        }

        private void search_results_Load(object sender, EventArgs e)
        {

            string qury1 = "select * from schedule where from_city=@from_c and to_city=@to_c and dept_date=@date_dept and Classes=@class";

            db_con.ConnectionString = con_string;
            db_con.Open();
            cmd.Connection = db_con;
            cmd.CommandText = qury1;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@from_c", Form1.cbx_from);
            cmd.Parameters.AddWithValue("@to_c",Form1.cbx_to);
            cmd.Parameters.AddWithValue("@date_dept", Form1.dept_date);
            cmd.Parameters.AddWithValue("@class", Form1.cbxx_class);




            adop = new SqlDataAdapter(cmd);
            adop.Fill(dt_search_rslt);

            dataGridView1.DataSource = dt_search_rslt;
            Btn_book();



        }

        private void Btn_book ()
        {
            DataGridViewButtonColumn book_btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(book_btn);
            book_btn.HeaderText = "Book Train";
            book_btn.Text = "Book";
            book_btn.UseColumnTextForButtonValue = true;

        }
        private void get_book_details()
        {

        }
        public static string selected_train,dept_date;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 12)
            {
                selected_train = dt_search_rslt.Rows[e.RowIndex]["Train_No"].ToString();
                dept_date = dt_search_rslt.Rows[e.RowIndex]["dept_date"].ToString();
                passenger_reservations p_r = new passenger_reservations();
                p_r.Show();
            }
            
            
        }
        
    }
}
