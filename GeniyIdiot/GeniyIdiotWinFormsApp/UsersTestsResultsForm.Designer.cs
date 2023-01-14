namespace GeniyIdiotWinFormsApp
{
    partial class UsersTestsResultsForm
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
            this.usersResultsTable = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountRightAnswersColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiagnosisColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clearTableButton = new System.Windows.Forms.Button();
            this.closeTableButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersResultsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // usersResultsTable
            // 
            this.usersResultsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersResultsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersResultsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.usersResultsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersResultsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.CountRightAnswersColumn,
            this.DiagnosisColumn});
            this.usersResultsTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersResultsTable.Location = new System.Drawing.Point(0, 0);
            this.usersResultsTable.Name = "usersResultsTable";
            this.usersResultsTable.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.usersResultsTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.usersResultsTable.RowTemplate.Height = 29;
            this.usersResultsTable.Size = new System.Drawing.Size(800, 518);
            this.usersResultsTable.TabIndex = 0;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Имя";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // CountRightAnswersColumn
            // 
            this.CountRightAnswersColumn.HeaderText = "Количество верных ответов";
            this.CountRightAnswersColumn.MinimumWidth = 6;
            this.CountRightAnswersColumn.Name = "CountRightAnswersColumn";
            this.CountRightAnswersColumn.ReadOnly = true;
            // 
            // DiagnosisColumn
            // 
            this.DiagnosisColumn.HeaderText = "Диагноз";
            this.DiagnosisColumn.MinimumWidth = 6;
            this.DiagnosisColumn.Name = "DiagnosisColumn";
            this.DiagnosisColumn.ReadOnly = true;
            // 
            // clearTableButton
            // 
            this.clearTableButton.Location = new System.Drawing.Point(0, 524);
            this.clearTableButton.Name = "clearTableButton";
            this.clearTableButton.Size = new System.Drawing.Size(395, 74);
            this.clearTableButton.TabIndex = 1;
            this.clearTableButton.Text = "Очистить таблицу";
            this.clearTableButton.UseVisualStyleBackColor = true;
            this.clearTableButton.Click += new System.EventHandler(this.clearTableButton_Click);
            // 
            // closeTableButton
            // 
            this.closeTableButton.Location = new System.Drawing.Point(401, 520);
            this.closeTableButton.Name = "closeTableButton";
            this.closeTableButton.Size = new System.Drawing.Size(399, 82);
            this.closeTableButton.TabIndex = 2;
            this.closeTableButton.Text = "Главное меню";
            this.closeTableButton.UseVisualStyleBackColor = true;
            this.closeTableButton.Click += new System.EventHandler(this.closeTableButton_Click);
            // 
            // UsersTestsResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.closeTableButton);
            this.Controls.Add(this.clearTableButton);
            this.Controls.Add(this.usersResultsTable);
            this.Location = new System.Drawing.Point(700, 100);
            this.Name = "UsersTestsResultsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Результаты всех тестов";
            this.Load += new System.EventHandler(this.UsersTestsResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersResultsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView usersResultsTable;
        private Button clearTableButton;
        private Button closeTableButton;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn CountRightAnswersColumn;
        private DataGridViewTextBoxColumn DiagnosisColumn;
    }
}