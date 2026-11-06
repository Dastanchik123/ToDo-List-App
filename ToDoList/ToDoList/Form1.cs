using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ToDoList
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string currentCategory = "Все";
        public string currentStatus = "Все";

        public List<TaskItem> Tasks = new List<TaskItem>()
        {
            new TaskItem("Разработать интерфейс", "Высокий", "2026-11-01", "Работа", "Активный"),
            new TaskItem("Купить продукты", "Низкий", "2026-11-02", "Личное", "Активный"),
            new TaskItem("Сделать домашнюю работу", "Средний", "2026-11-03", "Учёба", "Активный"),
            new TaskItem("Изучить C#", "Высокий", "2026-11-04", "Учёба", "Активный"),
            new TaskItem("Создать базу данных", "Высокий", "2026-11-05", "Работа", "Активный"),
            new TaskItem("Проверить код", "Средний", "2026-11-06", "Работа", "Завершенный"),
            new TaskItem("Исправить ошибки", "Высокий", "2026-11-07", "Работа", "Активный"),
            new TaskItem("Сделать дизайн", "Средний", "2026-11-08", "Работа", "Активный"),
            new TaskItem("Протестировать приложение", "Низкий", "2026-11-09", "Работа", "Активный"),
            new TaskItem("Завершить проект", "Высокий", "2026-11-10", "Работа", "Активный")
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            flowTasks.AutoScroll = true;
            flowTasks.WrapContents = false;
            flowTasks.FlowDirection = FlowDirection.TopDown;

            FilterTasks();
        }

        private void FilterTasks()
        {
            flowTasks.Controls.Clear();
            int count = 0;

            foreach (var task in Tasks)
            {
                bool matchCategory = (currentCategory == "Все" || task.Category == currentCategory);
                bool matchStatus = (currentStatus == "Все" || task.Status == currentStatus);

                if (matchCategory && matchStatus)
                {
                    flowTasks.Controls.Add(new TaskCard(task.Title, task.Priority, task.Date, task.Status, this));
                    count++;
                }
            }

            label5.Text = $"{currentCategory}";
            label6.Text = $"Показано: {count}";
        }

        public void AddNewTask(string title, string priority, string date, string category, string status)
        {
            Tasks.Add(new TaskItem(title, priority, date, category, status));
            FilterTasks();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentCategory = "Все";
            FilterTasks();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentCategory = "Работа";
            FilterTasks();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentCategory = "Личное";
            FilterTasks();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentCategory = "Учёба";
            FilterTasks();
        }



        private void button7_Click(object sender, EventArgs e)
        {
            currentStatus = "Активный";
            FilterTasks();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            currentStatus = "Завершенный";
            FilterTasks();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentStatus = "Все";
            FilterTasks();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            Form addModal = new AddModalScreen(this);
            addModal.ShowDialog();
        }
        public void chaingeStatus(TaskCard taskCard, string newStatus)
        {
            foreach (var task in Tasks)
            {
                if (task.Title == taskCard.Controls[1].Text) 
                {
                    task.Status = task.Status == "Активный" ? "Завершенный" : "Активный";
                    break;
                }
            }
            FilterTasks();
        }
    }



    public class TaskItem
    {
        public string Title { get; set; }
        public string Priority { get; set; }
        public string Date { get; set; }
        public string Progress { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }

        public TaskItem(string title, string priority, string date, string category, string status)
        {
            Title = title;
            Priority = priority;
            Date = date;
            Category = category;
            Status = status;
        }
    }
}