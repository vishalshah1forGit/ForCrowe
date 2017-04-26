using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Domain.Contract
{
    [ServiceContract]
    public interface IHelloWorldService
    {
        [OperationContract]
        string HelloWorld(string firstName);
    }
}
