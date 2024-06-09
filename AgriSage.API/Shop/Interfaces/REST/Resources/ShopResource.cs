using AgriSage.API.Shop.Domain.Model.ValueObjects;

namespace AgriSage.API.Shop.Interfaces.REST.Resources;

public record ShopResource(int Id, AmountProducts AmountProducts, BuyList BuyList, TotalPrice TotalPrice);