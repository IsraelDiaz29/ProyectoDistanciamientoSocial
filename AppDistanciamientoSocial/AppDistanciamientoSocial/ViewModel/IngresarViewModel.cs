using Android.Icu.Text;
using Android.Views;
using AppDistanciamientoSocial.Views;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.BehaviorsPack;

namespace AppDistanciamientoSocial.ViewModel
{
    public class IngresarViewModel
    {
        private INavigation Navigation;
        private Command SearchCommand { get; set; }


        public IngresarViewModel(INavigation navigation, String name)
        {
            this.Navigation = navigation;
           


        }

        public async void Empleado(string name)
        {

            //Cadena interpolada.

            string url = $"https://webapidistanciamientosocial20200610040741.azurewebsites.net/api/empleadonombre?nombre={name}";
            var client = new HttpClient();
            client.BaseAddress = new Uri(url);
            var response =
                await client.GetAsync(client.BaseAddress);
            response.EnsureSuccessStatusCode();
            var jsonResult =
                await response.Content.ReadAsStringAsync();
            if (jsonResult != null)
            {
                await Navigation.PushModalAsync(new NumOrganizacion(), false);
            }

        }
    }
}
