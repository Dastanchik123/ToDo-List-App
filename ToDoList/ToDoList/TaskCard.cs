
using System;
using System.Drawing;
using System.Windows.Forms;
using ToDoList;

public class TaskCard : Panel
{
    private Form1 mainForm;
    public TaskCard(string title, string priority,
                    string date, string status, Form1 form)
    {
        Size = new Size(880, 76);
        BackColor = Color.FromArgb(248, 250, 252);
        BorderStyle = BorderStyle.None;
        Margin = new Padding(0, 0, 0, 12);
        mainForm = form;


        CheckBox checkBox = new CheckBox();
        if (status == "Завершенный")
        {
            checkBox.Checked = true;
        }
        else if(status == "Активный")
        {
            checkBox.Checked = false;
        }
        checkBox.Location = new Point(16, 26);
        checkBox.Size = new Size(20, 20);
        checkBox.Click += (sender, e) => mainForm.chaingeStatus(this, status);
        Controls.Add(checkBox);

        Label titleLabel = new Label();
        titleLabel.Text = title;
        titleLabel.Location = new Point(50, 15);
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 10,
                                   FontStyle.Bold);
        titleLabel.ForeColor = Color.FromArgb(30, 41, 59);
        Controls.Add(titleLabel);

        Label priorityLabel = new Label();
        priorityLabel.Text = priority;
        priorityLabel.Location = new Point(50, 40);
        priorityLabel.AutoSize = true;
        priorityLabel.Padding = new Padding(5, 2, 5, 2);
        priorityLabel.Font = new Font("Segoe UI", 8);

        if (priority == "Высокий")
            priorityLabel.ForeColor = Color.Red;
        else
            priorityLabel.ForeColor = Color.Green;

        Controls.Add(priorityLabel);

        Label dateLabel = new Label();
        dateLabel.Text = "▢ " + date;
        dateLabel.Location = new Point(130, 42);
        dateLabel.AutoSize = true;
        dateLabel.Font = new Font("Segoe UI", 9);
        dateLabel.ForeColor = Color.Gray;
        Controls.Add(dateLabel);

        
    }
}
