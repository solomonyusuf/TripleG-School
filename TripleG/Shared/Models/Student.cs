using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TripleG.Shared.Models
{
    public class Student
    {
        [Key]
        [Required]
        [JsonProperty("studentId")]
        public Guid StudentId { get; set; }
        public string ResultId { get; set; }
        public string ImgPath { get; set; }
        [JsonProperty("parentId")]
        public string ParentId { get; set; }
        [StringLength(30)]
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        [StringLength(20)]
        [JsonProperty("lastName")]
        public string LastName { get; set; }
        [StringLength(20)]
        [JsonProperty("middleName")]
        public string MiddleName { get; set; }
        [StringLength(20)]
        [JsonProperty("class")]
        public string Class { get; set; }
        [StringLength(10)]
        [JsonProperty("sex")]
        public string Sex { get; set; }
        [StringLength(20)]
        [JsonProperty("dOB")]
        public string DOB { get; set; }
        [StringLength(10)]
        [JsonProperty("originState")]
        public string OriginState { get; set; }
        [JsonProperty("parent")]
        public ICollection<ParentInfo> Parent { get; }
        [JsonProperty("totalResult")]
        public int TotalResult { get; }
        [JsonProperty("timeStamp")]
        public DateTime TimeStamp { get; set; }


        public Student()
        {
            Parent = new List<ParentInfo>();

            TimeStamp = DateTime.Now;
        }
    }
}
