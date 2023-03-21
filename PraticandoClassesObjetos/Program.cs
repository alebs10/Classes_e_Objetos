using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoClassesObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Livro livro1 = new Livro()
            {
                titulo = "O Hobbit",
                autor = "J. R. R. Tolkien",
                numeroPaginas = 331,
                editora = "Harper Collins"
            };
            Funcionario funcionario = new Funcionario()
            {
                nome = "Zezinho da Silva",
                idade = 54,
                cargo = "Entregador",
                salario = 2091.50
            };

            Console.WriteLine("Livro 1: "+ livro1.titulo);
            Console.WriteLine("Livro 1: "+ livro1.autor);
            Console.WriteLine("Livro 1: " + livro1.numeroPaginas);
            Console.WriteLine("Livro 1: " + livro1.editora);

            Console.WriteLine("\nFuncionário 1: " + funcionario.nome);
            Console.WriteLine("Funcionário 1: " + funcionario.idade);
            Console.WriteLine("Funcionário 1: " + funcionario.cargo);
            Console.WriteLine("Funcionário 1: " + funcionario.salario);
            Console.ReadKey();
        }
    }
}
