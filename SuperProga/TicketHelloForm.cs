using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperProga
{
    public partial class TicketHelloForm : Form
    {
        Form1 parent;
        public TicketHelloForm(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void TicketChoose_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string number = btn.Text;
            parent.openChildForm(new ExamForm("ticket", number));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
