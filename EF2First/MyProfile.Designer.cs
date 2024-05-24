namespace EF2First
{
    partial class MyProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyProfile));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            jionDate = new Label();
            la_age = new Label();
            label8 = new Label();
            label7 = new Label();
            usern = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            MYnew = new TabPage();
            btn_edt = new Button();
            btn_delet = new Button();
            btn_Add = new Button();
            cobCat = new ComboBox();
            txt_des = new TextBox();
            prof = new TextBox();
            txt_title = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label6 = new Label();
            DGV1 = new DataGridView();
            AllN = new TabPage();
            pictureBox2 = new PictureBox();
            label12 = new Label();
            DGV2 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            MYnew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV1).BeginInit();
            AllN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(MYnew);
            tabControl1.Controls.Add(AllN);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(801, 451);
            tabControl1.TabIndex = 1;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            tabControl1.Selected += tabControl1_Selected;
            tabControl1.MouseDoubleClick += tabControl1_MouseDoubleClick;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(jionDate);
            tabPage1.Controls.Add(la_age);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(usern);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(button1);
            tabPage1.Font = new Font("Times New Roman", 14.2574253F, FontStyle.Italic, GraphicsUnit.Point, 0);
            tabPage1.ForeColor = Color.Maroon;
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(793, 421);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "My Profile";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // jionDate
            // 
            jionDate.AutoSize = true;
            jionDate.Font = new Font("Times New Roman", 17.8217812F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jionDate.ForeColor = Color.Black;
            jionDate.Location = new Point(592, 201);
            jionDate.Name = "jionDate";
            jionDate.Size = new Size(84, 29);
            jionDate.TabIndex = 11;
            jionDate.Text = "label10";
            // 
            // la_age
            // 
            la_age.AutoSize = true;
            la_age.Font = new Font("Times New Roman", 17.8217812F, FontStyle.Regular, GraphicsUnit.Point, 0);
            la_age.ForeColor = Color.Black;
            la_age.Location = new Point(592, 110);
            la_age.Name = "la_age";
            la_age.Size = new Size(72, 29);
            la_age.TabIndex = 10;
            la_age.Text = "label9";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 17.8217812F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(472, 200);
            label8.Name = "label8";
            label8.Size = new Size(114, 29);
            label8.TabIndex = 9;
            label8.Text = "Jion Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 17.8217812F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(67, 200);
            label7.Name = "label7";
            label7.Size = new Size(126, 29);
            label7.TabIndex = 8;
            label7.Text = "UserName";
            // 
            // usern
            // 
            usern.AutoSize = true;
            usern.Font = new Font("Times New Roman", 17.8217812F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usern.ForeColor = Color.Black;
            usern.Location = new Point(217, 200);
            usern.Name = "usern";
            usern.Size = new Size(72, 29);
            usern.TabIndex = 7;
            usern.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 17.8217812F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(481, 110);
            label5.Name = "label5";
            label5.Size = new Size(55, 29);
            label5.TabIndex = 6;
            label5.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 17.8217812F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(173, 110);
            label4.Name = "label4";
            label4.Size = new Size(72, 29);
            label4.TabIndex = 5;
            label4.Text = "label4";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 17.8217812F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(67, 109);
            label3.Name = "label3";
            label3.Size = new Size(75, 29);
            label3.TabIndex = 4;
            label3.Text = "Name";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(245, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 52);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(217, 33);
            label2.Name = "label2";
            label2.Size = new Size(0, 22);
            label2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.9603958F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(307, 23);
            label1.Name = "label1";
            label1.Size = new Size(137, 32);
            label1.TabIndex = 1;
            label1.Text = "My Profile";
            // 
            // button1
            // 
            button1.Location = new Point(527, 339);
            button1.Name = "button1";
            button1.Size = new Size(176, 51);
            button1.TabIndex = 0;
            button1.Text = "LogOut";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MYnew
            // 
            MYnew.BackColor = Color.Transparent;
            MYnew.Controls.Add(btn_edt);
            MYnew.Controls.Add(btn_delet);
            MYnew.Controls.Add(btn_Add);
            MYnew.Controls.Add(cobCat);
            MYnew.Controls.Add(txt_des);
            MYnew.Controls.Add(prof);
            MYnew.Controls.Add(txt_title);
            MYnew.Controls.Add(label11);
            MYnew.Controls.Add(label10);
            MYnew.Controls.Add(label9);
            MYnew.Controls.Add(label6);
            MYnew.Controls.Add(DGV1);
            MYnew.Location = new Point(4, 26);
            MYnew.Name = "MYnew";
            MYnew.Padding = new Padding(3);
            MYnew.Size = new Size(793, 421);
            MYnew.TabIndex = 1;
            MYnew.Text = "My News";
            MYnew.Click += MYnew_Click;
            // 
            // btn_edt
            // 
            btn_edt.BackColor = Color.WhiteSmoke;
            btn_edt.Font = new Font("Times New Roman", 14.2574253F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_edt.ForeColor = Color.FromArgb(192, 0, 0);
            btn_edt.Location = new Point(694, 234);
            btn_edt.Name = "btn_edt";
            btn_edt.Size = new Size(93, 35);
            btn_edt.TabIndex = 11;
            btn_edt.Text = "Edit";
            btn_edt.UseVisualStyleBackColor = false;
            btn_edt.Click += btn_edt_Click;
            // 
            // btn_delet
            // 
            btn_delet.BackColor = Color.WhiteSmoke;
            btn_delet.Font = new Font("Times New Roman", 14.2574253F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_delet.ForeColor = Color.FromArgb(192, 0, 0);
            btn_delet.Location = new Point(694, 296);
            btn_delet.Name = "btn_delet";
            btn_delet.Size = new Size(93, 35);
            btn_delet.TabIndex = 10;
            btn_delet.Text = "Delete";
            btn_delet.UseVisualStyleBackColor = false;
            btn_delet.Click += btn_delet_Click;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.WhiteSmoke;
            btn_Add.Font = new Font("Times New Roman", 14.2574253F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_Add.ForeColor = Color.FromArgb(192, 0, 0);
            btn_Add.Location = new Point(691, 184);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(93, 35);
            btn_Add.TabIndex = 9;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // cobCat
            // 
            cobCat.FormattingEnabled = true;
            cobCat.Location = new Point(517, 29);
            cobCat.Name = "cobCat";
            cobCat.Size = new Size(238, 25);
            cobCat.TabIndex = 8;
            // 
            // txt_des
            // 
            txt_des.Location = new Point(517, 68);
            txt_des.Multiline = true;
            txt_des.Name = "txt_des";
            txt_des.Size = new Size(250, 85);
            txt_des.TabIndex = 7;
            // 
            // prof
            // 
            prof.Location = new Point(133, 77);
            prof.Multiline = true;
            prof.Name = "prof";
            prof.Size = new Size(209, 66);
            prof.TabIndex = 6;
            // 
            // txt_title
            // 
            txt_title.Location = new Point(133, 26);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(209, 25);
            txt_title.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 15.6831684F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Maroon;
            label11.Location = new Point(381, 26);
            label11.Name = "label11";
            label11.Size = new Size(85, 25);
            label11.TabIndex = 4;
            label11.Text = "Catalog";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 15.6831684F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Maroon;
            label10.Location = new Point(381, 89);
            label10.Name = "label10";
            label10.Size = new Size(121, 25);
            label10.TabIndex = 3;
            label10.Text = "Discraption";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 15.6831684F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Maroon;
            label9.Location = new Point(44, 89);
            label9.Name = "label9";
            label9.Size = new Size(53, 25);
            label9.TabIndex = 2;
            label9.Text = "Prof";
            label9.Click += label9_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 15.6831684F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(41, 22);
            label6.Name = "label6";
            label6.Size = new Size(56, 25);
            label6.TabIndex = 1;
            label6.Text = "Title";
            // 
            // DGV1
            // 
            DGV1.BackgroundColor = SystemColors.ButtonHighlight;
            DGV1.BorderStyle = BorderStyle.None;
            DGV1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV1.Cursor = Cursors.Hand;
            DGV1.GridColor = SystemColors.ButtonFace;
            DGV1.Location = new Point(3, 174);
            DGV1.Name = "DGV1";
            DGV1.RowHeadersWidth = 43;
            DGV1.Size = new Size(677, 244);
            DGV1.TabIndex = 0;
            DGV1.CellContentClick += DGV1_CellContentClick;
            DGV1.RowHeaderMouseDoubleClick += DGV1_RowHeaderMouseDoubleClick;
            // 
            // AllN
            // 
            AllN.BackColor = Color.Transparent;
            AllN.Controls.Add(pictureBox2);
            AllN.Controls.Add(label12);
            AllN.Controls.Add(DGV2);
            AllN.Location = new Point(4, 26);
            AllN.Name = "AllN";
            AllN.Padding = new Padding(3);
            AllN.Size = new Size(793, 421);
            AllN.TabIndex = 2;
            AllN.Text = "All News";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(277, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 65);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 22.09901F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Maroon;
            label12.Location = new Point(336, 22);
            label12.Name = "label12";
            label12.Size = new Size(131, 36);
            label12.TabIndex = 1;
            label12.Text = "All News";
            // 
            // DGV2
            // 
            DGV2.BackgroundColor = SystemColors.ButtonHighlight;
            DGV2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV2.Location = new Point(18, 101);
            DGV2.Name = "DGV2";
            DGV2.RowHeadersWidth = 50;
            DGV2.Size = new Size(754, 314);
            DGV2.TabIndex = 0;
            // 
            // MyProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MyProfile";
            Text = "MyProfile";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            MYnew.ResumeLayout(false);
            MYnew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV1).EndInit();
            AllN.ResumeLayout(false);
            AllN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage MYnew;
        private TabPage AllN;
        private Button button1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label la_age;
        private Label label8;
        private Label label7;
        private Label usern;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label jionDate;
        private DataGridView DGV1;
        private Label label6;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txt_title;
        private TextBox prof;
        private Button btn_Add;
        private ComboBox cobCat;
        private TextBox txt_des;
        private Button btn_edt;
        private Button btn_delet;
        private DataGridView DGV2;
        private Label label12;
        private PictureBox pictureBox2;
    }
}