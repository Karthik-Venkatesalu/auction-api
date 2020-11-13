﻿using Application.Response.Model;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Interfaces
{
    public interface IFacade
    {
        BaseResponse GetPropertyCatalog();
    }
}
