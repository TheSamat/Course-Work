namespace Domain
{
    partial class AuthForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mergeSortButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputLogin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputOzCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mergeSortButton
            // 
            this.mergeSortButton.Location = new System.Drawing.Point(32, 217);
            this.mergeSortButton.Name = "mergeSortButton";
            this.mergeSortButton.Size = new System.Drawing.Size(155, 23);
            this.mergeSortButton.TabIndex = 0;
            this.mergeSortButton.Text = "Авторизация";
            this.mergeSortButton.UseVisualStyleBackColor = true;
            this.mergeSortButton.Click += new System.EventHandler(this.mergeSortButton_ClickAsync);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(60, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Авторизация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Неверный логин или пароль!";
            // 
            // inputLogin
            // 
            this.inputLogin.Location = new System.Drawing.Point(10, 69);
            this.inputLogin.Name = "inputLogin";
            this.inputLogin.Size = new System.Drawing.Size(189, 20);
            this.inputLogin.TabIndex = 25;
            this.inputLogin.Text = "menual";
            this.inputLogin.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Логин";
            // 
            // inputPassword
            // 
            this.inputPassword.Location = new System.Drawing.Point(10, 110);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(189, 20);
            this.inputPassword.TabIndex = 27;
            this.inputPassword.Text = "menual";
            this.inputPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Пароль";
            // 
            // inputOzCode
            // 
            this.inputOzCode.Location = new System.Drawing.Point(10, 151);
            this.inputOzCode.Name = "inputOzCode";
            this.inputOzCode.Size = new System.Drawing.Size(189, 20);
            this.inputOzCode.TabIndex = 29;
            this.inputOzCode.Text = "test";
            this.inputOzCode.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Код организации";
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 252);
            this.Controls.Add(this.inputOzCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mergeSortButton);
            this.Name = "AuthForm";
            this.Text = "AuthForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mergeSortButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputOzCode;
        private System.Windows.Forms.Label label4;
    }
}

