using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserServiceBase
{
    public interface IOperationDetails
    {
        bool Succedeed { get; }
        string Message { get; }
        string Property { get; }
    }
}
