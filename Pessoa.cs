using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteLab
{
    public abstract class Pessoa
    {
        public string nome { get; set; }
        public Endereco endereco { get; set; }  
        public abstract double  PagarImposto(float rendimento);
    }
}