using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp
{

    public class Prodotto
    {
        public string Codice { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string Descrizione { get; set; } = string.Empty;
        public double Prezzo { get; set; }

        public override string? ToString()
        {
            return $"Prodotto {Nome} Cod: {Codice} - {Descrizione} - {Prezzo}";
        }
    }
    public sealed class Ordine
    {
        public int IdOrdine { get; set; }
        public DateTime Data { get; set; }
        
        public List<Prodotto> Prodotti { get; set;} = new List<Prodotto>();

        public Venditore Venditore { get; set; }


        public int NoProdotti() => Prodotti.Count;

        public double Totale()
        {
            double prezzoTotale = 0;
            foreach(var prod in Prodotti)
            {
                prezzoTotale += prod.Prezzo;
            }

            return prezzoTotale;
        }

    }
}
