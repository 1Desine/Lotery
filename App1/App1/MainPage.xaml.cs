using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        private int answeredCorrectly = 0;
        private int currentQuestion = 0;
        private List<Question> questionsList;
        private Question cq;

        private struct Question
        {
            public string question;
            public int rightAnswer;
            public List<string> answersList;
        }


        public MainPage()
        {
            InitializeComponent();



            questionsList = new List<Question>()
            {
                new Question()
                {
                    question = "1",
                    rightAnswer = 2,
                    answersList = new List<string>()
                    {
                        "asd5",
                        "1",
                        "asd7",
                        "asd8",
                    }
                },
                new Question()
                {
                    question = "a",
                    rightAnswer = 1,
                    answersList = new List<string>()
                    {
                        "a",
                        "asdz",
                        "xasd",
                        "asdc",
                    }
                },
                new Question()
                {
                    question = "b",
                    rightAnswer = 2,
                    answersList = new List<string>()
                    {
                        "qe1",
                        "b",
                        "345",
                        "vbnm./",
                    }
                },
                new Question()
                {
                    question = "qwerty",
                    rightAnswer = 2,
                    answersList = new List<string>()
                    {
                        "s",
                        "qwerty",
                        "ytrewq",
                        "f",
                    }
                },
                new Question()
                {
                    question = "ewqewqewq",
                    rightAnswer = 1,
                    answersList = new List<string>()
                    {
                        "qweqwe",
                        "asdasd",
                        "sdas",
                        "asdasd",
                    }
                },




                new Question()
                {
                    question = "3",
                    rightAnswer = 3,
                    answersList = new List<string>()
                    {
                        "ывфап",
                        "фыв",
                        "%",
                        "вфыа",
                    }
                },
                new Question()
                {
                    question = "у а и",
                    rightAnswer = 3,
                    answersList = new List<string>()
                    {
                        "фывфывап",
                        "итльит",
                        "ыва ып у",
                        "фывпаыв",
                    }
                },
                new Question()
                {
                    question = "3467",
                    rightAnswer = 3,
                    answersList = new List<string>()
                    {
                        "апро",
                        "вапр",
                        "345",
                        "апр",
                    }
                },
                new Question()
                {
                    question = "пресс _ ту респект",
                    rightAnswer = 4,
                    answersList = new List<string>()
                    {
                        "s",
                        "qwerty",
                        "ytrewq",
                        "f",
                    }
                },
                new Question()
                {
                    question = "да я уже не могу",
                    rightAnswer = 3,
                    answersList = new List<string>()
                    {
                        "и ты",
                        "иа",
                        "и я :(",
                        "кто, я?",
                    }
                },



















                new Question()
                {
                    question = "не надоело?",
                    rightAnswer = 4,
                    answersList = new List<string>()
                    {
                        "неа",
                        "неа",
                        "неа",
                        "сколько можно",
                    }
                },
                new Question()
                {
                    question = "ну а мне надоело",
                    rightAnswer = 1,
                    answersList = new List<string>()
                    {
                        "a",
                        "Мне тоже",
                        "xasd",
                        "asdc",
                    }
                },
                new Question()
                {
                    question = "Дальше повтор",
                    rightAnswer = 2,
                    answersList = new List<string>()
                    {
                        "qe1",
                        "b",
                        "345",
                        "vbnm./",
                    }
                },
                new Question()
                {
                    question = "12 за работу пж",
                    rightAnswer = 2,
                    answersList = new List<string>()
                    {
                        "s",
                        "qwerty",
                        "ytrewq",
                        "f",
                    }
                },
                new Question()
                {
                    question = "ewqewqewq",
                    rightAnswer = 1,
                    answersList = new List<string>()
                    {
                        "qweqwe",
                        "asdasd",
                        "sdas",
                        "asdasd",
                    }
                },




                new Question()
                {
                    question = "3",
                    rightAnswer = 3,
                    answersList = new List<string>()
                    {
                        "ывфап",
                        "фыв",
                        "%",
                        "вфыа",
                    }
                },
                new Question()
                {
                    question = "у а и",
                    rightAnswer = 3,
                    answersList = new List<string>()
                    {
                        "фывфывап",
                        "итльит",
                        "ыва ып у",
                        "фывпаыв",
                    }
                },
                new Question()
                {
                    question = "3467",
                    rightAnswer = 3,
                    answersList = new List<string>()
                    {
                        "апро",
                        "вапр",
                        "345",
                        "апр",
                    }
                },
                new Question()
                {
                    question = "пресс _ ту респект",
                    rightAnswer = 4,
                    answersList = new List<string>()
                    {
                        "s",
                        "qwerty",
                        "ytrewq",
                        "f",
                    }
                },
                new Question()
                {
                    question = "да я уже не могу",
                    rightAnswer = 3,
                    answersList = new List<string>()
                    {
                        "и ты",
                        "иа",
                        "и я :(",
                        "кто, я?",
                    }
                },
            };





            SetNextQuestion();
        }
        private void SetNextQuestion()
        {
            if (currentQuestion >= questionsList.Count) return;
            cq = questionsList[currentQuestion];
            currentQuestion++;

            _Question.Text = cq.question;
            _Answer1.Text = cq.answersList[0];
            _Answer2.Text = cq.answersList[1];
            _Answer3.Text = cq.answersList[2];
            _Answer4.Text = cq.answersList[3];
        }

        private void Answer_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button.BindingContext.ToString() == cq.rightAnswer.ToString())
            {
                answeredCorrectly++;

                if(currentQuestion == questionsList.Count)
                {
                    _FinalResult.Text = "Your score: " + answeredCorrectly.ToString() + " / " + questionsList.Count.ToString();
                }
            }
            _AnsweredCorrectly.Text = "Correct: " + answeredCorrectly.ToString();

            SetNextQuestion();
        }
    }
}
