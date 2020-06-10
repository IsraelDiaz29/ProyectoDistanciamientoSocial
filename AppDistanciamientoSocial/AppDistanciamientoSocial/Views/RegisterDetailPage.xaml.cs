using AppDistanciamientoSocial.Model;
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
    public partial class RegisterDetailPage : ContentPage
    {
        public RegisterDetailPage()
        {
            InitializeComponent();
            BindingContext = new RegisterDetailViewModel();
        }

        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string bearName = (e.CurrentSelection.FirstOrDefault() as Employee).strNombre;
            // This works because route names are unique in this application.
            await Shell.Current.GoToAsync($"employeesdetails?strNombre={bearName}");
            // The full route is shown below.
            // await Shell.Current.GoToAsync($"//animals/bears/beardetails?name={bearName}");
        }
    }
}