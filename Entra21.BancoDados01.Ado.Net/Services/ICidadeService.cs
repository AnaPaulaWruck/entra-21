using Entra21.BancoDados01.Ado.Net.Models;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    internal interface ICidadeService
    {
        List<Cidade> ObterTodos();
        Cidade ObterPorId(int id);
        void Cadastrar(Cidade cidade);
        void Editar(Cidade cidade);
        void Apagar(int id);
    }
}