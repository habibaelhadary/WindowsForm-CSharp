namespace EF2First
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            txt_pass = new TextBox();
            label4 = new Label();
            btn_login = new Button();
            btn_sign = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24.2376232F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(253, 19);
            label1.Name = "label1";
            label1.Size = new Size(258, 38);
            label1.TabIndex = 0;
            label1.Text = "Login As Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Info;
            label2.Font = new Font("Times New Roman", 15.6831684F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 64, 64);
            label2.Location = new Point(82, 114);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 1;
            label2.Text = "Your Name";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.Location = new Point(253, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(456, 25);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // txt_pass
            // 
            txt_pass.BackColor = Color.WhiteSmoke;
            txt_pass.Location = new Point(253, 184);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(456, 25);
            txt_pass.TabIndex = 5;
            txt_pass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Info;
            label4.Font = new Font("Times New Roman", 15.6831684F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(128, 64, 64);
            label4.Location = new Point(73, 184);
            label4.Name = "label4";
            label4.Size = new Size(154, 25);
            label4.TabIndex = 6;
            label4.Text = "Your Password";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Click += label4_Click;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Silver;
            btn_login.Font = new Font("Times New Roman", 17.8217812F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.FromArgb(128, 64, 64);
            btn_login.Location = new Point(337, 302);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(149, 52);
            btn_login.TabIndex = 7;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // btn_sign
            // 
            btn_sign.BackColor = Color.Silver;
            btn_sign.Font = new Font("Times New Roman", 17.8217812F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_sign.ForeColor = Color.FromArgb(128, 64, 64);
            btn_sign.Location = new Point(526, 302);
            btn_sign.Name = "btn_sign";
            btn_sign.Size = new Size(149, 52);
            btn_sign.TabIndex = 8;
            btn_sign.Text = "SignUp";
            btn_sign.UseVisualStyleBackColor = false;
            btn_sign.Click += btn_sign_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_sign);
            Controls.Add(btn_login);
            Controls.Add(label4);
            Controls.Add(txt_pass);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "Login";
            TransparencyKey = Color.Transparent;
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private TextBox txt_pass;
        private Label label4;
        private Button btn_login;
        private Button btn_sign;
    }
}