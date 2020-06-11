using AppDistanciamientoSocial.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppDistanciamientoSocial.ViewModel
{
    public class PersonDetailViewModel
    {
        public Command SaveFriendCommand { get; set; }
        public Command DeleterFriendCommand { get; set; }
        public Employee NewFriend { get; set; }
        private INavigation Navigation;

        public PersonDetailViewModel(INavigation navigation)
        {
            NewFriend = new Employee();
            SaveFriendCommand = new Command(async () => await SaveFriend());

            Navigation = navigation;
        }

        public PersonDetailViewModel(INavigation navigation, Employee friend)
        {
            NewFriend = friend;
            SaveFriendCommand = new Command(async () => await SaveFriend());
            DeleterFriendCommand = new Command(async () => await DeleterFriend());
            Navigation = navigation;
        }


        public async Task SaveFriend()
        {
           
            string url = $"https://webapidistanciamientosocial20200610040741.azurewebsites.net/api/empleado?id={NewFriend.idEmpleado}";
            var client = new HttpClient();
           
            client.BaseAddress = new Uri(url);
            var json = JsonConvert.SerializeObject(NewFriend);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response =
                await client.PutAsync(url, content);
            response.EnsureSuccessStatusCode();
            await Navigation.PopToRootAsync();
        }

        public async Task DeleterFriend()
        {
            string url = $"https://webapidistanciamientosocial20200610040741.azurewebsites.net/api/empleado?id={NewFriend.idEmpleado}";
            var client = new HttpClient();
            client.BaseAddress = new Uri(url);
            var response =
                await client.DeleteAsync(client.BaseAddress);
            response.EnsureSuccessStatusCode();
            await Navigation.PopToRootAsync();
        }
    }
}