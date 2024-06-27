using System.Net.Mime;
using AgriSage.API.Shops.Domain.Model.Queries;
using AgriSage.API.Shops.Domain.Services;
using AgriSage.API.Shops.Interfaces.REST.Resources;
using AgriSage.API.Shops.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;

namespace AgriSage.API.Shops.Interfaces.REST;

[ApiController]
[Route("api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]

public class ShopsController(IShopCommandService shopCommandService, IShopQueryService shopQueryService) : ControllerBase
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

    [HttpGet]
    public async Task<IActionResult> GetAllShops()
    {
        var getAllShopsQuery = new GetAllShopsQuery();
        var shops = await shopQueryService.Handle(getAllShopsQuery);
        var shopResources = shops.Select(ShopResourceFromEntityAssembler.ToResourceFromEntity);
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