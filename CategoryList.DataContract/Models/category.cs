using System;
using System.Collections.Generic;

#nullable disable

namespace CategoryList.DataContract.Models
{
    public partial class category
    {
        public int Id { get; set; }
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? DisplayOrder { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
