using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FBC.Business.Models
{
    public class Family
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string FamilyName { get; set; }
        
        [MaxLength(100)]
        public string Address { get; set; }
        
        [MaxLength(20)]
        public string Phone { get; set; }
        
        [MaxLength(1000)]
        public string Description { get; set; }
        
        public List<ContactInfo> ContactInfo { get; set; }
    }
}
