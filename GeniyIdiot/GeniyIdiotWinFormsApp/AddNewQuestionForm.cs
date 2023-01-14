
namespace GeniyIdiotWinFormsApp
{
    public partial class AddNewQuestionForm : Form
    {
        private QuestionsStorage questionsStorage;
        private List<Question> questions;
        public AddNewQuestionForm()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.Enter) acceptNewQuestionButon_Click(acceptNewQuestionButon, null); };
        }
        private void AddNewQuestionForm_Load(object sender, EventArgs e)
        {
            questionsStorage = new QuestionsStorage();
            questions = new List<Question>();
            questions = questionsStorage.GetQuestions(false);
        }

        private void answerTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                var userAnswer = Convert.ToInt32(answerTextBox.Text);
            }
            catch
            {
                MessageBox.Show("�� ����� �� �������� �������� ���� ����� ��������� �� � ��������� �� -2147483647 �� 2147483647. " +
                    "\n��������� ������ � ���������� �����!", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void returnToMainMenuButton_Click(object sender, EventArgs e)
        {
            questionsStorage.SaveQuestions(questions, false);
            Close();
        }

        private void acceptNewQuestionButon_Click(object sender, EventArgs e)
        {
            string question = newQuestionTextBox.Text;
            int answer = Convert.ToInt32(answerTextBox.Text);
            var newQuestion = new Question(question, answer);
            questions.Add(newQuestion);
            MessageBox.Show("������ ������� ��������!", "��������������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            newQuestionTextBox.Text = "";
            answerTextBox.Text = "";
        }

    }
}