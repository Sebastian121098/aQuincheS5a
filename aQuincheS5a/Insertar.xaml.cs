using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace aQuincheS5a
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Insertar : ContentPage
    {
        public Insertar()
        {
            InitializeComponent();
        }

        private void btnInsertar_Clicked(object sender, EventArgs e)
        {
           try
            {
                WebClient cliente = new WebClient();
                var parametros = new System.Collections.Specialized.NameValueCollection();
                parametros.Add("codigo", txtCodigo.Text);
                parametros.Add("nombre", txtNombre.Text);
                parametros.Add("apellido", txtApellido.Text);
                parametros.Add("edad", txtEdad.Text);
                cliente.UploadValues("http://192.168.56.1/ws_uisrael/post.php", "POST", parametros);
                DisplayAlert("Alerta", "Dato insertado", "Cerrar");
                Navigation.PushAsync(new MainPage());
            } catch (Exception ex) {
                DisplayAlert("Alertar", ex.Message, "Cerrar");
            }
            var mensaje = "Elemento ingresado con exito";
            DependencyService.Get<Mensaje>().longAlert(mensaje);
        }

        private void btnCancelar_Clicked(object sender, EventArgs e)
        {
            
            
        }
    }
}