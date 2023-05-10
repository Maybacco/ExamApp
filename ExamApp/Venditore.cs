using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp
{

    public enum Settore
    {
        Auto,
        Moto,
    }

    public class Venditore : Persona
    {
        public Settore Settore { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Venditore venditore &&
                   Nome == venditore.Nome &&
                   Cognome == venditore.Cognome &&
                   Stipendio == venditore.Stipendio &&
                   Settore == venditore.Settore;
        }

        public override string? ToString()
        {
            return $"Venditore {Nome}{Cognome}";
        }

        public override double Tredicesima()
        {
            return Stipendio * 1.91;
        }
    }


    public class ResponsabileVenditori : Venditore
    {

        public List<Venditore> Venditori { get;set; } = new List<Venditore>();


        public void AggiungiVenditore(Venditore venditore)
        {
            Venditori.Add(venditore);
        }

        public Venditore RestituisciVenditore(int index)
        {
            if (index < Venditori.Count)
            {
                return Venditori[index];
            }
            else
            {
                return null;
            }
        }

        public void CancellaVenditore(int index)
        {
            if (index < Venditori.Count)
            {
                Venditori.RemoveAt(index);
            }
        }

        public override double Tredicesima()
        {
            return (Stipendio * 2) + (Venditori.Count * Stipendio * 0.15);
            
        }

        public override string? ToString()
        {
            return $"Resp Venditori: {Nome} {Cognome}";
        }
    }
}
