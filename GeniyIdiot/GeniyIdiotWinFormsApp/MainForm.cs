using GeniyIdiotLibrary;
using Newtonsoft.Json.Linq;
using System.Runtime.CompilerServices;

namespace GeniyIdiotWinFormsApp
{
    public partial class MainForm : Form
    {
        private List<Question> questions;
        private Question curentQuestion;
        private User User;
        private int questionsCount;
        private int questionNumber;
        private bool StandartQestionsList;
        private int timerTime;
        public MainForm()
        {
        }

        public MainForm(User user, bool standartQestionsList)
        {
            InitializeComponent();
            User = user;
            KeyPreview = true;
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.Enter) nextButton_Click(nextButton, null); };
            StandartQestionsList = standartQestionsList;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {            
            StartNewGame();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            var userAnswer = Convert.ToInt32(userAnswerTextBox.Text);
            int rightAnswer = curentQuestion.Answer;

            if (userAnswer == rightAnswer)
            {
                User.AcceptWrightAnswer();
            }
            questions.RemoveAt(questions.IndexOf(curentQuestion));
            var endGame = questions.Count() == 0;
            if (endGame)
            {
                endGameChoice();
            }
            else
            {
                userAnswerTextBox.Text = "";
                ShowNextQuestion();
            }
        }
        private void ShowNextQuestion()
        {
            timerTime = 10;
            timer1.Enabled = true;
            Random random = new Random();
            int randomQuestionIndex = random.Next(0, questions.Count);
            curentQuestion = questions[randomQuestionIndex];
            questionTextLabel.Text = curentQuestion.Text;
            questionNumber++;
            questionNumberLabel.Text = "Вопрос №" + questionNumber;

        }
        private void StartNewGame()
        {
            MessageBox.Show("Внимание, на ответ дается 10 секунд, если вы не успеваетете ответить вам не засчитают балл!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            questions = new QuestionsStorage().GetQuestions(StandartQestionsList);
            questionsCount = questions.Count();
            questionNumber = 0;
            ShowNextQuestion();
        }

        private void userAnswerTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                var userAnswer = Convert.ToInt32(userAnswerTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Вы ввели не числовое значение либо число находится не в диапозоне от -2147483647 до 2147483647. " +
                    "\nПроверьте данные и попробуйте снова!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void endGameChoice()
        {
            User.Diagnosis = AllTestMethods.GetUserDiagnosis(User, questionsCount);
            MessageBox.Show(AllTestMethods.ShowTestResult(User));
            DialogResult result = MessageBox.Show("Хотите начать тест заного?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                userAnswerTextBox.Text = "";
                User.CountRightAnswers = 0;
                StartNewGame();
            }
            else
            {
                var testsResults = new UsersResultsStorage();
                testsResults.SaveResultOfTesting(User);
                Close();
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timerTime != 0)
            {
                timerTime--;
                timerLabel.Text = "Временеи осталось: " + timerTime.ToString() + " сек.";                
            }
            if (timerTime == 0)
            {
                timer1.Enabled = false;
                questions.RemoveAt(questions.IndexOf(curentQuestion));
                var endGame = questions.Count() == 0;
                if (endGame)
                {
                    endGameChoice();
                }
                else
                {
                    userAnswerTextBox.Text = "";
                    ShowNextQuestion();
                }
            }            
        }
    }
}