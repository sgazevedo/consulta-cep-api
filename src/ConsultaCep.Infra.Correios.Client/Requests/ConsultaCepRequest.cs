namespace ConsultaCep.Infra.Correios.Client.Requests
{
  public class ConsultaCepRequest
  {
    public ConsultaCepRequest(string cep) 
    {
      Cep = cep;
    }

    public string Cep { get; set; }
  }
}
