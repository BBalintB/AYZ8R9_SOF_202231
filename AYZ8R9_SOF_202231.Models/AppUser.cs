using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AYZ8R9_SOF_202231.Models
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
        public virtual ICollection<Project> WorkingProjects{ get; set; }

        public AppUser()
        {
            WorkingProjects = new HashSet<Project>();
        }
    }
}
