using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCadernoDigital.PrimeiroDS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MateriasPrimeiroDS : ContentPage
    {
        public MateriasPrimeiroDS()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroDS.BancodeDados());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroDS.WebI());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroDS.AnaliseSistemas());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroDS.FundamentosInformatica());
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroDS.Design());
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroDS.LogicaProgramacao());
        }
    }
}