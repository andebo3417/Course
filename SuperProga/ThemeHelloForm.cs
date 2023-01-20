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
    public partial class ThemeHelloForm : Form
    {
        Form1 parent;
        public ThemeHelloForm(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void ThemeChoose_Click(object sender, EventArgs e)
        {
            Label btn = sender as Label;
            string theme = btn.Name;
            switch (theme)
            {
                case "lblTheme1":
                    parent.openChildForm(new ExamForm("theme", "theme1"));
                    break;
                case "lblTheme2":
                    parent.openChildForm(new ExamForm("theme", "theme2"));
                    break;
            }
        }
    }
}
