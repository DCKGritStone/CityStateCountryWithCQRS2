using CityStateCountryWithCQRS2.Application.Dto;
using MediatR;

namespace CityStateCountryWithCQRS2.Application.Command._Country.CreateCountry
{
    public class CreateCountryCommand : IRequest<CountryDto>
    {
        public string? Name { get; set; }
        public double? Code { get; set; }
    }
}
