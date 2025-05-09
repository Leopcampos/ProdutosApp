using Microsoft.EntityFrameworkCore;
using ProdutosApp.Infra.Data.Mappings;

namespace ProdutosApp.Infra.Data.Contexts;

/// <summary>
/// Classe de contexto para configuração do Entity Framework
/// </summary>
public class DataContext : DbContext
{
    /// <summary>
    /// Construtor para injeção de dependência, ou seja, para que esta classe 
    /// possa receber as configurações de conexão de banco de dados
    /// </summary>
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    /// <summary> 
    /// Método para adicionar as classes de mapeamento feitas no projeto 
    /// </summary> 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProdutoMap());
        modelBuilder.ApplyConfiguration(new CategoriaMap());
    }
}