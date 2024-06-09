using AgriSage.API.Payments.Domain.Model.Aggregates;
using AgriSage.API.Payments.Domain.Model.Commands;

namespace AgriSage.API.Payments.Domain.Services;

    public interface IPaymentCommandService
    {
        Task<Payment?> Handle(CreatePaymentCommand command);
    }
