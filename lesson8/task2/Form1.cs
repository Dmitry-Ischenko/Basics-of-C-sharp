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
        public Form1()
        {
            //Выполнил Ищенко Дмитрий
            //Создайте простую форму на котором свяжите свойство 
            //Text элемента TextBox со свойством Value элемента NumericUpDown
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            int output;
            if (Int32.TryParse(textBox1.Text,out output)) {
                if (output >=numericUpDown1.Minimum && output <=numericUpDown1.Maximum) numericUpDown1.Value = output;
            }
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = numericUpDown1.Value.ToString();
        }
    }
}
