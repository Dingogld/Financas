namespace Financas
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            panel1 = new Panel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            UDOB = new DateTimePicker();
            label6 = new Label();
            AddressTbfake = new Label();
            AddressTb = new TextBox();
            label2 = new Label();
            UPhoneTb = new TextBox();
            label1 = new Label();
            UnameTb = new TextBox();
            label7 = new Label();
            UPasswordTb = new TextBox();
            label5 = new Label();
            AddBtn = new Button();
            UserDGV = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(670, 45);
            panel1.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(52, 8);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 14;
            label3.Text = "Users";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(622, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // UDOB
            // 
            UDOB.CalendarFont = new Font("Segoe UI", 12F);
            UDOB.Format = DateTimePickerFormat.Short;
            UDOB.Location = new Point(267, 140);
            UDOB.Name = "UDOB";
            UDOB.Size = new Size(101, 23);
            UDOB.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DeepSkyBlue;
            label6.Location = new Point(267, 104);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 33;
            label6.Text = "User DOB";
            // 
            // AddressTbfake
            // 
            AddressTbfake.AutoSize = true;
            AddressTbfake.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddressTbfake.ForeColor = Color.DeepSkyBlue;
            AddressTbfake.Location = new Point(267, 176);
            AddressTbfake.Name = "AddressTbfake";
            AddressTbfake.Size = new Size(60, 20);
            AddressTbfake.TabIndex = 30;
            AddressTbfake.Text = "Address";
            // 
            // AddressTb
            // 
            AddressTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddressTb.Location = new Point(267, 214);
            AddressTb.Multiline = true;
            AddressTb.Name = "AddressTb";
            AddressTb.Size = new Size(221, 77);
            AddressTb.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(405, 112);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 28;
            label2.Text = "User Phone";
            // 
            // UPhoneTb
            // 
            UPhoneTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UPhoneTb.Location = new Point(405, 140);
            UPhoneTb.Name = "UPhoneTb";
            UPhoneTb.Size = new Size(221, 29);
            UPhoneTb.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(28, 115);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 26;
            label1.Text = "Name";
            // 
            // UnameTb
            // 
            UnameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UnameTb.Location = new Point(28, 138);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(221, 29);
            UnameTb.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DeepSkyBlue;
            label7.Location = new Point(28, 186);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 37;
            label7.Text = "Password";
            // 
            // UPasswordTb
            // 
            UPasswordTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UPasswordTb.Location = new Point(28, 214);
            UPasswordTb.Name = "UPasswordTb";
            UPasswordTb.Size = new Size(221, 29);
            UPasswordTb.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DeepSkyBlue;
            label5.Location = new Point(478, 48);
            label5.Name = "label5";
            label5.Size = new Size(118, 23);
            label5.TabIndex = 38;
            label5.Text = "View Expenses";
            label5.Click += label5_Click;
            // 
            // AddBtn
            // 
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddBtn.Location = new Point(235, 618);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(184, 33);
            AddBtn.TabIndex = 39;
            AddBtn.Text = "Add User";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // UserDGV
            // 
            UserDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserDGV.Location = new Point(17, 316);
            UserDGV.Name = "UserDGV";
            UserDGV.Size = new Size(636, 280);
            UserDGV.TabIndex = 40;
            UserDGV.CellContentClick += UserDGV_CellContentClick;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 685);
            Controls.Add(UserDGV);
            Controls.Add(AddBtn);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(UPasswordTb);
            Controls.Add(UDOB);
            Controls.Add(label6);
            Controls.Add(AddressTbfake);
            Controls.Add(AddressTb);
            Controls.Add(label2);
            Controls.Add(UPhoneTb);
            Controls.Add(label1);
            Controls.Add(UnameTb);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private DateTimePicker UDOB;
        private Label label6;
        private Label AddressTbfake;
        private TextBox AddressTb;
        private Label label2;
        private TextBox UPhoneTb;
        private Label label1;
        private TextBox UnameTb;
        private Label label7;
        private TextBox UPasswordTb;
        private Label label5;
        private Button AddBtn;
        private DataGridView UserDGV;
    }
}