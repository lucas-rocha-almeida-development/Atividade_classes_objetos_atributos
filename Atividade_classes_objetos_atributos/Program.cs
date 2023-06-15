using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_classes_objetos_atributos {
    internal class Program {
        static void Main(string[] args) {
            Pessoas pessoa1, pessoa2;
            pessoa1 = new Pessoas();
            pessoa2 = new Pessoas();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.WriteLine("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            pessoa1.IdadePessoa = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.WriteLine("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            pessoa2.IdadePessoa = int.Parse(Console.ReadLine());

            if (pessoa1.IdadePessoa > pessoa2.IdadePessoa) {

                Console.WriteLine("Pessoa mais velha é: " + pessoa1.Nome);
            }
            else {
                Console.WriteLine("Pessoa mais velha é: " + pessoa2.Nome);
            }
            Console.ReadKey();

            
            
        }
    }
}
