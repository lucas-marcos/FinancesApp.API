using FinancesApp.API.Models.Enums;

namespace FinancesApp.API.Models.TOs;

public class FinanceTO
{
    public int Id { get; set; }
    public decimal Value { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public TransactionType TransactionType { get; set; }
    public DateTime Date { get; set; }
}