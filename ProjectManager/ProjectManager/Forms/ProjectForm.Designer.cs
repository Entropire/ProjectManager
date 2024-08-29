namespace ProjectManager.Forms
{
    partial class ProjectForm
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
            ProjectName_l = new Label();
            Delete_btn = new Button();
            Return_btn = new Button();
            SuspendLayout();
            // 
            // ProjectName_l
            // 
            ProjectName_l.AutoSize = true;
            ProjectName_l.Location = new Point(329, 62);
            ProjectName_l.Name = "ProjectName_l";
            ProjectName_l.Size = new Size(96, 20);
            ProjectName_l.TabIndex = 0;
            ProjectName_l.Text = "Project name";
            ProjectName_l.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Delete_btn
            // 
            Delete_btn.Location = new Point(331, 180);
            Delete_btn.Name = "Delete_btn";
            Delete_btn.Size = new Size(94, 29);
            Delete_btn.TabIndex = 1;
            Delete_btn.Text = "Delete";
            Delete_btn.UseVisualStyleBackColor = true;
            Delete_btn.Click += Delete_btn_Click;
            // 
            // Return_btn
            // 
            Return_btn.Location = new Point(329, 226);
            Return_btn.Name = "Return_btn";
            Return_btn.Size = new Size(94, 29);
            Return_btn.TabIndex = 2;
            Return_btn.Text = "return";
            Return_btn.UseVisualStyleBackColor = true;
            Return_btn.Click += Return_btn_Click;
            // 
            // ProjectForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Return_btn);
            Controls.Add(Delete_btn);
            Controls.Add(ProjectName_l);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProjectForm";
            Text = "ProjectForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ProjectName_l;
        private Button Delete_btn;
        private Button Return_btn;
    }
}