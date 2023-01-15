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
    public partial class Form1 : Form
    {
        private bool MenuIsOpen = true;
        public Form1()
        {
            InitializeComponent();
        }

        //Menu buttons highlight
        private void PanelMenu_Highlight(object sender, EventArgs e)
        {
            panel_menu.BackColor = Color.LightSlateGray;
            btnMenu.BackColor = Color.LightSlateGray;
        }

        private void PanelMenu_HighlightRemove(object sender, EventArgs e)
        {
            panel_menu.BackColor = SystemColors.ActiveCaption;
            btnMenu.BackColor = SystemColors.ActiveCaption;
        }

        private void BtnExam_Highlight(object sender, EventArgs e)
        {
            btnExam.BackColor = Color.LightSlateGray;
            btnExamText.BackColor = Color.LightSlateGray;
            panelExam.BackColor = Color.LightSlateGray;
        }

        private void BtnExam_HighlightRemove(object sender, EventArgs e)
        {
            btnExam.BackColor = SystemColors.ActiveCaption;
            btnExamText.BackColor = SystemColors.ActiveCaption;
            panelExam.BackColor = Color.Transparent;
        }

        private void BtnTicket_Highlight(object sender, EventArgs e)
        {
            btnTicket.BackColor = Color.LightSlateGray;
            btnTicketText.BackColor = Color.LightSlateGray;
            panelTicket.BackColor = Color.LightSlateGray;
        }

        private void BtnTicket_HighlightRemove(object sender, EventArgs e)
        {
            btnTicket.BackColor = SystemColors.ActiveCaption;
            btnTicketText.BackColor = SystemColors.ActiveCaption;
            panelTicket.BackColor = SystemColors.ActiveCaption;
        }

        private void BtnTheme_Highlight(object sender, EventArgs e)
        {
            btnTheme.BackColor = Color.LightSlateGray;
            btnThemeText.BackColor = Color.LightSlateGray;
            panelTheme.BackColor = Color.LightSlateGray;
        }

        private void BtnTheme_HighlightRemove(object sender, EventArgs e)
        {
            btnTheme.BackColor = SystemColors.ActiveCaption;
            btnThemeText.BackColor = SystemColors.ActiveCaption;
            panelTheme.BackColor = SystemColors.ActiveCaption;
        }

        private void BtnMarathon_Highlight(object sender, EventArgs e)
        {
            btnMarathon.BackColor = Color.LightSlateGray;
            btnMarathonText.BackColor = Color.LightSlateGray;
            panelMarathon.BackColor = Color.LightSlateGray;
        }

        private void BtnMarathon_HighlightRemove(object sender, EventArgs e)
        {
            btnMarathon.BackColor = SystemColors.ActiveCaption;
            btnMarathonText.BackColor = SystemColors.ActiveCaption;
            panelMarathon.BackColor = SystemColors.ActiveCaption;
        }

        private void BtnTheory_Highlight(object sender, EventArgs e)
        {
            btnTheory.BackColor = Color.LightSlateGray;
            btnTheoryText.BackColor = Color.LightSlateGray;
            panelTheory.BackColor = Color.LightSlateGray;
        }

        private void BtnTheory_HighlightRemove(object sender, EventArgs e)
        {
            btnTheory.BackColor = SystemColors.ActiveCaption;
            btnTheoryText.BackColor = SystemColors.ActiveCaption;
            panelTheory.BackColor = SystemColors.ActiveCaption;
        }

        //Menu show/hide
        private async void BtnMenu_Click(object sender, EventArgs e)
        {
            bool expectation = false;

            if (MenuIsOpen == true)
            {
                while (!expectation && panelMainMenu.Size.Width > 54)
                {
                    expectation = true;
                    await Task.Delay(1);
                    panelMainMenu.Size = new Size(panelMainMenu.Size.Width - panelMainMenu.Size.Width / 5 - 1, panelMainMenu.Size.Height);
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
                    panelMainMenu.Size = new Size(panelMainMenu.Size.Width + (160 - panelMainMenu.Size.Width) / 8 + 1, panelMainMenu.Size.Height);
                    expectation = false;
                }
                MenuIsOpen = true;
            }
        }

        private void test(object sender, EventArgs e)
        {
            MessageBox.Show("123");
        }
    }
}
