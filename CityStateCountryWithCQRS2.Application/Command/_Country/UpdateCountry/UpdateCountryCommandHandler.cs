﻿using CityStateCountryWithCQRS2.Domain;
using CityStateCountryWithCQRS2.Domain.Entity;
using MediatR;

namespace CityStateCountryWithCQRS2.Application.Command._Country.UpdateCountry
{
    public class UpdateCountryCommandHandler : IRequestHandler<UpdateCountryCommand, int>
    {
        private readonly IRepository Repository;

        public UpdateCountryCommandHandler(IRepository countryRepository)
        {
            this.Repository = countryRepository;
        }
        public async Task<int> Handle(UpdateCountryCommand request, CancellationToken cancellationToken)
        {
            var updateCountry = new Country
            {
                Id = request.Id,
                Name = request.Name,
                Code = request.Code
            };

            return await Repository.UpdateCountryAsync(request.Id, updateCountry);
        }
    }
}
