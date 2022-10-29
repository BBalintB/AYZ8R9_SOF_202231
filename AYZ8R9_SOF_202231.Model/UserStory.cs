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
    public enum UserStoryStatus { 
        Backlog,ToDo,In_Progress,Verify,Done
    }
    public class UserStory
    {
        [Key]
        public string UserStoryId { get; set; }
        [Required]
        public string UserStoryName { get; set; }
        [Required]
        public string UserStoryDescription{ get; set; }
        [Required]
        public UserStoryStatus Status { get; set; }
        [Required]
        public int UserStoryPriority { get; set; }
        [ForeignKey(nameof(Sprint))]
        public string? SprintId { get; set; }
        [NotMapped]
        [JsonIgnore]
        public virtual Sprint? Sprint{ get; set; }

        public UserStory()
        {
            UserStoryId = Guid.NewGuid().ToString();
            Status = UserStoryStatus.Backlog;
        }
    }
}
