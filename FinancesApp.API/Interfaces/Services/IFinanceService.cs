using FinancesApp.API.Models;
using FinancesApp.API.Models.Enums;

namespace FinancesApp.API.Interfaces.Services;

public interface IFinanceService
{
    Finance Add(Finance finance);
    List<Finance> GetAll();
    List<Finance> GetAllByMonthNumber(int monthNumber);
    List<Finance> GetAllByMonthNumberAndTransactionType(int monthNumber, TransactionType transactionType);
}