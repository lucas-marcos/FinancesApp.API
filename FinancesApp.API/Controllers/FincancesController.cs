using AutoMapper;
using FinancesApp.API.Interfaces.Services;
using FinancesApp.API.Models;
using FinancesApp.API.Models.DTOs;
using FinancesApp.API.Models.Enums;
using FinancesApp.API.Models.TOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinancesApp.API.Controllers;

[ApiController, Route("api/finances")]
public class FincancesController(IFinanceService _financeService, IMapper _mapper) : ControllerBase
{
    [HttpPost, AllowAnonymous]
    public ActionResult<FinanceTO> AddFinance(AddFinanceDTO addFinanceDto)
    {
        return Ok(_financeService.Add(_mapper.Map<Finance>(addFinanceDto)));
    }

    [HttpGet("month/{monthNumber}"), AllowAnonymous]
    public ActionResult<FinanceTO> GetAllByMonthNumber(string monthNumber)
    {
        var result = _financeService.GetAllByMonthNumber(int.Parse(monthNumber));

        return Ok(_mapper.Map<List<FinanceTO>>(result));
    }
    
    [HttpGet("month/{monthNumber}/transactionType/{transactionType}"), AllowAnonymous]
    public ActionResult<FinanceTO> GetAllByMonthNumberAndTransactionType(string monthNumber, TransactionType transactionType)
    {
        var result = _financeService.GetAllByMonthNumberAndTransactionType(int.Parse(monthNumber), transactionType);

        return Ok(_mapper.Map<List<FinanceTO>>(result));
    }
}