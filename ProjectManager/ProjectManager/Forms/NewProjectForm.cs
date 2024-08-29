using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager.Forms
{
    public partial class NewProjectForm : Form
    {
        public NewProjectForm()
        {
            InitializeComponent();
            CreateProject_btn.Enabled = false;
        }

        private void ProjectName_tb_TextChanged(object sender, EventArgs e)
        {
            if (Program.ProjectHandlerInstance.projects.ContainsKey(ProjectName_tb.Text) ||
                ProjectName_tb.Text is null or "")
            {
                CreateProject_btn.Enabled = false;
                ProjectName_tb.ForeColor = Color.Red;
            }
            else
            {
                CreateProject_btn.Enabled = true;
                ProjectName_tb.ForeColor = Color.Black;
            }
        }

        private void ProjectDescription_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateProject_btn_Click(object sender, EventArgs e)
        {
            string projectDir = Path.Combine(Program.ProjectHandlerInstance.projectsDir, ProjectName_tb.Text);
            Program.ProjectHandlerInstance.CreateNewProject(ProjectName_tb.Text, ProjectDescription_tb.Text, projectDir);

            Close();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
