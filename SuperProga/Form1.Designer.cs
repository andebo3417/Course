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
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.panelTheory = new System.Windows.Forms.Panel();
            this.btnTheoryText = new System.Windows.Forms.Button();
            this.panelMarathon = new System.Windows.Forms.Panel();
            this.btnMarathonText = new System.Windows.Forms.Button();
            this.panelTheme = new System.Windows.Forms.Panel();
            this.btnThemeText = new System.Windows.Forms.Button();
            this.panelTicket = new System.Windows.Forms.Panel();
            this.btnTicketText = new System.Windows.Forms.Button();
            this.btnExamText = new System.Windows.Forms.Button();
            this.panelExam = new System.Windows.Forms.Panel();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.panelInnerForm = new System.Windows.Forms.Panel();
            this.btnTheory = new System.Windows.Forms.Button();
            this.btnMarathon = new System.Windows.Forms.Button();
            this.btnTheme = new System.Windows.Forms.Button();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnExam = new System.Windows.Forms.Button();
            this.panelMainMenu.SuspendLayout();
            this.panelTheory.SuspendLayout();
            this.panelMarathon.SuspendLayout();
            this.panelTheme.SuspendLayout();
            this.panelTicket.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMainMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMainMenu.Controls.Add(this.panelTheory);
            this.panelMainMenu.Controls.Add(this.panelMarathon);
            this.panelMainMenu.Controls.Add(this.panelTheme);
            this.panelMainMenu.Controls.Add(this.panelTicket);
            this.panelMainMenu.Controls.Add(this.btnMenu);
            this.panelMainMenu.Controls.Add(this.btnExamText);
            this.panelMainMenu.Controls.Add(this.btnExam);
            this.panelMainMenu.Controls.Add(this.panelExam);
            this.panelMainMenu.Controls.Add(this.panel_menu);
            this.panelMainMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(50, 612);
            this.panelMainMenu.TabIndex = 0;
            // 
            // panelTheory
            // 
            this.panelTheory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelTheory.Controls.Add(this.btnTheory);
            this.panelTheory.Controls.Add(this.btnTheoryText);
            this.panelTheory.Location = new System.Drawing.Point(0, 561);
            this.panelTheory.Margin = new System.Windows.Forms.Padding(0);
            this.panelTheory.Name = "panelTheory";
            this.panelTheory.Size = new System.Drawing.Size(160, 51);
            this.panelTheory.TabIndex = 5;
            this.panelTheory.MouseEnter += new System.EventHandler(this.BtnTheory_Highlight);
            this.panelTheory.MouseLeave += new System.EventHandler(this.BtnTheory_HighlightRemove);
            // 
            // btnTheoryText
            // 
            this.btnTheoryText.BackColor = System.Drawing.Color.Transparent;
            this.btnTheoryText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTheoryText.FlatAppearance.BorderSize = 0;
            this.btnTheoryText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnTheoryText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnTheoryText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheoryText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTheoryText.Location = new System.Drawing.Point(42, 10);
            this.btnTheoryText.Name = "btnTheoryText";
            this.btnTheoryText.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnTheoryText.Size = new System.Drawing.Size(109, 35);
            this.btnTheoryText.TabIndex = 5;
            this.btnTheoryText.Text = "Теория";
            this.btnTheoryText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTheoryText.UseVisualStyleBackColor = false;
            this.btnTheoryText.MouseEnter += new System.EventHandler(this.BtnTheory_Highlight);
            this.btnTheoryText.MouseLeave += new System.EventHandler(this.BtnTheory_HighlightRemove);
            // 
            // panelMarathon
            // 
            this.panelMarathon.Controls.Add(this.btnMarathon);
            this.panelMarathon.Controls.Add(this.btnMarathonText);
            this.panelMarathon.Location = new System.Drawing.Point(0, 214);
            this.panelMarathon.Margin = new System.Windows.Forms.Padding(0);
            this.panelMarathon.Name = "panelMarathon";
            this.panelMarathon.Size = new System.Drawing.Size(160, 51);
            this.panelMarathon.TabIndex = 4;
            this.panelMarathon.Click += new System.EventHandler(this.OpenMarathonForm);
            // 
            // btnMarathonText
            // 
            this.btnMarathonText.BackColor = System.Drawing.Color.Transparent;
            this.btnMarathonText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMarathonText.FlatAppearance.BorderSize = 0;
            this.btnMarathonText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnMarathonText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnMarathonText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarathonText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMarathonText.Location = new System.Drawing.Point(43, 14);
            this.btnMarathonText.Name = "btnMarathonText";
            this.btnMarathonText.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnMarathonText.Size = new System.Drawing.Size(109, 35);
            this.btnMarathonText.TabIndex = 5;
            this.btnMarathonText.Text = "Марафон";
            this.btnMarathonText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarathonText.UseVisualStyleBackColor = false;
            this.btnMarathonText.Click += new System.EventHandler(this.OpenMarathonForm);
            this.btnMarathonText.MouseEnter += new System.EventHandler(this.BtnMarathon_Highlight);
            this.btnMarathonText.MouseLeave += new System.EventHandler(this.BtnMarathon_HighlightRemove);
            // 
            // panelTheme
            // 
            this.panelTheme.Controls.Add(this.btnTheme);
            this.panelTheme.Controls.Add(this.btnThemeText);
            this.panelTheme.Location = new System.Drawing.Point(0, 163);
            this.panelTheme.Margin = new System.Windows.Forms.Padding(0);
            this.panelTheme.Name = "panelTheme";
            this.panelTheme.Size = new System.Drawing.Size(160, 51);
            this.panelTheme.TabIndex = 3;
            this.panelTheme.Click += new System.EventHandler(this.OpenThemeForm);
            // 
            // btnThemeText
            // 
            this.btnThemeText.BackColor = System.Drawing.Color.Transparent;
            this.btnThemeText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemeText.FlatAppearance.BorderSize = 0;
            this.btnThemeText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnThemeText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnThemeText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnThemeText.Location = new System.Drawing.Point(43, 12);
            this.btnThemeText.Name = "btnThemeText";
            this.btnThemeText.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnThemeText.Size = new System.Drawing.Size(109, 35);
            this.btnThemeText.TabIndex = 4;
            this.btnThemeText.Text = "По темам";
            this.btnThemeText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemeText.UseVisualStyleBackColor = false;
            this.btnThemeText.Click += new System.EventHandler(this.OpenThemeForm);
            this.btnThemeText.MouseEnter += new System.EventHandler(this.BtnTheme_Highlight);
            this.btnThemeText.MouseLeave += new System.EventHandler(this.BtnTheme_HighlightRemove);
            // 
            // panelTicket
            // 
            this.panelTicket.Controls.Add(this.btnTicketText);
            this.panelTicket.Controls.Add(this.btnTicket);
            this.panelTicket.Location = new System.Drawing.Point(0, 112);
            this.panelTicket.Margin = new System.Windows.Forms.Padding(0);
            this.panelTicket.Name = "panelTicket";
            this.panelTicket.Size = new System.Drawing.Size(160, 51);
            this.panelTicket.TabIndex = 2;
            this.panelTicket.Click += new System.EventHandler(this.OpenTicketForm);
            // 
            // btnTicketText
            // 
            this.btnTicketText.BackColor = System.Drawing.Color.Transparent;
            this.btnTicketText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTicketText.FlatAppearance.BorderSize = 0;
            this.btnTicketText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnTicketText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnTicketText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicketText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTicketText.Location = new System.Drawing.Point(43, 10);
            this.btnTicketText.Name = "btnTicketText";
            this.btnTicketText.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnTicketText.Size = new System.Drawing.Size(112, 35);
            this.btnTicketText.TabIndex = 3;
            this.btnTicketText.Text = "Билет";
            this.btnTicketText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTicketText.UseVisualStyleBackColor = false;
            this.btnTicketText.Click += new System.EventHandler(this.OpenTicketForm);
            this.btnTicketText.MouseEnter += new System.EventHandler(this.BtnTicket_Highlight);
            this.btnTicketText.MouseLeave += new System.EventHandler(this.BtnTicket_HighlightRemove);
            // 
            // btnExamText
            // 
            this.btnExamText.BackColor = System.Drawing.Color.Transparent;
            this.btnExamText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExamText.FlatAppearance.BorderSize = 0;
            this.btnExamText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnExamText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnExamText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExamText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExamText.Location = new System.Drawing.Point(43, 73);
            this.btnExamText.Name = "btnExamText";
            this.btnExamText.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnExamText.Size = new System.Drawing.Size(112, 31);
            this.btnExamText.TabIndex = 2;
            this.btnExamText.Text = "Экзамен";
            this.btnExamText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExamText.UseVisualStyleBackColor = false;
            this.btnExamText.Click += new System.EventHandler(this.OpenExamForm);
            this.btnExamText.MouseEnter += new System.EventHandler(this.BtnExam_Highlight);
            this.btnExamText.MouseLeave += new System.EventHandler(this.BtnExam_HighlightRemove);
            // 
            // panelExam
            // 
            this.panelExam.Location = new System.Drawing.Point(0, 61);
            this.panelExam.Margin = new System.Windows.Forms.Padding(0);
            this.panelExam.Name = "panelExam";
            this.panelExam.Size = new System.Drawing.Size(160, 51);
            this.panelExam.TabIndex = 1;
            this.panelExam.Click += new System.EventHandler(this.OpenExamForm);
            this.panelExam.MouseEnter += new System.EventHandler(this.BtnExam_Highlight);
            this.panelExam.MouseLeave += new System.EventHandler(this.BtnExam_HighlightRemove);
            // 
            // panel_menu
            // 
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(51, 50);
            this.panel_menu.TabIndex = 1;
            this.panel_menu.Click += new System.EventHandler(this.BtnMenu_Click);
            this.panel_menu.MouseEnter += new System.EventHandler(this.PanelMenu_Highlight);
            this.panel_menu.MouseLeave += new System.EventHandler(this.PanelMenu_HighlightRemove);
            // 
            // panelInnerForm
            // 
            this.panelInnerForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInnerForm.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelInnerForm.Location = new System.Drawing.Point(43, 0);
            this.panelInnerForm.Name = "panelInnerForm";
            this.panelInnerForm.Size = new System.Drawing.Size(1044, 612);
            this.panelInnerForm.TabIndex = 1;
            // 
            // btnTheory
            // 
            this.btnTheory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTheory.BackgroundImage = global::SuperProga.Properties.Resources.theory;
            this.btnTheory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTheory.FlatAppearance.BorderSize = 0;
            this.btnTheory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnTheory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnTheory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheory.Location = new System.Drawing.Point(7, 8);
            this.btnTheory.Name = "btnTheory";
            this.btnTheory.Size = new System.Drawing.Size(35, 35);
            this.btnTheory.TabIndex = 1;
            this.btnTheory.UseVisualStyleBackColor = false;
            this.btnTheory.MouseEnter += new System.EventHandler(this.BtnTheory_Highlight);
            this.btnTheory.MouseLeave += new System.EventHandler(this.BtnTheory_HighlightRemove);
            // 
            // btnMarathon
            // 
            this.btnMarathon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMarathon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMarathon.BackgroundImage")));
            this.btnMarathon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMarathon.FlatAppearance.BorderSize = 0;
            this.btnMarathon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnMarathon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnMarathon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarathon.Location = new System.Drawing.Point(7, 8);
            this.btnMarathon.Name = "btnMarathon";
            this.btnMarathon.Size = new System.Drawing.Size(35, 35);
            this.btnMarathon.TabIndex = 1;
            this.btnMarathon.UseVisualStyleBackColor = false;
            this.btnMarathon.Click += new System.EventHandler(this.OpenMarathonForm);
            this.btnMarathon.MouseEnter += new System.EventHandler(this.BtnMarathon_Highlight);
            this.btnMarathon.MouseLeave += new System.EventHandler(this.BtnMarathon_HighlightRemove);
            // 
            // btnTheme
            // 
            this.btnTheme.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTheme.BackgroundImage = global::SuperProga.Properties.Resources.by_themes;
            this.btnTheme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTheme.FlatAppearance.BorderSize = 0;
            this.btnTheme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnTheme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheme.Location = new System.Drawing.Point(7, 7);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.Size = new System.Drawing.Size(35, 35);
            this.btnTheme.TabIndex = 1;
            this.btnTheme.UseVisualStyleBackColor = false;
            this.btnTheme.Click += new System.EventHandler(this.OpenThemeForm);
            this.btnTheme.MouseEnter += new System.EventHandler(this.BtnTheme_Highlight);
            this.btnTheme.MouseLeave += new System.EventHandler(this.BtnTheme_HighlightRemove);
            // 
            // btnTicket
            // 
            this.btnTicket.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTicket.BackgroundImage = global::SuperProga.Properties.Resources.ticket;
            this.btnTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTicket.FlatAppearance.BorderSize = 0;
            this.btnTicket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnTicket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicket.Location = new System.Drawing.Point(7, 5);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(35, 35);
            this.btnTicket.TabIndex = 1;
            this.btnTicket.UseVisualStyleBackColor = false;
            this.btnTicket.Click += new System.EventHandler(this.OpenTicketForm);
            this.btnTicket.MouseEnter += new System.EventHandler(this.BtnTicket_Highlight);
            this.btnTicket.MouseLeave += new System.EventHandler(this.BtnTicket_HighlightRemove);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenu.BackgroundImage")));
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(7, 6);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(35, 35);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            this.btnMenu.MouseEnter += new System.EventHandler(this.PanelMenu_Highlight);
            this.btnMenu.MouseLeave += new System.EventHandler(this.PanelMenu_HighlightRemove);
            // 
            // btnExam
            // 
            this.btnExam.BackColor = System.Drawing.Color.Transparent;
            this.btnExam.BackgroundImage = global::SuperProga.Properties.Resources.exam;
            this.btnExam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExam.FlatAppearance.BorderSize = 0;
            this.btnExam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnExam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExam.Location = new System.Drawing.Point(7, 69);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(35, 35);
            this.btnExam.TabIndex = 1;
            this.btnExam.UseVisualStyleBackColor = false;
            this.btnExam.Click += new System.EventHandler(this.OpenExamForm);
            this.btnExam.MouseEnter += new System.EventHandler(this.BtnExam_Highlight);
            this.btnExam.MouseLeave += new System.EventHandler(this.BtnExam_HighlightRemove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.panelInnerForm);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMainMenu.ResumeLayout(false);
            this.panelTheory.ResumeLayout(false);
            this.panelMarathon.ResumeLayout(false);
            this.panelTheme.ResumeLayout(false);
            this.panelTicket.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainMenu;
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
        private System.Windows.Forms.Panel panelTheory;
        private System.Windows.Forms.Button btnTheory;
        private System.Windows.Forms.Button btnTheoryText;
        private System.Windows.Forms.Panel panelInnerForm;
    }
}

