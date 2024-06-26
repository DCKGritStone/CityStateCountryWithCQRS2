﻿using MediatR;

namespace CityStateCountryWithCQRS2.Application.Command._Country.UpdateCountry
{
    public class UpdateCountryCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double? Code { get; set; }
    }
}
