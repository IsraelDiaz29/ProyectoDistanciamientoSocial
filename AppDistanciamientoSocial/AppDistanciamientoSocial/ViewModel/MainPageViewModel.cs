using AppDistanciamientoSocial.Helpers;
using AppDistanciamientoSocial.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppDistanciamientoSocial.ViewModel
{
    public class RegisterDetailPageViewModel:BaseViewModel
    {

        ///crear lista de personas
        ///
        public ObservableCollection<Employee> Employees { get; set; }
       
        public ICommand SearchCommand { get; set; }

        public RegisterDetailPageViewModel()
        {
            SearchCommand =
                new Command(async (text) =>
                {
                    //string url = "";
                    //var services =
                    // new HttpHelper<Employees>();
                    //var employees = await services.GetRestServiceDataAsync(url);
                    //Employees = new ObservableCollection<Employee>(employees.employees);
                });
        }


        public async Task LoadEmployees()
        {
            var url = "https://www.amiiboapi.com/api/character";
            var services =
                new HttpHelper<Employees>();

            var employees = await services.GetRestServiceDataAsync(url);
            Employees = new ObservableCollection<Employee>(employees.employees);
        }
    }
}
