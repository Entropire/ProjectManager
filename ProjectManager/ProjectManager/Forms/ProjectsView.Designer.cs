namespace ProjectManager.Forms
{
    partial class ProjectsView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Search_tb = new TextBox();
            Language_cb = new ComboBox();
            Tag_cb = new ComboBox();
            ProjectList_flp = new FlowLayoutPanel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // Search_tb
            // 
            Search_tb.Location = new Point(12, 13);
            Search_tb.Name = "Search_tb";
            Search_tb.Size = new Size(462, 27);
            Search_tb.TabIndex = 0;
            // 
            // Language_cb
            // 
            Language_cb.FormattingEnabled = true;
            Language_cb.Location = new Point(480, 12);
            Language_cb.Name = "Language_cb";
            Language_cb.Size = new Size(151, 28);
            Language_cb.TabIndex = 1;
            // 
            // Tag_cb
            // 
            Tag_cb.FormattingEnabled = true;
            Tag_cb.Location = new Point(637, 12);
            Tag_cb.Name = "Tag_cb";
            Tag_cb.Size = new Size(151, 28);
            Tag_cb.TabIndex = 2;
            // 
            // ProjectList_flp
            // 
            ProjectList_flp.Location = new Point(12, 46);
            ProjectList_flp.Name = "ProjectList_flp";
            ProjectList_flp.Size = new Size(776, 392);
            ProjectList_flp.TabIndex = 3;
            // 
            // ProjectsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ProjectList_flp);
            Controls.Add(Tag_cb);
            Controls.Add(Language_cb);
            Controls.Add(Search_tb);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProjectsView";
            Text = "ProjectsView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Search_tb;
        private ComboBox Language_cb;
        private ComboBox Tag_cb;
        private FlowLayoutPanel ProjectList_flp;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}