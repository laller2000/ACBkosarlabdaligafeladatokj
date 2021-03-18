using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kosar2004
{
    class Liga
    {
        //hazai;idegen;hazai_pont;idegen_pont;helyszín;időpont
        private string hazai;
        private string idegen;
        private int hazai_pont;
        private int idegen_pont;
        private string helyszin;
        private DateTime idopont;

        public string Hazai { get => hazai; set => hazai = value; }
        public string Idegen { get => idegen; set => idegen = value; }
        public int Hazai_pont { get => hazai_pont; set => hazai_pont = value; }
        public int Idegen_pont { get => idegen_pont; set => idegen_pont = value; }
        public string Helyszin { get => helyszin; set => helyszin = value; }
        public DateTime Idopont { get => idopont; set => idopont = value; }

        public Liga(string hazai, string idegen, int hazai_pont, int idegen_pont, string helyszin, DateTime idopont)
        {
            Hazai = hazai;
            Idegen = idegen;
            Hazai_pont = hazai_pont;
            Idegen_pont = idegen_pont;
            Helyszin = helyszin;
            Idopont = idopont;
        }
        public Liga(string sor)
        {
            string[] adatok = sor.Split(';');
            Hazai = adatok[0];
            Idegen = adatok[1];
            Hazai_pont = int.Parse(adatok[2]);
            Idegen_pont = int.Parse(adatok[3]);
            Helyszin = adatok[4];
            Idopont = DateTime.Parse(adatok[5]);
        }
    }
}
