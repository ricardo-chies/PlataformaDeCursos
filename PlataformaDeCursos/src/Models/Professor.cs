using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaDeCursos.src.Models
{
    public class Professor
    {
        public int NumeroCadastro { get; private set; }
        public string Nome { get; set; }
        public string GrauDeFormacao { get; set; } = "";
        public List<string> Conhecimentos { get; set; } = new List<string>();

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