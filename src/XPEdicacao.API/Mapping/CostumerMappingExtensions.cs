using XPEducacao.API.Models;

namespace XPEducacao.API.Mapping
{

    // Extensões para conversão
    public static class CostumerMappingExtensions
    {
        /// <summary>
        /// Converte um CostumerRecord para Costumer.
        /// </summary>
        public static Costumer ToCostumer(this CostumerRecord record)
            => Costumer.Create(record.id, record.name, record.email);

        /// <summary>
        /// Converte um Costumer para CostumerRecord.
        /// </summary>
        public static CostumerRecord ToRecord(this Costumer customer)
            => new CostumerRecord(customer.Id, customer.Name ?? string.Empty, customer.Email ?? string.Empty);

        /// <summary>
        /// Converte IEnumerable<CostumerRecord> para List<Costumer>.
        /// </summary>
        public static List<Costumer> ToCostumerList(this IEnumerable<CostumerRecord> records)
            => records.Select(r => r.ToCostumer()).ToList();

        /// <summary>
        /// Converte IEnumerable<Costumer> para List<CostumerRecord>.
        /// </summary>
        public static List<CostumerRecord> ToRecordList(this IEnumerable<Costumer> customers)
            => customers.Select(c => c.ToRecord()).ToList();
    }
}
