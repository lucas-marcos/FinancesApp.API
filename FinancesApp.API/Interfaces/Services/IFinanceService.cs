using FinancesApp.API.Models;

namespace FinancesApp.API.Interfaces.Services;

public interface IFinanceService
{
    Finance Add(Finance finance);
    List<Finance> GetAll();
}