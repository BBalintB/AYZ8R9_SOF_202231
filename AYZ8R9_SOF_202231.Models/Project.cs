using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AYZ8R9_SOF_202231.Models
{
    public class Project
    {
        [Key]
        [Required]
        public string ProjectId { get; set; }
        [Required]
        public string ProjectName { get; set; }

        [ForeignKey(nameof(AppUser))]
        public string? OwnerId { get; set; }

        [NotMapped]
        public virtual AppUser? Owner { get; set; }
        [NotMapped]
        [JsonIgnore]
        public virtual ICollection<AppUser> ProjectUsers { get; set; }

        public Project()
        {
            ProjectId = Guid.NewGuid().ToString();
            ProjectUsers = new HashSet<AppUser>();
        }
    }
}
