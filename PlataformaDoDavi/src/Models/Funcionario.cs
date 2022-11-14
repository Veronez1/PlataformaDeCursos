using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaDoDavi.src.Models
{
    public class Funcionario
    {
        public int NumeroCadastro { get; private set; }
        public string Nome { get; set; }
        public string GrauDeFormacao { get; set; } = "";
        public List<string> Conhecimentos { get; set; } = new List<string>();

        //Coordenador
        public class Coordenador : Funcionario
        {
            public List<string> AreasDeAtuacao { get; set; } = new List<string>();

            public Coordenador(string nome)
            {
                this.Nome = nome;
            }
            public bool ValidaSeSabeConhecimento(string conhecimento)
            {
                return Conhecimentos.Contains(conhecimento)
                    || AreasDeAtuacao.Contains(conhecimento);
            }
        }
        //Professor
        public class Professor : Funcionario
        {
            public Professor(string nome)
            {
                this.Nome = nome;
            }
            public bool ValidaSeSabeConhecimento(string conhecimento)
            {
                return Conhecimentos.Contains(conhecimento);
            }
        }
    }
}

