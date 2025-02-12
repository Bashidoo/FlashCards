namespace GruppFlashCards
{
    partial class CategoryManager
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
            label1 = new Label();
            label2 = new Label();
            addButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            categoryIdTextBox = new TextBox();
            categoryNameTextBox = new TextBox();
            outputLabel = new Label();
            label4 = new Label();
            categoriesListBox = new ListBox();
            label3 = new Label();
            removeButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 104);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Category Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 59);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Category ID:";
            // 
            // addButton
            // 
            addButton.Location = new Point(26, 204);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 2;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(139, 204);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 3;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(262, 204);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // categoryIdTextBox
            // 
            categoryIdTextBox.Location = new Point(102, 56);
            categoryIdTextBox.Name = "categoryIdTextBox";
            categoryIdTextBox.Size = new Size(215, 23);
            categoryIdTextBox.TabIndex = 5;
            // 
            // categoryNameTextBox
            // 
            categoryNameTextBox.Location = new Point(102, 104);
            categoryNameTextBox.Name = "categoryNameTextBox";
            categoryNameTextBox.Size = new Size(215, 23);
            categoryNameTextBox.TabIndex = 6;
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Location = new Point(102, 158);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(0, 15);
            outputLabel.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(139, 9);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 8;
            label4.Text = "Category Manager";
            // 
            // categoriesListBox
            // 
            categoriesListBox.FormattingEnabled = true;
            categoriesListBox.ItemHeight = 15;
            categoriesListBox.Location = new Point(360, 24);
            categoriesListBox.Name = "categoriesListBox";
            categoriesListBox.Size = new Size(120, 169);
            categoriesListBox.TabIndex = 9;
            categoriesListBox.SelectedIndexChanged += categoriesListBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(360, 6);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 10;
            label3.Text = "Categories";
            // 
            // removeButton
            // 
            removeButton.Location = new Point(383, 204);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(75, 23);
            removeButton.TabIndex = 11;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // CategoryManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 252);
            Controls.Add(removeButton);
            Controls.Add(label3);
            Controls.Add(categoriesListBox);
            Controls.Add(label4);
            Controls.Add(outputLabel);
            Controls.Add(categoryNameTextBox);
            Controls.Add(categoryIdTextBox);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(addButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CategoryManager";
            Text = "CategoryManager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button addButton;
        private Button clearButton;
        private Button exitButton;
        private TextBox categoryIdTextBox;
        private TextBox categoryNameTextBox;
        private Label outputLabel;
        private Label label4;
        private ListBox categoriesListBox;
        private Label label3;
        private Button removeButton;
    }
}