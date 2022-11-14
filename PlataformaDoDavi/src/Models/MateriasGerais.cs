using PlataformaCurso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PlataformaDoDavi.src.Models.Funcionario;

namespace PlataformaDoDavi.src.Models
{
    public class MateriasGerais
    {
        public class Materia
        {
            private Funcionario.Professor? professorResponsavel;

            public string Nome { get; set; }
            public List<Aluno> Alunos { get; set; } = new List<Aluno>();
            public Professor? ProfessorResponsavel { get; set; }

            public Materia(string nome, Professor? professorResponsavel)
            {
                this.Nome = nome;

                if (professorResponsavel?.ValidaSeSabeConhecimento(nome) ?? false)
                {
                    this.ProfessorResponsavel = professorResponsavel;
                }
                else
                {
                    Console.WriteLine("Professor não está apto para ministrar esta matéria");
                    this.ProfessorResponsavel = null;
                }
            }

            public Materia(Professor? professorResponsavel, string nome)
            {
                Nome = nome;
                this.professorResponsavel = professorResponsavel;
            }

            public bool MatricularAluno(Aluno aluno)
            {
                if (!aluno.TemPendenciaFinanceira && this.Alunos.Count < 50)
                {
                    this.Alunos.Add(aluno);
                    return true;
                }

                return false;
            }
        }
        public class Extensao
        {
            private Funcionario.Professor? professorResponsavel;

            public string Nome { get; set; }
            public List<Aluno> Alunos { get; set; } = new List<Aluno>();
            public Professor? ProfessorResponsavel { get; set; }

            public Extensao(string nome, Professor? professorResponsavel)
            {
                this.Nome = nome;

                if (professorResponsavel?.ValidaSeSabeConhecimento(nome) ?? false)
                {
                    this.ProfessorResponsavel = professorResponsavel;
                }
                else
                {
                    Console.WriteLine("Professor não é apto para ministrar esta extensão");
                    this.ProfessorResponsavel = null;
                }
            }

            public Extensao(Professor? professorResponsavel, string nome)
            {
                Nome = nome;
                this.professorResponsavel = professorResponsavel;
            }

            public bool MatricularAluno(Aluno aluno)
            {
                if (this.Alunos.Count < 100)
                {
                    this.Alunos.Add(aluno);
                    return true;
                }

                return false;
            }
        }
    }
}
