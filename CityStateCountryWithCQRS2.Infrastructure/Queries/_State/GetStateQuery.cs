﻿using AutoMapper;
using CityStateCountryWithCQRS2.Application.Dto;
using CityStateCountryWithCQRS2.Domain.Queries._State;
using CityStateCountryWithCQRS2.Infrastructure.Data;

namespace CityStateCountryWithCQRS2.Infrastructure.Queries._State
{
    public class GetStateQuery : IGetStateQuery
    {
        private readonly CityStateCountryDbContext dbContext;
        private readonly IMapper mapper;

        public GetStateQuery(CityStateCountryDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
        public IList<StateDto> GetAllStateAsync()
        {
            return mapper.Map<IList<StateDto>>(dbContext.States.ToList());
            /* return dbContext.States.Include(state => state.Country).Select(state => new StateDto()
             {
                 Id = state.Id,
                 Name = state.Name,
                 Code = state.Code,
                 CountryId = state.CountryId,
                *//* Country = new CountryDto()
                 {
                     Name = state.Country.Name,
                     Code = state.Country.Code
                 }*//*

             }).ToList();*/
        }

        public StateDto GetStateByIdAsync(int id)
        {
            return mapper.Map<StateDto>(dbContext.States.FirstOrDefault(S => S.Id == id));
        }
    }
}
