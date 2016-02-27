using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Toman296Lab6.Models
{
    public class Member : IdentityUser
    {      
        /*public int MemberID { get; set; }
        [Required]
        [StringLength(12, MinimumLength =6)]
        [Display(Name ="Posting member: ")]
        public string MemberUName { get; set; }
        [RegularExpression(@"^[a-z0-9][-a-z0-9.!#$%&'*+-=?^_`{|}~\/]+@([-a-z0-9]+\.)+[a-z]{2,5}$")]
        public string MemberEmail { get; set; }*/
    }
}