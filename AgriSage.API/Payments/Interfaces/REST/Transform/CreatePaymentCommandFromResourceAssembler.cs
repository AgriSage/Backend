using AgriSage.API.Payments.Domain.Model.Commands;
using AgriSage.API.Payments.Interfaces.REST.Resources;

namespace AgriSage.API.Payments.Interfaces.REST.Transform;

    public static class CreatePaymentCommandFromResourceAssembler
    {
        public static CreatePaymentCommand ToCommandFromResource(CreatePaymentResource resource)
        {
            return new CreatePaymentCommand(resource.CardNumber, resource.ExpiryDate, resource.CVV);
        }
    }
