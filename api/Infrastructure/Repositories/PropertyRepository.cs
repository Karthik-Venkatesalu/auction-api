using Application.Property.Interfaces;
using Domain.Entities;
using System;
using System.Collections.ObjectModel;

namespace Infrastructure.Repositories
{
    public class PropertyRepository : IRepository
    {
        private PropertyCatalog _propertyCatalog = new PropertyCatalog();

        public PropertyRepository()
        {
            _propertyCatalog.Properties = new System.Collections.Generic.List<Property>()
            {
                new Property("Rock Homes, London", 1, 1, 1000),
                new Property("Sky Villa, Leeds", 2, 2, 1000),
                new Property("Hacker Estate, Manchester", 3, 3, 1000)
            };
        }

        public PropertyCatalog GetPropertyCatalog()
        {
            return _propertyCatalog;
        }
    }
}
