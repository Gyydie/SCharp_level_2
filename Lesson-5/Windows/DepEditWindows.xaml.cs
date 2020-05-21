using System.Windows;
using System.Data;

namespace Lesson_5.Windows
{
    /// <summary>
    /// Логика взаимодействия для DepEditWindows.xaml
    /// </summary>
    public partial class DepEditWindows : Window
    {
        public DataRow resultRow { get; set; }
        public DepEditWindows(DataRow dataRow)
        {
            InitializeComponent();
            resultRow = dataRow;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tblOldName.Text = resultRow["dName"].ToString();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            resultRow["dName"] = tboxNewName.Text;
            this.DialogResult = true;
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
