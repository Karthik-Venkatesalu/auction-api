using Application.DTO;
using Application.Property.Interfaces;
using Application.Response.Model;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Application.Property
{
    public class RequestHandler : IPropertyRequestHandler
    {
        private readonly IRepository _repository;

        public RequestHandler(IRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException("repository");
        }

        public Response<List<Domain.Entities.Property>> GetPropertyCatalog()
        {
            PropertyCatalog propertyCatalog = _repository.GetPropertyCatalog();
            return Response.Factory.CreateSuccessResponse(propertyCatalog.Properties);
        }
    }
}
