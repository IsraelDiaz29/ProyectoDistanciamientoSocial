using AppDistanciamientoSocial.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppDistanciamientoSocial.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SeleccionarCuenta : ContentPage
    {
        public SeleccionarCuentaViewModel ViewModel { get; set; }
        public SeleccionarCuenta()
        {
            InitializeComponent();
            ViewModel = new SeleccionarCuentaViewModel(Navigation);
            this.BindingContext = ViewModel;
        }
    }
}