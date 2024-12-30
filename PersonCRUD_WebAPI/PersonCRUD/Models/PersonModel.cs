namespace PersonCRUD.Models
{
    public class PersonModel
    {
        public Guid Id { get; init; } //
        public string Name { get; set; } = string.Empty; //uma das formas de inicializar a string, falando que ela pode ser nula, com o "string.Empty"?;

    }
}
