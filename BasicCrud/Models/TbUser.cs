using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BasicCrud.Models
{
    public partial class TbUser
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required!")]
        public string NmName { get; set; }
        [Required(ErrorMessage = "Email is required!")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Invalid email address!")]
        public string DsEmail { get; set; }
    }
}
