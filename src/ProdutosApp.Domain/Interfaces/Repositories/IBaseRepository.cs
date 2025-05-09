namespace ProdutosApp.Domain.Interfaces.Repositories;

/// <summary>
/// Interface para repositório genérico
/// </summary>
public interface IBaseRepository<TEntity, TKey>  
    where TEntity : class
{
    Task AddAsyc(TEntity obj);
    Task UpdateAsync(TEntity obj);
    Task DeleteAsync(TEntity obj);

    Task<List<TEntity>> GetAllAsync();
    Task<TEntity?> GetByIdAsync(TKey id);
}