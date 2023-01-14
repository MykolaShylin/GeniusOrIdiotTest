namespace GeniyIdiotWinFormsApp
{
    partial class DeliteQuestionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.questionsTable = new System.Windows.Forms.DataGridView();
            this.rowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userAnswerTextBox = new System.Windows.Forms.TextBox();
            this.deliteQuestionButton = new System.Windows.Forms.Button();
            this.startProgramButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.questionsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // questionsTable
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.questionsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.questionsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowNumber,
            this.questionColumn});
            this.questionsTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.questionsTable.Location = new System.Drawing.Point(0, 0);
            this.questionsTable.Name = "questionsTable";
            this.questionsTable.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.questionsTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.questionsTable.RowTemplate.Height = 29;
            this.questionsTable.Size = new System.Drawing.Size(794, 487);
            this.questionsTable.TabIndex = 0;
            // 
            // rowNumber
            // 
            this.rowNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rowNumber.HeaderText = "№";
            this.rowNumber.MinimumWidth = 6;
            this.rowNumber.Name = "rowNumber";
            this.rowNumber.ReadOnly = true;
            this.rowNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rowNumber.Width = 50;
            // 
            // questionColumn
            // 
            this.questionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.questionColumn.HeaderText = "Вопрос";
            this.questionColumn.MinimumWidth = 6;
            this.questionColumn.Name = "questionColumn";
            this.questionColumn.ReadOnly = true;
            this.questionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // userAnswerTextBox
            // 
            this.userAnswerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userAnswerTextBox.Location = new System.Drawing.Point(212, 509);
            this.userAnswerTextBox.Name = "userAnswerTextBox";
            this.userAnswerTextBox.PlaceholderText = "Введите номер вопроса, который хотите удалить";
            this.userAnswerTextBox.Size = new System.Drawing.Size(351, 27);
            this.userAnswerTextBox.TabIndex = 1;
            this.userAnswerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userAnswerTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.userAnswerTextBox_Validating);
            // 
            // deliteQuestionButton
            // 
            this.deliteQuestionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deliteQuestionButton.Location = new System.Drawing.Point(0, 552);
            this.deliteQuestionButton.Name = "deliteQuestionButton";
            this.deliteQuestionButton.Size = new System.Drawing.Size(329, 75);
            this.deliteQuestionButton.TabIndex = 2;
            this.deliteQuestionButton.Text = "Удалить вопрос";
            this.deliteQuestionButton.UseVisualStyleBackColor = true;
            this.deliteQuestionButton.Click += new System.EventHandler(this.deliteQuestionButton_Click);
            // 
            // startProgramButton
            // 
            this.startProgramButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startProgramButton.Location = new System.Drawing.Point(454, 552);
            this.startProgramButton.Name = "startProgramButton";
            this.startProgramButton.Size = new System.Drawing.Size(340, 75);
            this.startProgramButton.TabIndex = 3;
            this.startProgramButton.Text = "Сохранить и вернуться в главное меню";
            this.startProgramButton.UseVisualStyleBackColor = true;
            this.startProgramButton.Click += new System.EventHandler(this.startProgramButton_Click);
            // 
            // DeliteQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 626);
            this.Controls.Add(this.startProgramButton);
            this.Controls.Add(this.deliteQuestionButton);
            this.Controls.Add(this.userAnswerTextBox);
            this.Controls.Add(this.questionsTable);
            this.Location = new System.Drawing.Point(700, 100);
            this.Name = "DeliteQuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Меню удаления вопроса";
            this.Load += new System.EventHandler(this.DeliteQuestionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView questionsTable;
        private TextBox userAnswerTextBox;
        private Button deliteQuestionButton;
        private Button startProgramButton;
        private DataGridViewTextBoxColumn rowNumber;
        private DataGridViewTextBoxColumn questionColumn;
    }
}