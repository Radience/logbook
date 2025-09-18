using System.Windows;
using System.Windows.Input;

namespace Diplom.Messages
{
    /// <summary>
    /// Логика взаимодействия для MsgBox.xaml
    /// </summary>
    public partial class MsgBox : Window
    {
        public MsgBox(string exception)
        {
            InitializeComponent();
            messageError.Text = exception;
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
