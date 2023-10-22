using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Input_Click(object sender, RoutedEventArgs e)
        {
            InputDialog inputDialog = new InputDialog();
            inputDialog.ShowDialog();
        }

        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            CalcDialog CalcDialog = new CalcDialog();
            CalcDialog.ShowDialog();

        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            AboutDialog aboutDialog = new AboutDialog();
            aboutDialog.ShowDialog();
        }
    }
}
