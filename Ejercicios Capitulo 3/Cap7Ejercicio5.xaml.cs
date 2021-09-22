using System;
using System.Collections;
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

namespace Tarea3Aplicada.Ejercicios_Capitulo_3
{
    /// <summary>
    /// Interaction logic for Cap7Ejercicio5.xaml
    /// </summary>
    public partial class Cap7Ejercicio5 : Window
    {
        public Cap7Ejercicio5()
        {
            InitializeComponent();
        }


        public AgendaTelefonica agenda = new AgendaTelefonica();
        public Hashtable hagenda = new Hashtable();
       



        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {



        }



        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            AgendaTelefonica agenda = new AgendaTelefonica();



            agenda.nombre = PalabraTextBox.Text;
            agenda.telefono = DefiTextBox.Text;
            MessageBox.Show("Guardado con exito!");



            hagenda.Add(agenda.nombre, agenda.telefono);
            LlenarDataGrid();
        }



        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {



        }



        public void LlenarDataGrid()
        {
            DatosAgenda.ItemsSource = null;
            if (hagenda.Count > 0)
            {
                DatosAgenda.ItemsSource = hagenda;
            }
        }
    }
}
