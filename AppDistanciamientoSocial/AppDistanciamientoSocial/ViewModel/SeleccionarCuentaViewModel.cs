using AppDistanciamientoSocial.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppDistanciamientoSocial.ViewModel
{
    public class SeleccionarCuentaViewModel : INotifyPropertyChanged
    {

        public ICommand NextPageCommand { get; set; }
        public ICommand NextPageCommand2 { get; set; }

        public INavigation Navigation { get; set; }
        public SeleccionarCuentaViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
            NextPageCommand = new Command(async () =>
            {

                await Navigation.PushModalAsync(new IngresaNombre(),false);
            });
            NextPageCommand2 = new Command(async () =>
            {

                await Navigation.PushModalAsync(new Pantalla8(), false);
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

