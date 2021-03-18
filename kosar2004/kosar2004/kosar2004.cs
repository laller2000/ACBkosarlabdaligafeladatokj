using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kosar2004
{
    class kosar2004
    {
        static List<Liga> liga = new List<Liga>();
        static void Main(string[] args)
        {
            Console.WriteLine("2.feladat:eredmenyek.csv beolvasása!");
            Beolvas("eredmenyek.csv");
            int hazaidb = 0;
            int idegendb = 0;
            for (int i = 0; i < liga.Count; i++)
            {
                if (liga[i].Hazai=="Real Madrid")
                {
                    hazaidb++;
                }
                else if(liga[i].Idegen=="Real Madrid")
                {
                    idegendb++;
                }
            }
            Console.WriteLine($"\n3.feladat:Real Madrid: Hazai:{hazaidb} Idegen:{idegendb}");
            string voltdontelten =" ";
            for (int i = 0; i < liga.Count; i++)
            {
                if (liga[i].Hazai_pont==liga[i].Idegen_pont)
                {
                    voltdontelten = "Igen";
                    return;
                }
                else
                {
                    voltdontelten = "Nem";
                }

            }
           
            Console.WriteLine($"\n4.feladat:Voltdontetlen?:{voltdontelten}");
            for (int i = 0; i < liga.Count; i++)
            {
                if (liga[i].Idegen.Contains("Barcelona"))
                {
                    Console.WriteLine($"\n5.feladat:barcelonai csapat neve:{liga[i].Idegen}");
                }
            }
            
            Console.WriteLine("\n6.feladat:");
            for (int i = 0; i < liga.Count; i++)
            {
                if (liga[i].Idopont.Year==2004 && liga[i].Idopont.Month==11 && liga[i].Idopont.Day==21)
                {
                    Console.WriteLine($"\t{liga[i].Hazai}-{liga[i].Idegen} ({liga[i].Hazai_pont}:{liga[i].Idegen_pont})");
                }
            }
            Console.WriteLine("\n7.feladat:");
            var stadionok = liga.GroupBy(a => a.Helyszin).Select(b => new { o = b.Key, db = b.Count() }).Where(c => c.db > 20);
            foreach (var item in stadionok)
            {
                Console.WriteLine($"\t{item.o}:{item.db}");
            }
            Console.WriteLine("\nProgram Vége!");
            Console.ReadLine();
        }
        static void Beolvas(string filenev)
        {
            using (StreamReader sr=new StreamReader(filenev,Encoding.Default))
            {
                string fejlec = sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    Liga l = new Liga(sr.ReadLine());
                    liga.Add(l);
                }
            }
        }
    }
}
