using FinancesApp.API.Models.Enums;

namespace FinancesApp.API.Models.DTOs;

public class AddFinanceDTO
{
    public decimal Value { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public TransactionType TransactionType { get; set; }
}