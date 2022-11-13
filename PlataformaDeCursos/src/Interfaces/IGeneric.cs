using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaDeCursos.src.Interfaces
{
    public interface IGeneric<T> where T : class
    {
        public List<T> ObterTodos();
    }
}
