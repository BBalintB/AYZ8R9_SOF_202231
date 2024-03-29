﻿using System;
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
        private string usid = "";
        [Key]
        [Required]
        public string SprintId {
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
        [StringLength(20,ErrorMessage = "The name of the sprint has to be less then 20 character")]
        public string SprintName { get; set; }
        [Required]
        [MinLength(8,ErrorMessage = "The date has to be minimum 8 character long")]
        [MaxLength(10,ErrorMessage = "The date can't be longer than 10 charcter")]
        
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
            usid = Guid.NewGuid().ToString();
            UserStories = new HashSet<UserStory>();
        }

    }
}
