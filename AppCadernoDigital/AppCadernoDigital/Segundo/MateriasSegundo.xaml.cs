using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCadernoDigital.Segundo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MateriasSegundo : ContentPage
    {
        public MateriasSegundo()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Segundo.Portugues());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Segundo.Matematica());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Segundo.Geografia());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Segundo.Biologia());
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Segundo.Fisica());
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Segundo.Quimica());
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Segundo.Filosofia());
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Segundo.Historia());
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Segundo.Sociologia());
        }

        private void Button_Clicked_9(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Segundo.EdFisica());
        }
    }
}