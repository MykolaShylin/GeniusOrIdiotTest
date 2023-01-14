namespace GeniyIdiotWinFormsApp
{
    public partial class UsersTestsResultsForm : Form
    {
        private DataGridViewCell name;
        private DataGridViewCell countRightAnswers;
        private DataGridViewCell diagnosis;
        private DataGridViewRow row;
        private UsersResultsStorage resultsStorage;
        public UsersTestsResultsForm()
        {
            InitializeComponent();
        }

        private void UsersTestsResultsForm_Load(object sender, EventArgs e)
        {
            resultsStorage = new();
            if (!File.Exists(resultsStorage.FilePath))
            {
                MessageBox.Show("Результатов нет, пройдите тест и будьте первым в таблице!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            else
            {
                var results = resultsStorage.GetUsersResults();

                foreach (var user in results)
                {
                    name = new DataGridViewTextBoxCell();
                    countRightAnswers = new DataGridViewTextBoxCell();
                    diagnosis = new DataGridViewTextBoxCell();
                    row = new DataGridViewRow();

                    name.Value = user.UserName;
                    countRightAnswers.Value = user.CountRightAnswers;
                    diagnosis.Value = user.Diagnosis;

                    row.Cells.AddRange(name, countRightAnswers, diagnosis);
                    usersResultsTable.Rows.AddRange(row);
                }
            }            
            
        }

        private void closeTableButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearTableButton_Click(object sender, EventArgs e)
        {
            usersResultsTable.Rows.Clear();
            File.Delete(resultsStorage.FilePath);
            MessageBox.Show("Результаты всех тестов удалены!", "Информирование", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}