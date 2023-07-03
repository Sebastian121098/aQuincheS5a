using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace aQuincheS5a
{
    public partial class MainPage : ContentPage
    {
        private string Url = "http://192.168.56.1/ws_uisrael/post.php";
        private HttpClient client = new HttpClient();
        private ObservableCollection<Estudiante>post;
        public MainPage()
        {
            InitializeComponent();
            ObtenerDatos();
        }
        public async void ObtenerDatos()
        {
            var contenido = await client.GetStringAsync(Url);
            List<Estudiante> listaPost = JsonConvert.DeserializeObject<List<Estudiante>>(contenido);
            post = new ObservableCollection<Estudiante>(listaPost);
            listaEstudiantes.ItemsSource = post;
        }
        private async void btnMostrar_Clicked(object sender, EventArgs e)
        {
          
        }
    }
}
