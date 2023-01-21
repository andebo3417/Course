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
    public partial class TheoryForm : Form
    {

        public TheoryForm()
        {
            InitializeComponent();
            panelTheory.Location = new Point(0, 0);
        }

        private void Label_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            string number = label.Text[0].ToString() + label.Text[1];
            if (number[1] == '.') number = number.Remove(1, 1);
            rtbTheory.Text = Question.theoryList[int.Parse(number) - 1].theory;
            this.panelTheory.Visible = true;
            this.panelTheory.BringToFront();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.panelTheory.Visible = false;
            this.panelPars.BringToFront();
        }
    }
}
