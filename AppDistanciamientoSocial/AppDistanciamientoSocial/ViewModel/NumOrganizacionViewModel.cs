using AppDistanciamientoSocial.Views;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;

namespace AppDistanciamientoSocial.ViewModel
{
   public class NumOrganizacionViewModel
    {
        private INavigation Navigation;
        private Command SearchCommand { get; set; }


        public NumOrganizacionViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
         
        }

        public async void Confirmar(int name)
        {
            //Cadena interpolada.

            string url = $"https://webapidistanciamientosocial20200610040741.azurewebsites.net/api/empresa?idEmpresa={name}";
            var client = new HttpClient();
            client.BaseAddress = new Uri(url);
            var response =
                await client.GetAsync(client.BaseAddress);
            response.EnsureSuccessStatusCode();
            var jsonResult =
                await response.Content.ReadAsStringAsync();
            if (jsonResult != null)
            {
                await Navigation.PushModalAsync(new DispositivoEncontrado(), false);
            }

        }

    }
}
