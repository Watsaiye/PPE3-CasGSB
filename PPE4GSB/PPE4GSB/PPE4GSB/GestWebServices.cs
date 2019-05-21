using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PPE4GSB
{
    public class GestWebServices
    {
        private HttpClient ws;
        private string response;

        // Constructeur
        public GestWebServices()
        {
            ws = new HttpClient();
        }

        // Méthodes appelant les API PHP
        public async Task<List<Medicaments>> GetAllMedoc()
        {
            response = await ws.GetStringAsync("http://paris2.ingetis.fr/SLAM_2019/SEIGLER_Alan/Situation_2_Cas_GSB/GetLesMedocs.php");
            List<Medicaments> lesMedicaments = JsonConvert.DeserializeObject<List<Medicaments>>(response);
            return lesMedicaments;
        }
    }
}
