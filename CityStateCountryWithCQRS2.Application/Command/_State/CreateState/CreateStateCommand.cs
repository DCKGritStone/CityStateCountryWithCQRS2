using CityStateCountryWithCQRS2.Application.Dto;
using MediatR;

namespace CityStateCountryWithCQRS2.Application.Command._State.CreateState
{
    public class CreateStateCommand : IRequest<StateDto>
    {
        public string? Name { get; set; }
        public double? Code { get; set; }

        public int CountryId { get; set; }
    }
}
