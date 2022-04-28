using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Linq;
using HomeTasks.Dominio.Repositorio;
using HomeTasks.Dominio.Entidades;
using HomeTasks.Repositorio.Helpers;

namespace HomeTasks.Repositorio.Repositorios
{
    public class BaseRepositorio<T> : IRepositorio<T> where T : IEntidade
    {
        public ISession Session
        {
            get { return SessionManager.Instance.Session; }
        }

        public T Obter(long id)
        {
            //using (ISession session = NHibernateHelper.OpenSession())
            return Session.Get<T>(id);
        }

        public IList<T> ObterTodos()
        {
            //using (ISession session = NHibernateHelper.OpenSession())
            return (from t in Session.Linq<T>()
                    select t).ToList();
        }

        public T Salvar(T entity)
        {
            //using (ISession session = NHibernateHelper.OpenSession())
            {
                //using (ITransaction transaction = Session.BeginTransaction())
                {
                    Session.Save(entity);
                    Session.Flush();
                    //transaction.Commit();
                }
            }
            return entity;
        }

        public T Alterar(T entity)
        {
            Session.Clear();//adicionei esse metodo para limpar a sessao antes de atualizar --> david dantas
            Session.Update(entity);
            Session.Flush();
            return entity;
        }

        public void Excluir(T entity)
        {
            //using (ISession session = NHibernateHelper.OpenSession())
            {
                //using (ITransaction transaction = Session.BeginTransaction())
                {
                    Session.Delete(entity);
                    Session.Flush();
                    //transaction.Commit();
                }
            }
        }
    }

}
