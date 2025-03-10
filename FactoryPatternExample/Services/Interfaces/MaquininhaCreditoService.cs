using FactoryPatternExample.Models;

namespace FactoryPatternExample.Services.Interfaces
{
  public interface IMaquininhaCreditoService
  {
    bool GetMaquininhaServiceType(string tipo);
    Task<PagamentoResponseDTO> RegistraPagamento(long id);
  }
}
