using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXEMPLOEXPLORANDO.models
{
    public class Pessoa
    {
        public Pessoa() { }

        public Pessoa(string nome, string sobrenome)
        {
            // referenciando a prorpiedade
            Nome = nome;
            Sobrenome = sobrenome;
        }

        // desconstrutor
        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }

        private string _nome;
        private int _idade;

        public string Nome
        {
            get
            {
                return _nome.ToUpper();
            }

            set
            {
                // validaçao
                if (value == "")
                {
                    throw new ArgumentException("O nome nao pode ser vazio");
                }

                _nome = value;
            }
        }

        public string Sobrenome { get; set; }
        // propriedade somente de leitura ou seja nao precisa ser declarada
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade
        {
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade nao pode ser menor que zero");
                }

                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}