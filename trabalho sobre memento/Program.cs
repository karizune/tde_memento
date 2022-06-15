using System;
using trabalho_sobre_memento.Modelos;

namespace trabalho_sobre_memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var Cores = new
            {
                Titulo = ConsoleColor.Yellow,
                Corpo = ConsoleColor.Red,
            };

            ColorWriteLine(Cores.Titulo, "Primeiro caso (Criar nova pessoa e salvar o estado atual dela)");
            Pessoa pessoa = new Pessoa("Gabrielle", 23);
            Memento memento = pessoa.SalvarEstado();

            Console.WriteLine(pessoa.Detalhes());
            Console.WriteLine(memento.Detalhes());
            Console.ReadKey();
            Console.Clear();

            ColorWriteLine(Cores.Titulo, "Segundo caso (altera valores da pessoa e exibe os estados dela e do memento)");
            pessoa.Nome = "Luan";
            pessoa.Idade = 22;
            
            Console.WriteLine(pessoa.Detalhes());
            Console.WriteLine(memento.Detalhes());
            Console.ReadKey();
            Console.Clear();

            ColorWriteLine(Cores.Titulo, "Terceiro caso (restaura valor da pessoa utilizando do memento)");
            pessoa.RestaurarEstado(memento);
            Console.WriteLine(pessoa.Detalhes());
            Console.ReadKey();
            Console.Clear();
        }

        //função que só serve pra criar um texto diferente na tela
        static void ColorWriteLine(ConsoleColor color, string text) {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
