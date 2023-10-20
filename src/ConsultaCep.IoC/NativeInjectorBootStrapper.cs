using ConsultaCep.Domain.Interfaces;
using ConsultaCep.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ConsultaCep.IoC
{
  public static class NativeInjectorBootStrapper
  {
    public static void RegisterDependencies(this IServiceCollection services)
    {
      
      services.AddScoped<IConsultaCepService, ConsultaCepService>();
    }
  }
}