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

namespace LabWork41
{
    /// <summary>
    /// Логика взаимодействия для Task1.xaml
    /// </summary>
    public partial class Task1 : Window
    {
        public bool IsMenuOpened = false;

        public Task1()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            IsMenuOpened = !IsMenuOpened;
            MenuDoubleAnimation.From = IsMenuOpened ? 20 : 100;
            MenuDoubleAnimation.To = IsMenuOpened ? 100 : 20;
        }
    }
}
