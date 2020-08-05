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
    public partial class Client_view : Form
    {
        public Client_view()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void Client_view_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            passenger_login p_l = new passenger_login();
            p_l.Show();
        }
    }
}
