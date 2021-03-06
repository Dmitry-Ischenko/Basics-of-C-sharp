﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task3
{
    public partial class Form1 : Form
    {
        TrueFalse database;
        public Form1()
        {
            //Выполнил Ищенко Дмитрий
            //а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок (не создана база данных, обращение к несуществующему вопросу, открытие слишком большого файла и т.д.).
            //б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив другие «косметические» улучшения на свое усмотрение.
            //в) Добавить в приложение меню «О программе» с информацией о программе(автор, версия, авторские права и др.).
            //г)*Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных(элемент SaveFileDialog).
            InitializeComponent();
            //TrueFalse t = new TrueFalse();
            //t.
        }
        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Обработчик пункта меню New
        private void miNew_Click(object sender, EventArgs e)
        {
            database = new TrueFalse();
            nudNumber.Minimum = 0;
            nudNumber.Maximum = 0;
            nudNumber.Value = 0;
        }
        // Обработчик события изменения значения numericUpDown
        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            if (database == null) return;
            tboxQuestion.Text = database[(int)nudNumber.Value - 1].TextQuestion;
            cboxTrue.Checked = database[(int)nudNumber.Value - 1].Answer;
        }
        // Обработчик кнопки Добавить
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database.Add((database.Count + 1).ToString(), true);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }
        // Обработчик кнопки Удалить
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (nudNumber.Maximum == 1 || database == null) return;
            database.Remove((int)nudNumber.Value);
            nudNumber.Maximum--;
            if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
        }
        // Обработчик пункта меню Save
        private void miSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (database != null) database.SaveInFile(sfd.FileName);
                else MessageBox.Show("База данных не создана");
            }
        }
        // Обработчик пункта меню Open
        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    database = new TrueFalse();
                    database.LoadFromFile(ofd.FileName);
                    nudNumber.Minimum = 1;
                    nudNumber.Maximum = database.Count;
                    nudNumber.Value = 1;
                }
                catch (Exception z)
                {
                    MessageBox.Show(z.Message);
                }
            }
        }
        // Обработчик кнопки Сохранить (вопрос)
        private void btnSaveQuest_Click(object sender, EventArgs e)
        {
            if (database == null) return;
            database[(int)nudNumber.Value - 1].TextQuestion = tboxQuestion.Text;
            database[(int)nudNumber.Value - 1].Answer = cboxTrue.Checked;
        }

        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа была разработана методистами GeekBrains\n Доработана Ищенко Дмитрием");
        }
    }
}
