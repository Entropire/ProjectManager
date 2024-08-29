namespace ProjectManager.Forms
{
    partial class NewProjectForm
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
            ProjectName_tb = new TextBox();
            ProjectDescription_tb = new TextBox();
            ProjectName_l = new Label();
            ProjectDescription_l = new Label();
            CreateProject_btn = new Button();
            Cancel_btn = new Button();
            SuspendLayout();
            // 
            // ProjectName_tb
            // 
            ProjectName_tb.ForeColor = SystemColors.InfoText;
            ProjectName_tb.Location = new Point(319, 85);
            ProjectName_tb.Name = "ProjectName_tb";
            ProjectName_tb.Size = new Size(125, 27);
            ProjectName_tb.TabIndex = 0;
            ProjectName_tb.TextChanged += ProjectName_tb_TextChanged;
            // 
            // ProjectDescription_tb
            // 
            ProjectDescription_tb.Location = new Point(276, 138);
            ProjectDescription_tb.Multiline = true;
            ProjectDescription_tb.Name = "ProjectDescription_tb";
            ProjectDescription_tb.Size = new Size(235, 128);
            ProjectDescription_tb.TabIndex = 1;
            ProjectDescription_tb.TextChanged += ProjectDescription_tb_TextChanged;
            // 
            // ProjectName_l
            // 
            ProjectName_l.AutoSize = true;
            ProjectName_l.Location = new Point(321, 62);
            ProjectName_l.Name = "ProjectName_l";
            ProjectName_l.Size = new Size(96, 20);
            ProjectName_l.TabIndex = 2;
            ProjectName_l.Text = "Project name";
            // 
            // ProjectDescription_l
            // 
            ProjectDescription_l.AutoSize = true;
            ProjectDescription_l.Location = new Point(319, 115);
            ProjectDescription_l.Name = "ProjectDescription_l";
            ProjectDescription_l.Size = new Size(133, 20);
            ProjectDescription_l.TabIndex = 3;
            ProjectDescription_l.Text = "Project description";
            // 
            // CreateProject_btn
            // 
            CreateProject_btn.Location = new Point(350, 272);
            CreateProject_btn.Name = "CreateProject_btn";
            CreateProject_btn.Size = new Size(94, 29);
            CreateProject_btn.TabIndex = 4;
            CreateProject_btn.Text = "Create";
            CreateProject_btn.UseVisualStyleBackColor = true;
            CreateProject_btn.Click += CreateProject_btn_Click;
            // 
            // Cancel_btn
            // 
            Cancel_btn.Location = new Point(350, 307);
            Cancel_btn.Name = "Cancel_btn";
            Cancel_btn.Size = new Size(94, 29);
            Cancel_btn.TabIndex = 5;
            Cancel_btn.Text = "Cancel";
            Cancel_btn.UseVisualStyleBackColor = true;
            Cancel_btn.Click += Cancel_btn_Click;
            // 
            // NewProjectForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Cancel_btn);
            Controls.Add(CreateProject_btn);
            Controls.Add(ProjectDescription_l);
            Controls.Add(ProjectName_l);
            Controls.Add(ProjectDescription_tb);
            Controls.Add(ProjectName_tb);
            Name = "NewProjectForm";
            Text = "NewProjectForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ProjectName_tb;
        private TextBox ProjectDescription_tb;
        private Label ProjectName_l;
        private Label ProjectDescription_l;
        private Button CreateProject_btn;
        private Button Cancel_btn;
    }
}