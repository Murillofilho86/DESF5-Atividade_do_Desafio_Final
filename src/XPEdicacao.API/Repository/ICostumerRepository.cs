using XPEducacao.API.Models;

namespace XPEducacao.API.Repository
{
    public interface ICostumerRepository
    {
        List<Costumer> GetAll();

        Costumer Get(long id);

        void Add(Costumer customer);

        void Update(Costumer customer);

        void Delete(long id);

        List<Costumer> GetByName(string name);
    }
}
