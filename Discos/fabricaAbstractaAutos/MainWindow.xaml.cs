using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using fabricaAbstractaAutos.Clases;
using fabricaAbstractaAutos.Fabrica;


namespace fabricaAbstractaAutos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();            

        }

        private void btnCrearMazda_Click(object sender, RoutedEventArgs e)
        {
            IFabricadePartes fabrica = new fabricaMazda();
            IAuto auto = fabrica.crearAuto();
            IMotor motor = fabrica.crearMotor();
            ICarroceria carroceria = fabrica.crearCarroceria();

            listadePartes.Items.Add(auto.darCaracteristica());
            listadePartes.Items.Add(motor.darCaracteristica());
            listadePartes.Items.Add(carroceria.darCaracteristica());
        }

        private void btnCrearRenault_Click(object sender, RoutedEventArgs e)
        {
            IFabricadePartes fabrica = new fabricaRenault();
                IAuto auto = fabrica.crearAuto();
                IMotor motor = fabrica.crearMotor();
                ICarroceria carroceria = fabrica.crearCarroceria();

                listadePartes.Items.Add(auto.darCaracteristica());
                listadePartes.Items.Add(motor.darCaracteristica());
                listadePartes.Items.Add(carroceria.darCaracteristica());
            }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            listadePartes.Items.Clear();
        }
    }          
}


