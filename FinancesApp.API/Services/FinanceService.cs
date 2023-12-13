using FinancesApp.API.Interfaces.Repositories;
using FinancesApp.API.Interfaces.Services;
using FinancesApp.API.Models;
using FinancesApp.API.Models.Enums;

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
    
    public List<Finance> GetAllByMonthNumberAndTransactionType(int monthNumber, TransactionType transactionType)
    {
        return _financeRepository.BuscarTodos()
            .Where(a => a.Date.Month == monthNumber && a.TransactionType == transactionType)
            .ToList();
    }

    public void DeleteById(int id)
    {
        _financeRepository.Remover(id);
        _financeRepository.Salvar();
    }
}