using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using webanthuc.Entity;
using webanthuc.Model;

namespace webanthuc.Response
{
    public class AccountInformation
    {
        [Required]
        public string token {  get; set; }
        public informationUser user { get; set; }
       
    }
}
