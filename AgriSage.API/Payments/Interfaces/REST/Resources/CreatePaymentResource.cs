namespace AgriSage.API.Payments.Interfaces.REST.Resources;

    public record CreatePaymentResource(string CardNumber, DateTime ExpiryDate, string CVV);
