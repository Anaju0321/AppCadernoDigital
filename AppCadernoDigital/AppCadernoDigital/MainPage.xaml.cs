//dando os using para acessar as pastas com as outras paginas no projeto inteiro
using AppCadernoDigital.Primeiro;
using AppCadernoDigital.Segundo;
using AppCadernoDigital.Terceiro;
using AppCadernoDigital.PrimeiroDS;
using AppCadernoDigital.SegundoDS;
using AppCadernoDigital.TerceiroDS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCadernoDigital
{
    public partial class MainPage : ContentPage
    {
      

        public MainPage()
        {
            //Deixando a barra de navegação transparente na pagina inicial do app
            NavigationPage.SetHasNavigationBar(this, false);

            InitializeComponent();
        }

        //Prenchendo os metodos gerados pelo clicked na .xaml e definindo as paginas para a navegação para
        //as paginas do primeiro, segundo e terceiro do curso e do etim.
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MateriasPrimeiro());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Segundo.MateriasSegundo());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Terceiro.MateriasTerceiro());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroDS.MateriasPrimeiroDS());
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SegundoDS.MateriasSegundoDS());
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerceiroDS.MateriasTerceiroDS());
        }
    }
}
