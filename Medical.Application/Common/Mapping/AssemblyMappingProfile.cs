﻿using AutoMapper;
using System.Reflection;

namespace Medical.Application.Common.Mapping
{
    public class AssemblyMappingProfile : Profile
    {
        public AssemblyMappingProfile(Assembly assembly)
        {
            ApplyMappingsFromAssembly(assembly);
        }

        private void ApplyMappingsFromAssembly(Assembly assembly)
        {
            List<Type>? types = assembly.GetExportedTypes()
                .Where(type => type.GetInterfaces()
                .Any(i => i.IsGenericType && i
                .GetGenericTypeDefinition() == typeof(IMapWidth<>)))
                .ToList();

            foreach (var type in types)
            {
                var instance = Activator.CreateInstance(type );
                var methodInfo = type.GetMethod("Mapping");
                methodInfo?.Invoke(instance, new object[] { this });
            }
        }
    }
}
