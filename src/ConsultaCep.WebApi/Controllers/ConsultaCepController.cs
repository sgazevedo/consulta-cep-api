using ConsultaCep.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ConsultaCep.WebApi.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ConsultaCepController : ControllerBase
  {
    private readonly IConsultaCepService _consultaCepService;

    public ConsultaCepController(IConsultaCepService consultaCepService)
    {
      _consultaCepService = consultaCepService;
    }

    [HttpGet("/{cep}")]
    public async Task<IActionResult> Get(string cep) =>
      Ok(await _consultaCepService.GetConsultaCepAsync(cep));
  }
}
