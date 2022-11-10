using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukkMaraton2019
{
    internal class Versenytav
    {
        private string _rajtszam;
        private string _kategoria;
        private string _nev;
        private string _egyesulet;
        private string _ido;
        
        public string Tav
        {
            get
            {
                switch (_rajtszam[0])
                {
                    case 'M': return "Mini";
                    case 'R': return "Rövid";
                    case 'K': return "Közép";
                    case 'H': return "Hosszú";
                    case 'E': return "Pedelec";
                }
                return "Hibás rajtszám";
            }
        }

        public string Kategoria { get => _kategoria;}
        public string Nev { get => _nev;}
        public string Egyesulet { get => _egyesulet;}
        public string Ido { get => _ido;}
        public string Rajtszam { get => _rajtszam; set => _rajtszam = value; }

        public Versenytav(string rajtszam, string kategoria, string nev, string egyesulet, string ido)
        {
            _rajtszam = rajtszam;
            _kategoria = kategoria;
            _nev = nev;
            _egyesulet = egyesulet;
            _ido = ido;
        }
    }

}
