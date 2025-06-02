using ConsomeApi.Services.Interfaces;
using ConsomeApi.Services.Refit;
using ConsomeApi.Services.Response;

namespace ConsomeApi.Services
{

    public class IntegrationService : IViacepIntegracao
    {
        private readonly IViaCepIntegracaoRefit _viaCepIntegracaoRefit;
        public IntegrationService(IViaCepIntegracaoRefit viaCepIntegracaoRefit)
        {
            _viaCepIntegracaoRefit = viaCepIntegracaoRefit;
            
        }
        public async Task<ViaCepResponse> ObterDadosViaCep(string cep)
        {
            var responseData = await _viaCepIntegracaoRefit.ObterDadosViaCep(cep);
            if (responseData != null && responseData.IsSuccessStatusCode){
                return responseData.Content;
            }
            return null;

        }
    }
}
