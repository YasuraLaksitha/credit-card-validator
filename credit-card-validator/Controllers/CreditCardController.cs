using credit_card_validator.DTO;
using Microsoft.AspNetCore.Mvc;

namespace credit_card_validator.Controllers;

[ApiController]
[Route("[controller]")]
public class CreditCardController(ILogger<CreditCardController> logger) : ControllerBase
{
    [HttpPost]
    public IActionResult Post([FromBody] CreditCardDTO cardDto)
    {
        logger.LogInformation("Request Received | {}", cardDto);
        return Ok("Request received");
    }
}