using AppDistanciamientoSocial.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AppDistanciamientoSocial.ViewModel
{
    public partial class ReportViewModel 
    {
        HttpClient client;

        public ReportViewModel()
        {
            client = new HttpClient();
        }
        public async Task<List<Incidencia>> LoadIncidencias()
        {
            String url = "https://webapidistanciamientosocial20200610040741.azurewebsites.net/api/empleado";
            Uri uri = new Uri(string.Format(url, string.Empty));

            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                List<Incidencia> incidencias = JsonConvert.DeserializeObject<List<Incidencia>>(content);
                return incidencias;
            }
            return null;
        }
    }
}
