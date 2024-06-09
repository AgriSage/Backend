namespace AgriSage.API.Payments.Interfaces.REST.Resources;

    public record PaymentResource(int Id, string CardNumber, DateTime ExpiryDate, string CVV);
