using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class AddModalScreen : Form
    {
        private Form1 mainForm;
        public AddModalScreen(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddModalScreen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Пожалуйста, введите название задачи.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(comboBox1.SelectedItem?.ToString()))
            {
                MessageBox.Show("Пожалуйста, выберите приоритет задачи.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                mainForm.AddNewTask(textBox1.Text, comboBox1.SelectedItem.ToString(), dateTimePicker1.Value.ToString("yyyy-MM-dd"), comboBox1.SelectedItem.ToString(), "Активный");
                this.Close();
            }
        }
    }
}
