using System;
using System.ComponentModel.DataAnnotations;

namespace Envoy.CustomRegistrar.Core.Models
{
    public class User
    {
        public virtual int Id { get; protected internal  set; }
        [Required]
        [Display(Name = "First Name")]
        public virtual String FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public virtual String LastName { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public virtual  String Email { get; set; }

        [Required]
        [Display(Name = "Address Line 1")]
        public virtual String AddressLine1 { get; set; }
        [Required]
        [Display(Name = "Address Line 2")]
        public virtual String AddressLine2 { get; set; }
        [Required]
        public virtual String Postcode { get; set; }
    }
}