using System;
using trabalho_sobre_memento.Modelos;

namespace trabalho_sobre_memento
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criar a instância de pessoa
            Pessoa pessoa = new Pessoa("Gabrielle",23);

            //Salvar estado
            pessoa.SalvarEstado();

            //Mostrar situação atual e do memento
            pessoa.MostrarDetalhes();

            //Alterar atributos
            pessoa.Nome = "Luan";
            pessoa.Idade = 23;

            //Mostrar situação atual e do memento
            Console.WriteLine();
            pessoa.MostrarDetalhes();

            //Restaurar estado
            pessoa.RestaurarEstado();

            //Mostrar situação atual e do memento
            Console.WriteLine();
            pessoa.MostrarDetalhes();

            Console.ReadKey();
        }
    }
}
