using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks.Dominio.Entidades
{
    public class Tarefas: IEntidade
    {
        public long Id { get; private set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        

        public Tarefas() { }
        public Tarefas(long id) { Id = id; }

    }
}
