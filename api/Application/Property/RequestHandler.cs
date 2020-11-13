using Application.Property.Interfaces;
using Application.Dto.Request;
using Application.Dto.Response.Model;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Application.Property
{
    public class RequestHandler : IPropertyRequestHandler
    {
        private readonly IRepository _repository;

        public RequestHandler(IRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException("repository");
        }

        public Response<Dto.Model.Property> AddProperty(Request<Dto.Model.Property> propertyRequest)
        {
            var newProperty = _repository
                .AddProperty(propertyRequest.Data.MapToDomain())
                .MapToDto();

            return Response.Builder.BuildSuccessResponse(newProperty);
        }

        public Response<IEnumerable<Dto.Model.Property>> GetPropertyCatalog()
        {
            PropertyCatalog propertyCatalog = _repository.GetPropertyCatalog();
            return Response.Builder.BuildSuccessResponse(propertyCatalog.Properties.Select(p => p.MapToDto()));
        }
    }
}
