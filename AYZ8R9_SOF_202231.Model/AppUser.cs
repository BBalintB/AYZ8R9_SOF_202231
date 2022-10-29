using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AYZ8R9_SOF_202231.Model
{
    public class AppUser:IdentityUser
    {
        [StringLength(100)]
        [Required]
        public string FirstName { get; set; }
        [StringLength(100)]
        [Required]
        public string LastName { get; set; }
        [StringLength(100)]
        public string? PhotoContentType { get; set; }
        public byte[]? PhotoData { get; set; }

        [NotMapped]
        [JsonIgnore]
        public virtual ICollection<ProjectAppUser> WorkingProjects{ get; set; }



        public AppUser()
        {
            WorkingProjects = new HashSet<ProjectAppUser>();
        }
    }
}
