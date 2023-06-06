using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAula05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string sobrenome;
            string endereço;
            string bairro;
            string cidade;
            string estado;
            int viagem;
            int planejamentoviagem;
            string desconto;
            string pergunta;

            Console.WriteLine("Bem-vindo ao sistema de cadastro da Conradito Airline");
            Console.WriteLine("Informe seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Agora seu sobrenome");
            sobrenome = Console.ReadLine();
            Console.WriteLine($"Olá,Sr(a).{nome} {sobrenome},vamos continuar seu cadastro...");
            Console.WriteLine("Agora informe os dados a seguir:");
            Console.WriteLine("-Endereço:");
            endereço = Console.ReadLine();
            Console.WriteLine("-Bairro:");
            bairro = Console.ReadLine();
            Console.WriteLine("-Cidade:");
            cidade = Console.ReadLine();
            Console.WriteLine("-Estado:");
            estado = Console.ReadLine();
            Console.WriteLine($"O Sr(a).{sobrenome} mora na cidade de {cidade}-{estado},no endereço {endereço}, localizado no baiiro {bairro}.");
            Console.WriteLine("\n \n");
            Console.WriteLine("Quantas viagens o Sr(a). fez no ano anterior?");
            viagem =Int32.Parse(Console.ReadLine());
            Console.WriteLine("Quantas viagens o Sr(a). planeja fazer esse ano?");
            planejamentoviagem =Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Viagens realizadas anteriormente foi de {viagem} viagens");
            Console.WriteLine($"Faltam no total {10-viagem} para completar 10 viagens");
            Console.WriteLine($"O Sr(a). tem uma media de {viagem / 2} por ano");
            Console.WriteLine($"Suas viagens são realizadas com o intervalo de {24/viagem} meses entre cada viagem ");
            Console.WriteLine("\n \n \n");
            Console.WriteLine($"Obrigado {nome} {sobrenome},o seu cadastro foi realizado com sucesso!");
            Console.WriteLine("\n \n \n \n");
            Console.WriteLine("Digite seu cupom de desconto:");
            desconto = Console.ReadLine();
            if(desconto == "Conradito10")
            {
                Console.WriteLine("Parabéns,você recebeu 10% de desconto na sua proxima viagem");
            }
            else
            {
                Console.WriteLine("Esse cupom não existe");
            }
            Console.WriteLine(" \nVocê gostaria de receber promoções no seu e-mail?");
            pergunta = Console.ReadLine();
            if (pergunta == "sim")
            {
                Console.WriteLine($"Obrigado {nome} por se registrar você receberá novos e-mails em breve.");
            }
            else
            {
                Console.WriteLine("Ok, você não receberá e-mails de promoções.");
            }
            Console.WriteLine("Obrigado e volte sempre");       
           
            
               
            

            
              
           




            Console.ReadKey();
        }
    }
}
