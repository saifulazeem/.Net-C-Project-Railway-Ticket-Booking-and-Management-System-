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
    public partial class Regstr : Form
    {
        public Regstr()
        {
            InitializeComponent();
        }

        string con = "Data Source=DESKTOP-7IPHAO9;Initial Catalog=RTRS;Integrated Security=True";
        SqlCommand cmd = new SqlCommand();
        SqlConnection my_connection = new SqlConnection();
        //Regstr reg = new Regstr();
        //Data_bases sgn_in = new Data_bases();
        SqlDataAdapter adop = new SqlDataAdapter();
        DataTable db_user = new DataTable();
        public static string u_name, u_email, u_pass;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Regstr_Load(object sender, EventArgs e)
        {
            my_connection.ConnectionString = con;
            my_connection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            u_email = textBox2.Text;
            string querry = "select * from admin_info where Email='" + u_email + "'";
            cmd.Connection = my_connection;

            cmd.CommandText = querry;
             adop = new SqlDataAdapter(cmd);
           
            adop.Fill(db_user);

            if(db_user.Rows.Count>0)
            {
              DialogResult dr=  MessageBox.Show( "Email" + textBox2.Text + "Already Exist", "Message", MessageBoxButtons.RetryCancel);
                if(dr==DialogResult.Retry)
                {
                  //  reg.Show();
                }
            }
            else if(textBox3.Text==textBox4.Text)
            {
                u_name = textBox1.Text;
                u_pass = textBox3.Text;
                string que = "Insert into admin_info(Name,Email,Password) values('"+u_name+"','"+u_email+"','"+u_pass+"')";

                cmd.Connection = my_connection;
                cmd.CommandText = que;
                cmd.ExecuteNonQuery();
               DialogResult dr= MessageBox.Show( "Account Created! Login now. ", "Message",MessageBoxButtons.OK);
                if(dr==DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show( "Passward Dont Match Exist","Warning", MessageBoxButtons.RetryCancel);
                if (dr == DialogResult.Retry)
                {
                  //  reg.Show();
                }
            }


        }
    }
}
