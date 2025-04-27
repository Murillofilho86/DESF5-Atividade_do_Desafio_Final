using NuGet.Protocol.Core.Types;
using XPEducacao.API.Models;

namespace XPEducacao.API.Services
{
    public interface ICostumerService
    {
        List<CostumerRecord> GetAll();

        CostumerRecord Get(long id);

        void Add(CostumerRecord record);

        void Update(CostumerRecord record);

        void Delete(long id);
        List<CostumerRecord> GetByName(string name);
    }
}
