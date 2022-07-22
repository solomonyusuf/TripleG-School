using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TripleG.Shared.Models
{
    public class Staffs
    {
        [Key]
        [Required]
        public Guid id { get; set; }
        [StringLength(200)]
        public string ImgPath { get; set; }
        [StringLength(20)]
        public string FirstName { get; set; }
        [StringLength(20)]
        public string LastName { get; set; }
        [StringLength(20)]
        public string MiddleName { get; set; }
        [DataType(DataType.EmailAddress)]
        [StringLength(20)]
        public string Email { get; set; }
        [StringLength(30)]
        public string Address { get; set; }
        [StringLength(30)]
        public string Status { get; set; }
        [StringLength(30)]
        public string Subject { get; set; }
        [DataType(DataType.PhoneNumber)]
        [StringLength(15)]
        public string PhoneNumber { get; set; }
        [StringLength(15)]
        public string AccountNumber { get; set; }
        [StringLength(15)]
        public string Bank { get; set; }
        [StringLength(40)]
        public string Position { get; set; }
        [DataType(DataType.Date)]
        [StringLength(20)]
        public string DOB { get; set; }
        [StringLength(10)]
        public string OriginState { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime TimeStamp { get; set; }
        public Staffs()
        {
            TimeStamp = DateTime.Now;
        }

    }
}
