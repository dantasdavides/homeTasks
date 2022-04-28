using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeTasks.Dominio.Entidades;

namespace HomeTasks.Dominio.Repositorio
{
    public interface IRepositorio<T>
       where T : IEntidade
    {
        /// <summary>
        /// Retorna um objeto
        /// </summary>
        /// <param name="id">Identificador da entidade</param>
        /// <returns>Retorna uma entidade</returns>
        T Obter(long id);
        /// <summary>
        /// Retorna todos os objetos do tipo entidade
        /// </summary>
        /// <returns></returns>
        IList<T> ObterTodos();
        /// <summary>
        /// Persiste uma entidade no repositorio de informações
        /// </summary>
        /// <param name="entidade">Entidade a ser salva no repositorio</param>
        /// <returns>Retornar a entidade persistida</returns>
        T Salvar(T entidade);
        /// <summary>
        /// Elimina a entidade persistida do repositorio
        /// </summary>
        /// <param name="entidade"></param>
        void Excluir(T entidade);


        T Alterar(T entidade);


    }

}
