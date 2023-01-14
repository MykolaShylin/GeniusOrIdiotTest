using System.Xml.Linq;

namespace GeniyIdiotWinFormsApp
{
    public partial class DeliteQuestionForm : Form
    {
        private QuestionsStorage questionsStorage;
        private List<Question> questions;
        private DataGridViewCell questionNumber;
        private DataGridViewCell question;
        private DataGridViewRow row;
        public DeliteQuestionForm()
        {
            InitializeComponent();
        }

        private void DeliteQuestionForm_Load(object sender, EventArgs e)
        {
            questionsStorage = new();
            questions = questionsStorage.GetQuestions(false);
            int numberOfQuestion = 0;

            foreach (var quest in questions)
            {
                numberOfQuestion++;
                questionNumber = new DataGridViewTextBoxCell();
                question = new DataGridViewTextBoxCell();
                row = new DataGridViewRow();

                questionNumber.Value = numberOfQuestion;
                question.Value = quest.Text;

                row.Cells.AddRange(questionNumber, question);
                questionsTable.Rows.AddRange(row);
            }
        }

        private void userAnswerTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                var userAnswer = Convert.ToInt32(userAnswerTextBox.Text);
                if (userAnswer > questions.Count() || userAnswer < 1)
                {
                    MessageBox.Show("Вы ввели номер вопроса, которого нет в списке. Проверьте данные и попробуйте снова!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Вы ввели не числовое значение! Проверьте данные и попробуйте снова!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void startProgramButton_Click(object sender, EventArgs e)
        {
            questionsStorage.SaveQuestions(questions, false);
            Close();
        }

        private void deliteQuestionButton_Click(object sender, EventArgs e)
        {
            var userAnswer = Convert.ToInt32(userAnswerTextBox.Text);
            questionsTable.Rows.RemoveAt(userAnswer - 1);
            questions.RemoveAt(userAnswer - 1);
            MessageBox.Show("Вопрос удален!", "Информирование", MessageBoxButtons.OK, MessageBoxIcon.Information);
            userAnswerTextBox.Text = "";
        }
    }
}