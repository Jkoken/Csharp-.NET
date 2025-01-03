using PersonCRUD.Data;
using PersonCRUD.Routes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<PersonContext>(); //Utilizado para Injetar a conexão com o banco de dados;

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.PersonRoutes();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();


//Criar migration para então, atualizar o banco de dados;
//dotnet ef migrations add nome_aqui...