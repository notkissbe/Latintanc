using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Latintanc
{
    internal class Feladatok
    {
        private List<Par> lista = new List<Par>();

        public List<Par> Lista { get => lista; set => lista = value; }

        public void Beolvasas()
        {
            StreamReader r = new StreamReader("tancrend.txt");

            while (!r.EndOfStream)
            {
                string tanc = r.ReadLine();
                string no = r.ReadLine();
                string ferfi = r.ReadLine();
                lista.Add(new Par(tanc, no, ferfi));
            }
            r.Close();
        }

        public string Masodik()
        {

            return $"Elso tanc: {lista[0].Tanctipus}, Utolso tanc: {lista.Last().Tanctipus}";

        }
        public int Harmadik()
        {
            int szamlalo = 0;
            foreach (var valami in lista)
            {
                if (valami.Tanctipus == "samba")
                {
                    szamlalo++;
                }
            }
            return szamlalo;
        }

        public List<string> Negyedik()
        {
            List<string> tancoltbenne = new List<string>();
            foreach (var valami in lista)
            {
                if (valami.Nonev == "Vilma")
                {
                    tancoltbenne.Add(valami.Tanctipus);

                }
            }
            return tancoltbenne;

        }
    }
}
