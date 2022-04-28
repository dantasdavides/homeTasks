using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeTasks.Dominio.Entidades;
using HomeTasks.Dominio.Repositorio;

namespace HomeTasks.Dominio.Servicos
{
    public class TarefasServico
    {
        private readonly ITarefasRepositorio _repositorio;

        public TarefasServico(ITarefasRepositorio repositorio)
        {
            _repositorio = repositorio;

        }

        public ITarefasRepositorio Repositorio
        {
            get { return _repositorio; }
        }
    }
}
