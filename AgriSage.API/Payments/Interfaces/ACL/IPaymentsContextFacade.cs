using AgriSage.API.Payments.Domain.Model.Aggregates;
using System.Threading.Tasks;

namespace AgriSage.API.Payments.Interfaces.ACL;

    public interface IPaymentsContextFacade
    {
        Task<int> CreatePayment(string cardNumber, DateTime expiryDate, string cvv);
        Task<Payment?> GetPaymentById(int paymentId);
    }
