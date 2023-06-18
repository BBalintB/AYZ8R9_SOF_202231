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
        private string usid = "";
        [Key]
        public string UserStoryId {
            get { return usid; }
            set { 
                if(value != null)
                { 
                    usid = value; 
                }
            }
        }
        [Required]
        [MaxLength(30,ErrorMessage = "The story name cant be longer then 30 characters!")]
        public string UserStoryName { get; set; }
        [Required]
        public string UserStoryDescription{ get; set; }
        [Required]
        public UserStoryStatus Status { get; set; }
        [Required]
        [Range(1,25,ErrorMessage = "The priority can't be smaler than 1 and can't be bigger than 25!")]
        public int UserStoryPriority { get; set; }
        [ForeignKey(nameof(Sprint))]
        public string? SprintId { get; set; }
        [NotMapped]
        [JsonIgnore]
        public virtual Sprint? Sprint{ get; set; }

        [ForeignKey(nameof(User))]
        public string? UserId { get; set; }
        [NotMapped]
        [JsonIgnore]
        public virtual AppUser? User { get; set; }

        public UserStory()
        {
            usid = Guid.NewGuid().ToString();
            Status = UserStoryStatus.Backlog;
        }
    }
}
