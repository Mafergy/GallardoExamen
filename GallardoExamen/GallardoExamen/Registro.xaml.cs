using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GallardoExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string usuario, string clave)
        {
            
            InitializeComponent();
            lblUsuario.Text = usuario;
            lblClave.Text = clave;
            txtUsuario.Text = usuario;
            txtClave.Text = clave;
        }

       

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            //Mostrar una notificación “Elemento guardado con exito
            try
            {
                //almacenando en varibales lo que usuario ingresa
                string usuario = txtUsuario.Text;
                string clave = txtClave.Text;

                //Permite abrir la ventana(ViewDos)
                await Navigation.PushAsync(new Resumen(usuario, clave));
               
                
                    await DisplayAlert("Exito", "Datos Guardados correctamente", "oK");
               
            }
            catch (Exception ex)
            {
                await DisplayAlert("Mensaje de advertencia", ex.Message, "OK");
            }
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                double cuotain = Convert.ToDouble(txtMonto.Text);
                

                //Operacion
                double cuotas = ((cuotain - 1800)/3);
                double cuota = cuotas * 0.05;
                
                double final = cuotas + cuota;


                //Visualizacion el resultado en pantalla 
                
                txtFinal.Text = final.ToString();


            }
            catch (Exception ex)
            {

                DisplayAlert("Mensaje De Alerta", ex.Message, "Salir");
            }


        }
    }
}