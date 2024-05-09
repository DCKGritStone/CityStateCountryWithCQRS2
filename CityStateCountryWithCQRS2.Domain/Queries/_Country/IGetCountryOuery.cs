using CityStateCountryWithCQRS2.Application.Dto;

namespace CityStateCountryWithCQRS2.Domain.Queries._Country
{
    public interface IGetCountryOuery
    {
        IList<CountryDto> GetAllCountryAsync();

        CountryDto GetCountryByIdAsync(int id);
    }
}
