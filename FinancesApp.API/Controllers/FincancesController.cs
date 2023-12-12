using AutoMapper;
using FinancesApp.API.Interfaces.Services;
using FinancesApp.API.Models;
using FinancesApp.API.Models.DTOs;
using FinancesApp.API.Models.TOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinancesApp.API.Controllers;

[ApiController, Route("api/finances")]
public class FincancesController(IFinanceService _financeService, IMapper _mapper) : ControllerBase
{
    [HttpPost, AllowAnonymous]
    public ActionResult<FinanceTO> AddFinance([FromBody] AddFinanceDTO addFinanceDto)
    {
        return Ok(_financeService.Add(_mapper.Map<Finance>(addFinanceDto)));
    }

    [HttpGet, AllowAnonymous]
    public ActionResult<FinanceTO> GetAll()
    {
        var result = _financeService.GetAll();

        return Ok(_mapper.Map<List<FinanceTO>>(result));
    }
}