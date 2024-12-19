using ArgeProject.Application.Features.Commands.SampleC.CreateSample;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ArgeProject.MainApi.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class SampleController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly ILogger<SampleController> _logger;

    public SampleController(IMediator mediator, ILogger<SampleController> logger)
    {
        _mediator = mediator;
        _logger = logger;
    }

    [HttpPost]
    public async Task<IActionResult> CreateSampleAsync()
    {
        _logger.LogInformation("Test Log");
        var result = await _mediator.Send(new CreateSampleCommand());
        return Ok();
    }   
}
