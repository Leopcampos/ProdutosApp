using ProdutosApp.Domain.Entities;

namespace ProdutosApp.Domain.Interfaces.Repositories;

/// <summary>
/// Interface para repositório de Produto
/// </summary>
public interface IProdutoRepository : IBaseRepository<Produto, Guid>
{
}