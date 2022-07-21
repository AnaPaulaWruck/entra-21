using Entra21.BancoDados01.Ado.Net.Models;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    internal interface IUnidadeFederativaService
    {
        void Cadastrar(UnidadeFederativa unidadeFederativa);
        void Editar (UnidadeFederativa unidadeFederativa);
        void Apagar(int id);
        List<UnidadeFederativa> ObterTodos();
        UnidadeFederativa ObterPorId(int id);
    }
}