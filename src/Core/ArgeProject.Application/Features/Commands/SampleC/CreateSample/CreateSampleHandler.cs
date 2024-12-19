using ArgeProject.Application.Abstractions.Repositories;
using ArgeProject.Application.Commons.Models;
using MediatR;

namespace ArgeProject.Application.Features.Commands.SampleC.CreateSample
{
    public class CreateSampleHandler : IRequestHandler<CreateSampleCommand, SuccessResult>
    {
        private readonly ISampleRepository _repository;

        public CreateSampleHandler(ISampleRepository repository)
        {
            _repository = repository;
        }

        public async Task<SuccessResult> Handle(CreateSampleCommand request, CancellationToken cancellationToken)
        {
            await _repository.InsertSampleDataAsync();
            return new SuccessResult();
        }
    }
}
