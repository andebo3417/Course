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
        public Form1()
        {
            InitializeComponent();
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

        private void BtnTheme_Highlight(object sender, EventArgs e)
        {
            btnTheme.BackColor = Color.LightSlateGray;
            btnThemeText.BackColor = Color.LightSlateGray;
        }

        private void BtnTheme_HighlightRemove(object sender, EventArgs e)
        {
            btnTheme.BackColor = SystemColors.ActiveCaption;
            btnThemeText.BackColor = SystemColors.ActiveCaption;
        }

        private void BtnTicket_Highlight(object sender, EventArgs e)
        {
            btnTicket.BackColor = Color.LightSlateGray;
            btnTicketText.BackColor = Color.LightSlateGray;
        }

        private void BtnTicket_HighlightRemove(object sender, EventArgs e)
        {
            btnTicket.BackColor = SystemColors.ActiveCaption;
            btnTicketText.BackColor = SystemColors.ActiveCaption;
        }

        private void BtnMarathon_Highlight(object sender, EventArgs e)
        {
            btnMarathon.BackColor = Color.LightSlateGray;
            btnMarathonText.BackColor = Color.LightSlateGray;
        }

        private void BtnMarathon_HighlightRemove(object sender, EventArgs e)
        {
            btnMarathon.BackColor = SystemColors.ActiveCaption;
            btnMarathonText.BackColor = SystemColors.ActiveCaption;
        }

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
    }
}
