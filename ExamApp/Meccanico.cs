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

    public class CapoMeccanico : Meccanico
    {

    }
}   
