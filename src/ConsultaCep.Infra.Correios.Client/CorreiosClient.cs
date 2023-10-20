using ConsultaCep.Infra.Correios.Client.Requests;
using ConsultaCep.Infra.Correios.Client.Responses;

namespace ConsultaCep.Infra.Correios.Client
{
  public class CorreiosClient : ICorreiosClient
  {
    public CorreiosClient() { }

    public async Task<ConsultaCepResponse?> ConsultaCepAsync(ConsultaCepRequest consultaCepRequest)
    {
      using (var wsCorreios = new WSCorreios.AtendeClienteClient())
      {
        try
        {
          var request = new WSCorreios.consultaCEP()
          {
            cep = consultaCepRequest.Cep
          };

          var response = await wsCorreios.consultaCEPAsync(request);

          if (response is null)
            return default;

          return new ConsultaCepResponse()
          {
            Bairro = response.@return.bairro,
            Cep = response.@return.cep,
            Cidade = response.@return.cidade,
            Complemento = response.@return.complemento2,
            Logradouro = response.@return.end,
            Uf = response.@return.uf
          };
        } catch (Exception)
        {
          return default;
        }
      }
    }
  }
}