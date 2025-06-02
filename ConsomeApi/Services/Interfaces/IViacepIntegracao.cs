using ConsomeApi.Services.Response;

namespace ConsomeApi.Services.Interfaces
{
    public interface IViacepIntegracao
    {
        Task<ViaCepResponse> ObterDadosViaCep(string cep);
    }
}
