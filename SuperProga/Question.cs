using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SuperProga
{
    internal class Question
    {
        private int id_;
        private string question_;
        private string theme_;
        private string answers_;
        private int rightAnswer_;
        private string theory_;
        private int hasImg_;
        private static string nullPath = "placeholder";

        public static Question[] questionList;
        public static string[][] themes =
            {
                new string[] {"theme1", "theme1", "theme1" },
                new string[] {"theme2", "theme2", "theme2" },
                new string[] {"theme3", "theme3", "theme3" },
                new string[] {"theme4", "theme4", "theme4" },
            };
        public static int[][] tickets =
        {
            new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }
        };

        public int id
        {
            get { return id_; }
            set { 
                if (value >= 0) 
                    id_ = value;
                else
                {
                    Console.WriteLine("Tried to set negative id.\n");
                    id_ = 0;
                }    
            }
        }

        public string question
        {
            get { return question_; }
            set { question_ = value; }
        }

        public string theme
        {
            get { return theme_; }
            set { theme_ = value; }
        }

        public string answers
        {
            get {return answers_; }
            set {
                this.answers_ = value;
            }
        }

        public int rightAnswer
        {
            get { return rightAnswer_; }
            set {
                if (value >= 0)
                    rightAnswer_ = value;
                else
                {
                    Console.WriteLine("Tried to set negative rightAnswer.\n");
                    rightAnswer_ = 0;
                }
            }
        }

        public string theory
        {
            get { return theory_; }
            set { theory_ = value; }
        }

        public bool hasImg
        {
            get { 
                if (hasImg_ > 0) return true;
                else return false;
            }
            set {
                if (value == true) hasImg_ = 1;
                else hasImg_ = 0;
            }
        }
        public Question()
        {
            this.id = 0;
            this.question = "";
            this.theme = "theme1";
            this.answers = "1;2;3;4";
            this.rightAnswer = 1;
            this.theory = "Par 1.1";
        }
        public Question(int id, string question, string theme, string answers, int rightAnswer, string theory, bool hasImg)
        {
            this.id = id;
            this.question = question;
            this.theme = theme;
            this.answers = answers;
            this.rightAnswer = rightAnswer;
            this.theory = theory;
            if (hasImg == true) ;
        }

        public static void createList()
        {
            using (AppContext db = new AppContext())
            {
                questionList = db.Questions.ToArray();
            }
        }

        public static Question[] createListByTheme(string[] themes)
        {
            Question[] filtered = new Question[0];
            if (questionList == null) createList();
            foreach(Question q in questionList)
            {
                if (themes.Contains(q.theme))
                {
                    filtered = filtered.Append(q).ToArray();
                }
            }
            return filtered;
        }

        public static Question[] createListByTheme(string theme)
        {
            Question[] filtered = new Question[0];
            if (questionList == null) createList();
            foreach (Question q in questionList)
            {
                if (theme == q.theme)
                {
                    filtered = filtered.Append(q).ToArray();
                }
            }
            return filtered;
        }

        public static Question[] getTicket(int number)
        {
            Question[] filtered = new Question[0];
            foreach (int var in tickets[number])
            {
                filtered = filtered.Append(questionList[var - 1]).ToArray();
            }
            return filtered;
        }

        public static Question[] getFive(string[] themes)
        {
            Question[] all = createListByTheme(themes);
            Question[] five = new Question[0];
            Random random = new Random();
            int index = 0;
            while (five.Length != 5)
            {
                index = random.Next(0, all.Length);
                if (!five.Contains(all[index]))
                {
                    five = five.Append(all[index]).ToArray();
                }
            }
            return five;
        }

        public static Question[] getFive(Question[] alreadyHave, string[] themes)
        {
            Question[] all = createListByTheme(themes);
            Question[] five = new Question[0];
            Random random = new Random();
            int index = 0;
            while (five.Length != 5)
            {
                index = random.Next(0, all.Length);
                if (!five.Contains(all[index]) && !alreadyHave.Contains(all[index]))
                {
                    five = five.Append(all[index]).ToArray();
                }
            }
            return five;
        }

        public static Question[] getAll()
        {
            Question[] all = new Question[questionList.Length];
            questionList.CopyTo(all, 0);
            return all;
        }
        public static bool operator ==(Question obj1, Question obj2)
        {
            if (obj1.id == obj2.id)
                return true;
            else return false;
        }

        public static bool operator!= (Question obj1, Question obj2) => !(obj1 == obj2);
    }
}
