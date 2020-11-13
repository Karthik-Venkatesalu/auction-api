using Application.Property.Interfaces;
using Domain.Entities;
using System;
using System.Collections.ObjectModel;
using System.Linq;

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

        public Property AddProperty(Property property)
        {
            var newProperty = new Property(property.Name, new Random().Next(), property.OwnerID, property.BasePrice);
            _propertyCatalog.Properties.Add(newProperty);
            return newProperty;
        }

        public PropertyCatalog GetPropertyCatalog()
        {
            return _propertyCatalog;
        }

        public Domain.Entities.Property GetProperty(int propertyID)
        {
            return _propertyCatalog.Properties.FirstOrDefault(p => p.ID == propertyID);
        }
    }
}
