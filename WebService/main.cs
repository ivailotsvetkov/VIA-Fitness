using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.Web;

namespace WebService
{
    public class main
    {
        static void Main(string[] args)
        {
            WebServiceHost host = new WebServiceHost(typeof(Service), new Uri("http://localhost:8000/"));
            ServiceEndpoint ep = host.AddServiceEndpoint(typeof(IService), new WebHttpBinding(), "");
            host.Open();
            using (ChannelFactory<IService> cf =
                new ChannelFactory<IService>(new WebHttpBinding(), "http://localhost:8000"))
            {
                cf.Endpoint.Behaviors.Add(new WebHttpBehavior());
                IService channel = cf.CreateChannel();
                string s;
                s = channel.GetUsers();
            }
                host.Close();
        }
    }
}
