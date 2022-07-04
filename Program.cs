using System;

namespace ClienteLab
{
    class Program{
        static void Main(string[] args)
        {
          // Instanciando o objeto diretamente:
            // Endereco end = new Endereco();
            // end.logradouro = "Rua Mário";
            // end.Numero = 29;
            // end.complemento = "Próximo ao Mercado Extra";
            // end.enderecoComercial =  false;
            
            // PessoaFisica novapf = new PessoaFisica();
            // novapf.endereco = end;
            // novapf.cpf = "12345";
            // novapf.dataNascimento = new DateTime (1992, 11, 29);
            // novapf.nome = "Jessi";

            // Console.WriteLine(novapf.endereco.logradouro);
            // Console.WriteLine(novapf.nome);

  // Solicitando informação ao usuário:
      string? opcao;
      do
      {
        Console.WriteLine(@$"
      ****************************************************************
      *              CADASTRO PESSOAS FÍSICAS E JURÍDICAS            *
      ****************************************************************
      *               Escolha uma das opções abaixo                  *
      *               1 - Cadastrar                                  *
      *               0 - Sair                                       *
      ****************************************************************
      ");
        opcao = Console.ReadLine();
        switch (opcao)
        {
          case "1":
            Endereco endPf = new Endereco();
            Console.WriteLine($"Digite seu Logradouro");                
            endPf.logradouro = Console.ReadLine();
            Console.WriteLine($"Digite o Numero");
            endPf.Numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite o Complemento (Pressione ENTER para vazio)");
            endPf.complemento = Console.ReadLine();
            Console.WriteLine($"Este endereço é comercial? S/N");
            string enderecoComercial = Console.ReadLine().ToUpper();

            if (enderecoComercial == "S" )
            {
              endPf.enderecoComercial = true;
            }
            else{
              endPf.enderecoComercial = false;
            }

            PessoaFisica novapf = new PessoaFisica();
            novapf.endereco = endPf;

            Console.WriteLine($"Digite seu CPF (somente números)");
            novapf.cpf = Console.ReadLine();

            Console.WriteLine($"Digite seu Nome");
            novapf.nome = Console.ReadLine();


            Console.WriteLine($"Digite sua data de nascimento [AAAA,MM,DD");
            novapf.dataNascimento = DateTime.Parse(Console.ReadLine());     

           StreamWriter sw = new StreamWriter($"{novapf.nome}.txt");
           sw.Write($"{novapf.nome},{novapf.cpf}, {novapf.dataNascimento}, {novapf.endereco.logradouro}, {novapf.endereco.Numero} ");
           sw.Close();
            break;
            
          case "0":
            Console.WriteLine(@$"
      ****************************************************************
      *           Obrigado por utilizar o nosso sistema!             *
      ****************************************************************
      ");
            break;

          default:
            Console.WriteLine("Opção inválida, digite uma opção valida");
            break;
        }

      } while (opcao != "0");




        }
    }
}