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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamHelloForm));
            this.panelHello = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            this.sqliteCommand2 = new Microsoft.Data.Sqlite.SqliteCommand();
            this.Info = new System.Windows.Forms.Label();
            this.panelHello.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHello
            // 
            this.panelHello.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelHello.Controls.Add(this.Info);
            this.panelHello.Controls.Add(this.textBox1);
            this.panelHello.Controls.Add(this.button1);
            this.panelHello.Location = new System.Drawing.Point(0, 0);
            this.panelHello.Name = "panelHello";
            this.panelHello.Size = new System.Drawing.Size(1037, 612);
            this.panelHello.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Image = global::SuperProga.Properties.Resources.quit;
            this.button1.Location = new System.Drawing.Point(831, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "Proceed";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnProceed_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 104);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1013, 292);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // sqliteCommand1
            // 
            this.sqliteCommand1.CommandText = null;
            this.sqliteCommand1.CommandTimeout = 30;
            this.sqliteCommand1.Connection = null;
            this.sqliteCommand1.Transaction = null;
            this.sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // sqliteCommand2
            // 
            this.sqliteCommand2.CommandText = null;
            this.sqliteCommand2.CommandTimeout = 30;
            this.sqliteCommand2.Connection = null;
            this.sqliteCommand2.Transaction = null;
            this.sqliteCommand2.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info.Location = new System.Drawing.Point(376, 43);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(277, 42);
            this.Info.TabIndex = 4;
            this.Info.Text = "INFORMATION";
            this.Info.Click += new System.EventHandler(this.label1_Click);
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
            this.panelHello.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHello;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label Info;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand2;
    }
}