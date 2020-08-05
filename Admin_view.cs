using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Railways_Ticket_Reservation_System
{
    public partial class Admin_view : Form
    {
        public Admin_view()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            schedual_add a_d = new schedual_add();
            a_d.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            update_trains u_t = new update_trains();
            u_t.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            update_passengers u_p = new update_passengers();
            u_p.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_view_Load(object sender, EventArgs e)
        {
            label1.Text = Data_bases.dt_info.Rows[0]["Name"].ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ticket_info t_i = new ticket_info();
            t_i.Show();
        }
    }
}
