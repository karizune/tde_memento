using System;
using System.Collections.Generic;
using System.Text;

namespace trabalho_sobre_memento.Modelos
{
    public class Memento
    {
        public Pessoa pessoa { get; private set; }

        public Memento(Pessoa pessoa)
        {
            this.pessoa = pessoa;
        }

        public string Detalhes()
        {
            return $"Memento: Nome é {pessoa.Nome} e idade é {pessoa.Idade}";
        }
    }
}
