using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinDecifraMe
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string texto = enResposta.Text.Trim();
            if (texto.ToUpper() == "TRÊS" || texto.ToUpper() == "TRES" || texto == "3")
            {
                Navigation.PushAsync(new Page3());
            }
            else
            {
                DisplayAlert("A Esfinge Fala:", "Você foi devorado!", "OK");
                Navigation.PopToRootAsync();
            }
        }
    }
}