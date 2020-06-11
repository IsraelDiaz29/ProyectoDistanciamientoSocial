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
    public partial class Pantalla8 : ContentPage
    {
        public Pantalla8ViewModel ViewModel { get; set; }
        public Pantalla8()
        {
            InitializeComponent();
            ViewModel = new Pantalla8ViewModel(Navigation);
            this.BindingContext = ViewModel;
        }

        private void GradientButton_OnTouchesEnded(object sender, IEnumerable<NGraphics.Point> e)
        {
            ViewModel.Confirmar(Int32.Parse(txtNumber.Text));
            
        }
    }
}