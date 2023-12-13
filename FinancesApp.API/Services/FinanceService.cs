using FinancesApp.API.Interfaces.Repositories;
using FinancesApp.API.Interfaces.Services;
using FinancesApp.API.Models;

namespace FinancesApp.API.Services;

public class FinanceService(IFinanceRepository _financeRepository) : IFinanceService
{
    public Finance Add(Finance finance)
    {
        _financeRepository.AdicionarAtualizarSalvar(finance);

        return finance;
    }

    public List<Finance> GetAll() => _financeRepository.BuscarTodos().ToList();

    public List<Finance> GetAllByMonthNumber(int monthNumber)
    {
        return _financeRepository.BuscarTodos()
            .Where(a => a.Date.Month == monthNumber)
            .ToList();
    } 
}