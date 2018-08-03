using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Formulario
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void Continue_Tapped(object sender, EventArgs e)
        {
            if (await validarFormulario())
            {
                await DisplayAlert("Exito", "Todos Tus campos cumplieron la validacion", "OK");
            }
        }
        private async Task<bool> validarFormulario()
        {
            if (String.IsNullOrWhiteSpace(UserName.Text))
            {
                await this.DisplayAlert("Advertencia", "El campo es obligatorio", "OK");
                return false;
            }
            else if (!UserName.Text.ToCharArray().All(char.IsLetter))
            {
                await this.DisplayAlert("Advertencia", "Tu informacion contiene numeros, favor validar.", "OK");
                return false
            }
        }
    
       
    }
}
