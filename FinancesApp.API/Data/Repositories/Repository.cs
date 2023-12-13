using FinancesApp.API.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FinancesApp.API.Data.Repositories;

public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    protected ApplicationDbContext Db;
    protected readonly DbSet<TEntity> DbSet;

    protected Repository(ApplicationDbContext context)
    {
        Db = context;
        DbSet = Db.Set<TEntity>();
    }

    public void Adicionar(TEntity obj)
    {
        if (obj == null)
            return;

        DbSet.Add(obj);
    }

    public void Remover(int id)
    {
        DbSet.Remove(DbSet.Find(id));
    }

    public IQueryable<TEntity> BuscarTodos()
    {
        return DbSet;
    }

    public int Salvar()
    {
        return Db.SaveChanges();
    }

    public int AdicionarAtualizarSalvar(TEntity obj)
    {
        if (obj is null) return 0;

        Adicionar(obj);

        return Salvar();
    }
}