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

namespace Tarea3Aplicada.Ejercicios_Capitulo_3
{
    /// <summary>
    /// Interaction logic for Cap6Ejercicio12345.xaml
    /// </summary>
    public partial class Cap6Ejercicio12345 : Window
    {
        public Cap6Ejercicio12345()
        {
            InitializeComponent();
        }

        int cantsalones;
        int estudiantes;
        int i = 0;
        int j = 0;
        double[][] calif;
        double prom;
        int[] cant;
        int repeticion;
        int y = 1, o = 1;
        int t = 0;
        int d = 0;
        double prom1;
        double mayor, menor;
        double mayorgeneral, menorgeneral;
        int h = 1;
        private void CantidadAulasButton_Click(object sender, RoutedEventArgs e)
        {
            cantsalones = int.Parse(CantidadAulasTextBox.Text);
            CantidadAulasTextBox.IsReadOnly = true;
            CantidadAulasButton.Visibility = Visibility.Hidden;
            AlumnosLabel.Visibility = Visibility.Visible;
            CantidadAlumnosTextBox.Visibility = Visibility.Visible;
            CantidadAlumnosButton.Visibility = Visibility.Visible;
            calif = new double[cantsalones][];
            cant = new int[cantsalones];
        }

        private void CantidadAlumnosButton_Click(object sender, RoutedEventArgs e)
        {
            estudiantes = int.Parse(CantidadAlumnosTextBox.Text);
            calif[i] = new double[estudiantes];
            cant[i] = estudiantes;
            string r = "Cantidad de alumnos del salon " + (i + 2);
            AlumnosLabel.Content = r;
            i++;



            CantidadAlumnosTextBox.Clear();
            if (i == cantsalones)
            {
                CantidadAlumnosTextBox.IsReadOnly = true;
                CantidadAlumnosButton.Visibility = Visibility.Hidden;
                CalificacionLabel.Visibility = Visibility.Visible;
                CalificacionTextBox.Visibility = Visibility.Visible;
                CalificacionButton.Visibility = Visibility.Visible;
                repeticion = cant[0];
                string rt = "Cantidad de alumnos del salon " + (i);
                AlumnosLabel.Content = rt;
            }
        }

        private void CalificacionButton_Click(object sender, RoutedEventArgs e)
        {
            double calificaciones = Convert.ToDouble(CalificacionTextBox.Text);
            CalificacionTextBox.Clear();
            calif[j][t] = calificaciones;



            if (t == repeticion - 1)
            {
                y = 1;
                o++;
                d++;
                t = 0;
                j++;
                if (j == cantsalones)
                {



                }
                else
                {
                    repeticion = cant[d];
                }
            }
            else
            {
                y++;
                t++;
            }



            if (j == cantsalones)
            {
                CalificacionTextBox.IsReadOnly = true;
                CalificacionButton.Visibility = Visibility.Hidden;
                AlumnosLabel.Visibility = Visibility.Hidden;
                CantidadAlumnosTextBox.Visibility = Visibility.Hidden;
                CalificacionLabel.Visibility = Visibility.Hidden;
                CalificacionTextBox.Visibility = Visibility.Hidden;
                PromedioGeLabel.Visibility = Visibility.Visible;
                PromedioGeneralTextBox.Visibility = Visibility.Visible;
                ListaCalificacionesListBox.Visibility = Visibility.Visible;
                MenorLabel.Visibility = Visibility.Visible;
                MayorLabel.Visibility = Visibility.Visible;
                CalificacionMenorTextBox.Visibility = Visibility.Visible;
                CalificacionMayorTextBox.Visibility = Visibility.Visible;
                NuevoButton.Visibility = Visibility.Visible;
                int s = 0;
                double total = 0;
                int g = 0;
                for (int m = 0; m < cant[0]; m++)
                {
                    total += calif[s][m];
                    g++;
                }
                prom = Convert.ToDouble(total / g);



                int z = 1, c = 0;
                PromedioTextBox.Text = prom.ToString();
                prom1 += prom;
                for (int v = 0; v < cant[0]; v++)
                {
                    ListaCalificacionesListBox.Items.Add("Calificacion alumno " + z + " es " + calif[c][v]);
                    if (v == 0)
                    {
                        mayor = calif[c][v];
                        menor = calif[c][v];
                        mayorgeneral = calif[c][v];
                        menorgeneral = calif[c][v];
                    }
                    else
                    {
                        if (calif[c][v] > mayor)
                        {
                            mayor = calif[c][v];
                        }
                        if (calif[c][v] < menor)
                        {
                            menor = calif[c][v];
                        }
                        if (calif[c][v] > mayorgeneral)
                        {
                            mayorgeneral = calif[c][v];
                        }
                        if (calif[c][v] < menorgeneral)
                        {
                            menorgeneral = calif[c][v];
                        }
                    }
                    z++;
                }
                CalificacionMenorTextBox.Text = menor.ToString();
                CalificacionMayorTextBox.Text = mayor.ToString();
            }
            if (j == cantsalones)
            {
                o--;
                y = repeticion;
            }
            CalificacionLabel.Content = "Calificacion del alumno " + y + " del salon " + o;
        

    }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            ListaCalificacionesListBox.Items.Clear();
            int cont = 0;
            int z = 1;
            double total1 = 0;
            for (int i = 0; i < cant[h]; i++)
            {
                total1 += calif[h][cont];
                cont++;
            }
            PromedioLabel.Content = "Promedio de calificaciones del salon: " + (h + 1);
            prom = Convert.ToDouble(total1 / cont);
            PromedioTextBox.Text = prom.ToString();
            prom1 += prom;
            for (int v = 0; v < cant[h]; v++)
            {
                ListaCalificacionesListBox.Items.Add("Calificacion alumno " + z + " es: " + calif[h][v]);
                if (v == 0)
                {
                    mayor = calif[h][v];
                    menor = calif[h][v];
                }
                else
                {
                    if (calif[h][v] > mayor)
                    {
                        mayor = calif[h][v];
                    }
                    if (calif[h][v] < menor)
                    {
                        menor = calif[h][v];
                    }
                }



                if (calif[h][v] > mayorgeneral)
                {
                    mayorgeneral = calif[h][v];
                }
                if (calif[h][v] < menorgeneral)
                {
                    menorgeneral = calif[h][v];
                }
                z++;
            }
            CalificacionMenorTextBox.Text = menor.ToString();
            CalificacionMayorTextBox.Text = mayor.ToString();
            h++;
            if (h == cantsalones)
            {
                ContinuarButton.Visibility = Visibility.Visible;
                NuevoButton.Visibility = Visibility.Hidden;
            }
        }

        

        private void ContinuarButton_Click(object sender, RoutedEventArgs e)
        {
            ListaCalificacionesListBox.Items.Clear();
            for (int i = 0; i < cantsalones; i++)
            {
                ListaCalificacionesListBox.Items.Add("Salon " + (i + 1));
                for (int j = 0; j < cant[i]; j++)
                {
                    ListaCalificacionesListBox.Items.Add("Alumno " + (j + 1) + ": " + calif[i][j]);
                }
            }
            PromedioLabel.Visibility = Visibility.Hidden;
            PromedioTextBox.Visibility = Visibility.Hidden;
            PromedioGeLabel.Visibility = Visibility.Visible;
            PromedioGeneralTextBox.Visibility = Visibility.Visible;
            MenorLabel.Content = "Calificacion menor general";
            MayorLabel.Content = "Calificacion mayor general";
            double prom2 = prom1 / cantsalones;
            PromedioGeneralTextBox.Text = prom2.ToString("N2");
            CalificacionMenorTextBox.Text = menorgeneral.ToString();
            CalificacionMayorTextBox.Text = mayorgeneral.ToString();
            CancelarButton.Visibility = Visibility.Visible;
            ContinuarButton.Visibility = Visibility.Hidden;
        
    }

        private void CancelarButton_Click(object sender, RoutedEventArgs e)
        {
            {
                Close();
            }

        }






    }
}
