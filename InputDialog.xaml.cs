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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для InputDialog.xaml
    /// </summary>
    public partial class InputDialog : Window
    {
        public InputDialog()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            int Number1 = int.Parse(txtNumber1.Text);
            int Number2 = int.Parse(txtNumber2.Text);
            int Number3 = int.Parse(txtNumber3.Text);

            int resultSumm = 0;
            int resultLeastMultiple = 0;

            if (chkSumm.IsChecked == true)
        resultSumm = Number1 + Number2 + Number3;

            if (chkLeastMultiple.IsChecked == true)
            {
                resultLeastMultiple = CalculateLeastMultiple(Number1, Number2);
            }
            
            MessageBox.Show($"Summ: {resultSumm}\nНаименьшее кратное: {resultLeastMultiple}");
            Close();
        }
        private int CalculateLeastMultiple(int Number1, int Number2)
        {
            int s = Number1 * Number2;
            for (int i = 1; i <= s; i++)
            {
                if ((i % Number1 == 0) && (i % Number2 == 0))
                {
                    return i;
                }
            }
            return s;
        }
    }
    
}
