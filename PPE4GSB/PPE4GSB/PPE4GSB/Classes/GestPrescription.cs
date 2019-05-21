using System;
using System.Collections.Generic;
using System.Text;

namespace PPE4GSB
{
    public class GestPrescription
    {
        private List<Medicaments> lesMedicaments;
        private List<Individu_type> lesIndividus;

        public GestPrescription()
        {
            lesMedicaments = new List<Medicaments>();
            lesIndividus = new List<Individu_type>();
        }

        public List<Medicaments> GetlesMedicaments()
        {
            return lesMedicaments;
        }

        public void AjouterMedicaments(Medicaments leMedicament)
        {
            lesMedicaments.Add(leMedicament);
        }

        public List<Individu_type> GetlesIndividus()
        {
            return lesIndividus;
        }

        public void AjouterIndividu(Individu_type leIndividu)
        {
            lesIndividus.Add(leIndividu);
        }

    }
}
