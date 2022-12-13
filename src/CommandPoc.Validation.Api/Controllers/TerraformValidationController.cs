using CommandPoc.Validation.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CommandPoc.Validation.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class TerraformValidationController : ControllerBase
{
    private readonly ILogger<TerraformValidationController> _logger;
        private readonly IMediator _mediator;

    public TerraformValidationController(
        ILogger<TerraformValidationController> logger,
        IMediator mediator    
    )
    {
        _mediator = mediator;
        _logger = logger;
    }

    [HttpPost(Name = "StartTerraformValidation")]
    public async Task<string> Post([FromBody]TerraformValidationRequest request)
    {
        var command = new StartTerraformValidationCommand(request.directory);
        var result = await _mediator.Send(command);

        return result.ValidationStatus;
    }

    public record TerraformValidationRequest(string directory);
}
