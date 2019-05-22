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
        public async Task<List<Medicaments>> GetMedicamentsAsync()
        {
            response = await ws.GetStringAsync("http://paris2.ingetis.fr/SLAM_2019/SEIGLER_Alan/Situation_2_Cas_GSB/GetLesMedocs.php");
            List<Medicaments> lesMedicaments = JsonConvert.DeserializeObject<List<Medicaments>>(response);
            return lesMedicaments;
        }

        public async Task<List<Individu_type>> GetIndividu_TypesAsync()
        {
            response = await ws.GetStringAsync("http://paris2.ingetis.fr/SLAM_2019/SEIGLER_Alan/Situation_2_Cas_GSB/GetLesIndividus.php");
            List<Individu_type> lesIndividus = JsonConvert.DeserializeObject<List<Individu_type>>(response);
            return lesIndividus;
        }

        public async void InsertMedicament(string med_depotlegal, string med_nomCommercial, string fam_code, string med_contrIndic, string med_composition, string med_effets, double med_prixechantillon)
        {
            response = await ws.GetStringAsync("http://paris2.ingeteis.fr/SLAM_2019/SEIGLER_Alan/Situation_2_Cas_GSB/InsererMedoc.php?depot=" + med_depotlegal + "&nomcom=" + med_nomCommercial + "&codefam=" + fam_code + "&compo=" + med_composition + "&effets=" + med_effets + "&contrindic=" + med_contrIndic + "&prix=" + med_prixechantillon);
        }
    }
}
