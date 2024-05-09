using CityStateCountryWithCQRS2.Domain;
using CountryStateCityWithCQRS.Application.Command._City.DeleteCity;
using MediatR;

namespace CityStateCountryWithCQRS2.Application.Command._City.DeleteCity
{
    public class DeleteCityCommandHandler : IRequestHandler<DeleteCityCommand, int>
    {
        private readonly IRepository Repository;

        public DeleteCityCommandHandler(IRepository cityRepository)
        {
            this.Repository = cityRepository;
        }
        public async Task<int> Handle(DeleteCityCommand request, CancellationToken cancellationToken)
        {
            return await Repository.DeleteCityAsync(request.Id);
        }
    }
}
