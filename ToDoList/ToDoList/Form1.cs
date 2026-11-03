namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public string[,] Tasks =
  {
    { "Разработать интерфейс", "Высокий", "2026-11-01", "2/3", "Работа" },
    { "Купить продукты", "Низкий", "2026-11-02", "0/3", "Личное" },
    { "Сделать домашнюю работу", "Средний", "2026-11-03", "1/3", "Учёба" },
    { "Изучить C#", "Высокий", "2026-11-04", "3/5", "Учёба" },
    { "Создать базу данных", "Высокий", "2026-11-05", "1/4", "Работа" },
    { "Проверить код", "Средний", "2026-11-06", "2/2", "Работа" },
    { "Исправить ошибки", "Высокий", "2026-11-07", "0/3", "Работа" },
    { "Сделать дизайн", "Средний", "2026-11-08", "1/3", "Работа" },
    { "Протестировать приложение", "Низкий", "2026-11-09", "0/2", "Работа" },
    { "Завершить проект", "Высокий", "2026-11-10", "0/5", "Работа" }
};
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            flowTasks.AutoScroll = true;
            flowTasks.WrapContents = false;
            flowTasks.FlowDirection = FlowDirection.TopDown;



            label5.Text = " Все задачи";
            flowTasks.Controls.Clear();

            for (int i = 0; i < Tasks.GetLength(0); i++)
            {
                flowTasks.Controls.Add(
                    new TaskCard(
                        Tasks[i, 0],
                        Tasks[i, 1],
                        Tasks[i, 2],
                        Tasks[i, 3]
                    )
                );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = " Все задачи";
            flowTasks.Controls.Clear();
            for (int i = 0; i < Tasks.GetLength(0); i++)
            {
                flowTasks.Controls.Add(
                    new TaskCard(
                        Tasks[i, 0],
                        Tasks[i, 1],
                        Tasks[i, 2],
                        Tasks[i, 3]
                    )
                );
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = "Работа";
            flowTasks.Controls.Clear();
            for (int i = 0; i < Tasks.GetLength(0); i++)
            {
                if (Tasks[i, 4] == "Работа")
                    flowTasks.Controls.Add(
                        new TaskCard(
                            Tasks[i, 0],
                            Tasks[i, 1],
                            Tasks[i, 2],
                            Tasks[i, 3]
                        )
                    );
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Text = "Личное";
            flowTasks.Controls.Clear();
            for (int i = 0; i < Tasks.GetLength(0); i++)
            {
                if (Tasks[i, 4] == "Личное")
                    flowTasks.Controls.Add(
                        new TaskCard(
                            Tasks[i, 0],
                            Tasks[i, 1],
                            Tasks[i, 2],
                            Tasks[i, 3]
                        )
                    );
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label5.Text = " Учёба";
            flowTasks.Controls.Clear();
            for (int i = 0; i < Tasks.GetLength(0); i++)
            {
                if (Tasks[i, 4] == "Учёба")
                    flowTasks.Controls.Add(
                        new TaskCard(
                            Tasks[i, 0],
                            Tasks[i, 1],
                            Tasks[i, 2],
                            Tasks[i, 3]
                        )
                    );
            }
        }
    }
}
