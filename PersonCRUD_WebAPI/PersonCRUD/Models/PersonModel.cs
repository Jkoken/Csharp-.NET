namespace PersonCRUD.Models
{
    public class PersonModel
    {

        public PersonModel(string name)
        {
            Name = name;
            Id = Guid.NewGuid();
        }

        public Guid Id { get; init; } //
        public string Name { get; private set; } = string.Empty; //uma das formas de inicializar a string, para evitar erro de não nulo, é com o "string.Empty". Outra forma é adicionar o "?" junto do string (public string? ...), ou usando o required;

        public void ChangeName(string name) //Esse método é como uma forma de evitar erro de desenvolvedor.
        {
            Name = name;
        }

        public void SetInactive()
        {
            Name = "Disabled";
        }
    }
}
