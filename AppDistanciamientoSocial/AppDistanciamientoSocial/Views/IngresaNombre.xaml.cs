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
    public partial class IngresaNombre : ContentPage
    {
        public IngresarViewModel ViewModel { get; set; }
        public IngresaNombre()
        {
            InitializeComponent();
            ViewModel = new IngresarViewModel(Navigation,this.txtName.Text);
            this.BindingContext = ViewModel;
        }

        private void GradientButton_OnTouchesEnded(object sender, IEnumerable<NGraphics.Point> e)
        {
            ViewModel.Empleado(txtName.Text);
        }
    }
}