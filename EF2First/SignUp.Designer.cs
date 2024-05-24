namespace EF2First
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            btn_up = new Button();
            label1 = new Label();
            txt_name = new TextBox();
            txt_age = new TextBox();
            txt_pass = new TextBox();
            txt_user = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btn_up
            // 
            btn_up.BackColor = Color.Snow;
            btn_up.Font = new Font("Times New Roman", 17.8217812F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_up.ForeColor = Color.FromArgb(128, 64, 64);
            btn_up.Location = new Point(596, 448);
            btn_up.Margin = new Padding(3, 4, 3, 4);
            btn_up.Name = "btn_up";
            btn_up.Size = new Size(155, 72);
            btn_up.TabIndex = 0;
            btn_up.Text = "SignUp";
            btn_up.UseVisualStyleBackColor = false;
            btn_up.Click += btn_up_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 17.8217812F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 64, 64);
            label1.Location = new Point(140, 124);
            label1.Name = "label1";
            label1.Size = new Size(133, 29);
            label1.TabIndex = 1;
            label1.Text = "Your Name";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(365, 131);
            txt_name.Margin = new Padding(3, 4, 3, 4);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(280, 33);
            txt_name.TabIndex = 5;
            // 
            // txt_age
            // 
            txt_age.Location = new Point(365, 215);
            txt_age.Margin = new Padding(3, 4, 3, 4);
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(271, 33);
            txt_age.TabIndex = 6;
            txt_age.TextChanged += txt_age_TextChanged;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(365, 296);
            txt_pass.Margin = new Padding(3, 4, 3, 4);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(271, 33);
            txt_pass.TabIndex = 7;
            txt_pass.UseSystemPasswordChar = true;
            // 
            // txt_user
            // 
            txt_user.Location = new Point(365, 375);
            txt_user.Margin = new Padding(3, 4, 3, 4);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(271, 33);
            txt_user.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 17.8217812F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(128, 64, 64);
            label5.Location = new Point(135, 368);
            label5.Name = "label5";
            label5.Size = new Size(180, 29);
            label5.TabIndex = 9;
            label5.Text = "Your Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 17.8217812F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(128, 64, 64);
            label6.Location = new Point(140, 295);
            label6.Name = "label6";
            label6.Size = new Size(176, 29);
            label6.TabIndex = 10;
            label6.Text = "Your Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 17.8217812F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(128, 64, 64);
            label7.Location = new Point(140, 214);
            label7.Name = "label7";
            label7.Size = new Size(112, 29);
            label7.TabIndex = 11;
            label7.Text = "Your Age";
            label7.Click += label7_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 24.2376232F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(266, 11);
            label2.Name = "label2";
            label2.Size = new Size(275, 39);
            label2.TabIndex = 12;
            label2.Text = "SignUp As Author";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 588);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txt_user);
            Controls.Add(txt_pass);
            Controls.Add(txt_age);
            Controls.Add(txt_name);
            Controls.Add(label1);
            Controls.Add(btn_up);
            Font = new Font("Times New Roman", 15.6831684F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 5, 5, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SignUp";
            Text = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_up;
        private Label label1;
        private TextBox txt_name;
        private TextBox txt_age;
        private TextBox txt_pass;
        private TextBox txt_user;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label2;
    }
}