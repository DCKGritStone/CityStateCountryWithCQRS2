using AutoMapper;
using CityStateCountryWithCQRS2.Application.Dto;
using CityStateCountryWithCQRS2.Domain;
using CityStateCountryWithCQRS2.Domain.Entity;
using MediatR;

namespace CityStateCountryWithCQRS2.Application.Command._Country.CreateCountry
{
    public class CreateCountryCommandHandler : IRequestHandler<CreateCountryCommand, CountryDto>
    {
        private readonly IRepository Repository;
        private readonly IMapper mapper;

        public CreateCountryCommandHandler(IRepository countryRepository, IMapper mapper)
        {
            this.Repository = countryRepository;
            this.mapper = mapper;
        }
        public async Task<CountryDto> Handle(CreateCountryCommand request, CancellationToken cancellationToken)
        {
            var createCountry = new Country
            {
                Name = request.Name,
                Code = request.Code
            };

            var result = await Repository.CreateCountryAsync(createCountry);

            return mapper.Map<CountryDto>(result);
        }
    }
}
