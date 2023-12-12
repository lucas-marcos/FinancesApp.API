using FinancesApp.API.Interfaces.Repositories;
using FinancesApp.API.Models;

namespace FinancesApp.API.Data.Repositories;

public class FinanceRepository : Repository<Finance>, IFinanceRepository
{
    public FinanceRepository(ApplicationDbContext context) : base(context)
    {
    }
}