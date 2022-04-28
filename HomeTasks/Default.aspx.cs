using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HomeTasks.Dominio.Entidades;
using HomeTasks.Dominio.Servicos;
using HomeTasks.Repositorio.Repositorios;

namespace HomeTasks
{
    public partial class _Default : Page
    {

        private TarefasServico _tarefasservico;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateGridView(); ;
            }
        }

        void NovoRegistro()
        {
            btnNovo.Visible = false;
            btnPesquisar.Visible = false;
            pnlGrid.Visible = false;
            pnlCadastro.Visible = true;
            pnlPesquisa.Visible = false;
        }

        void LimpaCampos()
        {
            txDescricao.Text = "";           
        }

        void Cancelar()
        {
            btnNovo.Visible = true;
            btnPesquisar.Visible = true;
            pnlGrid.Visible = true;
            pnlCadastro.Visible = false;
            pnlPesquisa.Visible = true;
        }

        void PopulateGridView()
        {
            _tarefasservico = new TarefasServico(new TarefasRepositorio());
            IList<Tarefas> dados = _tarefasservico.Repositorio.ObterTodos();
            gv.DataSource = dados;
            gv.DataBind();
        }
        protected void btnNovo_Click(object sender, EventArgs e)
        {
            NovoRegistro();
            Session["idRow"] = null;
            Session["dtCadastro"] = null;
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Equals(""))
            {

                PopulateGridView();
            }
            else
            {

                _tarefasservico = new TarefasServico(new TarefasRepositorio());
                IList<Tarefas> dados = _tarefasservico.Repositorio.PesquisarPorNome(TextBox1.Text);
                gv.DataSource = dados;
                gv.DataBind();
            }

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["idRow"] != null)
                {
                    _tarefasservico = new TarefasServico(new TarefasRepositorio());
                    Tarefas entTarefa = _tarefasservico.Repositorio.Obter((long)Session["idRow"]);

                    entTarefa.Descricao = txDescricao.Text;

                    _tarefasservico.Repositorio.Alterar(entTarefa);
                    Cancelar();
                    LimpaCampos();
                    PopulateGridView();
                }
                else
                {
                    _tarefasservico = new TarefasServico(new TarefasRepositorio());
                    Tarefas entTarefa = new Tarefas();

                    entTarefa.Descricao = txDescricao.Text;
                    entTarefa.DataCriacao = DateTime.Now;

                    _tarefasservico.Repositorio.Salvar(entTarefa);
                    Cancelar();
                    LimpaCampos();
                    PopulateGridView();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
            LimpaCampos();
        }

        protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowId = int.Parse(e.CommandArgument.ToString());

            _tarefasservico = new TarefasServico(new TarefasRepositorio());

            switch (e.CommandName.ToString().ToUpper())
            {
                case "EDITAR":
                    var tarefa = _tarefasservico.Repositorio.Obter(rowId);

                    txDescricao.Text = tarefa.Descricao;
                    
                    NovoRegistro();
                    Session["idRow"] = tarefa.Id;
                    Session["dtCadastro"] = tarefa.DataCriacao;

                    break;
                case "EXCLUIR":
                    var extarefa = _tarefasservico.Repositorio.Obter(rowId);

                    _tarefasservico.Repositorio.Excluir(extarefa);

                    PopulateGridView();
                    break;
            }
        }
    }
}
