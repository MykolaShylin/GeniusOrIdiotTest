namespace GeniyIdiotWinFormsApp
{
    partial class ProgramStartMenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenuLable = new System.Windows.Forms.Label();
            this.standartQuestionsListButton = new System.Windows.Forms.Button();
            this.existingQuestionsListButton = new System.Windows.Forms.Button();
            this.addQuestionButton = new System.Windows.Forms.Button();
            this.deliteQuestionButton = new System.Windows.Forms.Button();
            this.usersResultsButton = new System.Windows.Forms.Button();
            this.exitProgramButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenuLable
            // 
            this.mainMenuLable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainMenuLable.Location = new System.Drawing.Point(46, 18);
            this.mainMenuLable.Name = "mainMenuLable";
            this.mainMenuLable.Size = new System.Drawing.Size(552, 48);
            this.mainMenuLable.TabIndex = 0;
            this.mainMenuLable.Text = "Здравствуйте, вы находитесь в главном меню программы по определению уровня вашего" +
    " интелекта, пожалуйста, выбирете пункт меню!";
            this.mainMenuLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // standartQuestionsListButton
            // 
            this.standartQuestionsListButton.Location = new System.Drawing.Point(155, 84);
            this.standartQuestionsListButton.Name = "standartQuestionsListButton";
            this.standartQuestionsListButton.Size = new System.Drawing.Size(320, 64);
            this.standartQuestionsListButton.TabIndex = 1;
            this.standartQuestionsListButton.Text = "Стандартный список вопросов";
            this.standartQuestionsListButton.UseVisualStyleBackColor = true;
            this.standartQuestionsListButton.Click += new System.EventHandler(this.standartQuestionsListButton_Click);
            // 
            // existingQuestionsListButton
            // 
            this.existingQuestionsListButton.Location = new System.Drawing.Point(155, 177);
            this.existingQuestionsListButton.Name = "existingQuestionsListButton";
            this.existingQuestionsListButton.Size = new System.Drawing.Size(320, 64);
            this.existingQuestionsListButton.TabIndex = 2;
            this.existingQuestionsListButton.Text = "Существующий список вопросов";
            this.existingQuestionsListButton.UseVisualStyleBackColor = true;
            this.existingQuestionsListButton.Click += new System.EventHandler(this.existingQuestionsListButton_Click);
            // 
            // addQuestionButton
            // 
            this.addQuestionButton.Location = new System.Drawing.Point(155, 271);
            this.addQuestionButton.Name = "addQuestionButton";
            this.addQuestionButton.Size = new System.Drawing.Size(320, 64);
            this.addQuestionButton.TabIndex = 3;
            this.addQuestionButton.Text = "Добавить новый вопрос";
            this.addQuestionButton.UseVisualStyleBackColor = true;
            this.addQuestionButton.Click += new System.EventHandler(this.addQuestionButton_Click);
            // 
            // deliteQuestionButton
            // 
            this.deliteQuestionButton.Location = new System.Drawing.Point(155, 369);
            this.deliteQuestionButton.Name = "deliteQuestionButton";
            this.deliteQuestionButton.Size = new System.Drawing.Size(320, 64);
            this.deliteQuestionButton.TabIndex = 4;
            this.deliteQuestionButton.Text = "Удалить вопрос";
            this.deliteQuestionButton.UseVisualStyleBackColor = true;
            this.deliteQuestionButton.Click += new System.EventHandler(this.deliteQuestionButton_Click);
            // 
            // usersResultsButton
            // 
            this.usersResultsButton.Location = new System.Drawing.Point(155, 469);
            this.usersResultsButton.Name = "usersResultsButton";
            this.usersResultsButton.Size = new System.Drawing.Size(320, 64);
            this.usersResultsButton.TabIndex = 5;
            this.usersResultsButton.Text = "Показать результаты всех игр";
            this.usersResultsButton.UseVisualStyleBackColor = true;
            this.usersResultsButton.Click += new System.EventHandler(this.usersResultsButton_Click);
            // 
            // exitProgramButton
            // 
            this.exitProgramButton.Location = new System.Drawing.Point(155, 567);
            this.exitProgramButton.Name = "exitProgramButton";
            this.exitProgramButton.Size = new System.Drawing.Size(320, 64);
            this.exitProgramButton.TabIndex = 6;
            this.exitProgramButton.Text = "Закрыть программу";
            this.exitProgramButton.UseVisualStyleBackColor = true;
            this.exitProgramButton.Click += new System.EventHandler(this.exitProgramButton_Click);
            // 
            // ProgramStartMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 660);
            this.Controls.Add(this.exitProgramButton);
            this.Controls.Add(this.usersResultsButton);
            this.Controls.Add(this.deliteQuestionButton);
            this.Controls.Add(this.addQuestionButton);
            this.Controls.Add(this.existingQuestionsListButton);
            this.Controls.Add(this.standartQuestionsListButton);
            this.Controls.Add(this.mainMenuLable);
            this.Name = "ProgramStartMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.ProgramStartMenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label mainMenuLable;
        private Button standartQuestionsListButton;
        private Button existingQuestionsListButton;
        private Button addQuestionButton;
        private Button deliteQuestionButton;
        private Button usersResultsButton;
        private Button exitProgramButton;
    }
}