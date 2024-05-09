using MediatR;

namespace CountryStateCityWithCQRS.Application.Command._Country.DeleteCountry
{
    public class DeleteCountryCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
