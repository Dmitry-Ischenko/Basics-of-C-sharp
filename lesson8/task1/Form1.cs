using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Выполнил Ищенко Дмитрий
            //С помощью рефлексии выведите все свойства структуры DateTime
            InitializeComponent();
            Type tp = Type.GetType("System.DateTime");
            PropertyInfo[] propery = tp.GetProperties();
            int i = 0;
            foreach (PropertyInfo mi in propery)
            {
                i++;
                listBox1.Items.Add($"Property[{i}] = {mi.Name}");         
            }

        }
    }
}
