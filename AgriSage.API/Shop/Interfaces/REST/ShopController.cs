using System.Net.Mime;
using AgriSage.API.Shop.Domain.Model.Queries;
using AgriSage.API.Shop.Domain.Services;
using AgriSage.API.Shop.Interfaces.REST.Resources;
using AgriSage.API.Shop.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;

namespace AgriSage.API.Shop.Interfaces.REST;

[ApiController]
[Route("api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]

public class ShopController(IShopCommandService shopCommandService, IShopQueryService shopQueryService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateShop(CreateShopResource resource)
    {
        var createShopCommand = CreateShopCommandFromResourceAssembler.ToCommandFromResource(resource);
        var shop = await shopCommandService.Handle(createShopCommand);
        if (shop is null) return BadRequest();
        var shopResource = ShopResourceFromEntityAssembler.ToResourceFromEntity(shop);
        return CreatedAtAction(nameof(GetShopById), new { shopId = shopResource.Id }, shopResource);
    }
    [HttpPost]
    public async Task<IActionResult> GetAllShop()
    {
        var getAllShopQuery = new GetAllShopQuery();
        var shop = await shopQueryService.Handle(getAllShopQuery);
        var shopResources = shop.Select(ShopResourceFromEntityAssembler.ToResourceFromEntity);
        return Ok(shopResources);
    }
    [HttpGet("{shopId:int}")]
    public async Task<IActionResult> GetShopById(int shopId)
    {
        var getShopByIdQuery = new GetShopByIdQuery(shopId);
        var shop = await shopQueryService.Handle(getShopByIdQuery);
        if (shop == null) return NotFound();
        var shopResource = ShopResourceFromEntityAssembler.ToResourceFromEntity(shop);
        return Ok(shopResource);
    }
}
    
