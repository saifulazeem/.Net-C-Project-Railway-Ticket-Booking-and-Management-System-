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

namespace Railways_Ticket_Reservation_System
{
    public partial class passenger_reservations : Form
    {
        public static string p_fname, p_lname, p_cnic,p_mobile, query;
        string con_string = "Data Source=DESKTOP-7IPHAO9;Initial Catalog=RTRS;Integrated Security=True";
        SqlDataAdapter adp;
        DataTable dt_check = new DataTable();
        int no;
        private void button1_Click(object sender, EventArgs e)
        {
            p_fname = fname.Text;
            p_lname = lname.Text;
            p_cnic = cnic.Text;
            p_mobile = mobile.Text;
            check_user();
            if (dt_check.Rows.Count > 0)
            {
                ticket();
                if (no > 0)
                {
                    DialogResult dr = MessageBox.Show("Train booked! view ticket information now.", "Message", MessageBoxButtons.OK);
                    if (dr == DialogResult.OK)
                    {
                        passenger_login p_t = new passenger_login();
                        p_t.Show();
                    }
                }
                else
                {
                    MessageBox.Show("There is some error booking the train.");
                }
            }
            else
            {
                passenger();
                ticket();
                if (no > 0)
                {
                    DialogResult dr = MessageBox.Show("Train booked! view ticket information now.", "Message", MessageBoxButtons.OK);
                    if (dr == DialogResult.OK)
                    {
                        passenger_login p_t = new passenger_login();
                        p_t.Show();
                    }
                }
                else
                {
                    MessageBox.Show("There is some error booking the train.");
                }
            }
        }
        public void check_user()
        {
            dt_check.Rows.Clear();
            query = "";
            query = "select * from only_passenger_data where CNIC=@cnic or Mobile=@mobile";
            cmd.CommandText = query;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@cnic", p_cnic);
            cmd.Parameters.AddWithValue("@mobile", p_mobile);
            adp = new SqlDataAdapter(cmd);
            adp.Fill(dt_check);
        }
        public void passenger()
        {
            query = "";
            query = "insert into only_passenger_data(Name,CNIC,Mobile)values(@fname,@cnic,@mobile)";
            cmd.CommandText = query;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@fname", p_fname + " " + p_lname);
            cmd.Parameters.AddWithValue("@cnic", p_cnic);
            cmd.Parameters.AddWithValue("@mobile", p_mobile);
            int no1 = cmd.ExecuteNonQuery();
            

            //query = "insert into passenger_info(p_fname,p_lname,p_cnic,p_mobile,Train_No,dept_date)values(@fname,@lname,@cnic,@mobile,@train_no,@dept_date)";
            //cmd.CommandText = query;
            //txt_train_no.Text = search_results.selected_train;
            //txt_dpt_date.Text = search_results.dept_date;
            //cmd.Parameters.Clear();
            //cmd.Parameters.AddWithValue("@fname", p_fname);
            //cmd.Parameters.AddWithValue("@lname", p_lname);
            //cmd.Parameters.AddWithValue("@cnic", p_cnic);
            //cmd.Parameters.AddWithValue("@mobile", p_mobile);
            //cmd.Parameters.AddWithValue("@train_no", txt_train_no.Text);
            //cmd.Parameters.AddWithValue("@dept_date", txt_dpt_date.Text);
            //no = cmd.ExecuteNonQuery();
            //if (no > 0)
            //{
            //    DialogResult dr = MessageBox.Show("Train booked! view ticket information now.", "Message", MessageBoxButtons.OK);
            //    if (dr == DialogResult.OK)
            //    {
            //        passenger_login p_t = new passenger_login();
            //        p_t.Show();
            //    }
            //}
        }
        public void ticket()
        {
            query = "insert into passenger_info(p_fname,p_lname,p_cnic,p_mobile,Train_No,dept_date)values(@fname,@lname,@cnic,@mobile,@train_no,@dept_date)";
            cmd.CommandText = query;
            txt_train_no.Text = search_results.selected_train;
            txt_dpt_date.Text = search_results.dept_date;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@fname", p_fname);
            cmd.Parameters.AddWithValue("@lname", p_lname);
            cmd.Parameters.AddWithValue("@cnic", p_cnic);
            cmd.Parameters.AddWithValue("@mobile", p_mobile);
            cmd.Parameters.AddWithValue("@train_no", txt_train_no.Text);
            cmd.Parameters.AddWithValue("@dept_date", txt_dpt_date.Text);
            no = cmd.ExecuteNonQuery();
        }
        private void txt_train_no_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SqlCommand cmd = new SqlCommand();
        SqlConnection db_con = new SqlConnection();
        public passenger_reservations()
        {
            InitializeComponent();
        }

        private void passenger_reservations_Load(object sender, EventArgs e)
        {
            db_con.ConnectionString = con_string;
            db_con.Open();
            cmd.Connection = db_con;
            txt_train_no.Text = search_results.selected_train;
            txt_dpt_date.Text = search_results.dept_date;
            txt_dpt_date.Enabled = false;
            txt_train_no.Enabled = false;
        }
    }
}
