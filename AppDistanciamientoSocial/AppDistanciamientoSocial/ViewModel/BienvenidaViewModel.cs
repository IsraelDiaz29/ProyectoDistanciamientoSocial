
using AppDistanciamientoSocial.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppDistanciamientoSocial.ViewModel
{
   public class BienvenidaViewModel: INotifyPropertyChanged
    {
        public ICommand NextPageCommand { get; set; }

        public INavigation Navigation { get; set; }
        public BienvenidaViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
            NextPageCommand = new Command(async () =>
            {

                
                await Navigation.PushModalAsync(new SeleccionarCuenta(),false);
                

            });
        }


        public event PropertyChangedEventHandler PropertyChanged;


        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
