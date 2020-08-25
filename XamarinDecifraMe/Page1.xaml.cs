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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string texto = enResposta.Text.Trim();
            if(texto.ToUpper() == "AZUL" || texto.ToUpper() == "AZÚL")
            {
                Navigation.PushAsync(new Page2());
            }
            else
            {
                DisplayAlert("A Esfinge Fala:", "Você foi devorado!", "OK");
                Navigation.PopAsync();
            }
        }
    }
}