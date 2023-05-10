using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp
{
    public abstract class Persona
    {
        public string Nome { get; set; } = string.Empty;
        public string Cognome { get; set; } = string.Empty;
        public double Stipendio { get; set; }

        public override string? ToString()
        {
            return base.ToString();
        }

        public abstract double Tredicesima();
    }


}
