using Application.Property.Interfaces;
using Application.Response;
using Application.Response.Model;
using Domain.Entities;
using Infrastructure.Interfaces;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class Facade : IFacade
    {
        private readonly IRepository _repository = new PropertyRepository();

        public BaseResponse GetPropertyCatalog()
        {
            return new Application.Property.RequestHandler(_repository).GetPropertyCatalog();
        }
    }
}
