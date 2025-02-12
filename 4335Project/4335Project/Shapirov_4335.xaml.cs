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

namespace _4335Project
{
    /// <summary>
    /// Логика взаимодействия для Shapirov_4335.xaml
    /// </summary>
    public partial class Shapirov_4335 : Window
    {
        public Shapirov_4335()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Shapirov Aydar 18 years old");
        }
    }
}
