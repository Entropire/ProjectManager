using ProjectManager.Objects;

namespace ProjectManager.Forms
{
    public partial class ProjectsView : Form
    {
        public ProjectsView()
        {
            InitializeComponent();

            Program.ProjectHandlerInstance.OnProjectListChange += UpdateProjectsList;

            foreach (Project project in Program.ProjectHandlerInstance.projects.Values)
            {
                AddProjectToList(project);
            }
        }

        private void UpdateProjectsList(bool added, Project project)
        {
            if (added)
            {
                AddProjectToList(project);
            }
            else
            {
                Button newButton = new Button();
                newButton.Text = project.name;

                ProjectList_flp.Controls.Remove(newButton);
            }
        }

        private void AddProjectToList(Project project)
        {
            Button newButton = new Button();
            newButton.Text = project.name;

            newButton.Click += (object sender, EventArgs e) =>
            {
                Button clickedButton = (Button)sender;

                Project project = Program.ProjectHandlerInstance.projects[clickedButton.Text];

                ProjectForm projectForm = new ProjectForm(project);

                Program.UpdateForm(projectForm);
            };

            ProjectList_flp.Controls.Add(newButton);
        }
    }
}
