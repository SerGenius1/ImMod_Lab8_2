using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lab_8._2
{
    public partial class Form1 : Form
    {
        private Random random;

        private string[] positiveAnswers;
        private string[] indecisiveAnswers;
        private string[] neutralAnswers;
        private string[] negativeAnswers;
        private List<string[]> answers;
        private double[] probabilities = new double[4] { 0.25, 0.15, 0.40, 0.20 };

        private Dictionary<string, string> previousAnswers;

        public Form1()
        {
            InitializeComponent();

            positiveAnswers = new string[5]
            {
                "Это несомненно",
                "Это определенно так",
                "Без сомнения",
                "Да, определенно",
                "Вы можете положиться на это"
            };

            indecisiveAnswers = new string[5]
            {
                "Насколько я понимаю, да",
                "Вероятнее всего",
                "Перспективы хорошие",
                "Знаки указывают на то, что да",
                "Скорее всего да"
            };

            neutralAnswers = new string[5]
            {
                "Ответ туманный, попробуйте еще раз",
                "Спросите еще раз позже",
                "Лучше не говорить тебе сейчас",
                "Сейчас я не могу ничего предсказать",
                "Сосредоточься и спроси еще раз"
            };

            negativeAnswers = new string[5]
            {
                "Не рассчитывай на это",
                "Мой ответ - нет",
                "Мои источники говорят, что нет",
                "Перспективы не очень хорошие",
                "Очень сомнительно"
            };

            answers = new List<string[]> { positiveAnswers, indecisiveAnswers, neutralAnswers, negativeAnswers };

            previousAnswers = new Dictionary<string, string>();

            random = new Random();
        }

        private void bt_Predict_Click(object sender, EventArgs e)
        {
            var question = input.Text;
            //Приведение всех букв к нижнему регистру и удаление всей пунктуации, чтобы она не прияла на содержание вопроса
            question = question.ToLower();
            question = Regex.Replace(question, "\\p{P}", string.Empty);
            question = Regex.Replace(question, " ", string.Empty);

            if (previousAnswers.ContainsKey(question))
            {
                label_Answer.Text = previousAnswers[question];
                return;
            }

            double probability =  random.NextDouble();

            int typeOfAnswer = 0;
            while (probability >= 0)
            {
                probability -= probabilities[typeOfAnswer];
                typeOfAnswer++;
            }
            typeOfAnswer--;

            var answer = answers[typeOfAnswer][random.Next(0,4)];

            //Если выпала секция "спросите позже", то ответ не сохраняется
            if (typeOfAnswer != 2)
            {
                previousAnswers[question] = answer;
            }

            label_Answer.Text = answer;
        }
    }
}
