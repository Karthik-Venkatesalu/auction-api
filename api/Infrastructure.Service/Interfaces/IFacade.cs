using Domain.Entities;
using Service.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface IFacade
    {
        List<Document<PropertyCatalog>> GetProperties();
    }
}
