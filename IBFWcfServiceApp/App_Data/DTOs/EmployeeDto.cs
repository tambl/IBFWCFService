using System.Runtime.Serialization;

namespace IBFWCFService.Models
{
    [DataContract]
    public class EmployeeDto
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public int? positionid { get; set; }
        [DataMember]
        public string fname { get; set; }
        [DataMember]
        public string lname { get; set; }
        [DataMember]
        public string idn { get; set; }//პირადი ნომერი
        [DataMember]
        public string phone { get; set; }//საკონტაქტო ნომერი
        [DataMember]
        public string loginid { get; set; }//სარეგისტრაციო სახელი

    }
}