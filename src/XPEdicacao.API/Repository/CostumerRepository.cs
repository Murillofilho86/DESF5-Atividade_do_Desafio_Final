using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System.Xml.Linq;
using XPEducacao.API.Models;

namespace XPEducacao.API.Repository
{
    public class CostumerRepository : ICostumerRepository
    {

        public void Delete(long id) => _costumer.Where(customer => customer.Id != id).ToList();

        public List<Costumer> GetAll() => _costumer;

        public Costumer Get(long id)
        {
            return _costumer.FirstOrDefault(customer => customer.Id == id);
        }

        public void Add(Costumer customer)
        {
            var newId = _costumer.Max(c => c.Id) + 1;
            Costumer.Create(newId, customer.Name, customer.Email);
            _costumer.Add(customer);
        }

        public void Update(Costumer costumer)
        {

            _costumer.Select(costumer =>
             {
                 if (costumer.Id == costumer.Id)
                 {
                    // Costumer.Alter(costumer.Name, costumer.Email);
                 }
                 return costumer;
             }).ToList();
        }

        public List<Costumer> GetByName(string name)
        {
            return _costumer.Where(p => p.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }


        #region Mock

        private readonly List<Costumer> _costumer = new List<Costumer>()
        {
            Costumer.Create(1, "Maria Silva", "maria.silva@email.com"),
            Costumer.Create(2, "João Oliveira", "joao.oliveira@email.com"),
            Costumer.Create(3, "Carla Souza", "carla.souza@email.com"),
            Costumer.Create(4, "Pedro Lima", "pedro.lima@email.com"),
            Costumer.Create(5, "Ana Costa", "ana.costa@email.com"),
        };

        #endregion


    }
}
