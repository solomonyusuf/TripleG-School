using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TripleG.Shared.Models
{
    public class ParentInfo

    {
        [Key]
        [Required]
        [JsonProperty("parentId")]
        public Guid ParentId { get; set; }
        public Guid StudentId { get; set; }
        [StringLength(50)]
        [JsonProperty("parentName")]
        public string ParentName { get; set; }
        [StringLength(50)]
        [JsonProperty("email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [StringLength(15)]
        [JsonProperty("occupation")]
        public string Occupation { get; set; }
        [StringLength(12)]
        [JsonProperty("city")]
        public string City { get; set; }
        [DataType(DataType.PhoneNumber)]
        [JsonProperty("phoneNumber_1")]
        [StringLength(15)]
        public string PhoneNumber_1 { get; set; }
        [DataType(DataType.PhoneNumber)]
        [StringLength(15)]
        [JsonProperty("phoneNumber_2")]
        public string PhoneNumber_2 { get; set; }
        [StringLength(50)]
        [JsonProperty("address_1")]
        public string Address_1 { get; set; }
        [StringLength(50)]
        [JsonProperty("address_2")]
        public string Address_2 { get; set; }

    }
}
