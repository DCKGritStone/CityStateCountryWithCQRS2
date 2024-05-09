using CityStateCountryWithCQRS2.Domain;
using CityStateCountryWithCQRS2.Domain.Entity;
using MediatR;

namespace CityStateCountryWithCQRS2.Application.Command._State.UpdateState
{
    public class UpdateStateCommandHandler : IRequestHandler<UpdateStateCommand, int>
    {
        private readonly IRepository Repository;

        public UpdateStateCommandHandler(IRepository stateRepository)
        {
            this.Repository = stateRepository;
        }
        public async Task<int> Handle(UpdateStateCommand request, CancellationToken cancellationToken)
        {
            var updateState = new State
            {
                Id = request.Id,
                Name = request.Name,
                Code = request.Code,
                CountryId = request.CountryId
            };
            return await Repository.UpdateStateAsync(request.Id, updateState);
        }
    }
}