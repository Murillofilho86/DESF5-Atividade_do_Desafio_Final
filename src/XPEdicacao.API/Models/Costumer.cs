namespace XPEducacao.API.Models
{
    public class Costumer
    {

        public long Id { get; private set; }

        public string? Name { get; private set; }

        public string? Email { get; private set; }


        public static Costumer Create(long id, string nome, string email)
         => new Costumer() { Id = id, Name = nome, Email = email };

        public void Alter(string nome, string email)
        {
            Name = nome;
            Email = email;
        }
    }
}
