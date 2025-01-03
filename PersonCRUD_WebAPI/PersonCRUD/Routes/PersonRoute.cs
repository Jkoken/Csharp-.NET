using Microsoft.EntityFrameworkCore;
using PersonCRUD.Data;
using PersonCRUD.Models;

namespace PersonCRUD.Routes
{
    public static class PersonRoute //Pode ser static pois não precisa instanciar, deixa pela própria aplicação instanciá-la
    { //Se a classe é estática, todos os membros devem ser estáticos
        public static void PersonRoutes(this WebApplication app) //Utilizando o "this" para tornar o método um "Extension Method".
        {
            //app.MapGet("person", () => new PersonModel("Jackson")); //primeiro parâmetro > ROTA | segundo parâmetro > Handler (como ele vai manusear a rota)


            var route = app.MapGroup("person"); //Isso faz com que não seja necessário passar o parâmetro de rota toda vez que chamar um método relacionado.
            
            route.MapPost("", async (PersonRequest req, PersonContext context) => //Colocando como async é mais seguro em se tratando de databases (salvo exceções).
            { //PersonRequest = arquivo de requisição | //PersonContext = database;
                var person = new PersonModel(req.name);
                await context.AddAsync(person); //Aqui ela fica "marcada" como adicionada, mas não é feito o commit ainda. Como se fosse um "pré" commit.
                await context.SaveChangesAsync(); //Aqui é o "commit" para de fato adicionar a "person" criada acima, ao database.
            });

            route.MapGet("", async (PersonContext context) =>
            {
                var people = await context.People.ToListAsync(); //Criando uma variável para armazenar a tabela People do banco de dados;
                return Results.Ok(people); //Dessa forma, se der tudo certo, ele vai retornar people;
            });

            route.MapPut("{id:guid}", async (Guid id, PersonRequest req, PersonContext context) =>
            { //.FirstOrDefaultAsync(): Isso faz com que, caso o ID em questão não existe, não será gerada uma exceção
                var person = await context.People.FirstOrDefaultAsync(x => x.Id == id);

                if (person == null)
                    return Results.NotFound();

                person.ChangeName(req.name);
                await context.SaveChangesAsync();

                return Results.Ok(person);
            });

            route.MapDelete("{id:guid}", async (Guid id, PersonContext context) => //Ao invés de dar um "hard delete" estamos fazendo um "soft delete", mantendo o ID, só alterando o nome, nesse caso.
            {
                var person = await context.People.FirstOrDefaultAsync(x => x.Id == id);

                if (person == null)
                    return Results.NotFound();

                person.SetInactive();
                await context.SaveChangesAsync();
                return Results.Ok(person);
            });
        }
    }
}
