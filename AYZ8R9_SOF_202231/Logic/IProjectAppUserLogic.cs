﻿using AYZ8R9_SOF_202231.Model;

namespace AYZ8R9_SOF_202231.Logic
{
    public interface IProjectAppUserLogic
    {
        void CreatePA(ProjectAppUser newPA);
        void DeletePA(string projectId, string userId);
        IEnumerable<ProjectAppUser> GetAllPA();
        ProjectAppUser GetOnePA(string id);
    }
}