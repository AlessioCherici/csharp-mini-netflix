using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
    {
    public class SerieTV
        {
        private string nome;
        private int numeroPuntate;
        private int numeroStagioni;
        private bool vista;
        private string[] genere;
        private ushort statusVisualizzazione;

            public SerieTV(string nome, int numeroPuntate, int numeroStagioni, string[] genere, ushort statusVisualizzazione)
            {
            this.nome = nome;   
            this.numeroPuntate = numeroPuntate;
            this.numeroStagioni = numeroStagioni;
            this.genere = genere;
            SetStatusVisualizzazione(statusVisualizzazione);
            }

        //-------------------------------------------- Metodi Get --------------------------------------------

        public string GetNome() 
            { 
            return this.nome;
            }
        public int GetNumeroPuntate() 
            {
            return this.numeroPuntate;
            }
        public int GetNumeroStagioni() 
            {
            return this.numeroStagioni;
            }
        public string[] GetGenere()
            {
            return this.genere; 
            }
        public string IsVista() 
            {
            if (this.vista)
                {
                return "Si";
                }
            else
                {
                return "No / La sto vedendo";
                }
            }
        public string GetStatusVisualizzazione()
            {
            switch(this.statusVisualizzazione)
                {
                case 0:
                   
                    return "In corso";
                    break;

                case 1:                   
                    return "Completata";
                    break;

                case 2:                    
                    return "In pausa";
                    break;

                case 3:                   
                    return "Abbandonata";
                    break;

                case 4:                    
                    return "Da vedere";
                    break;

                default:
                    return "Sconosciuto";
                    break;
                }
            }
        public void StampaSerieTv()
            {
            Console.WriteLine("-------------" + this.nome + "-------------");
            Console.WriteLine("Numero puntate: " + this.numeroPuntate);
            Console.WriteLine("Numero stagioni: " + this.numeroStagioni);
            StampaArray();
            Console.WriteLine("Status: " + GetStatusVisualizzazione());
            Console.WriteLine("--------------------------------------------");
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
        //-------------------------------------------- Metodi Set --------------------------------------------

        public void SetStatusVisualizzazione(ushort valore)
            {
            switch (valore)
                {
                case 0:
                    this.vista = true;
                    this.statusVisualizzazione = 0;
                    break;

                case 1:
                    this.vista = true;
                    this.statusVisualizzazione = 1;
                    break;

                case 2:
                    this.vista = true;
                    this.statusVisualizzazione = 2;
                    break;

                case 3:
                    this.vista = true;
                    this.statusVisualizzazione = 3;
                    break;

                case 4:
                    this.vista = false;
                    this.statusVisualizzazione = 4;
                    break;

                default:
                    this.statusVisualizzazione = 100;
                    break;
                }
            }
        }
    }
