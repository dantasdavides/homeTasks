using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks.Dominio.Entidades
{
    public interface IEntidade
    {
        /// <summary>
        /// Identificador das entidades
        /// </summary>
        long Id { get; }
        /// <summary>
        /// Data de cadastro de todas as entidades
        /// </summary>
        DateTime DataCriacao { get; set; }
        /// <summary>
        
    }
}
