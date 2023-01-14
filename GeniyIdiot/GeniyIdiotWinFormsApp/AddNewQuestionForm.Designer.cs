namespace GeniyIdiotWinFormsApp
{
    partial class AddNewQuestionForm
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
            this.newQuestionLable = new System.Windows.Forms.Label();
            this.newQuestionTextBox = new System.Windows.Forms.TextBox();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.answerLable = new System.Windows.Forms.Label();
            this.returnToMainMenuButton = new System.Windows.Forms.Button();
            this.acceptNewQuestionButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newQuestionLable
            // 
            this.newQuestionLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.newQuestionLable.Location = new System.Drawing.Point(1, 45);
            this.newQuestionLable.Name = "newQuestionLable";
            this.newQuestionLable.Size = new System.Drawing.Size(606, 22);
            this.newQuestionLable.TabIndex = 0;
            this.newQuestionLable.Text = "Введите новый вопрос";
            this.newQuestionLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newQuestionTextBox
            // 
            this.newQuestionTextBox.Location = new System.Drawing.Point(53, 114);
            this.newQuestionTextBox.Name = "newQuestionTextBox";
            this.newQuestionTextBox.PlaceholderText = "Введите вопрос";
            this.newQuestionTextBox.Size = new System.Drawing.Size(513, 27);
            this.newQuestionTextBox.TabIndex = 1;
            this.newQuestionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(53, 243);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.PlaceholderText = "Введите ответ";
            this.answerTextBox.Size = new System.Drawing.Size(513, 27);
            this.answerTextBox.TabIndex = 3;
            this.answerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.answerTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.answerTextBox_Validating);
            // 
            // answerLable
            // 
            this.answerLable.Location = new System.Drawing.Point(1, 188);
            this.answerLable.Name = "answerLable";
            this.answerLable.Size = new System.Drawing.Size(617, 22);
            this.answerLable.TabIndex = 2;
            this.answerLable.Text = "Введите ответ";
            this.answerLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // returnToMainMenuButton
            // 
            this.returnToMainMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.returnToMainMenuButton.Location = new System.Drawing.Point(413, 324);
            this.returnToMainMenuButton.Name = "returnToMainMenuButton";
            this.returnToMainMenuButton.Size = new System.Drawing.Size(153, 54);
            this.returnToMainMenuButton.TabIndex = 5;
            this.returnToMainMenuButton.Text = "Сохранить и вернуться в главное меню";
            this.returnToMainMenuButton.UseVisualStyleBackColor = true;
            this.returnToMainMenuButton.Click += new System.EventHandler(this.returnToMainMenuButton_Click);
            // 
            // acceptNewQuestionButon
            // 
            this.acceptNewQuestionButon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.acceptNewQuestionButon.Location = new System.Drawing.Point(53, 324);
            this.acceptNewQuestionButon.Name = "acceptNewQuestionButon";
            this.acceptNewQuestionButon.Size = new System.Drawing.Size(151, 53);
            this.acceptNewQuestionButon.TabIndex = 6;
            this.acceptNewQuestionButon.Text = "Добавить вопрос";
            this.acceptNewQuestionButon.UseVisualStyleBackColor = true;
            this.acceptNewQuestionButon.Click += new System.EventHandler(this.acceptNewQuestionButon_Click);
            // 
            // AddNewQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 415);
            this.Controls.Add(this.acceptNewQuestionButon);
            this.Controls.Add(this.returnToMainMenuButton);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.answerLable);
            this.Controls.Add(this.newQuestionTextBox);
            this.Controls.Add(this.newQuestionLable);
            this.Name = "AddNewQuestionForm";
            this.Text = "Меню нового вопроса";
            this.Load += new System.EventHandler(this.AddNewQuestionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label newQuestionLable;
        private TextBox newQuestionTextBox;
        private TextBox answerTextBox;
        private Label answerLable;
        private Button returnToMainMenuButton;
        private Button acceptNewQuestionButon;
    }
}