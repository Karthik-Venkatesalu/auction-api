﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Application.Property.Interfaces
{
    public interface IRepository
    {
        PropertyCatalog GetPropertyCatalog();

        Domain.Entities.Property AddProperty(Domain.Entities.Property property);
        Domain.Entities.Property GetProperty(int propertyID);
    }
}
