using ConsultaCep.Domain.Dtos;

namespace ConsultaCep.Domain.Interfaces
{
  public interface IConsultaCepService
  {
    Task<ConsultaCepDto?> GetConsultaCepAsync(string cep);
  }
}
