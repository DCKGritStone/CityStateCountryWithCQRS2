﻿using AutoMapper;
using CityStateCountryWithCQRS2.Application.Dto;
using CityStateCountryWithCQRS2.Domain.Entity;

namespace CityStateCountryWithCQRS2.Application.Common.Mapping
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<City, CityDto>().ReverseMap();
            CreateMap<State, StateDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
        }
        /*public AutoMapping()
        {
            ApplyMappingFromAssembly(Assembly.GetExecutingAssembly());
        }

        private void ApplyMappingFromAssembly(Assembly assembly)
        {
            var mapFromType = typeof(IMapFrom<>);
            var mappingMethodName = nameof(IMapFrom<object>.Mapping);
            bool HasInterface(Type t) => t.IsGenericType && t.GetGenericTypeDefinition() == mapFromType;

            var types = assembly.GetExportedTypes().Where(t => t.GetInterfaces().Any(HasInterface)).ToList();

            var argumentTypes = new Type[] { typeof(Profile) };

            foreach ( var type in types)
            {
                var instance = Activator.CreateInstance(type);
                var methodInfo = type.GetMethod(mappingMethodName);
                if ( methodInfo != null )
                {
                   methodInfo.Invoke(instance, new object[] {this});
                }
                else
                {
                    var interfaces = type.GetInterfaces().Where(HasInterface).ToList();
                    if ( interfaces.Count > 0 )
                    {
                        foreach (var @interface in interfaces)
                        {
                            var interfaceMethodInfo= @interface.GetMethod(mappingMethodName, argumentTypes);

                            interfaceMethodInfo?.Invoke(instance, new object[] {this});
                        }
                    }
                }
            }
        }*/
    }
}
