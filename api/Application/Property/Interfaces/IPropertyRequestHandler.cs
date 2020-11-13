using Application.Dto.Response.Model;
using Application.Dto.Request;
using System.Collections.Generic;

namespace Application.Property.Interfaces
{
    public interface IPropertyRequestHandler
    {
        Response<IEnumerable<Dto.Model.Property>> GetPropertyCatalog();
        Response<Dto.Model.Property> AddProperty(Request<Dto.Model.Property> propertyRequest);
    }
}