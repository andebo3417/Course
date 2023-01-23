using Microsoft.EntityFrameworkCore;
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
    public partial class ExamForm : Form
    {
        private Question[] questions;
        private int[] answers;
        private int curQuestion;
        private string QuizMode = "exam";
        private bool isChecking = false;
        private int mistakes = 0;
        private string theme;
        private int ticket;

        int minutes;
        int seconds;

        public ExamForm(string mode)
        {
            InitializeComponent();
            RtbQuestion.BorderStyle = BorderStyle.None;
            rtbTheory.BorderStyle = BorderStyle.None;
            this.QuizMode = mode;
            questions = createList();
            answers = new int[questions.Length];
            curQuestion = 0;
            showQuestion(questions[curQuestion]);
            if (mode == "exam")
            {
                minutes = 20;
                seconds = 0;
                timerExam.Enabled = true;
                labelTime.Visible = true;
                updateTimer();
            }
        }

        public ExamForm(string mode, string theme)
        {
            InitializeComponent();
            RtbQuestion.BorderStyle = BorderStyle.None;
            rtbTheory.BorderStyle = BorderStyle.None;
            this.QuizMode = mode;
            this.theme = theme;
            questions = createList();
            answers = new int[questions.Length];
            curQuestion = 0;
            showQuestion(questions[curQuestion]);
        }

        public ExamForm(string mode, int ticket)
        {
            InitializeComponent();
            RtbQuestion.BorderStyle = BorderStyle.None;
            rtbTheory.BorderStyle = BorderStyle.None;
            this.QuizMode = mode;
            questions = createList();
            answers = new int[questions.Length];
            curQuestion = 0;
            showQuestion(questions[curQuestion]);
            if (mode == "ticket")
            {
                this.ticket = ticket;
                minutes = 20;
                seconds = 0;
                timerExam.Enabled = true;
                labelTime.Visible = true;
                updateTimer();
            }
        }

        private Question[] createList()
        {
            Question[] questions = null;
            if (QuizMode == "exam")
            {
                questions = Question.getFive(Question.themes[0]);
                //questions = questions.Concat(Question.getFive(themes[1])).ToArray();
                //questions = questions.Concat(Question.getFive(themes[2])).ToArray();
                //questions = questions.Concat(Question.getFive(themes[3])).ToArray();
            }
            if (QuizMode == "theme")
            {
                questions = Question.createListByTheme(this.theme);
            }
            if (QuizMode == "ticket")
            {
                questions = Question.getTicket(ticket);
            }
            if (QuizMode == "marathon")
            {
                questions = Question.getAll();
            }
            return questions;
        }

        private void showQuestion(Question question)
        {
            string path;
            string[] answerVars = question.answers.Split(';');
            if (question.hasImg == true)
            {
                path = "assets\\images\\" + question.id + ".jpg";
                pBoxImage.BackgroundImage = new Bitmap(Bitmap.FromFile(path));
            }
            else
            {
                pBoxImage.BackgroundImage = global::SuperProga.Properties.Resources.no_image;
            }
            RtbQuestion.Text = question.question;
            btnAnswer1.Text = answerVars[0];
            btnAnswer2.Text = answerVars[1];
            btnAnswer3.Text = answerVars[2];
            if (answerVars.Length < 4)
            {
                btnAnswer4.Visible = false;
            }
            else
            {
                btnAnswer4.Visible = true;
                btnAnswer4.Text = answerVars[3];
            }

            if (isChecking == false)
            {
                clearButtons();
                enableBtns();
                if (answers[curQuestion] != 0)
                {
                    paintGivenAns(answers[curQuestion]);
                    disableBtns();
                }
            }
            else
            {
                disableBtns();
                clearButtons();
                switch (questions[curQuestion].rightAnswer)
                {
                    case 1:
                        btnAnswer1.BackColor = Color.Green;
                        break;
                    case 2:
                        btnAnswer2.BackColor = Color.Green;
                        break;
                    case 3:
                        btnAnswer3.BackColor = Color.Green;
                        break;
                    case 4:
                        btnAnswer4.BackColor = Color.Green;
                        break;
                    default: break;
                }
                if (questions[curQuestion].rightAnswer != answers[curQuestion] && answers[curQuestion] != 0)
                {
                    switch (answers[curQuestion])
                    {
                        case 1:
                            btnAnswer1.BackColor = Color.Red;
                            break;
                        case 2:
                            btnAnswer2.BackColor = Color.Red;
                            break;
                        case 3:
                            btnAnswer3.BackColor = Color.Red;
                            break;
                        case 4:
                            btnAnswer4.BackColor = Color.Red;
                            break;
                        default: break;
                    }
                }
                rtbTheory.Text = questions[curQuestion].theory;
            }
        }
        
        private void BtnNext_Click(object sender, EventArgs e)
        {
            curQuestion++;
            showQuestion(questions[curQuestion]);
            if (curQuestion == questions.Length - 1)
            {
                btnNext.Enabled = false;
            }
            if (curQuestion > 0) btnPrev.Enabled = true;
        }
        private void BtnPrev_Click(object sender, EventArgs e)
        {
            curQuestion--;
            showQuestion(questions[curQuestion]);
            if (curQuestion == 0)
            {
                btnPrev.Enabled = false;
            }
            if (curQuestion < questions.Length - 1)
            {
                btnNext.Enabled = true;
            }
        }
        private void BtnGiveAnswer(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int ans = int.Parse(btn.Name[btn.Name.Length - 1].ToString());
            answers[curQuestion] = ans;
            paintGivenAns(ans);
            disableBtns();

            if (ans != questions[curQuestion].rightAnswer)
            {
                mistakes++;
                if (QuizMode == "exam")
                {
                    if (mistakes < 2)
                    {
                        foreach (string[] themeCluster in Question.themes)
                        {
                            if (themeCluster.Contains(questions[curQuestion].theme))
                            {
                                questions = questions.Concat(Question.getFive(questions, themeCluster)).ToArray();
                                answers = answers.Concat(new int[5]).ToArray();
                            }
                        }
                    }
                    else endExam();
                }
            }
        }
        private void BtnCheckAnswers(object sender, EventArgs e)
        {
            endExam();
        }
        private void clearButtons()
        {
            btnAnswer1.BackColor = SystemColors.ActiveCaption;
            btnAnswer2.BackColor = SystemColors.ActiveCaption;
            btnAnswer3.BackColor = SystemColors.ActiveCaption;
            btnAnswer4.BackColor = SystemColors.ActiveCaption;
        }
        private void paintGivenAns(int answer)
        {
            clearButtons();
            switch (answer)
            {
                case 1:
                    btnAnswer1.BackColor = Color.Yellow;
                    break;
                case 2:
                    btnAnswer2.BackColor = Color.Yellow;
                    break;
                case 3:
                    btnAnswer3.BackColor = Color.Yellow;
                    break;
                case 4:
                    btnAnswer4.BackColor = Color.Yellow;
                    break;
                default: break;
            }
        }
        private void disableBtns()
        {
            btnAnswer1.Enabled = false;
            btnAnswer2.Enabled = false;
            btnAnswer3.Enabled = false;
            btnAnswer4.Enabled = false;
        }
        private void enableBtns()
        {
            btnAnswer1.Enabled = true;
            btnAnswer2.Enabled = true;
            btnAnswer3.Enabled = true;
            btnAnswer4.Enabled = true;
        }
        private void updateTimer()
        {
            string min = minutes > 9 ? minutes.ToString() : "0" + minutes.ToString();
            string sec = seconds > 9 ? seconds.ToString() : "0" + seconds.ToString();
            labelTime.Text = min + ":" + sec;
        }
        private void endExam()
        {
            int noAnswer = 0;
            isChecking = true;
            showQuestion(questions[curQuestion]);
            timerExam.Stop();
            foreach (int var in answers)
                if (var == 0) noAnswer++;
            labelAll.Text = questions.Length.ToString();
            labelWrong.Text = mistakes.ToString();
            labelNoAnswer.Text = noAnswer.ToString();
            labelRight.Text = (questions.Length - mistakes - noAnswer).ToString();
            panelBye.Visible = true;
            panelBye.Location = new Point(0, 0);
            panelBye.Size = new Size(1150, 750);
            panelBye.BringToFront();
            btnShowBye.Visible = true;
            rtbTheory.Visible = true;
            btnEndExam.Enabled = false;
        }
        private void TimerExam_Tick(object sender, EventArgs e)
        {
            string time = "";
            if (seconds == 0)
            {
                seconds = 59;
                minutes--;
            }
            else seconds--;
            updateTimer();
            if (time == "00:00") endExam();
        }
        private void BtnHideBye_Click(object sender, EventArgs e)
        {
            panelBye.Visible = false;
        }
        private void BtnShowBye_Click(object sender, EventArgs e)
        {
            panelBye.Visible = true;
        }

        private void panelBye_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pBoxImage_Click(object sender, EventArgs e)
        {

        }
    }
}

