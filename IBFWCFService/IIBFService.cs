using IBFWCFService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace IBFWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IIBFService
    {
        //[OperationContract]
        //[WebInvoke(Method = "GET", UriTemplate = "policies/{id}", ResponseFormat = WebMessageFormat.Json)]
        //[WebInvoke(Method = "GET", UriTemplate = "policies/{ids}/{isConfirmed}/{startDate}/{endDate}/{count}", ResponseFormat = WebMessageFormat.Json)]
        //List<Person> GetData(string ids, string isConfirmed, string startDate, string endDate, string count);


        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "policies/{ids}/{isConfirmed}/{startDate}/{endDate}/{count}", ResponseFormat = WebMessageFormat.Json)]
        List<Person> GetPolicies(string ids, string isConfirmed, string startDate, string endDate, string count);


    }
}
