using ConsultaCep.Domain.Dtos;
using ConsultaCep.Domain.Interfaces;
using ConsultaCep.Infra.Correios.Client;
using ConsultaCep.Infra.Correios.Client.Requests;

namespace ConsultaCep.Services
{
  public class ConsultaCepService : IConsultaCepService
  {
    public readonly ICorreiosClient _correiosClient;

    public ConsultaCepService(ICorreiosClient correiosClient)
    {
      _correiosClient = correiosClient;
    }

    public async Task<ConsultaCepDto?> GetConsultaCepAsync(string cep)
    {
      var consultaCepRequest = new ConsultaCepRequest(cep);

      var consultaCepResponse = await _correiosClient.ConsultaCepAsync(consultaCepRequest);

      if (consultaCepResponse is null)
        return default;

      return new ConsultaCepDto()
      {
        Bairro = consultaCepResponse.Bairro,
        Cep = consultaCepResponse.Cep,
        Cidade = consultaCepResponse.Cidade,
        Logradouro = consultaCepResponse.Logradouro,
        Complemento = consultaCepResponse.Complemento,
        Uf = consultaCepResponse.Uf
      };
    }
  }
}