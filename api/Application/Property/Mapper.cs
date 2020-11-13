using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Property
{
    public static class Mapper
    {
        public static Domain.Entities.Property MapToDomain(this Dto.Model.Property property)
        {
            return new Domain.Entities.Property(
                property.Name,
                property.ID,
                property.OwnerID,
                property.BasePrice);
        }

        public static Dto.Model.Property MapToDto(this Domain.Entities.Property property)
        {
            return new Dto.Model.Property()
            {
                BasePrice = property.BasePrice,
                Name = property.Name,
                ID = property.ID,
                OwnerID = property.OwnerID
            };
        }
    }
}
