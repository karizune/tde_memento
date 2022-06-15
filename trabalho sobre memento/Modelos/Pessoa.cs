using System;
using System.Collections.Generic;
using System.Text;

namespace trabalho_sobre_memento.Modelos
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        //salvar estado, guardar informações de nome e idade. criando uma nova instancia do objeto
        public Memento SalvarEstado()
        {
            Console.WriteLine("\nSalvando estado...");
            return new Memento(new Pessoa(Nome,Idade));
        }

        //restaurar estado, recuperar informações do memento e passar para a classe atual
        public void RestaurarEstado(Memento memento)
        {
            Console.WriteLine("\nRestaurando estado...");
            if (memento != null && memento.pessoa != null)
            {
                Nome = memento.pessoa.Nome;
                Idade = memento.pessoa.Idade;
            }
        }

        public string Detalhes()
        {
            return $"\nPessoa: Nome é {Nome} e idade é {Idade}";
        }
    }
}
