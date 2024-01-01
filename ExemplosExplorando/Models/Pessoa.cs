using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosExplorando.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }


        public Pessoa(string nome, string sobreNome)
        {
            Nome = nome;
            SobreNome = sobreNome;
            

        }

        private string _nome;
        private int _idade;


        public string Nome 
        { 
            get => _nome.ToUpper();


            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O nome nao pode ser vazio!");
                }

                _nome = value;

            }

        }

        public string SobreNome { get; set; }
        public string NomeCompleto => $"{Nome} {SobreNome}";

        public int Idade 
        { 
            get => _idade;

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("A idade nao pode ser menor do q zero!");
                }
                _idade = value;

            }

        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome:{NomeCompleto}, Idade: {Idade}");
        }
    }
}