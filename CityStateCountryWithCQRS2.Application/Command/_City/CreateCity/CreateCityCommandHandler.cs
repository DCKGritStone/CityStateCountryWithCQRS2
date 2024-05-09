using AutoMapper;
using CityStateCountryWithCQRS2.Application.Dto;
using CityStateCountryWithCQRS2.Domain.Entity;
using CityStateCountryWithCQRS2.Domain;
using MediatR;

namespace CityStateCountryWithCQRS2.Application.Command._City.CreateCity
{
    public class CreateCityCommandHandler : IRequestHandler<CreateCityCommand, CityDto>
    {
        private readonly IRepository Repository;
        private readonly IMapper mapper;

        public CreateCityCommandHandler(IRepository cityRepository, IMapper mapper)
        {
            this.Repository = cityRepository;
            this.mapper = mapper;
        }
        public async Task<CityDto> Handle(CreateCityCommand request, CancellationToken cancellationToken)
        {
            var createCity = new City
            {
                Name = request.Name,
                Code = request.Code,
                StateId = request.StateId
            };

            var result = await Repository.CreateCityAsync(createCity);

            return mapper.Map<CityDto>(result);
        }
    }
}
