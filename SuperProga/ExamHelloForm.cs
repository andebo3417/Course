﻿using System;
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
    public partial class ExamHelloForm : Form
    {
        Form1 parent;
        public ExamHelloForm(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void BtnProceed_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new ExamForm("exam"));
        }
    }
}
