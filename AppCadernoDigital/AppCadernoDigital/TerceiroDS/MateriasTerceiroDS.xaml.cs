using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCadernoDigital.TerceiroDS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MateriasTerceiroDS : ContentPage
    {
        public MateriasTerceiroDS()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerceiroDS.WebIII());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerceiroDS.Internet());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerceiroDS.QTS());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerceiroDS.TCC());
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerceiroDS.MobileII());
        }
    }
}