namespace GruppFlashCards
{
    partial class Register
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
            label3 = new Label();
            userEmailTextBox = new TextBox();
            userNameTextBox = new TextBox();
            userPasswordTextBox = new TextBox();
            registerButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            outputLabel = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 54);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 117);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 186);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // userEmailTextBox
            // 
            userEmailTextBox.Location = new Point(94, 117);
            userEmailTextBox.Name = "userEmailTextBox";
            userEmailTextBox.Size = new Size(320, 23);
            userEmailTextBox.TabIndex = 4;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(94, 51);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(320, 23);
            userNameTextBox.TabIndex = 5;
            // 
            // userPasswordTextBox
            // 
            userPasswordTextBox.Location = new Point(94, 186);
            userPasswordTextBox.Name = "userPasswordTextBox";
            userPasswordTextBox.Size = new Size(320, 23);
            userPasswordTextBox.TabIndex = 6;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(23, 255);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(75, 23);
            registerButton.TabIndex = 7;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(185, 255);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 8;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(339, 255);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 9;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Location = new Point(98, 226);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(0, 15);
            outputLabel.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(172, 9);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 11;
            label4.Text = "Create an account";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 310);
            Controls.Add(label4);
            Controls.Add(outputLabel);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(registerButton);
            Controls.Add(userPasswordTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(userEmailTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox userEmailTextBox;
        private TextBox userNameTextBox;
        private TextBox userPasswordTextBox;
        private Button registerButton;
        private Button clearButton;
        private Button exitButton;
        private Label outputLabel;
        private Label label4;
    }
}