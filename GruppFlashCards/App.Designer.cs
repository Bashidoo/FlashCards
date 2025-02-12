namespace GruppFlashCards
{
    partial class App
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Logout_Click = new Button();
            categoryList = new ListBox();
            label1 = new Label();
            questionLabel = new Label();
            answerLabel = new Label();
            answerTextBox = new TextBox();
            checkButton = new Button();
            clearButton = new Button();
            flashcardManager = new Button();
            categoryManagerButton = new Button();
            userOBJLabel = new Label();
            exitButton = new Button();
            outputLabel = new Label();
            questionPrompt = new Label();
            outputDateLabel = new Label();
            SuspendLayout();
            // 
            // Logout_Click
            // 
            Logout_Click.Location = new Point(12, 286);
            Logout_Click.Name = "Logout_Click";
            Logout_Click.Size = new Size(75, 23);
            Logout_Click.TabIndex = 0;
            Logout_Click.Text = "Logout";
            Logout_Click.UseVisualStyleBackColor = true;
            Logout_Click.Click += Logout_Click_Click;
            // 
            // categoryList
            // 
            categoryList.BackColor = SystemColors.Window;
            categoryList.FormattingEnabled = true;
            categoryList.ItemHeight = 15;
            categoryList.Location = new Point(12, 37);
            categoryList.Name = "categoryList";
            categoryList.Size = new Size(122, 169);
            categoryList.TabIndex = 1;
            categoryList.SelectedIndexChanged += CategoryList_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 2;
            label1.Text = "Category";
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.Location = new Point(152, 37);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(58, 15);
            questionLabel.TabIndex = 3;
            questionLabel.Text = "Question:";
            // 
            // answerLabel
            // 
            answerLabel.AutoSize = true;
            answerLabel.Location = new Point(152, 119);
            answerLabel.Name = "answerLabel";
            answerLabel.Size = new Size(49, 15);
            answerLabel.TabIndex = 5;
            answerLabel.Text = "Answer:";
            // 
            // answerTextBox
            // 
            answerTextBox.Location = new Point(152, 137);
            answerTextBox.Multiline = true;
            answerTextBox.Name = "answerTextBox";
            answerTextBox.Size = new Size(619, 80);
            answerTextBox.TabIndex = 6;
            answerTextBox.TextChanged += answerTextBox_TextChanged;
            // 
            // checkButton
            // 
            checkButton.Location = new Point(174, 223);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(104, 23);
            checkButton.TabIndex = 7;
            checkButton.Text = "Check";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += checkButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(284, 223);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(120, 23);
            clearButton.TabIndex = 8;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // flashcardManager
            // 
            flashcardManager.Location = new Point(517, 223);
            flashcardManager.Name = "flashcardManager";
            flashcardManager.Size = new Size(127, 23);
            flashcardManager.TabIndex = 9;
            flashcardManager.Text = "Flash Card Manager";
            flashcardManager.UseVisualStyleBackColor = true;
            flashcardManager.Click += flashcardManager_Click;
            // 
            // categoryManagerButton
            // 
            categoryManagerButton.Location = new Point(650, 223);
            categoryManagerButton.Name = "categoryManagerButton";
            categoryManagerButton.Size = new Size(121, 23);
            categoryManagerButton.TabIndex = 10;
            categoryManagerButton.Text = "Category Manager";
            categoryManagerButton.UseVisualStyleBackColor = true;
            categoryManagerButton.Click += categoryManagerButton_Click;
            // 
            // userOBJLabel
            // 
            userOBJLabel.AutoSize = true;
            userOBJLabel.Location = new Point(437, 19);
            userOBJLabel.Name = "userOBJLabel";
            userOBJLabel.Size = new Size(0, 15);
            userOBJLabel.TabIndex = 11;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(696, 286);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 12;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Location = new Point(403, 274);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(0, 15);
            outputLabel.TabIndex = 13;
            outputLabel.Click += outputLabel_Click;
            // 
            // questionPrompt
            // 
            questionPrompt.AutoSize = true;
            questionPrompt.Location = new Point(216, 37);
            questionPrompt.Name = "questionPrompt";
            questionPrompt.Size = new Size(0, 15);
            questionPrompt.TabIndex = 14;
            questionPrompt.Click += questionPrompt_Click;
            // 
            // outputDateLabel
            // 
            outputDateLabel.AutoSize = true;
            outputDateLabel.Location = new Point(303, 290);
            outputDateLabel.Name = "outputDateLabel";
            outputDateLabel.Size = new Size(101, 15);
            outputDateLabel.TabIndex = 15;
            outputDateLabel.Text = "Next Review Date:";
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 335);
            Controls.Add(outputDateLabel);
            Controls.Add(questionPrompt);
            Controls.Add(outputLabel);
            Controls.Add(exitButton);
            Controls.Add(userOBJLabel);
            Controls.Add(categoryManagerButton);
            Controls.Add(flashcardManager);
            Controls.Add(clearButton);
            Controls.Add(checkButton);
            Controls.Add(answerTextBox);
            Controls.Add(answerLabel);
            Controls.Add(questionLabel);
            Controls.Add(label1);
            Controls.Add(categoryList);
            Controls.Add(Logout_Click);
            Name = "App";
            Text = "App";
            Load += App_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Logout_Click;
        private ListBox CategoryList;
        private Label label1;
        private Label questionLabel;
        private Label answerLabel;
        private TextBox answerTextBox;
        private Button checkButton;
        private Button clearButton;
        private Button flashcardManager;
        private Button categoryManagerButton;
        private Label userOBJLabel;
        private Button exitButton;
        private Label outputLabel;
        private ListBox categoryList;
        private Label questionPrompt;
        private Label outputDateLabel;
    }
}