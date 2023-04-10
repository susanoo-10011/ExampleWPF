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

namespace ExampleWPF
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

        private void Button_Hide_Click(object sender, RoutedEventArgs e)
        {
            tabControl.Visibility = Visibility.Collapsed;
            Expenses();
            Income();
        }

        private void Button_Expenses_Click(object sender, RoutedEventArgs e)
        {
            //tabControl.SelectedIndex = 0;
            tabControl.Visibility = Visibility.Visible; //устанавливает свойство Visible, из за чего открывается вкладка.
        }

        private void Expenses()
        {
            int exProducts;
            if (Int32.TryParse(ExpensesProducts.Text, out exProducts))
            {
                totalExpenses.Text = Convert.ToString(exProducts);
                // теперь вы можете использовать значение exProducts
            }
            else
            {
                MessageBox.Show("Данные введены некорректно");
                ExpensesProducts.Text = "";
                // если в TextBox не было введено корректное значение типа int
            }
        }

        private void Income()
        {
            int finance;
            if (Int32.TryParse(Revenue.Text, out finance))
            {
                totalIncome.Text = Convert.ToString(finance);
                // теперь вы можете использовать значение exProducts
            }
            else
            {
                MessageBox.Show("Данные введены некорректно");
                Revenue.Text = "";
                // если в TextBox не было введено корректное значение типа int
            }
        }
    }
}
