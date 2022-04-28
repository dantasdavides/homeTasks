using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeTasks.Dominio.Entidades;
using HomeTasks.Dominio.Repositorio;
using NHibernate;


namespace HomeTasks.Repositorio.Repositorios
{
    public class TarefasRepositorio : BaseRepositorio<Tarefas>, ITarefasRepositorio
    {
        public IList<Tarefas> PesquisarPorNome(string nome)
        {
            var query = " select * from tarefas where Descricao like '%" + nome + "%'";
            ISQLQuery iquery = Session.CreateSQLQuery(query);
            iquery.AddEntity("Tarefas", typeof(Tarefas));
            var result = iquery.List<Tarefas>();
            return result;
        }
    }
}
