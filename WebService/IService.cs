using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace WebService
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        [WebGet]
        string GetUsers();

    }
}
