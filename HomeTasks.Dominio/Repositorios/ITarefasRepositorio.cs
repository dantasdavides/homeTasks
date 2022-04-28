using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeTasks.Dominio.Entidades;

namespace HomeTasks.Dominio.Repositorio
{
    public interface ITarefasRepositorio : IRepositorio<Tarefas>
    {
        IList<Tarefas> PesquisarPorNome(string nome);
    }
}
