
namespace GeniyIdiotWinFormsApp
{
    public partial class ProgramStartMenuForm : Form
    {
        private QuestionsStorage questionsList;

        public ProgramStartMenuForm()
        {
            InitializeComponent();
        }

        private void ProgramStartMenuForm_Load(object sender, EventArgs e)
        {
            mainMenuLable.Text = "Здравствуйте, вы находитесь в главном меню программы по определению \nуровня вашего интелекта, пожалуйста, выбирете пункт меню!";
            questionsList = new();
            questionsList.SaveQuestions(questionsList.StandartTestQuestions, true);
        }

        private void standartQuestionsListButton_Click(object sender, EventArgs e)
        {
            var standartQuestionsList = true;
            var nameEnteringMenu = new UserNameForm(standartQuestionsList);
            nameEnteringMenu.Show();
        }

        private void existingQuestionsListButton_Click(object sender, EventArgs e)
        {
            var standartQuestionsList = false;
            var nameEnteringMenu = new UserNameForm(standartQuestionsList);
            nameEnteringMenu.Show();
        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            var newQuestion = new AddNewQuestionForm();
            newQuestion.Show();
        }

        private void exitProgramButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usersResultsButton_Click(object sender, EventArgs e)
        {
            var usersResultsTable = new UsersTestsResultsForm();
            usersResultsTable.Show();
        }

        private void deliteQuestionButton_Click(object sender, EventArgs e)
        {
            var questionsTable = new DeliteQuestionForm();
            questionsTable.Show();
        }
    }
}