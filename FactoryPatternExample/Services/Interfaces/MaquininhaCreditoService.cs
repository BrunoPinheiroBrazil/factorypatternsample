using FactoryPatternExample.Models;

namespace FactoryPatternExample.Services.Interfaces
{
  public interface IMaquininhaCreditoService
  {
    Task<PagamentoResponseDTO> RegistraPagamento(long id);
  }
}
