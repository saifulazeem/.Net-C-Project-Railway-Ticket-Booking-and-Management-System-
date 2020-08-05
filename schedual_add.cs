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
    public partial class schedual_add : Form
    {


        string con_string = "Data Source=DESKTOP-7IPHAO9;Initial Catalog=RTRS;Integrated Security=True";

        SqlCommand cmd = new SqlCommand();
        SqlConnection db_con = new SqlConnection();
        SqlDataAdapter adop = new SqlDataAdapter();

        public static string c_from, c_to, t_name, t_fare, t_dept_date, t_dept_time, t_durration, t_stops, t_classes,t_arrival,t_number;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public schedual_add()
        {
            InitializeComponent();
        }

        private void schedual_add_Load(object sender, EventArgs e)
        {
            db_con.ConnectionString = con_string;
            db_con.Open();
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            c_from = tbx_from_city.Text;
            c_to = tbx_to_city.Text;
            t_classes = tbx_classes.Text;
            t_dept_date = tbx_dept_date.Text;
            t_dept_time = tbx_dept_time.Text;
            t_fare = tbx_fares.Text;
            t_name = tbx_train_name.Text;
            t_durration = tbx_durration.Text;
            t_stops = tbx_stops.Text;
            t_arrival = tbx_arrival.Text;
            t_number = tbx_train_no.Text;



            string qury1 = "INSERT into schedule(from_city,to_city,dept_date,dept_time,stops,Durration,Classes,Train_Name,fares,Train_No,Arrival_Time) values(@from_city,@to_city,@dept_date,@dept_time,@t_stops,@t_durration,@t_classes,@t_train_name,@t_fares,@t_number,@t_arrival)";
            cmd.CommandText = qury1;
            cmd.Connection = db_con;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@from_city", c_from);
            cmd.Parameters.AddWithValue("@to_city", c_to);
            cmd.Parameters.AddWithValue("@dept_date", t_dept_date);
            cmd.Parameters.AddWithValue("@dept_time", t_dept_time);
            cmd.Parameters.AddWithValue("@t_stops", t_stops);
            cmd.Parameters.AddWithValue("@t_durration", t_durration);
            cmd.Parameters.AddWithValue("@t_classes", t_classes);
            cmd.Parameters.AddWithValue("@t_train_name", t_name);
            cmd.Parameters.AddWithValue("@t_fares", t_fare);
            cmd.Parameters.AddWithValue("@t_number", t_number);
            cmd.Parameters.AddWithValue("@t_arrival", t_arrival);
            

            int rows= cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show(rows + " added");
            }
        }
    }
}
