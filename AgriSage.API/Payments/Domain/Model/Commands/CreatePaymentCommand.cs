namespace AgriSage.API.Payments.Domain.Model.Commands;

public record CreatePaymentCommand(string CardNumber, DateTime ExpiryDate, string CVV);
