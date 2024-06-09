using AgriSage.API.Payments.Domain.Model.Aggregates;
using AgriSage.API.Payments.Interfaces.REST.Resources;

namespace AgriSage.API.Payments.Interfaces.REST.Transform;

    public static class PaymentResourceFromEntityAssembler
    {
        public static PaymentResource ToResourceFromEntity(Payment entity)
        {
            return new PaymentResource(entity.Id, entity.Cardnumber.Value, entity.Expirydate.Value, entity.Cardverification.Value);
        }
    }
