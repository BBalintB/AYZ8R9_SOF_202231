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
    public class Sprint
    {
        [Key]
        [Required]
        public string SprintId { get; set; }
        [Required]
        public string SprintName { get; set; }
        [Required]
        public string SprintDueDate { get; set; }
        [ForeignKey(nameof(Project))]
        public string? ProjectId { get; set; }
        [NotMapped]
        [JsonIgnore]
        public virtual Project? Project { get; set; }

        [NotMapped]
        [JsonIgnore]
        public virtual ICollection<UserStory> UserStories { get; set; }

        public Sprint()
        {
            SprintId = Guid.NewGuid().ToString();
            UserStories = new HashSet<UserStory>();
        }

    }
}
