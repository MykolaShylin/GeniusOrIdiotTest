
namespace GeniyIdiotWinFormsApp
{
    public partial class UserNameForm : Form
    {
        public User User;
        private bool StandartQestionsList;
        public UserNameForm(bool standartQestionsList)
        {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.Enter) startButton_Click(startButton, null); };
            StandartQestionsList = standartQestionsList;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            string name = userNameTextBox.Text;
            User = new User(name);            
            Close();
            var questionsForm = new MainForm(User, StandartQestionsList);
            questionsForm.Show();
        }

        private void userNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string name = userNameTextBox.Text;
            if (string.IsNullOrEmpty(name) || name.Any(x => !char.IsLetter(x)))
            {
                MessageBox.Show("Вы ничего не ввели либо имя содержит не только буквы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}