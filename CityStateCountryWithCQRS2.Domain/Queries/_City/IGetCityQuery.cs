using CityStateCountryWithCQRS2.Application.Dto;

namespace CityStateCountryWithCQRS2.Domain.Queries._City
{
    public interface IGetCityQuery
    {
        IList<CityDto> GetAllCityAsync();

        IList<CityDto> GetALLCitiesByStateIdAsync(int id);

        CityDto GetCityByIdAsync(int id);



    }
}
