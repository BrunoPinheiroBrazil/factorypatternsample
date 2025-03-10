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
      var service = _servicosMaquininhas.FirstOrDefault(s => s.GetMaquininhaServiceType(tipo));
      ValidaServico(service);
      return service;
    }

    private static Task ValidaServico(IMaquininhaCreditoService? service)
    {
      if (service == null)
        throw new ArgumentException($"Serviço que implementa IMaquininhaCreditoService não encontrado, verifique a injeção de dependencias do seu projeto!");

      return Task.CompletedTask;
    }
  }
}
