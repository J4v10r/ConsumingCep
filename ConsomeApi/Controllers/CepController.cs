using ConsomeApi.Services;
using ConsomeApi.Services.Interfaces;
using ConsomeApi.Services.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsomeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CepController : ControllerBase
    {
        private readonly IViacepIntegracao _viacepIntegracao;
       public CepController(IViacepIntegracao viacepIntegracao) {
            _viacepIntegracao = viacepIntegracao;
        }

          
    [HttpGet("cep")]
        public async Task<ActionResult<ViaCepResponse>> ListarDadoscep(string cep){
          var response = await  _viacepIntegracao.ObterDadosViaCep(cep);
            if (response == null){
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}

