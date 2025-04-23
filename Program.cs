using CarCRUD.Data; // Corrigido para CarCRUD.Data
using CarCRUD.Routes; // Corrigido para CarCRUD.Routes

var builder = WebApplication.CreateBuilder(args);

// Adicionar serviços ao contêiner.
builder.Services.AddOpenApi();
builder.Services.AddScoped<ContextoCarro>(); // Corrigido para ContextoCarro

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configurar o pipeline de requisições HTTP.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.RotaCarro(); // Corrigido para RotaCarro

app.UseHttpsRedirection();
app.Run();