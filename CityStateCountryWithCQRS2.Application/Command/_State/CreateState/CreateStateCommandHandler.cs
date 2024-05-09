using AutoMapper;
using CityStateCountryWithCQRS2.Application.Dto;
using CityStateCountryWithCQRS2.Domain;
using CityStateCountryWithCQRS2.Domain.Entity;
using MediatR;

namespace CityStateCountryWithCQRS2.Application.Command._State.CreateState
{
    public class CreateStateCommandHandler : IRequestHandler<CreateStateCommand, StateDto>
    {
        private readonly IRepository Repository;
        private readonly IMapper mapper;

        public CreateStateCommandHandler(IRepository stateRepository, IMapper mapper)
        {
            this.Repository = stateRepository;
            this.mapper = mapper;
        }
        public async Task<StateDto> Handle(CreateStateCommand request, CancellationToken cancellationToken)
        {
            var createState = new State
            {
                Name = request.Name,
                Code = request.Code,
                CountryId = request.CountryId
            };

            var result = await Repository.CreateStateAsync(createState);

            return mapper.Map<StateDto>(result);
        }
    }
}
