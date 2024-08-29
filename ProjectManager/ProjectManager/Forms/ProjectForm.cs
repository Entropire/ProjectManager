using ProjectManager.Objects;

namespace ProjectManager.Forms
{
    public partial class ProjectForm : Form
    {
        private Project? project;

        public ProjectForm(Project project)
        {
            this.project = project;

            InitializeComponent();

            ProjectName_l.Text = this.project.name;
        }

        private void Return_btn_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            Program.UpdateForm(mainMenuForm);
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            Program.ProjectHandlerInstance.DeleteProject(project);
            MainMenuForm mainMenuForm = new MainMenuForm();
            Program.UpdateForm(mainMenuForm);
        }
    }
}
