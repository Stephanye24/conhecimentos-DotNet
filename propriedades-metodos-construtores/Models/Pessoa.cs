using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace propriedades_metodos_construtores.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        private string _nome;
        private int _idade;
        private string _nomeCompleto;
        public string Nome 
        { 
            get => _nome.ToUpper();

            set 
            {
                if (value == "")
                {
                    throw new ArgumentException("Nome não pode ser vazio");
                }

                _nome = value;
            } 
        }
        public int Idade 
        { 
            get => _idade;
            set 
            {
                if(value < 0)
                {
                    throw new ArgumentException("Idade não pode ser menor que 0.");
                }
                _idade = value;

            } 
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto 
        { 
            get => $"{Nome} {Sobrenome}";

            set => _nomeCompleto = value; 
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}