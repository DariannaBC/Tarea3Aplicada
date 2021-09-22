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
using Tarea3Aplicada.Ejercicios_Capitulo_3;


namespace Tarea3Aplicada
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Cap6Ejercicio12345 cap6Ejercicio12345 = new Cap6Ejercicio12345();
            cap6Ejercicio12345.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Cap7Ejercicio1 cap7Ejercicio1 = new Cap7Ejercicio1();
            cap7Ejercicio1.Show();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Cap7Ejercicio2 cap7Ejercicio2 = new Cap7Ejercicio2();
            cap7Ejercicio2.Show();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Cap7Ejercicio5 cap7Ejercicio5 = new Cap7Ejercicio5();
            cap7Ejercicio5.Show();
        }
    }
}
