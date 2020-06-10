
using AppDistanciamientoSocial.Model;
using AppDistanciamientoSocial.Views;
using Hangfire.Annotations;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppDistanciamientoSocial.ViewModel
{
    public class RegisterDetailPageViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Employee> employees;

        ///crear lista de personas
        ///
        public ObservableCollection<Employee> Employees
        {
            get => employees; 
            set
            {
                employees = value;
                OnPropertyChanged();
            }
        }

        public ICommand SearchCommand { get; set; }
        public Command DeleterFriendCommand { get; set; }
        private INavigation Navigation;
        private Employee _currentEmployee;

        

        public Command ItemTappedCommand { get; set; }


        public Employee CurrentEmployee
        {
            get { return _currentEmployee; }
            set
            {
                _currentEmployee = value;
                OnPropertyChanged();
            }
        }
        public RegisterDetailPageViewModel()
        {
            SearchCommand =
                new Command(async (param) =>
                {
                    //Cadena interpolada.
                    var empleados = param as Employee;
                    if (empleados != null)
                    {
                        string url = $"https://webapidistanciamientosocial20200610040741.azurewebsites.net/api/empleado?id={empleados.idEmployee}";
                        var client = new HttpClient();
                        client.BaseAddress = new Uri(url);
                        var response =
                            await client.GetAsync(client.BaseAddress);
                        response.EnsureSuccessStatusCode();
                        var jsonResult =
                            await response.Content.ReadAsStringAsync();
                        Employees = JsonConvert.DeserializeObject<ObservableCollection<Employee>>(jsonResult);
                    }

                });
            ItemTappedCommand = new Command(async () => await NavigateToEditView());

        }


        public async Task LoadEmployees()
        {
            var url = "https://webapidistanciamientosocial20200610040741.azurewebsites.net/api/empleado";

            var client = new HttpClient();
            client.BaseAddress = new Uri(url);
            var response =
                await client.GetAsync(client.BaseAddress);
            response.EnsureSuccessStatusCode();
            var jsonResult =
                await response.Content.ReadAsStringAsync();
            Employees = JsonConvert.DeserializeObject<ObservableCollection<Employee>>(jsonResult);



        }

        public async Task NavigateToEditView()
        {
            await Navigation.PushAsync(new PersonalDetail(CurrentEmployee));
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


}

