using AutoMapper;
using CityStateCountryWithCQRS2.Application.Dto;
using CityStateCountryWithCQRS2.Domain.Queries._Country;
using CityStateCountryWithCQRS2.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CityStateCountryWithCQRS2.Infrastructure.Queries._Country
{
    public class GetCountryQuery : IGetCountryOuery
    {
        private readonly CityStateCountryDbContext dbContext;
        private readonly IMapper mapper;

        public GetCountryQuery(CityStateCountryDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
        public IList<CountryDto> GetAllCountryAsync()
        {

            return mapper.Map<IList<CountryDto>>(dbContext.Countries.ToList());
            /* return dbContext.Countries.Select(country => new CountryDto()
             {
                 Id = country.Id,
                 Name = country.Name,
                 Code = country.Code
                 *//* Country = new CountryDto()
                  {
                      Name = state.Country.Name,
                      Code = state.Country.Code
                  }*//*

             }).ToList();*/
        }

        public CountryDto GetCountryByIdAsync(int id)
        {
            return mapper.Map<CountryDto>(dbContext.Countries.AsNoTracking().FirstOrDefaultAsync(Co => Co.Id == id));
        }
    }
}
