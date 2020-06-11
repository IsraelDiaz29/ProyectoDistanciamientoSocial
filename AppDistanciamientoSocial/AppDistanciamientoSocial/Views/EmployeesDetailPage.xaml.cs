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
    public partial class EmployeesDetailPage : ContentPage
    {

        public ReportViewModel ViewModel { get; set; }
        public EmployeesDetailPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            ViewModel = new ReportViewModel();
            await ViewModel.LoadIncidencias();
            this.BindingContext = ViewModel;
        }
    }
}