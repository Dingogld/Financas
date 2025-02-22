namespace Financas
{
    partial class Expenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expenses));
            panel1 = new Panel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ExpenseNameTb = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ExpAmtTb = new TextBox();
            label4 = new Label();
            ExpDescTb = new TextBox();
            label5 = new Label();
            ExpCatTb = new ComboBox();
            label6 = new Label();
            ExpDate = new DateTimePicker();
            AddBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel1.Size = new Size(607, 45);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(52, 8);
            label3.Name = "label3";
            label3.Size = new Size(112, 23);
            label3.TabIndex = 14;
            label3.Text = "Add Expenses";
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
            pictureBox1.Location = new Point(549, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ExpenseNameTb
            // 
            ExpenseNameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExpenseNameTb.Location = new Point(86, 155);
            ExpenseNameTb.Name = "ExpenseNameTb";
            ExpenseNameTb.Size = new Size(221, 29);
            ExpenseNameTb.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(86, 132);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 13;
            label1.Text = "Expense Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(86, 203);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 15;
            label2.Text = "Expense Amount";
            // 
            // ExpAmtTb
            // 
            ExpAmtTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExpAmtTb.Location = new Point(86, 226);
            ExpAmtTb.Name = "ExpAmtTb";
            ExpAmtTb.Size = new Size(221, 29);
            ExpAmtTb.TabIndex = 14;
            ExpAmtTb.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DeepSkyBlue;
            label4.Location = new Point(86, 470);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 17;
            label4.Text = "Expense Description";
            // 
            // ExpDescTb
            // 
            ExpDescTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExpDescTb.Location = new Point(86, 508);
            ExpDescTb.Multiline = true;
            ExpDescTb.Name = "ExpDescTb";
            ExpDescTb.Size = new Size(221, 77);
            ExpDescTb.TabIndex = 16;
            ExpDescTb.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DeepSkyBlue;
            label5.Location = new Point(86, 296);
            label5.Name = "label5";
            label5.Size = new Size(121, 20);
            label5.TabIndex = 18;
            label5.Text = "Expense Category";
            // 
            // ExpCatTb
            // 
            ExpCatTb.Font = new Font("Segoe UI", 12F);
            ExpCatTb.FormattingEnabled = true;
            ExpCatTb.Items.AddRange(new object[] { "Food", "Shopping", "Medical", "House", "Travel", "Gasoline", "Vehicle", "Phone", "Others" });
            ExpCatTb.Location = new Point(86, 329);
            ExpCatTb.Name = "ExpCatTb";
            ExpCatTb.Size = new Size(221, 29);
            ExpCatTb.TabIndex = 19;
            ExpCatTb.SelectedIndexChanged += ExpCatTb_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DeepSkyBlue;
            label6.Location = new Point(86, 392);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 20;
            label6.Text = "Expense Date";
            // 
            // ExpDate
            // 
            ExpDate.Location = new Point(86, 432);
            ExpDate.Name = "ExpDate";
            ExpDate.Size = new Size(233, 23);
            ExpDate.TabIndex = 21;
            // 
            // AddBtn
            // 
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddBtn.Location = new Point(135, 620);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(184, 33);
            AddBtn.TabIndex = 22;
            AddBtn.Text = "Add Expense";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // Expenses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 724);
            Controls.Add(AddBtn);
            Controls.Add(ExpDate);
            Controls.Add(label6);
            Controls.Add(ExpCatTb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(ExpDescTb);
            Controls.Add(label2);
            Controls.Add(ExpAmtTb);
            Controls.Add(label1);
            Controls.Add(ExpenseNameTb);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Expenses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Expenses";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox ExpenseNameTb;
        private Label label1;
        private Label label2;
        private TextBox ExpAmtTb;
        private Label label4;
        private TextBox ExpDescTb;
        private Label label5;
        private ComboBox ExpCatTb;
        private Label label6;
        private DateTimePicker ExpDate;
        private Button AddBtn;
    }
}