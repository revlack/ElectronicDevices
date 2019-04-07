using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EletronicDevicesApi.Interfaces
{
    public enum Status {
        Sucess,
        Error,
        Unauthorized,
        Aborted,
        Undefined
    }
    public interface IApiResponse
    {
        Status Status { get; set; }
        Object Response { get; set; }
    }
}
