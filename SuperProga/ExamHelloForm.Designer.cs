namespace SuperProga
{
    partial class ExamHelloForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHello = new System.Windows.Forms.Panel();
            this.btnProceed = new FontAwesome.Sharp.IconButton();
            this.RtbHello = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelHello.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHello
            // 
            this.panelHello.BackColor = System.Drawing.SystemColors.Control;
            this.panelHello.Controls.Add(this.btnProceed);
            this.panelHello.Controls.Add(this.RtbHello);
            this.panelHello.Controls.Add(this.pictureBox2);
            this.panelHello.Location = new System.Drawing.Point(0, 0);
            this.panelHello.Name = "panelHello";
            this.panelHello.Size = new System.Drawing.Size(1037, 612);
            this.panelHello.TabIndex = 9;
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.SkyBlue;
            this.btnProceed.FlatAppearance.BorderSize = 0;
            this.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProceed.IconChar = FontAwesome.Sharp.IconChar.Forward;
            this.btnProceed.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnProceed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProceed.IconSize = 64;
            this.btnProceed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProceed.Location = new System.Drawing.Point(724, 466);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(250, 83);
            this.btnProceed.TabIndex = 2;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProceed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.BtnProceed_Click);
            // 
            // RtbHello
            // 
            this.RtbHello.BackColor = System.Drawing.Color.DodgerBlue;
            this.RtbHello.Location = new System.Drawing.Point(33, 32);
            this.RtbHello.Name = "RtbHello";
            this.RtbHello.Size = new System.Drawing.Size(452, 517);
            this.RtbHello.TabIndex = 1;
            this.RtbHello.Text = "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::SuperProga.Properties.Resources.exam;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(724, 185);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 216);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // ExamHelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 612);
            this.Controls.Add(this.panelHello);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExamHelloForm";
            this.Text = "ExamHelloForm";
            this.panelHello.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHello;
        private FontAwesome.Sharp.IconButton btnProceed;
        private System.Windows.Forms.RichTextBox RtbHello;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}