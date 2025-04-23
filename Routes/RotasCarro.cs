using Microsoft.EntityFrameworkCore;
using CarCRUD.Data;
using CarCRUD.Models;

namespace CarCRUD.Routes;

public static class RotasCarro
{
    public static void RotaCarro(this WebApplication app)
    {
        var rotas = app.MapGroup("carro");

        rotas.MapPost("",
            async (RequisicaoCarro req, ContextoCarro contexto) =>
            {
                var carro = new CarroModelo(req.modelo);
                await contexto.AddAsync(carro);
                await contexto.SaveChangesAsync();
                return Results.Created($"/carro/{carro.Id}", carro);
            });

        rotas.MapGet("", async (ContextoCarro contexto) =>
        {
            var carros = await contexto.Carros.ToListAsync();
            return Results.Ok(carros);
        });

        rotas.MapPut("{id:guid}",
            async (Guid id, RequisicaoCarro req, ContextoCarro contexto) =>
            {
                var carro = await contexto.Carros.FirstOrDefaultAsync(x => x.Id == id);
                if (carro == null)
                    return Results.NotFound();

                carro.AlterarModelo(req.modelo);
                await contexto.SaveChangesAsync();

                return Results.Ok(carro);
            });

        rotas.MapDelete("{id:guid}",
            async (Guid id, ContextoCarro contexto) =>
            {
                var carro = await contexto.Carros.FirstOrDefaultAsync(x => x.Id == id);
                if (carro == null)
                    return Results.NotFound();

                carro.DefinirComoInativo();
                await contexto.SaveChangesAsync();

                return Results.Ok(carro);
            });
    }
}