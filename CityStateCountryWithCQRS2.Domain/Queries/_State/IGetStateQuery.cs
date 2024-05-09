using CityStateCountryWithCQRS2.Application.Dto;

namespace CityStateCountryWithCQRS2.Domain.Queries._State
{
    public interface IGetStateQuery
    {
        IList<StateDto> GetAllStateAsync();

        StateDto GetStateByIdAsync(int id);
    }
}
