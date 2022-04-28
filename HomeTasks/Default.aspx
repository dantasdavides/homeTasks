<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HomeTasks._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ConteudoGeral" runat="server">
    <br />
    <asp:Button ID="btnNovo" runat="server" Text="Novo" OnClick="btnNovo_Click" />
    <br />
    <br />
    <asp:Panel ID="pnlPesquisa" runat="server">
        <fieldset>
            <legend>Pesquisar</legend>
            <table width="100%">
                <tr>
                    <td>
                        <label>
                            Digite o nome da tarefa que deseja buscar</label>
                    </td>
                    <td width="1%">
                    </td>
                    <td width="24%">
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Width="525px"></asp:TextBox>
                    </td>
                    <td>
                    </td>
                    <td>
                        <asp:Button ID="btnPesquisar" runat="server" Text="Pesquisar" OnClick="btnPesquisar_Click"
                            Width="208px" />
                    </td>
                </tr>
            </table>
        </fieldset>
    </asp:Panel>
    <asp:Panel ID="pnlCadastro" runat="server" Visible="false">
        <fieldset>
            <legend><strong>Dados da Tarefa:</strong></legend>
            <br />
            <table border="0" cellpadding="5" cellspacing="5">
                <tr>
                    <td colspan="2" align="left" class="style3">
                        <strong>Descrição:<br />
                        </strong>
                        <asp:TextBox ID="txDescricao" runat="server" CssClass="input100" 
                            Width="507px" MaxLength="50"></asp:TextBox>
                        &nbsp;
                    </td>                    
                </tr>
            </table>            
            <br />
            <br />
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
            &nbsp;<asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
        </fieldset>
    </asp:Panel>
    <br />
    <br />
    <asp:Panel ID="pnlGrid" runat="server">
        <asp:GridView ID="gv" runat="server" Width="100%" AutoGenerateColumns="False" BorderStyle="None"
            OnRowCommand="gv_RowCommand" BorderWidth="0px">
            <RowStyle CssClass="GridRow" />
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton ID="btnEditar" runat="server" CommandArgument='<%# Eval("Id") %>'
                            CommandName="EDITAR" ImageUrl="~/_images/icone_editar.png" ToolTip="Editar registro"
                            Width="24px"/>
                    </ItemTemplate>
                    <HeaderStyle Width="26px" />
                    <ItemStyle Width="24px" />
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton ID="btnExcluir" runat="server" CommandArgument='<%# Eval("Id") %>'
                            CommandName="EXCLUIR" ImageUrl="~/_images/icone_excluir.gif" ToolTip="Excluir registro"
                            Width="24px" OnClientClick="return confirm('Deseja excluir o registro?')" />
                    </ItemTemplate>
                    <HeaderStyle Width="16px" />
                    <ItemStyle Width="14px" />
                </asp:TemplateField>
                <asp:BoundField DataField="Id" HeaderText="Código" />
                <asp:BoundField DataField="Descricao" HeaderText="Descrição" />                
                <asp:BoundField DataField="DataCriacao" DataFormatString="{0:dd/MM/yyyy hh:mm}"
                    HeaderText="Data de Criação">
                    <HeaderStyle Width="140px" />
                    <ItemStyle Width="140px" />
                </asp:BoundField>
            </Columns>
            <EmptyDataTemplate>
                Não existe registro cadastrado!
            </EmptyDataTemplate>
            <HeaderStyle CssClass="GridHeader" />
        </asp:GridView>
    </asp:Panel>
</asp:Content>
