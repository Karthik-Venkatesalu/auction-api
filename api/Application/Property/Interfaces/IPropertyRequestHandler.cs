using Application.Response.Model;
using System.Collections.Generic;

namespace Application.Property.Interfaces
{
    public interface IPropertyRequestHandler
    {
        Response<List<Domain.Entities.Property>> GetPropertyCatalog();
    }
}