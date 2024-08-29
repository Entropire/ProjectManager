using ProjectManager.Objects;
using System.Text.Json;

namespace ProjectManager
{
    internal class ProjectHandler
    {
        public Action<bool, Project>? OnProjectListChange;

        internal Dictionary<string, Project> projects = new Dictionary<string, Project>();

        internal string? projectsDir;

        public ProjectHandler()
        {
            projectsDir = Path.Combine(Directory.GetCurrentDirectory(), "Projects");

            if (!Directory.Exists(projectsDir))
            {
                Directory.CreateDirectory(projectsDir);
            }

            LoadProjects();
        }

        private void LoadProjects()
        {
            string[] projectdirs = Directory.GetDirectories(projectsDir);

            foreach (string dir in projectdirs)
            {
                string jsonString = File.ReadAllText(Path.Combine(dir, "info.json"));
                Project project = JsonSerializer.Deserialize<Project>(jsonString);

                if (project != null)  
                {
                    projects.Add(project.name, project);
                }
            }
        }

        internal void CreateNewProject(string name, string description, string location)
        {
            Project newProject = new(name, description, location);

            if (!Directory.Exists(location))
            {
                Directory.CreateDirectory(location);
            }

            string jsonString = JsonSerializer.Serialize(newProject);
            File.WriteAllText(Path.Combine(location, "info.json"), jsonString);

            projects.Add(name, newProject);

            OnProjectListChange?.Invoke(true, newProject);
        }

        internal void DeleteProject(Project project)
        {
            Directory.Delete(project.location, true);
            projects.Remove(project.name);
        }
    }
}
