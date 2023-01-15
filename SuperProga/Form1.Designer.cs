namespace SuperProga
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMarathonText = new System.Windows.Forms.Button();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnThemeText = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnTicketText = new System.Windows.Forms.Button();
            this.btnMarathon = new System.Windows.Forms.Button();
            this.btnExamText = new System.Windows.Forms.Button();
            this.btnTheme = new System.Windows.Forms.Button();
            this.btnExam = new System.Windows.Forms.Button();
            this.panelExam = new System.Windows.Forms.Panel();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.panelTicket = new System.Windows.Forms.Panel();
            this.panelTheme = new System.Windows.Forms.Panel();
            this.panelMarathon = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelTicket.SuspendLayout();
            this.panelTheme.SuspendLayout();
            this.panelMarathon.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panelMarathon);
            this.panel1.Controls.Add(this.panelTheme);
            this.panel1.Controls.Add(this.panelTicket);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.btnExamText);
            this.panel1.Controls.Add(this.btnExam);
            this.panel1.Controls.Add(this.panelExam);
            this.panel1.Controls.Add(this.panel_menu);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 451);
            this.panel1.TabIndex = 0;
            // 
            // btnMarathonText
            // 
            this.btnMarathonText.BackColor = System.Drawing.Color.Transparent;
            this.btnMarathonText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMarathonText.FlatAppearance.BorderSize = 0;
            this.btnMarathonText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnMarathonText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarathonText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMarathonText.Location = new System.Drawing.Point(42, 14);
            this.btnMarathonText.Name = "btnMarathonText";
            this.btnMarathonText.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnMarathonText.Size = new System.Drawing.Size(109, 35);
            this.btnMarathonText.TabIndex = 5;
            this.btnMarathonText.Text = "Марафон";
            this.btnMarathonText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarathonText.UseVisualStyleBackColor = false;
            this.btnMarathonText.MouseEnter += new System.EventHandler(this.BtnMarathon_Highlight);
            this.btnMarathonText.MouseLeave += new System.EventHandler(this.BtnMarathon_HighlightRemove);
            // 
            // btnTicket
            // 
            this.btnTicket.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTicket.BackgroundImage = global::SuperProga.Properties.Resources.ticket;
            this.btnTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTicket.FlatAppearance.BorderSize = 0;
            this.btnTicket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicket.Location = new System.Drawing.Point(7, 5);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(35, 35);
            this.btnTicket.TabIndex = 1;
            this.btnTicket.UseVisualStyleBackColor = false;
            this.btnTicket.MouseEnter += new System.EventHandler(this.BtnTicket_Highlight);
            this.btnTicket.MouseLeave += new System.EventHandler(this.BtnTicket_HighlightRemove);
            // 
            // btnThemeText
            // 
            this.btnThemeText.BackColor = System.Drawing.Color.Transparent;
            this.btnThemeText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemeText.FlatAppearance.BorderSize = 0;
            this.btnThemeText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnThemeText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnThemeText.Location = new System.Drawing.Point(42, 12);
            this.btnThemeText.Name = "btnThemeText";
            this.btnThemeText.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnThemeText.Size = new System.Drawing.Size(109, 35);
            this.btnThemeText.TabIndex = 4;
            this.btnThemeText.Text = "По темам";
            this.btnThemeText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemeText.UseVisualStyleBackColor = false;
            this.btnThemeText.MouseEnter += new System.EventHandler(this.BtnTheme_Highlight);
            this.btnThemeText.MouseLeave += new System.EventHandler(this.BtnTheme_HighlightRemove);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenu.BackgroundImage")));
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(7, 6);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(35, 35);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.MouseEnter += new System.EventHandler(this.PanelMenu_Highlight);
            this.btnMenu.MouseLeave += new System.EventHandler(this.PanelMenu_HighlightRemove);
            // 
            // btnTicketText
            // 
            this.btnTicketText.BackColor = System.Drawing.Color.Transparent;
            this.btnTicketText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTicketText.FlatAppearance.BorderSize = 0;
            this.btnTicketText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnTicketText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicketText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTicketText.Location = new System.Drawing.Point(42, 10);
            this.btnTicketText.Name = "btnTicketText";
            this.btnTicketText.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnTicketText.Size = new System.Drawing.Size(112, 35);
            this.btnTicketText.TabIndex = 3;
            this.btnTicketText.Text = "Билет";
            this.btnTicketText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTicketText.UseVisualStyleBackColor = false;
            this.btnTicketText.MouseEnter += new System.EventHandler(this.BtnTicket_Highlight);
            this.btnTicketText.MouseLeave += new System.EventHandler(this.BtnTicket_HighlightRemove);
            // 
            // btnMarathon
            // 
            this.btnMarathon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMarathon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMarathon.BackgroundImage")));
            this.btnMarathon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMarathon.FlatAppearance.BorderSize = 0;
            this.btnMarathon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnMarathon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarathon.Location = new System.Drawing.Point(7, 8);
            this.btnMarathon.Name = "btnMarathon";
            this.btnMarathon.Size = new System.Drawing.Size(35, 35);
            this.btnMarathon.TabIndex = 1;
            this.btnMarathon.UseVisualStyleBackColor = false;
            this.btnMarathon.MouseEnter += new System.EventHandler(this.BtnMarathon_Highlight);
            this.btnMarathon.MouseLeave += new System.EventHandler(this.BtnMarathon_HighlightRemove);
            // 
            // btnExamText
            // 
            this.btnExamText.BackColor = System.Drawing.Color.Transparent;
            this.btnExamText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExamText.FlatAppearance.BorderSize = 0;
            this.btnExamText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnExamText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExamText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExamText.Location = new System.Drawing.Point(42, 73);
            this.btnExamText.Name = "btnExamText";
            this.btnExamText.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnExamText.Size = new System.Drawing.Size(112, 31);
            this.btnExamText.TabIndex = 2;
            this.btnExamText.Text = "Экзамен";
            this.btnExamText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExamText.UseVisualStyleBackColor = false;
            this.btnExamText.MouseEnter += new System.EventHandler(this.BtnExam_Highlight);
            this.btnExamText.MouseLeave += new System.EventHandler(this.BtnExam_HighlightRemove);
            // 
            // btnTheme
            // 
            this.btnTheme.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTheme.BackgroundImage = global::SuperProga.Properties.Resources.by_themes;
            this.btnTheme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTheme.FlatAppearance.BorderSize = 0;
            this.btnTheme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheme.Location = new System.Drawing.Point(7, 7);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.Size = new System.Drawing.Size(35, 35);
            this.btnTheme.TabIndex = 1;
            this.btnTheme.UseVisualStyleBackColor = false;
            this.btnTheme.MouseEnter += new System.EventHandler(this.BtnTheme_Highlight);
            this.btnTheme.MouseLeave += new System.EventHandler(this.BtnTheme_HighlightRemove);
            // 
            // btnExam
            // 
            this.btnExam.BackColor = System.Drawing.Color.Transparent;
            this.btnExam.BackgroundImage = global::SuperProga.Properties.Resources.exam;
            this.btnExam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExam.FlatAppearance.BorderSize = 0;
            this.btnExam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExam.Location = new System.Drawing.Point(7, 69);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(35, 35);
            this.btnExam.TabIndex = 1;
            this.btnExam.UseVisualStyleBackColor = false;
            this.btnExam.MouseEnter += new System.EventHandler(this.BtnExam_Highlight);
            this.btnExam.MouseLeave += new System.EventHandler(this.BtnExam_HighlightRemove);
            // 
            // panelExam
            // 
            this.panelExam.Location = new System.Drawing.Point(0, 61);
            this.panelExam.Margin = new System.Windows.Forms.Padding(0);
            this.panelExam.Name = "panelExam";
            this.panelExam.Size = new System.Drawing.Size(157, 51);
            this.panelExam.TabIndex = 1;
            this.panelExam.MouseEnter += new System.EventHandler(this.BtnExam_Highlight);
            this.panelExam.MouseLeave += new System.EventHandler(this.BtnExam_HighlightRemove);
            // 
            // panel_menu
            // 
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(50, 50);
            this.panel_menu.TabIndex = 1;
            this.panel_menu.MouseEnter += new System.EventHandler(this.PanelMenu_Highlight);
            this.panel_menu.MouseLeave += new System.EventHandler(this.PanelMenu_HighlightRemove);
            // 
            // panelTicket
            // 
            this.panelTicket.Controls.Add(this.btnTicketText);
            this.panelTicket.Controls.Add(this.btnTicket);
            this.panelTicket.Location = new System.Drawing.Point(0, 112);
            this.panelTicket.Margin = new System.Windows.Forms.Padding(0);
            this.panelTicket.Name = "panelTicket";
            this.panelTicket.Size = new System.Drawing.Size(157, 51);
            this.panelTicket.TabIndex = 2;
            // 
            // panelTheme
            // 
            this.panelTheme.Controls.Add(this.btnTheme);
            this.panelTheme.Controls.Add(this.btnThemeText);
            this.panelTheme.Location = new System.Drawing.Point(0, 163);
            this.panelTheme.Margin = new System.Windows.Forms.Padding(0);
            this.panelTheme.Name = "panelTheme";
            this.panelTheme.Size = new System.Drawing.Size(157, 51);
            this.panelTheme.TabIndex = 3;
            // 
            // panelMarathon
            // 
            this.panelMarathon.Controls.Add(this.btnMarathon);
            this.panelMarathon.Controls.Add(this.btnMarathonText);
            this.panelMarathon.Location = new System.Drawing.Point(0, 214);
            this.panelMarathon.Margin = new System.Windows.Forms.Padding(0);
            this.panelMarathon.Name = "panelMarathon";
            this.panelMarathon.Size = new System.Drawing.Size(157, 51);
            this.panelMarathon.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panelTicket.ResumeLayout(false);
            this.panelTheme.ResumeLayout(false);
            this.panelMarathon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnMarathon;
        private System.Windows.Forms.Button btnTheme;
        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Button btnExamText;
        private System.Windows.Forms.Button btnTicketText;
        private System.Windows.Forms.Button btnThemeText;
        private System.Windows.Forms.Button btnMarathonText;
        private System.Windows.Forms.Panel panelExam;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panelMarathon;
        private System.Windows.Forms.Panel panelTheme;
        private System.Windows.Forms.Panel panelTicket;
    }
}

