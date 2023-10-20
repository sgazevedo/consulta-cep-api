using ConsultaCep.Infra.Correios.Client.Requests;
using ConsultaCep.Infra.Correios.Client.Responses;

namespace ConsultaCep.Infra.Correios.Client
{
  public interface ICorreiosClient
  {
    Task<ConsultaCepResponse?> ConsultaCepAsync(ConsultaCepRequest consultaCepRequest);
  }
}
