namespace PersonCRUD.Routes
{
    public static class PersonRoute //Pode ser static pois não precisa instanciar, deixa pela própria aplicação instanciá-la
    { //Se a classe é estática, todos os membros devem ser estáticos
        public static void PersonRoutes(this WebApplication app) //Utilizando o "this" para tornar o método um "Extension Method".
        {
            app.MapGet("person", () => "Hello World!"); //primeiro parâmetro > ROTA | segundo parâmetro > Handler (como ele vai manusear a rota)
        }
    }
}
