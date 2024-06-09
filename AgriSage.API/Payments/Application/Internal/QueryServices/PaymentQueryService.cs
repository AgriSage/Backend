using AgriSage.API.Payments.Domain.Model.Aggregates;
using AgriSage.API.Payments.Domain.Model.Queries;
using AgriSage.API.Payments.Domain.Repositories;
using AgriSage.API.Payments.Domain.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AgriSage.API.Payments.Application.Internal.QueryServices;

    public class PaymentQueryService : IPaymentQueryService
    {
        private readonly IPaymentRepository _paymentRepository;

        public PaymentQueryService(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task<IEnumerable<Payment>> Handle(GetAllPaymentsQuery query)
        {
            return await _paymentRepository.ListAsync();
        }

        public async Task<Payment?> Handle(GetPaymentByIdQuery query)
        {
            return await _paymentRepository.FindByIdAsync(query.PaymentId);
        }
    }
