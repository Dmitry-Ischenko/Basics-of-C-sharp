using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1
{
    public partial class Form1 : Form
    {
        //Выполнил Ищенко Дмитрий
        //а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
        //б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок. 
        //Игрок должен получить это число за минимальное количество ходов.
        //в) *Добавить кнопку «Отменить», которая отменяет последние ходы. Используйте обобщенный класс Stack.
        //Вся логика игры должна быть реализована в классе с удвоителем.
        int _getStartResult = 0;
        Stack<int> stack = new Stack<int>();
        public Form1()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnBack.Text = "Назад";
            btnReset.Text = "Сброс";
            lblNumber.Text = "0";
            this.Text = "Удвоитель";
        }
        private void btnCommand1_Click(object sender, EventArgs e)
        {
            ResultCount();
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
        }
        private void btnCommand2_Click(object sender, EventArgs e)
        {
            ResultCount();
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResultCountAllClickButton.Text = "0";
            lblNumber.Text = "1";
            stack.Clear();
        }
        private void ResultCount ()
        {
            ResultCountAllClickButton.Text = (int.Parse(ResultCountAllClickButton.Text) + 1).ToString();
            stack.Push(int.Parse(lblNumber.Text));
            if (int.Parse(lblNumber.Text) == _getStartResult)
            {
                MessageBox.Show("Вы выйграли! Вам понадобилось {0} ходов", ResultCountAllClickButton.Text);
                ResultCountAllClickButton.Text = "0";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            Random rand = new Random();            
            _getStartResult = rand.Next(1, Int32.MaxValue);
            MessageBox.Show($"Получите число {_getStartResult} за минимальное количество ходов");
            ResultCountAllClickButton.Text = "0";
            lblNumber.Text = "1";
            stack.Clear();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                lblNumber.Text = (stack.Pop()).ToString();
            }
        }
    }



    }
