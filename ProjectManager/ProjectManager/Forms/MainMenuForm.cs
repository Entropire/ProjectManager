namespace ProjectManager.Forms
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();

            Form childForm = new ProjectsView();

            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;

            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(childForm);

            childForm.Show();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Projects_btn_Click(object sender, EventArgs e)
        {
            Form childForm = new ProjectsView();

            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;

            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(childForm);

            childForm.Show();
        }

        private void NewProject_btn_Click(object sender, EventArgs e)
        {
            Form newForm = new NewProjectForm();

            newForm.TopLevel = true;

            newForm.Show();
        }
    }
}
