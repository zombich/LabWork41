using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LabWork41
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public bool IsMenuOpened = false;

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            IsMenuOpened = !IsMenuOpened;
            MenuDoubleAnimation.From = IsMenuOpened ? 20 : 100;
            MenuDoubleAnimation.To = IsMenuOpened ? 100 : 20;
        }
    }
}