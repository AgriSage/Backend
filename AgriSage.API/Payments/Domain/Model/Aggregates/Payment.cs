using AgriSage.API.Payments.Domain.Model.Commands;
using AgriSage.API.Payments.Domain.Model.ValueObjects;

namespace AgriSage.API.Payments.Domain.Model.Aggregates;

public partial class Payment
{
    public Payment()
    {
        Cardnumber = new CardNumber();
        Expirydate = new ExpiryDate();
        Cardverification = new CardVerification();
    }

    public Payment(string number, DateTime expiry, string cvv)
    {
        Cardnumber = new CardNumber(number);
        Expirydate = new ExpiryDate(expiry);
        Cardverification = new CardVerification(cvv);
    }

    public Payment(CreatePaymentCommand command)
    {
        Cardnumber = new CardNumber(command.CardNumber);
        Expirydate = new ExpiryDate(command.ExpiryDate);
        Cardverification = new CardVerification(command.CVV);
    }
    
    public int Id { get; }
    public CardNumber Cardnumber { get; private set; }
    public CardVerification Cardverification { get; private set; }
    public ExpiryDate Expirydate { get; private set; }

    public string CardNumber => Cardnumber.Cardnumber;
    public string CardVerification => Cardverification.Cvv;
    public string ExpiryDate => Expirydate.Value.ToString("MM/dd/yyyy");
}
