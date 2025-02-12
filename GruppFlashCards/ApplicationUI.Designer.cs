namespace GruppFlashCards
{
    partial class ApplicationUI
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
            txt_Email = new TextBox();
            txt_password = new TextBox();
            button_login = new Button();
            button_Exit = new Button();
            button_clear = new Button();
            button_register = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Traditional Arabic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(179, 77);
            label1.Name = "label1";
            label1.Size = new Size(286, 32);
            label1.TabIndex = 0;
            label1.Text = "Welcome To FlashCards App";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 171);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 242);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(165, 171);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(317, 23);
            txt_Email.TabIndex = 3;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(165, 239);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(317, 23);
            txt_password.TabIndex = 4;
            // 
            // button_login
            // 
            button_login.Location = new Point(357, 284);
            button_login.Name = "button_login";
            button_login.Size = new Size(122, 33);
            button_login.TabIndex = 5;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // button_Exit
            // 
            button_Exit.Location = new Point(357, 341);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(122, 36);
            button_Exit.TabIndex = 7;
            button_Exit.Text = "Exit";
            button_Exit.UseVisualStyleBackColor = true;
            button_Exit.Click += button_Exit_Click;
            // 
            // button_clear
            // 
            button_clear.Location = new Point(165, 341);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(106, 37);
            button_clear.TabIndex = 8;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_Click;
            // 
            // button_register
            // 
            button_register.Location = new Point(165, 284);
            button_register.Name = "button_register";
            button_register.Size = new Size(106, 33);
            button_register.TabIndex = 6;
            button_register.Text = "Register";
            button_register.UseVisualStyleBackColor = true;
            button_register.Click += button_register_Click;
            // 
            // ApplicationUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 450);
            Controls.Add(button_clear);
            Controls.Add(button_Exit);
            Controls.Add(button_register);
            Controls.Add(button_login);
            Controls.Add(txt_password);
            Controls.Add(txt_Email);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ApplicationUI";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_Email;
        private TextBox txt_password;
        private Button button_login;
        private Button button_Exit;
        private Button button_clear;
        private Button button_register;
    }
}