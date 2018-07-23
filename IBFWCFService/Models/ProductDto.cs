using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IBFWCFService.Models
{
    [DataContract]
    public class ProductDto
    {
        [DataMember]
        public int ProductId { get; set; }
        [DataMember] //ე.წ. IBF კოდი
        public string ProductName { get; set; }
        [DataMember]
        public ProductCategoryDto ProductCategory { get; set; }  // პროდუქტის კატეგორიის ობიექტი
    }


}
