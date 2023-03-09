using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 01

            Console.WriteLine("\t\t---Dados do usuário---\n");
            string nome, endereco, telefone;

            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Endereço: ");
            endereco = Console.ReadLine();

            Console.Write("Telefone: ");
            telefone = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("\t\t---Dados do usuário---\n");
            Console.WriteLine("Nome: " + nome + "\nEndereço: " + endereco + "\nTelefone: " + telefone);
            Console.WriteLine("\n\t\t---Dados do usuário---\n");
            Console.WriteLine("Nome: {0}\nEndereço: {1}\nTelefone: {2}", nome,endereco,telefone);
            Console.WriteLine("\n\t\t---Dados do usuário---\n");
            Console.WriteLine($"Nome: {nome}\nEndereço: {endereco}\nTelefone: {telefone}");

        }
    }
}
