using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace SuperProga
{
    public partial class Form1 : Form
    {
        private bool MenuIsOpen = false;
        private Form activeForm = null;

        public Form1()
        {
            InitializeComponent();
            Question.createList();
        }

        //Menu show/hide
        private async void BtnMenu_Click(object sender, EventArgs e)
        {
            bool expectation = false;

            if (MenuIsOpen == true)
            {
                while (!expectation && panelMainMenu.Size.Width > 52)
                {
                    expectation = true;
                    await Task.Delay(1);
                    panelMainMenu.Size = new Size(panelMainMenu.Size.Width - panelMainMenu.Size.Width / 6 - 1, panelMainMenu.Size.Height);
                    expectation = false;
                }
                MenuIsOpen = false;
            }
            else
            {
                while (!expectation && panelMainMenu.Size.Width < 160)
                {
                    expectation = true;
                    await Task.Delay(1);
                    panelMainMenu.Size = new Size(panelMainMenu.Size.Width + (160 - panelMainMenu.Size.Width) / 5 + 1, panelMainMenu.Size.Height);
                    expectation = false;
                }
                MenuIsOpen = true;
            }
        }

        //Inner form show

        public void openChildForm(Form ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelInnerForm.Controls.Add(ChildForm);
            panelInnerForm.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
            activeForm = ChildForm;
        }

        private void OpenExamForm(object sender, EventArgs e)
        {
            openChildForm(new ExamHelloForm(this));
        }

        private void OpenTicketForm(object sender, EventArgs e)
        {
            openChildForm(new TicketHelloForm(this));
        }

        private void OpenThemeForm(object sender, EventArgs e)
        {
            openChildForm(new ThemeHelloForm(this));
        }

        private void OpenMarathonForm(object sender, EventArgs e)
        {
            openChildForm(new MarathonHelloForm(this));
        }

        private void OpenTheoryForm(object sender, EventArgs e)
        {
            openChildForm(new TheoryForm());
        }
    }
}
