namespace GruppFlashCards
{
    partial class FlashCardManager
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
            components = new System.ComponentModel.Container();
            flashcardNameTextBox = new TextBox();
            flashcardQuestionTextBox = new TextBox();
            flashcardDescriptionTextBox = new TextBox();
            flashcardAnswerTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            outputConsoleLabel = new Label();
            addButton = new Button();
            clearButton = new Button();
            categoryManagerList = new ListBox();
            label6 = new Label();
            FlashCardManagerLabel = new Label();
            exitButton = new Button();
            busherSundayContextBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)busherSundayContextBindingSource).BeginInit();
            SuspendLayout();
            // 
            // flashcardNameTextBox
            // 
            flashcardNameTextBox.Location = new Point(131, 48);
            flashcardNameTextBox.Name = "flashcardNameTextBox";
            flashcardNameTextBox.Size = new Size(239, 23);
            flashcardNameTextBox.TabIndex = 0;
            // 
            // flashcardQuestionTextBox
            // 
            flashcardQuestionTextBox.Location = new Point(131, 98);
            flashcardQuestionTextBox.Multiline = true;
            flashcardQuestionTextBox.Name = "flashcardQuestionTextBox";
            flashcardQuestionTextBox.Size = new Size(239, 62);
            flashcardQuestionTextBox.TabIndex = 1;
            // 
            // flashcardDescriptionTextBox
            // 
            flashcardDescriptionTextBox.Location = new Point(131, 166);
            flashcardDescriptionTextBox.Multiline = true;
            flashcardDescriptionTextBox.Name = "flashcardDescriptionTextBox";
            flashcardDescriptionTextBox.Size = new Size(239, 55);
            flashcardDescriptionTextBox.TabIndex = 2;
            // 
            // flashcardAnswerTextBox
            // 
            flashcardAnswerTextBox.Location = new Point(131, 235);
            flashcardAnswerTextBox.Multiline = true;
            flashcardAnswerTextBox.Name = "flashcardAnswerTextBox";
            flashcardAnswerTextBox.Size = new Size(239, 56);
            flashcardAnswerTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 51);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 6;
            label1.Text = "Flash Card Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 98);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 7;
            label2.Text = "Flash Card Question:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 169);
            label3.Name = "label3";
            label3.Size = new Size(128, 15);
            label3.TabIndex = 8;
            label3.Text = "Flash Card Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 243);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 9;
            label4.Text = "Flash Card Answer:";
            // 
            // outputConsoleLabel
            // 
            outputConsoleLabel.AutoSize = true;
            outputConsoleLabel.Location = new Point(190, 309);
            outputConsoleLabel.Name = "outputConsoleLabel";
            outputConsoleLabel.Size = new Size(0, 15);
            outputConsoleLabel.TabIndex = 10;
            // 
            // addButton
            // 
            addButton.Location = new Point(144, 351);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 11;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(251, 351);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 12;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // categoryManagerList
            // 
            categoryManagerList.FormattingEnabled = true;
            categoryManagerList.ItemHeight = 15;
            categoryManagerList.Location = new Point(376, 48);
            categoryManagerList.Name = "categoryManagerList";
            categoryManagerList.Size = new Size(120, 244);
            categoryManagerList.TabIndex = 13;
            categoryManagerList.SelectedIndexChanged += categoryManagerList_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(376, 30);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 14;
            label6.Text = "Category";
            // 
            // FlashCardManagerLabel
            // 
            FlashCardManagerLabel.AutoSize = true;
            FlashCardManagerLabel.Location = new Point(169, 9);
            FlashCardManagerLabel.Name = "FlashCardManagerLabel";
            FlashCardManagerLabel.Size = new Size(112, 15);
            FlashCardManagerLabel.TabIndex = 15;
            FlashCardManagerLabel.Text = "Flash Card Manager";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(417, 350);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 16;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // busherSundayContextBindingSource
            // 
            busherSundayContextBindingSource.DataSource = typeof(Models.BusherSundayContext);
            // 
            // FlashCardManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 405);
            Controls.Add(exitButton);
            Controls.Add(FlashCardManagerLabel);
            Controls.Add(label6);
            Controls.Add(categoryManagerList);
            Controls.Add(clearButton);
            Controls.Add(addButton);
            Controls.Add(outputConsoleLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flashcardAnswerTextBox);
            Controls.Add(flashcardDescriptionTextBox);
            Controls.Add(flashcardQuestionTextBox);
            Controls.Add(flashcardNameTextBox);
            Name = "FlashCardManager";
            Text = "FlashCardManager";
            ((System.ComponentModel.ISupportInitialize)busherSundayContextBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox flashcardNameTextBox;
        private TextBox flashcardQuestionTextBox;
        private TextBox flashcardDescriptionTextBox;
        private TextBox flashcardAnswerTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label outputConsoleLabel;
        private Button addButton;
        private Button clearButton;
        private ListBox categoryManagerList;
        private Label label6;
        private Label FlashCardManagerLabel;
        private Button exitButton;
        private BindingSource busherSundayContextBindingSource;
    }
}