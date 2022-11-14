using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PlataformaDoDavi.src.Models.Funcionario;

namespace PlataformaDoDavi.src.Services
{
    public class FuncionarioService
    {
        public class ProfessorService {
            
               private List<Professor> ListaDeProfessores = new List<Professor>();

        public void IniciarCadastro()
        {
            Professor novoProfessor;

            Console.WriteLine("Digite o nome do professor");
            var nome = Console.ReadLine();

            if (!string.IsNullOrEmpty(nome))
            {
                novoProfessor = new Professor(nome);

                Console.WriteLine("Digite as áreas de atuação separado por vírgula (SÓ APERTE ENTER QUANDO ACABAR)");
                var conhecimentos = Console.ReadLine();

                novoProfessor.Conhecimentos = conhecimentos?.Split(",").ToList() ?? new List<string>();
                ListaDeProfessores.Add(novoProfessor);

                Console.WriteLine("Professor cadastrado com sucesso!");
            }
        }

        public List<Professor> ObterTodos()
        {
            return this.ListaDeProfessores;
        }
    } }
    public class CoordenadorService
    {
        private List<Coordenador> ListaDeCoordenador = new List<Coordenador>();

        public void IniciarCadastro()
        {
            Coordenador novoCoordenador;

            Console.WriteLine("Digite o nome do coordenador");
            var nome = Console.ReadLine();

            if (!string.IsNullOrEmpty(nome))
            {
                novoCoordenador = new Coordenador(nome);

                Console.WriteLine("Digite as áreas de atuação separado por vírgula (SÓ APERTE ENTER QUANDO ACABAR)");
                var conhecimentos = Console.ReadLine();

                novoCoordenador.Conhecimentos = conhecimentos?.Split(",").ToList() ?? new List<string>();
                ListaDeCoordenador.Add(novoCoordenador);

                Console.WriteLine("Coordenador cadastrado com sucesso!");
            }
        }

        public List<Coordenador> ObterTodos()
        {
            return this.ListaDeCoordenador;
        }
    }
}
