using CityStateCountryWithCQRS2.Application.Command._City.UpdateCity;
using CityStateCountryWithCQRS2.Domain;
using CityStateCountryWithCQRS2.Domain.Entity;
using MediatR;

namespace CountryStateCityWithCQRS.Application.Command._City.UpdateCity
{
    public class UpdateCityCommandHandler : IRequestHandler<UpdateCityCommand, int>
    {
        private readonly IRepository Repository;

        public UpdateCityCommandHandler(IRepository cityRepository)
        {
            this.Repository = cityRepository;
        }
        public async Task<int> Handle(UpdateCityCommand request, CancellationToken cancellationToken)
        {
            var updateCity = new City
            {
                Id = request.Id,
                Name = request.Name,
                Code = request.Code,
                StateId = request.StateId
            };
            return await Repository.UpdateCityAsync(request.Id, updateCity);

        }
    }
}
