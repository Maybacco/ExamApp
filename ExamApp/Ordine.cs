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
        
        public Dictionary<Prodotto, int> ElencoProdotti { get; set;} = new Dictionary<Prodotto, int>();

        public Venditore Venditore { get; set; }


        public int NoProdotti() => ElencoProdotti.Count;

        public double Totale()
        {
            double prezzoTotale = 0;
            foreach(var prod in ElencoProdotti)
            {
                prezzoTotale += prod.Key.Prezzo;
            }

            return prezzoTotale;
        }

        public void Scontrino()
        {
            var subTotale = 0.0;
            foreach(var prod in ElencoProdotti)
            {
                var currentProd = prod.Key;
                subTotale += prod.Value * currentProd.Prezzo;

                Console.WriteLine($"{currentProd.Codice} - {currentProd.Nome} | {prod.Value} x {currentProd.Prezzo} | {subTotale}");
            }
            
        }

        public override string? ToString()
        {
            return $"Ordine {IdOrdine} di {Venditore.Nome} {Venditore.Cognome}: NoProdotti: {NoProdotti()} - Tot: {Totale()}";
        }
    }
}
