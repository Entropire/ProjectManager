namespace ProjectManager.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Program.UpdateForm += ShowForm;

            MainMenuForm mainMenuForm = new MainMenuForm();
            ShowForm(mainMenuForm);
        }

        private void ShowForm(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            Content_p.Controls.Clear();
            Content_p.Controls.Add(form);

            form.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Content_p_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
