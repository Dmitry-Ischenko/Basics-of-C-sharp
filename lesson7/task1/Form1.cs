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
        public Form1()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = "0";
            this.Text = "Удвоитель";
        }
        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
        }
        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }



    }
