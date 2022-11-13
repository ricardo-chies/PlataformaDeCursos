﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaDeCursos.src.Models
{
    public class Aluno
    {
        public int Ra { get; set; }
        public string Nome { get; set; }
        public bool TemPendenciaFinanceira { get; private set; } = false;

        public Aluno(string nome)
        {
            this.Nome = nome;
        }

        public void AlterarSituacaoFinanceira()
        {
            this.TemPendenciaFinanceira = !TemPendenciaFinanceira;
        }
    }
}