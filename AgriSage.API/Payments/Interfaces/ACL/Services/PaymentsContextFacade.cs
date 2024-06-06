using AgriSage.API.Payments.Domain.Model.Aggregates;
using AgriSage.API.Payments.Domain.Model.Commands;
using AgriSage.API.Payments.Domain.Model.Queries;
using AgriSage.API.Payments.Domain.Services;

namespace AgriSage.API.Payments.Interfaces.ACL.Services;

    /**
     * Payments context facade.
     *
     * <summary>
     * This class represents the payments context facade, part of the payments anti-corruption layer.
     * It contains the methods to interact with the payments context from other bounded context.
     * </summary>
     */
    public class PaymentsContextFacade : IPaymentsContextFacade
    {
        private readonly IPaymentCommandService _paymentCommandService;
        private readonly IPaymentQueryService _paymentQueryService;

        public PaymentsContextFacade(IPaymentCommandService paymentCommandService, IPaymentQueryService paymentQueryService)
        {
            _paymentCommandService = paymentCommandService;
            _paymentQueryService = paymentQueryService;
        }

        /**
         * Create a payment.
         *
         * <param name="cardNumber">The card number of the payment</param>
         * <param name="expiryDate">The expiry date of the card</param>
         * <param name="cvv">The CVV of the card</param>
         * <returns>The payment id</returns>
         */
        public async Task<int> CreatePayment(string cardNumber, DateTime expiryDate, string cvv)
        {
            var createPaymentCommand = new CreatePaymentCommand(cardNumber, expiryDate, cvv);
            var payment = await _paymentCommandService.Handle(createPaymentCommand);
            return payment?.Id ?? 0;
        }

        /**
         * Fetch a payment by id.
         *
         * <param name="paymentId">The id of the payment</param>
         * <returns>The payment entity</returns>
         */
        public async Task<Payment?> GetPaymentById(int paymentId)
        {
            var getPaymentByIdQuery = new GetPaymentByIdQuery(paymentId);
            return await _paymentQueryService.Handle(getPaymentByIdQuery);
        }
    }
