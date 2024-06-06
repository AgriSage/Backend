using  AgriSage.API.Payments.Domain.Model.Aggregates;
using  AgriSage.API.Payments.Domain.Model.ValueObjects;
using AgriSage.API.Shared.Domain.Repositories;

namespace AgriSage.API.Payments.Domain.Repositories;

public interface IPaymentRepository : IBaseRepository<Payment>
{
    Task AddAsync(Payment payment);
    Task<Payment?> FindByIdAsync(int id);
    Task<IEnumerable<Payment>> ListAsync();
}