using ProdutosApp.Domain.Entities;

namespace ProdutosApp.Domain.Interfaces.Repositories;

/// <summary>
/// Interface para repositório de Categoria
/// </summary>
public interface ICategoriaRepository : IBaseRepository<Categoria, Guid?>
{
}