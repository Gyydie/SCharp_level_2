﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lesson_5.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddEmpWindows.xaml
    /// </summary>
    public partial class AddEmpWindows : Window
    {
        public AddEmpWindows()
        {
            InitializeComponent();
        }
        /// <summary>Обработчик нажатия кнопки "сохранить"</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (MainWindow.db.addEmp(tboxName.Text, tboxSurname.Text, tboxAge.Text, tboxSalary.Text, uint.Parse(tboxDepartment.Text)))
            {
                MessageBox.Show("Сотрудник добавлен!");
                this.Close();
            }
            else
                MessageBox.Show("Такой сотрудник уже существует или введены некоректные данные!");
        }
    }
}
