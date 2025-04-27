using XPEducacao.API.Mapping;
using XPEducacao.API.Models;
using XPEducacao.API.Repository;

namespace XPEducacao.API.Services
{
    public class CostumerService : ICostumerService
    {
        private readonly ICostumerRepository _repository;

        public CostumerService(ICostumerRepository repository)
        {
            _repository = repository;
        }

        public void Delete(long id) => _repository.Delete(id);

        public List<CostumerRecord> GetAll()
        {
            List<Costumer> costumers = _repository.GetAll();
            return costumers.ToRecordList();
        }

        public CostumerRecord Get(long id)
        {
            Costumer costumer = _repository.Get(id);
            return costumer.ToRecord();
        }

        public void Add(CostumerRecord record)
        {
            Costumer customer = Costumer.Create(record.id, record.name, record.email);

            _repository.Add(customer);
        }

        public void Update(CostumerRecord record)
        {
            Costumer existingCostomer = _repository.Get(record.id);

            existingCostomer.Alter(record.name, record.email);

            _repository.Update(existingCostomer);
           
        }

        public List<CostumerRecord> GetByName(string name)
        {
            List<Costumer> costumers = _repository.GetByName(name);

            return costumers.ToRecordList();
        }
    }
}
