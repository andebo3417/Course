namespace SuperProga
{
    partial class MarathonHelloForm
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
            this.btnProceed = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
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
            this.btnProceed.Location = new System.Drawing.Point(679, 442);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(250, 83);
            this.btnProceed.TabIndex = 3;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProceed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.BtnProceed_Click);
            // 
            // MarathonHelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 612);
            this.Controls.Add(this.btnProceed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MarathonHelloForm";
            this.Text = "MarathonHelloForm";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnProceed;
    }
}