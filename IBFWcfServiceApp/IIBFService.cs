using IBFWCFService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace IBFWcfServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IIBFService
    {

        //[OperationContract]
        //[WebGet( UriTemplate = "policies/?id={ids}&isConfirmed={isConfirmed}&startDate={startDate}&endDate={endDate}&count={count}", ResponseFormat = WebMessageFormat.Json)]
        //[WebInvoke(Method = "GET", UriTemplate = "policies/?id={ids}&isConfirmed={isConfirmed}&startDate={startDate}&endDate={endDate}&count={count}",
        //    RequestFormat = WebMessageFormat.Json,
        //    ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        ////http://localhost:8732/IBFService/policies/?id=1&id=2&isConfirmed=true&startDate=01-01-2013&endDate=01-02-2013&count=5
        //List<PersonDto> GetPolicies(string ids, string isConfirmed, string startDate, string endDate, string count);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "policies/?id={ids}&isConfirmed={isConfirmed}&startDate={startDate}&endDate={endDate}&count={count}&versionId={versionIds}&policyNumber={policyNumber}&clientId={clientIds}", ResponseFormat = WebMessageFormat.Json)]
        //http://localhost:8732/IBFService.svc/policies/?id=1&id=2&isConfirmed=true&startDate=01-01-2013&endDate=01-02-2013&count=5
        List<PolicyDto> GetPolicies(string ids, string isConfirmed, string startDate, string endDate, string count, string versionIds, string policyNumber, string clientIds);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "policies/?id={ids}", ResponseFormat = WebMessageFormat.Json)]
        //http://localhost:8732/IBFService.svc/policies/?id=1&id=2
        //HttpResponseMessage UpdatePolicyVersionSyncDate(string ids);
        bool UpdatePolicyVersionSyncDate(string ids);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "transfers/?id={ids}&isConfirmed={isConfirmed}&startDate={startDate}&endDate={endDate}&clientId={clientIds}&bankAccounts={bankAccounts}&count={count}", ResponseFormat = WebMessageFormat.Json)]
        //http://localhost:8732/IBFService.svc/transfers/?id=1&id=2&isConfirmed=true&startDate=01-01-2013&endDate=01-02-2013&count=5
        List<TransferDto> GetTransfers(string ids, string isConfirmed, string startDate, string endDate, string clientIds, string bankAccounts, string count);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "transfers/?id={ids}", ResponseFormat = WebMessageFormat.Json)]
        //http://localhost:8732/IBFService.svc/transfers/?id=1&id=2
        bool UpdateTransfersSyncDate(string ids);

    }


}
