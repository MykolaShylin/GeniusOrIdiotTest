namespace GeniyIdiotWinFormsApp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nextButton = new System.Windows.Forms.Button();
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.userAnswerTextBox = new System.Windows.Forms.TextBox();
            this.timerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // nextButton
            // 
            this.nextButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nextButton.Location = new System.Drawing.Point(0, 334);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(765, 111);
            this.nextButton.TabIndex = 0;
            this.nextButton.Text = "Далее";
            this.nextButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.questionNumberLabel.Location = new System.Drawing.Point(0, 62);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(767, 25);
            this.questionNumberLabel.TabIndex = 1;
            this.questionNumberLabel.Text = "Вопрос № 1";
            this.questionNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.Location = new System.Drawing.Point(-2, 115);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(767, 25);
            this.questionTextLabel.TabIndex = 2;
            this.questionTextLabel.Text = "Текст вопроса";
            this.questionTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userAnswerTextBox
            // 
            this.userAnswerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userAnswerTextBox.Location = new System.Drawing.Point(277, 178);
            this.userAnswerTextBox.Name = "userAnswerTextBox";
            this.userAnswerTextBox.PlaceholderText = "Введите ответ";
            this.userAnswerTextBox.Size = new System.Drawing.Size(208, 27);
            this.userAnswerTextBox.TabIndex = 3;
            this.userAnswerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userAnswerTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.userAnswerTextBox_Validating);
            // 
            // timerLabel
            // 
            this.timerLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.timerLabel.Location = new System.Drawing.Point(-2, 253);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(767, 45);
            this.timerLabel.TabIndex = 4;
            this.timerLabel.Text = "таймер";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 445);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.userAnswerTextBox);
            this.Controls.Add(this.questionTextLabel);
            this.Controls.Add(this.questionNumberLabel);
            this.Controls.Add(this.nextButton);
            this.Location = new System.Drawing.Point(700, 300);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Тестовое окно";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button nextButton;
        private Label questionNumberLabel;
        private Label questionTextLabel;
        private TextBox userAnswerTextBox;
        private Label timerLabel;
        private System.Windows.Forms.Timer timer1;
    }
}