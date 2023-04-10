using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using webanthuc.Migrations;

namespace webanthuc.Model
{
    public class informationUser
    {
     
        public List<string>  roleName { get; set; }
     
        public string Name { get; set; }
            
        public string id { get; set; }
    }
}
