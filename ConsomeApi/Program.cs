using ConsomeApi.Services;
using ConsomeApi.Services.Interfaces;
using ConsomeApi.Services.Refit;
using Refit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddRefitClient<IViaCepIntegracaoRefit>().ConfigureHttpClient(c =>
c.BaseAddress = new Uri("https://viacep.com.br/"));
builder.Services.AddScoped<IViacepIntegracao,IntegrationService>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
