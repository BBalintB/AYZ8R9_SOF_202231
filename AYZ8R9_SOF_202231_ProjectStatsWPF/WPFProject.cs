using AYZ8R9_SOF_202231.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AYZ8R9_SOF_202231_ProjectStatsWPF
{
    class WPFProject:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private string projectId;

        public string ProjectId
        {
            get { return projectId; }
            set { projectId = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Id")); }
        }


        private string projectName;

        public string ProjectName
        {
            get { return projectName; }
            set { projectName = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name")); }
        }

        private string ownerId;

        public string OwnerId
        {
            get { return ownerId; }
            set { ownerId = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OwnerId")); }
        }

        private AppUser owner;

        public AppUser Owner
        {
            get { return owner; }
            set { owner = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Owner")); }
        }

        private ICollection<AppUser> projectUsers;

        public ICollection<AppUser> ProjectUsers
        {
            get { return projectUsers; }
            set { projectUsers = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ProjectUsers")); }
        }

        private ICollection<AppUser> projectSprints;

        public ICollection<AppUser> ProjectSprints
        {
            get { return projectSprints; }
            set { projectSprints = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ProjectSprints")); }
        }


    }
}
