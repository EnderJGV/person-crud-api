using Microsoft.EntityFrameworkCore;
using Person.Data;
using Person.Models;

namespace Person.Routes
{
    public static class PersonRoute
    {
        public static void PersonRoutes(this WebApplication app)
        {
            var route = app.MapGroup("api");

            //Rota de teste para verificar se a API está funcionando corretamente
            route.MapGet("/testApiConection", () => "API is running correctly! in localhost");

            //Esta rota retorna todas as pessoas cadastradas no banco de dados
            route.MapGet("/GetAllPeople", async (PersonContext context) =>
            {
                var people = await context.People.ToListAsync();
                return Results.Ok(people);
            });
            
            //Esta rota retorna uma pessoa específica com base no ID fornecido
            route.MapGet("/GetPersonById/{id:guid}", async (Guid id, PersonContext context) =>
            {
                var person = await context.People.FirstOrDefaultAsync(x => x.Id == id);
                if (person == null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(person);
            });

            //Esta rota cria uma nova pessoa e a salva no banco de dados
            route.MapPost("/CreatePerson",
                async (PersonRequest req, PersonContext context) =>
            {
                var responsePersonResquet = new PersonModel(req.name, req.gender, req.document, req.email, req.phone, req.address, req.city, req.state, req.zipCode, req.birthDate);


                await context.AddAsync(responsePersonResquet);
                await context.SaveChangesAsync();
                return Results.Ok(responsePersonResquet);
            });

            //Esta rota realiza a atualização dos dados de uma pessoa existente no banco de dados
            route.MapPut("/UpdatePerson/{id:guid}/",
                async (Guid id, PersonRequest req, PersonContext context) =>
                {
                    var person = await context.People.FirstOrDefaultAsync(x => x.Id == id);

                    if (person == null)
                    {
                        return Results.NotFound();
                    }

                    person.ChangeName(req.name);
                    person.ChangeDocument(req.document);
                    person.ChangeEmail(req.email);
                    person.ChangePhone(req.phone);
                    person.ChangeAddress(req.address);
                    person.ChangeCity(req.city);
                    person.ChangeState(req.state);
                    person.ChangeZipCode(req.zipCode);
                    person.Updated_at = DateTime.UtcNow;

                    await context.SaveChangesAsync();
                    return Results.Ok(person);
                }
            );

            //Esta rota realiza a exclusão lógica de uma pessoa, definindo o campo IsActive como false
            route.MapDelete("/DeletePersonById/{id:guid}",
                async (Guid id, PersonContext context) =>
            {
                var person = await context.People.FirstOrDefaultAsync(x => x.Id == id);

                if (person == null)
                {
                    return Results.NotFound();
                }

                person.SetInactive();
                await context.SaveChangesAsync();
                return Results.Ok(person);
            });

        }
    }
}
