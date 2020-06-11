using AppDistanciamientoSocial.Model;
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

namespace AppDistanciamientoSocial.ViewModel
{
    public partial class ReportViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Incidencia> incidencias;

        ///crear lista de personas
        ///
        public ObservableCollection<Incidencia> Incidencias
        {
            get => incidencias;
            set
            {
                incidencias = value;
                OnPropertyChanged();
            }
        }

        public ReportViewModel()
        {
           
        }
        public async Task LoadIncidencias()
        {
            var url = "https://webapidistanciamientosocial20200610040741.azurewebsites.net/api/reportes";

            var client = new HttpClient();
            client.BaseAddress = new Uri(url);
            var response =
                await client.GetAsync(client.BaseAddress);
            response.EnsureSuccessStatusCode();
            var jsonResult =
                await response.Content.ReadAsStringAsync();
            Incidencias = JsonConvert.DeserializeObject<ObservableCollection<Incidencia>>(jsonResult);



        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
