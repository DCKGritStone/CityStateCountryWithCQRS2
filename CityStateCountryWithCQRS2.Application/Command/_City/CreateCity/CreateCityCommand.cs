using CityStateCountryWithCQRS2.Application.Dto;
using MediatR;

namespace CityStateCountryWithCQRS2.Application.Command._City.CreateCity
{
    public class CreateCityCommand : IRequest<CityDto>
    {
        public string? Name { get; set; }
        public double? Code { get; set; }

        public int StateId { get; set; }
    }
}
