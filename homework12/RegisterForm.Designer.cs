namespace homework12
{
    partial class RegisterForm
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
            label1 = new Label();
            pAvatar = new PictureBox();
            btnSelectPhoto = new Button();
            label2 = new Label();
            txtLogin = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            btnSave = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pAvatar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(43, 31);
            label1.Name = "label1";
            label1.Size = new Size(217, 30);
            label1.TabIndex = 0;
            label1.Tag = "";
            label1.Text = "Створення акаунту";
            // 
            // pAvatar
            // 
            pAvatar.Location = new Point(43, 74);
            pAvatar.Name = "pAvatar";
            pAvatar.Size = new Size(120, 120);
            pAvatar.TabIndex = 1;
            pAvatar.TabStop = false;
            // 
            // btnSelectPhoto
            // 
            btnSelectPhoto.Cursor = Cursors.Hand;
            btnSelectPhoto.Location = new Point(43, 223);
            btnSelectPhoto.Name = "btnSelectPhoto";
            btnSelectPhoto.Size = new Size(217, 23);
            btnSelectPhoto.TabIndex = 2;
            btnSelectPhoto.Text = "Обрати фото профілю";
            btnSelectPhoto.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(43, 262);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 3;
            label2.Text = "Логін:";
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Segoe UI", 11F);
            txtLogin.Location = new Point(94, 262);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(166, 27);
            txtLogin.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(43, 313);
            label3.Name = "label3";
            label3.Size = new Size(59, 19);
            label3.TabIndex = 5;
            label3.Text = "Пароль:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(108, 305);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 27);
            textBox1.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.ForeColor = Color.Green;
            btnSave.Location = new Point(43, 356);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(217, 23);
            btnSave.TabIndex = 7;
            btnSave.Text = "Зареєструватися";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.ForeColor = Color.FromArgb(192, 0, 0);
            btnBack.Location = new Point(43, 404);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(217, 23);
            btnBack.TabIndex = 8;
            btnBack.Text = "Скасувати";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(txtLogin);
            Controls.Add(label2);
            Controls.Add(btnSelectPhoto);
            Controls.Add(pAvatar);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "Реєстрація";
            ((System.ComponentModel.ISupportInitialize)pAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pAvatar;
        private Button btnSelectPhoto;
        private Label label2;
        private TextBox txtLogin;
        private Label label3;
        private TextBox textBox1;
        private Button btnSave;
        private Button btnBack;
    }
}
