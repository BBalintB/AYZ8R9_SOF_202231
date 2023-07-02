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
    public class ProjectAppUser
    {
        private string usid = "";
        [Key]
        public string ConnectionId {
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
        public string AppUserId { get; set; }
        [Required]
        public string ProjectId { get; set; }
        [NotMapped]
        [JsonIgnore]
        public virtual AppUser? User { get; set; }
        [NotMapped]
        [JsonIgnore]
        public virtual Project? Project { get; set; }
        public ProjectAppUser()
        {
           usid = Guid.NewGuid().ToString();
        }
    }
}
