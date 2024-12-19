using ArgeProject.Application.Commons.Models;
using MediatR;

namespace ArgeProject.Application.Features.Commands.SampleC.CreateSample
{
    public record CreateSampleCommand() : IRequest<SuccessResult>;
}
