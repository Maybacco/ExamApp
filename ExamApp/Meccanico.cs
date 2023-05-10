using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp
{

    public enum Tipologia
    {
        Carrozzeria,
        Meccanica
    }

    public class Meccanico : Persona
    {

        public Tipologia Tipologia { get; set; }    


        public override double Tredicesima()
        {
            return Stipendio * 1.93;
        }
    }

    public class CapoOfficina : Meccanico
    {
        public List<Ordine> Ordini { get; set; } = new List<Ordine>();

        public void AggiungiOrdine(Ordine ordine, int index)
        {
            Ordini.Insert(index, ordine);
        }

        public int NoOrdini()
        {
            return Ordini.Count;
        }

        public override double Tredicesima()
        {
            double totaleOrdini = 0;
            foreach(var ordine in Ordini)
            {
                totaleOrdini += ordine.Totale();
            }
            return totaleOrdini + Stipendio * 2;
        }
    }
}   
