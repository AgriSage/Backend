using AgriSage.API.Payments.Domain.Model.Aggregates;
using AgriSage.API.Payments.Domain.Model.Queries;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AgriSage.API.Payments.Domain.Services;

public interface IPaymentQueryService
{
    Task<IEnumerable<Payment>> Handle(GetAllPaymentsQuery query);
    Task<Payment?> Handle(GetPaymentByIdQuery query);
}