using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteLab
{
    public class PessoaJuridica:Pessoa //  Indica que está herdando dados da classe Pessoa
    {
        public string cnpj { get; set; }
        public string razaoSocial { get; set; }

        public override double PagarImposto(float rendimento)
        {
            if(rendimento <= 1500){
                return 0;
            } else if(rendimento > 1500 && rendimento <= 5000){
                return rendimento * .03;
            }else{
                return (rendimento / 100)* 5;
            }
        }

        public  bool ValidarCNPJ (string cnpj) {
                
        if (cnpj.Length >= 14 && cnpj.Substring( cnpj.Length-4 ) == "0001") {
           return true;

        } else {
            return false;

        }
    }
    }
}