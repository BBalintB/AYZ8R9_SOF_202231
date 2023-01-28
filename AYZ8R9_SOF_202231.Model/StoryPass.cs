using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AYZ8R9_SOF_202231.Model
{
    public class StoryPass
    {
        public Sprint Sprint { get; set; }
        public IEnumerable<UserStory> Stories { get; set; }
    }
}
