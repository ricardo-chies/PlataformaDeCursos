using PlataformaDeCursos.src.Interfaces;
using PlataformaDeCursos.src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaDeCursos.src.Services
{
    public class ProfessorService : GenericService<Professor>, IProfessor
    {
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

    }
}