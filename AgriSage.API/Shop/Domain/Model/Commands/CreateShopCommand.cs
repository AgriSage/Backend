namespace AgriSage.API.Shop.Domain.Model.Commands;

public record CreateShopCommand(int Amount, float Price, string Products);