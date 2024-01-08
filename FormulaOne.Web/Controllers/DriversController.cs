using FormulaOne.Application.Drivers.Commands.CreateDriver;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FormulaOne.Web.Controllers;

[ApiController]
[Route("api/drivers")]
public class DriversController : ControllerBase
{
    [HttpPost]
    public async Task<IResult> AddDriver(ISender sender, CreateDriverCommand newDriver)
    {
        Guid newDriverId = await sender.Send(newDriver);
        return Results.Ok(newDriverId);
    }
}
