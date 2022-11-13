using PlataformaDeCursos.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaDeCursos.src.Services
{
    public class GenericService<T> : IGeneric<T> where T : class
    {
        private List<T> ListaDeT = new List<T>();

        public List<T> ObterTodos()
        {
            return this.ListaDeT;
        }
    }
}
