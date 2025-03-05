using FactoryPatternExample.Services;
using FactoryPatternExample.Services.Interfaces;

namespace FactoryPatternExample.Factories
{
  public interface IPagamentoFactory
  {
    IMaquininhaCreditoService? CreateMaquininhaCreditoService(string tipo);
  }
  public class PagamentoFactory : IPagamentoFactory
  {
    private readonly IEnumerable<IMaquininhaCreditoService> _servicosMaquininhas;
    public PagamentoFactory(IEnumerable<IMaquininhaCreditoService> servicosMaquininhas)
    {
      _servicosMaquininhas = servicosMaquininhas;
    }

    public IMaquininhaCreditoService? CreateMaquininhaCreditoService(string tipo)
    {
      switch (tipo.ToLower())
      {
        case "nubank":
          var servicoNubank = _servicosMaquininhas.OfType<NuBank>().FirstOrDefault();
          ValidaServico(servicoNubank);
          return servicoNubank;
        case "ourobank":
          var servicoOuroBank = _servicosMaquininhas.OfType<OuroBank>().FirstOrDefault();
          ValidaServico(servicoOuroBank);
          return servicoOuroBank;
        default:
          throw new ArgumentException("Modelo de pagamento inválido!");
      }
    }

    private static Task ValidaServico(IMaquininhaCreditoService? service)
    {
      if (service == null)
        throw new ArgumentException($"Serviço que implementa IMaquininhaCreditoService não encontrado, verifique a injeção de dependencias do seu projeto!");

      return Task.CompletedTask;
    }
  }
}
