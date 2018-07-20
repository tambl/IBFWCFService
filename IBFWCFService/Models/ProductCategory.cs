using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IBFWCFService.Models
{
    [DataContract]
    public class ProductCategory
    {
        [DataMember]
        public int ProductCategoryId { get; set; }
        [DataMember] //ე.წ. IBF კოდი
        public string ProductCategoryName { get; set; }
        [DataMember]
        public int ProductTypeId { get; set; }
        [DataMember] // პროდუქტის ტიპის აიდი IBF კოდი
        public string ProductTypeName { get; set; } // პროდუქტის ტიპის დასახელება
    }

}
