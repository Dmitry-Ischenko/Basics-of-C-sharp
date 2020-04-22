using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2
{
    public partial class Form1 : Form
    {
        //Выполнил Ищенко Дмитрий
        //Используя Windows Forms, разработать игру «Угадай число». 
        //    Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток.
        //    Компьютер говорит, больше или меньше загаданное число введенного.
        //a) Для ввода данных от человека используется элемент TextBox;
        //б) **Реализовать отдельную форму c TextBox для ввода числа.
        int _secretNumber = 0;
        int answerCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            _secretNumber = rand.Next(1, 101);
            labelMSG.Text = "Я загадал число от 1 до 100 \n Попробуй угадай!";
            btnAction.Enabled = true;
            answerCount = 0;
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            answerCount++;
            int answer;
            if (Int32.TryParse(boxAnswer.Text,out answer))
            {
                if (answer == _secretNumber)
                {
                    labelMSG.Text = $"Отлично! \nТы угадал за {answerCount} попыток.";
                    MessageBox.Show($"Отлично! Ты угадал за {answerCount} попыток.");
                    btnAction.Enabled = false;
                } else if (answer > _secretNumber)
                {
                    labelMSG.Text = $"{answer} больше загаднного!";
                } else
                {
                    labelMSG.Text = $"{answer} меньше загаднного!";
                }
            }
        }

        private void BoxAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
