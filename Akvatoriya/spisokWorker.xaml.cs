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

namespace Akvatoriya
{
    /// <summary>
    /// Логика взаимодействия для spisokWorker.xaml
    /// </summary>
    public partial class spisokWorker : Window
    {
        public spisokWorker()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            admin admin=new admin();
            admin.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            newWorker worker = new newWorker();
            worker.Show();
            this.Close();
        }
    }
}
