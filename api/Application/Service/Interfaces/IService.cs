using Application.Service.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Service.Interfaces
{
    public interface IService
    {
        WinningBidData Execute(int eventID);
    }
}
