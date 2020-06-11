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
    public partial class NumOrganizacion : ContentPage
    {
        public NumOrganizacionViewModel ViewModel { get; set; }
        public NumOrganizacion()
        {
            InitializeComponent();
            ViewModel = new NumOrganizacionViewModel(Navigation);
            this.BindingContext = ViewModel;
        }

        private void GradientButton_OnTouchesEnded(object sender, IEnumerable<NGraphics.Point> e)
        {
            ViewModel.Confirmar(Int32.Parse(this.txtNumber.Text));
        }
    }
}