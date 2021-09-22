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
    /// Interaction logic for Cap7Ejercicio2.xaml
    /// </summary>
    public partial class Cap7Ejercicio2 : Window
    {
        public Cap7Ejercicio2()
        {
            InitializeComponent();
        }

        public Diccionario diccionario = new Diccionario();
        public Hashtable hdiccionario = new Hashtable();
       
        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }



        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            //hdiccionario.Remove();
        }



        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            Diccionario diccionario = new Diccionario();



            diccionario.termino = PalabraTextBox.Text;
            diccionario.definicion = DefiTextBox.Text;
            MessageBox.Show("Guardado con exito!");



            hdiccionario.Add(diccionario.termino, diccionario.definicion);
            LlenarDataGrid();
        }



        private void Limpiar()
        {
            hdiccionario.Clear();
        }



        public void LlenarDataGrid()
        {
            DatosDiccionario.ItemsSource = null;
            if (hdiccionario.Count > 0)
            {
                DatosDiccionario.ItemsSource = hdiccionario;
            }
        }
    }
}
