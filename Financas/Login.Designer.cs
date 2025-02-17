namespace Financas
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            UnameTb = new TextBox();
            Loginbtn = new Button();
            PasswordTb = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(149, 366);
            panel1.TabIndex = 1;
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(201, 29);
            label1.Name = "label1";
            label1.Size = new Size(222, 23);
            label1.TabIndex = 3;
            label1.Text = "Expense Management System";
            
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(284, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            
            // 
            // UnameTb
            // 
            UnameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UnameTb.Location = new Point(201, 146);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(202, 29);
            UnameTb.TabIndex = 8;
            
            // 
            // Loginbtn
            // 
            Loginbtn.FlatStyle = FlatStyle.Flat;
            Loginbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Loginbtn.Location = new Point(252, 281);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(104, 33);
            Loginbtn.TabIndex = 9;
            Loginbtn.Text = "Login";
            Loginbtn.UseVisualStyleBackColor = true;
            Loginbtn.Click += button1_Click;
            // 
            // PasswordTb
            // 
            PasswordTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTb.Location = new Point(201, 212);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(202, 29);
            PasswordTb.TabIndex = 10;
           
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(273, 334);
            label2.Name = "label2";
            label2.Size = new Size(54, 23);
            label2.TabIndex = 11;
            label2.Text = "Admin";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(201, 123);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 12;
            label3.Text = "UserName";
            
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DeepSkyBlue;
            label4.Location = new Point(201, 189);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 13;
            label4.Text = "Password";
            label4.Click += label4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(460, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 366);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PasswordTb);
            Controls.Add(Loginbtn);
            Controls.Add(UnameTb);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox UnameTb;
        private Button Loginbtn;
        private TextBox PasswordTb;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
    }
}