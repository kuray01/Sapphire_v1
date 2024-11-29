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

namespace Sapphire_v1.Pages
{
    /// <summary>
    /// Логика взаимодействия для register_1.xaml
    /// </summary>
    public partial class register_1 : Window
    {
        public register_1()
        {
            InitializeComponent();
        }

        private void Register1Button_Click(object sender, RoutedEventArgs e)
        {
            register_2 registerWindow = new register_2();
            registerWindow.Show();
            this.Close();
        }
    }
}
