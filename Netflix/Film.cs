using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
    {
    public class Film
        {
        private string titolo;
        private string regista;
        private int durata;
        private string[] genere;

        public Film(string titolo, string regista, int durata, string[] genere)
            {
            this.titolo = titolo;
            this.regista = regista;

            this.durata = durata;
            this.genere = genere;
            }
        public string getTitolo()
            {
            return titolo;
            }
        public string getRegista()
            {
            return regista;
            }

        public int getDurata()
            {
            return durata;
            }
        public string[] getGenere()
            {
            return genere;
            }
        public void StampaFilm()
            {
            Console.WriteLine("----" + "SCHEDA FILM" + "-----");
            Console.WriteLine("titolo: " + titolo);
            Console.WriteLine("regista: " + regista);
            Console.WriteLine("durata: " + durata + "min");
            StampaArray();
            Console.Write("----------------------------");
            }
        public void StampaArray()
            {
            Console.Write("Genere: ");
            foreach (string genere in this.genere)
                {
                Console.Write(genere + " ");
                }
            Console.Write("\n");
            }
        }
    }
