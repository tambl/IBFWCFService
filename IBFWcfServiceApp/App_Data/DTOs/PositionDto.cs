using System.Runtime.Serialization;

namespace IBFWCFService.Models
{
    [DataContract]
    public class PositionDto
    {
        [DataMember]
        public int positionid { get; set; }
       
        [DataMember]
        public string name { get; set; }// სახელი
    }
}