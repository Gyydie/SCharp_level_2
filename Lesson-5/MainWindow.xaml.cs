using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lesson_5.Class;
using Lesson_5.Windows;
using System.Windows.Controls;

namespace Lesson_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal static Programm db;
        public MainWindow()
        {
            InitializeComponent();
            db = new Programm();
            empList.ItemsSource = db.GetEmployees();
            DepartList.ItemsSource = db.GetDeptaments();
            //db.updateData += Update;
        }

        /// <summary>Обработка события выбора элемента из списка</summary>
        /// <param name="sender">Объект</param>
        /// <param name="args">Параметры</param>
        private void Selected(object sender, SelectionChangedEventArgs args)
        {
            TextBlockInf.Text = db.GetInfo(sender);
        }

        /// <summary>Обработка нажатия кнопки "редактировать департамент"</summary>
        /// <param name="sender">Объект</param>
        /// <param name="args">Параметры</param>
        private void BtnEditDep_Click(object sender, RoutedEventArgs e)
        {
            if (DepartList.SelectedItem != null)
            {
                Department editdep = DepartList.SelectedItem as Department;
                DepEditWindows depEditWindow = new DepEditWindows(editdep.DepartID, editdep.Name);
                depEditWindow.Owner = this;
                depEditWindow.Show();
            }
            else
                MessageBox.Show("Выберете отдел для редактирования!");
        }

        /// <summary>Обработка нажатия кнопки "редактировать сотрудника"</summary>
        /// <param name="sender">Объект</param>
        /// <param name="args">Параметры</param>
        private void BtnEditEmp_Click(object sender, RoutedEventArgs e)
        {
            if (empList.SelectedItem != null)
            {
                EmpEditWindows empEditWindow = new EmpEditWindows(empList.SelectedItem as Employee);
                empEditWindow.Owner = this;
                empEditWindow.Show();
            }
            else
                MessageBox.Show("Выберете сотрудника для редактирования!");
        }

        /// <summary>Обработка нажатия кнопки "добавить сотрудника"</summary>
        /// <param name="sender">Объект</param>
        /// <param name="args">Параметры</param>
        private void BtnCreateEmp_Click(object sender, RoutedEventArgs e)
        {
            AddEmpWindows addEmpWindow = new AddEmpWindows();
            addEmpWindow.Owner = this;
            addEmpWindow.Show();
        }

        /// <summary>Обработка нажатия кнопки "добавить департамент"</summary>
        /// <param name="sender">Объект</param>
        /// <param name="args">Параметры</param>
        private void BtnCreateDep_Click(object sender, RoutedEventArgs e)
        {
            AddDepWindows addDepWindow = new AddDepWindows();
            addDepWindow.Owner = this;
            addDepWindow.Show();
        }

        /// <summary>Обновляет данные на форме</summary>
        internal void Update()
        {
            empList.ItemsSource = db.GetEmployees();
            DepartList.ItemsSource = db.GetDeptaments();
        }
    }
}
