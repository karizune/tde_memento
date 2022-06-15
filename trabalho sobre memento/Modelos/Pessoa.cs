using System;
using System.Collections.Generic;
using System.Text;

namespace trabalho_sobre_memento.Modelos
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa Memento { get; private set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        //salvar estado, guardar informações de nome e idade. criando uma nova instancia do objeto
        public void SalvarEstado()
        {
            Memento = new Pessoa(Nome, Idade);
        }

        //restaurar estado, recuperar informações do memento e passar para a classe atual
        public void RestaurarEstado()
        {
            if (Memento != null)
            {
                Nome = Memento.Nome;
                Idade = Memento.Idade;
            }
        }

        public void MostrarDetalhes()
        {
            Console.WriteLine($"Pessoa: Nome é {Nome} e idade é {Idade}");

            if (Memento != null)
            {
                Console.WriteLine($"Memento: Nome é {Memento.Nome} e idade é {Memento.Idade}");
            }
        }
    }
}
