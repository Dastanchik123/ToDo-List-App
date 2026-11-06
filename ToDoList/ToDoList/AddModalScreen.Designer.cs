namespace ToDoList
{
    partial class AddModalScreen
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
            label4 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(25, 24);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "Новая задача";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonShadow;
            label4.Location = new Point(25, 44);
            label4.Name = "label4";
            label4.Size = new Size(369, 19);
            label4.TabIndex = 2;
            label4.Text = "____________________________________________________________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(25, 84);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 3;
            label2.Text = "Новая задача *";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 105);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Например: Подготовить отчёт ....";
            textBox1.Size = new Size(335, 26);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(25, 168);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Добавте подробности ...";
            textBox2.Size = new Size(335, 83);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(21, 147);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 5;
            label3.Text = "Описание";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Работа ", "Личное", "Учёба" });
            comboBox1.Location = new Point(23, 285);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(139, 27);
            comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Работа ", "Личное", "Учёба" });
            comboBox2.Location = new Point(215, 285);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(141, 27);
            comboBox2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 263);
            label5.Name = "label5";
            label5.Size = new Size(73, 19);
            label5.TabIndex = 9;
            label5.Text = "Категория";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(215, 263);
            label6.Name = "label6";
            label6.Size = new Size(78, 19);
            label6.TabIndex = 10;
            label6.Text = "Приоритет";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 322);
            label7.Name = "label7";
            label7.Size = new Size(123, 19);
            label7.TabIndex = 11;
            label7.Text = "Срок выполнения";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(25, 344);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(331, 26);
            dateTimePicker1.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(161, 376);
            button1.Name = "button1";
            button1.Size = new Size(93, 30);
            button1.TabIndex = 13;
            button1.Text = "Отмена ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(79, 70, 229);
            button2.ForeColor = Color.White;
            button2.Location = new Point(260, 376);
            button2.Name = "button2";
            button2.Size = new Size(96, 30);
            button2.TabIndex = 14;
            button2.Text = "Создать";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(339, 21);
            button3.Name = "button3";
            button3.Size = new Size(25, 25);
            button3.TabIndex = 15;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // AddModalScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 435);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddModalScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "\\";
            Load += AddModalScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}