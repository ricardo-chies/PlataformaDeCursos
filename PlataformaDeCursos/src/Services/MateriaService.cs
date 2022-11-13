﻿using PlataformaDeCursos.src.Interfaces;
using PlataformaDeCursos.src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaDeCursos.src.Services
{
    public class MateriaService : GenericService<Materia>, IMateria
    {
        private List<Materia> ListaDeMaterias = new List<Materia>();

        public void CriarMateria(List<Professor> professoresPossiveis)
        {
            Materia novaMateria;

            Console.WriteLine("Digite o nome da matéria");
            var nome = Console.ReadLine();

            if (!string.IsNullOrEmpty(nome))
            {
                var professorResponsavel = SelecionaProfessorResponsavel(professoresPossiveis);

                novaMateria = new Materia(nome, professorResponsavel);
                Console.WriteLine("Materia cadastrada com sucesso!");
            }
        }

        private Professor? SelecionaProfessorResponsavel(List<Professor> professores)
        {
            Console.WriteLine("Escolha o professor responsável (SELECIONE A OPÇÂO)");

            for (int i = 0; i < professores.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {professores[i].Nome}");
            }

            var textoDigitado = Console.ReadLine();

            if (!string.IsNullOrEmpty(textoDigitado))
            {
                var indice = int.Parse(textoDigitado) - 1;
                return professores[indice];
            }

            return null;
        }

    }
}