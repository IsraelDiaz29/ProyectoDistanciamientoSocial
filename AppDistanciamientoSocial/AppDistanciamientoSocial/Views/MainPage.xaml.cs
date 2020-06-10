using AppDistanciamientoSocial.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppDistanciamientoSocial
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        //public MainPageViewModel  ViewModel { get; set; }
        public MainPage()
        {
            InitializeComponent();
        }

//       // protected override async void OnAppearing()
//        {
//            base.OnAppearing();
//            ViewModel = new MainPageViewModel();
//            this.BindingContext = ViewModel;
//            await ViewModel.LoadEmployees();
//;
//        }
    }
}
