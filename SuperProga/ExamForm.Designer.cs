namespace SuperProga
{
    partial class ExamForm
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
            this.RtbQuestion = new System.Windows.Forms.RichTextBox();
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            this.panelQuiz = new System.Windows.Forms.Panel();
            this.panelBye = new System.Windows.Forms.Panel();
            this.btnHideBye = new System.Windows.Forms.Button();
            this.labelNoAnswer = new System.Windows.Forms.Label();
            this.labelWrong = new System.Windows.Forms.Label();
            this.labelRight = new System.Windows.Forms.Label();
            this.labelAll = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNa = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.lblbW = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.pBoxImage = new System.Windows.Forms.PictureBox();
            this.btnEndExam = new System.Windows.Forms.Button();
            this.btnShowBye = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.timerExam = new System.Windows.Forms.Timer(this.components);
            this.rtbTheory = new System.Windows.Forms.RichTextBox();
            this.panelQuiz.SuspendLayout();
            this.panelBye.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // RtbQuestion
            // 
            this.RtbQuestion.BackColor = System.Drawing.SystemColors.Control;
            this.RtbQuestion.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RtbQuestion.Location = new System.Drawing.Point(12, 316);
            this.RtbQuestion.Name = "RtbQuestion";
            this.RtbQuestion.ReadOnly = true;
            this.RtbQuestion.Size = new System.Drawing.Size(1123, 90);
            this.RtbQuestion.TabIndex = 1;
            this.RtbQuestion.Text = "В каком случае водитель совершит вынужденную остановку?";
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAnswer1.FlatAppearance.BorderSize = 0;
            this.btnAnswer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnswer1.Location = new System.Drawing.Point(12, 412);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAnswer1.Size = new System.Drawing.Size(1123, 51);
            this.btnAnswer1.TabIndex = 2;
            this.btnAnswer1.Text = "Answer1";
            this.btnAnswer1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnswer1.UseVisualStyleBackColor = false;
            this.btnAnswer1.Click += new System.EventHandler(this.BtnGiveAnswer);
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAnswer2.FlatAppearance.BorderSize = 0;
            this.btnAnswer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnswer2.Location = new System.Drawing.Point(12, 469);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAnswer2.Size = new System.Drawing.Size(1123, 51);
            this.btnAnswer2.TabIndex = 3;
            this.btnAnswer2.Text = "Answer2";
            this.btnAnswer2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnswer2.UseVisualStyleBackColor = false;
            this.btnAnswer2.Click += new System.EventHandler(this.BtnGiveAnswer);
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAnswer3.FlatAppearance.BorderSize = 0;
            this.btnAnswer3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnswer3.Location = new System.Drawing.Point(12, 526);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAnswer3.Size = new System.Drawing.Size(1123, 51);
            this.btnAnswer3.TabIndex = 4;
            this.btnAnswer3.Text = "Answer3";
            this.btnAnswer3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnswer3.UseVisualStyleBackColor = false;
            this.btnAnswer3.Click += new System.EventHandler(this.BtnGiveAnswer);
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAnswer4.FlatAppearance.BorderSize = 0;
            this.btnAnswer4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnswer4.Location = new System.Drawing.Point(12, 583);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAnswer4.Size = new System.Drawing.Size(1123, 51);
            this.btnAnswer4.TabIndex = 5;
            this.btnAnswer4.Text = "Answer4";
            this.btnAnswer4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnswer4.UseVisualStyleBackColor = false;
            this.btnAnswer4.Click += new System.EventHandler(this.BtnGiveAnswer);
            // 
            // panelQuiz
            // 
            this.panelQuiz.BackColor = System.Drawing.SystemColors.Control;
            this.panelQuiz.Controls.Add(this.rtbTheory);
            this.panelQuiz.Controls.Add(this.panelBye);
            this.panelQuiz.Controls.Add(this.btnNext);
            this.panelQuiz.Controls.Add(this.btnPrev);
            this.panelQuiz.Controls.Add(this.btnAnswer4);
            this.panelQuiz.Controls.Add(this.btnAnswer3);
            this.panelQuiz.Controls.Add(this.btnAnswer2);
            this.panelQuiz.Controls.Add(this.btnAnswer1);
            this.panelQuiz.Controls.Add(this.RtbQuestion);
            this.panelQuiz.Controls.Add(this.pBoxImage);
            this.panelQuiz.Controls.Add(this.btnEndExam);
            this.panelQuiz.Controls.Add(this.btnShowBye);
            this.panelQuiz.Controls.Add(this.labelTime);
            this.panelQuiz.Location = new System.Drawing.Point(0, 0);
            this.panelQuiz.Name = "panelQuiz";
            this.panelQuiz.Size = new System.Drawing.Size(1150, 750);
            this.panelQuiz.TabIndex = 8;
            // 
            // panelBye
            // 
            this.panelBye.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelBye.Controls.Add(this.btnHideBye);
            this.panelBye.Controls.Add(this.labelNoAnswer);
            this.panelBye.Controls.Add(this.labelWrong);
            this.panelBye.Controls.Add(this.labelRight);
            this.panelBye.Controls.Add(this.labelAll);
            this.panelBye.Controls.Add(this.label1);
            this.panelBye.Controls.Add(this.lblNa);
            this.panelBye.Controls.Add(this.lblR);
            this.panelBye.Controls.Add(this.lblbW);
            this.panelBye.Controls.Add(this.labelResult);
            this.panelBye.Location = new System.Drawing.Point(960, 30);
            this.panelBye.Name = "panelBye";
            this.panelBye.Size = new System.Drawing.Size(187, 397);
            this.panelBye.TabIndex = 11;
            this.panelBye.Visible = false;
            // 
            // btnHideBye
            // 
            this.btnHideBye.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHideBye.FlatAppearance.BorderSize = 0;
            this.btnHideBye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideBye.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHideBye.Location = new System.Drawing.Point(52, 338);
            this.btnHideBye.Name = "btnHideBye";
            this.btnHideBye.Size = new System.Drawing.Size(291, 49);
            this.btnHideBye.TabIndex = 9;
            this.btnHideBye.Text = "Показать вопросы";
            this.btnHideBye.UseVisualStyleBackColor = false;
            this.btnHideBye.Click += new System.EventHandler(this.BtnHideBye_Click);
            // 
            // labelNoAnswer
            // 
            this.labelNoAnswer.AutoSize = true;
            this.labelNoAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNoAnswer.ForeColor = System.Drawing.Color.Snow;
            this.labelNoAnswer.Location = new System.Drawing.Point(320, 287);
            this.labelNoAnswer.Name = "labelNoAnswer";
            this.labelNoAnswer.Size = new System.Drawing.Size(24, 26);
            this.labelNoAnswer.TabIndex = 8;
            this.labelNoAnswer.Text = "0";
            // 
            // labelWrong
            // 
            this.labelWrong.AutoSize = true;
            this.labelWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWrong.ForeColor = System.Drawing.Color.DarkRed;
            this.labelWrong.Location = new System.Drawing.Point(320, 249);
            this.labelWrong.Name = "labelWrong";
            this.labelWrong.Size = new System.Drawing.Size(24, 26);
            this.labelWrong.TabIndex = 7;
            this.labelWrong.Text = "0";
            // 
            // labelRight
            // 
            this.labelRight.AutoSize = true;
            this.labelRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRight.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelRight.Location = new System.Drawing.Point(320, 209);
            this.labelRight.Name = "labelRight";
            this.labelRight.Size = new System.Drawing.Size(24, 26);
            this.labelRight.TabIndex = 6;
            this.labelRight.Text = "0";
            // 
            // labelAll
            // 
            this.labelAll.AutoSize = true;
            this.labelAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAll.Location = new System.Drawing.Point(320, 166);
            this.labelAll.Name = "labelAll";
            this.labelAll.Size = new System.Drawing.Size(24, 26);
            this.labelAll.TabIndex = 5;
            this.labelAll.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(47, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Всего вопросов: ";
            // 
            // lblNa
            // 
            this.lblNa.AutoSize = true;
            this.lblNa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNa.Location = new System.Drawing.Point(47, 287);
            this.lblNa.Name = "lblNa";
            this.lblNa.Size = new System.Drawing.Size(252, 26);
            this.lblNa.TabIndex = 3;
            this.lblNa.Text = "Вопросов не отвечено: ";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblR.Location = new System.Drawing.Point(47, 209);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(238, 26);
            this.lblR.TabIndex = 2;
            this.lblR.Text = "Правильных ответов: ";
            // 
            // lblbW
            // 
            this.lblbW.AutoSize = true;
            this.lblbW.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblbW.Location = new System.Drawing.Point(47, 249);
            this.lblbW.Name = "lblbW";
            this.lblbW.Size = new System.Drawing.Size(215, 26);
            this.lblbW.TabIndex = 1;
            this.lblbW.Text = "Ошибок допущено: ";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(45, 84);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(260, 37);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "Экзамен не сдан";
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = global::SuperProga.Properties.Resources.right_arrow;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(1075, 688);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(60, 50);
            this.btnNext.TabIndex = 7;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackgroundImage = global::SuperProga.Properties.Resources.left_arrow;
            this.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrev.Enabled = false;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Location = new System.Drawing.Point(12, 688);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(60, 50);
            this.btnPrev.TabIndex = 6;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // pBoxImage
            // 
            this.pBoxImage.BackgroundImage = global::SuperProga.Properties.Resources.no_image;
            this.pBoxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxImage.InitialImage = global::SuperProga.Properties.Resources.no_image;
            this.pBoxImage.Location = new System.Drawing.Point(338, 59);
            this.pBoxImage.Name = "pBoxImage";
            this.pBoxImage.Size = new System.Drawing.Size(265, 228);
            this.pBoxImage.TabIndex = 0;
            this.pBoxImage.TabStop = false;
            // 
            // btnEndExam
            // 
            this.btnEndExam.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEndExam.FlatAppearance.BorderSize = 0;
            this.btnEndExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEndExam.Location = new System.Drawing.Point(941, 11);
            this.btnEndExam.Name = "btnEndExam";
            this.btnEndExam.Size = new System.Drawing.Size(194, 64);
            this.btnEndExam.TabIndex = 12;
            this.btnEndExam.Text = "Завершить тестирование";
            this.btnEndExam.UseVisualStyleBackColor = false;
            this.btnEndExam.Click += new System.EventHandler(this.BtnCheckAnswers);
            // 
            // btnShowBye
            // 
            this.btnShowBye.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShowBye.FlatAppearance.BorderSize = 0;
            this.btnShowBye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowBye.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowBye.Location = new System.Drawing.Point(941, 93);
            this.btnShowBye.Name = "btnShowBye";
            this.btnShowBye.Size = new System.Drawing.Size(194, 64);
            this.btnShowBye.TabIndex = 11;
            this.btnShowBye.Text = "Показать результаты";
            this.btnShowBye.UseVisualStyleBackColor = false;
            this.btnShowBye.Visible = false;
            this.btnShowBye.Click += new System.EventHandler(this.BtnShowBye_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(12, 30);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(66, 26);
            this.labelTime.TabIndex = 10;
            this.labelTime.Text = "20:00";
            this.labelTime.Visible = false;
            // 
            // timerExam
            // 
            this.timerExam.Interval = 1000;
            this.timerExam.Tick += new System.EventHandler(this.TimerExam_Tick);
            // 
            // rtbTheory
            // 
            this.rtbTheory.BackColor = System.Drawing.SystemColors.Control;
            this.rtbTheory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbTheory.Location = new System.Drawing.Point(102, 651);
            this.rtbTheory.Name = "rtbTheory";
            this.rtbTheory.ReadOnly = true;
            this.rtbTheory.Size = new System.Drawing.Size(948, 77);
            this.rtbTheory.TabIndex = 13;
            this.rtbTheory.Text = "";
            this.rtbTheory.Visible = false;
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1150, 750);
            this.Controls.Add(this.panelQuiz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExamForm";
            this.Text = "ExamForm";
            this.panelQuiz.ResumeLayout(false);
            this.panelQuiz.PerformLayout();
            this.panelBye.ResumeLayout(false);
            this.panelBye.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxImage;
        private System.Windows.Forms.RichTextBox RtbQuestion;
        private System.Windows.Forms.Button btnAnswer1;
        private System.Windows.Forms.Button btnAnswer2;
        private System.Windows.Forms.Button btnAnswer3;
        private System.Windows.Forms.Button btnAnswer4;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panelQuiz;
        private System.Windows.Forms.Timer timerExam;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panelBye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNa;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblbW;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelAll;
        private System.Windows.Forms.Label labelNoAnswer;
        private System.Windows.Forms.Label labelWrong;
        private System.Windows.Forms.Label labelRight;
        private System.Windows.Forms.Button btnHideBye;
        private System.Windows.Forms.Button btnEndExam;
        private System.Windows.Forms.Button btnShowBye;
        private System.Windows.Forms.RichTextBox rtbTheory;
    }
}