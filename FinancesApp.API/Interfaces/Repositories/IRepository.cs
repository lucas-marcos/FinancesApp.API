namespace FinancesApp.API.Interfaces.Repositories;

public interface IRepository<TEntity>
{
    public IQueryable<TEntity> BuscarTodos();
    public int Salvar();
    void Remover(int id);
    public int AdicionarAtualizarSalvar(TEntity obj);
}