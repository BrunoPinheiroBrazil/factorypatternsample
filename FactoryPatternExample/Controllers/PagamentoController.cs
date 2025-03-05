using FactoryPatternExample.Factories;
using FactoryPatternExample.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FactoryPatternExample.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class PagamentoController : ControllerBase
  {
    private readonly IPagamentoFactory _pagamentoFactory;

    public PagamentoController(IPagamentoFactory pagamentoFactory)
    {
      _pagamentoFactory = pagamentoFactory;
    }

    [HttpGet(Name = "GetPagamento")]
    public async Task<IActionResult> Get(string tipo)
    {
      try
      {
        var maquininhaCreditoService = _pagamentoFactory.CreateMaquininhaCreditoService(tipo);
        var response = await maquininhaCreditoService.RegistraPagamento(1);
        return Ok(response);
      }
      catch (Exception ex)
      {
        return BadRequest(ex.Message);
      }
    }
  }
}
