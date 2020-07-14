using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Controles_Practica_1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }



        private async void BtbMostrar_Clicked(object sender, EventArgs e)
        {

            int año = Int32.Parse(txtFecha.Text);
            int edad = 2020 - año;
            string Situación;


            if (check1.IsChecked == true)
            {
                Situación = " estoy casado/a "; 
            }else{
                Situación = " no estoy casado/a ";

            }
            var profesión = picker1.SelectedItem;

            await DisplayAlert("Mensaje", "Hola mi nombre es " + txtNombre.Text + " " + txtApellido.Text + ", tengo " + edad + " años de edad y nací en " + txtLugar.Text + " , en la actualidad" + Situación + "y soy profesional en el area de " + profesión + ".", "OK");

        }

    }
}
