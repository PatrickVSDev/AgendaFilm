using AgendaFilm.Model;
using AgendaFilm.Model.Repositories;
using System.Collections.Generic;

namespace AgendaFilm.Controller
{
    public class OrdemServicoController
    {
        private readonly OrdemServicoRepositorio repositorio = new OrdemServicoRepositorio();

        public bool Cadastrar(OrdemServico ordem, List<OrdemProduto> produtos)
        {
            return repositorio.Add(ordem, produtos);
        }

        public List<OrdemServicoDTO> ListarTodos()
        {
            return repositorio.GetAll();
        }

        public OrdemServico BuscarPorId(int id)
        {
            return repositorio.GetById(id);
        }

        public List<OrdemProduto> BuscarProdutosPorOrdem(int ordemId)
        {
            return repositorio.GetProdutosByOrdemId(ordemId);
        }

        public bool Excluir(int id)
        {
            return repositorio.Delete(id);
        }
    }
}
