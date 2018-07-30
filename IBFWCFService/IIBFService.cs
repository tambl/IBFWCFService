using IBFWCFService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
        [WebInvoke(Method = "GET", UriTemplate = "policies/?id={ids}&isConfirmed={isConfirmed}&startDate={startDate}&endDate={endDate}&count={count}", ResponseFormat = WebMessageFormat.Json)]
        //http://localhost:8732/IBFService/policies/?id=1&id=2&isConfirmed=true&startDate=01-01-2013&endDate=01-02-2013&count=5
        List<PolicyDto> GetPolicies(string ids, string isConfirmed, string startDate, string endDate, string count);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "policies/?id={ids}", ResponseFormat = WebMessageFormat.Json)]
        //http://localhost:8732/IBFService/policies/?id=1&id=2
        //HttpResponseMessage UpdatePolicyVersionSyncDate(string ids);
        bool UpdatePolicyVersionSyncDate(string ids);
    }
}
