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
using System.Windows.Shapes;

namespace Lesson_5.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddDepWindows.xaml
    /// </summary>
    public partial class AddDepWindows : Window
    {
        public AddDepWindows()
        {
            InitializeComponent();
        }
        /// <summary>Обработчик нажатия кнопки "сохранить"</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSaveDep_Click(object sender, RoutedEventArgs e)
        {
            if (MainWindow.db.addDep(tboxNewDep.Text))
            {
                MessageBox.Show("Отдел добавлен!");
                this.Close();
            }
            else
                MessageBox.Show("Такой отдел уже существует!");
        }
    }
}
