using FactoryPatternExample.Models;
using FactoryPatternExample.Services.Interfaces;

namespace FactoryPatternExample.Services
{
  public class OuroBank : IMaquininhaCreditoService
  {
    public bool GetMaquininhaServiceType(string tipo)
    {
      return GetType().Name.ToLower() == tipo.ToLower();
    }

    public async Task<PagamentoResponseDTO> RegistraPagamento(long id)
    {
      await Task.Run(() =>
      {
        Console.WriteLine("Pagamento efetuado com OuroBank!");
      });
      return new PagamentoResponseDTO
      {
        Sucesso = true,
        Mensagem = "Pagamento efetuado com OuroBank!"
      };
    }
  }
}
