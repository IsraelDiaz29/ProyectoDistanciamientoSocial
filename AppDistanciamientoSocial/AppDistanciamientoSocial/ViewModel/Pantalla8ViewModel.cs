﻿using AppDistanciamientoSocial.Views;
using Hangfire.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace AppDistanciamientoSocial.ViewModel
{
     public class Pantalla8ViewModel: INotifyPropertyChanged
    {
        private INavigation Navigation;
        private Command SearchCommand { get; set; }


        public Pantalla8ViewModel(INavigation navigation)
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
                await Navigation.PushAsync(new PrincipalPage().MainPage, false);
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
