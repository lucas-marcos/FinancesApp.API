using System.ComponentModel.DataAnnotations;
using FinancesApp.API.Models.Enums;

namespace FinancesApp.API.Models;

public class Finance
{
    [Key]
    public int Id { get; private set; }
    public int Value { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public TransactionType TransactionType { get; private set; }
    public DateTime Date { get; private set; }
}