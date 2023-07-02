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
    
    public class Project
    {
        private string usid = "";
        [Key]
        [Required]
        public string ProjectId {
            get { return usid; }
            set
            {
                if (value != null)
                {
                    usid = value;
                }
            }
        }
        [Required]
        [StringLength(20,ErrorMessage ="The project name has to be shorter than 20 characters")]
        public string ProjectName { get; set; }

        [ForeignKey(nameof(AppUser))]
        public string OwnerId { get; set; }

        [NotMapped]
        public virtual AppUser? Owner { get; set; }
        [NotMapped]
        public virtual ICollection<ProjectAppUser> ProjectUsers { get; set; }

        [NotMapped]
        public virtual ICollection<Sprint> ProjectSprints{ get; set; }

        public Project()
        {
            usid = Guid.NewGuid().ToString();
            ProjectUsers = new HashSet<ProjectAppUser>();
            ProjectSprints= new HashSet<Sprint>();
        }
    }
}
