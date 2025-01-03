using Microsoft.EntityFrameworkCore;
using PersonCRUD.Models;

namespace PersonCRUD.Data
{
    public class PersonContext : DbContext //DbContext é a representação do banco de dados, ou seja, no database terá o "PersonContext" como DB;
    {
        public DbSet<PersonModel> People { get; set; } //DbSet é a representação da TABELA PersonModel do DB, em memória.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { //Esse Método é utilizado para configuração do provider do banco de dados, nesse caso, o sqlite.
            optionsBuilder.UseSqlite("Data Source = personCrud.sqlite"); //Dentro dos parênteses entra a connectionString de cada provider
            base.OnConfiguring(optionsBuilder);
        }
    }
}
