namespace ProjectManager.Forms
{
    partial class MainMenuForm
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
            Projects_btn = new Button();
            Exit_btn = new Button();
            Settings_btn = new Button();
            NewProject_btn = new Button();
            ContentPanel = new Panel();
            SuspendLayout();
            // 
            // Projects_btn
            // 
            Projects_btn.Location = new Point(12, 12);
            Projects_btn.Name = "Projects_btn";
            Projects_btn.Size = new Size(94, 29);
            Projects_btn.TabIndex = 0;
            Projects_btn.Text = "Projects";
            Projects_btn.UseVisualStyleBackColor = true;
            Projects_btn.Click += Projects_btn_Click;
            // 
            // Exit_btn
            // 
            Exit_btn.Location = new Point(12, 509);
            Exit_btn.Name = "Exit_btn";
            Exit_btn.Size = new Size(94, 29);
            Exit_btn.TabIndex = 1;
            Exit_btn.Text = "Exit";
            Exit_btn.UseVisualStyleBackColor = true;
            Exit_btn.Click += Exit_btn_Click;
            // 
            // Settings_btn
            // 
            Settings_btn.Location = new Point(12, 474);
            Settings_btn.Name = "Settings_btn";
            Settings_btn.Size = new Size(94, 29);
            Settings_btn.TabIndex = 2;
            Settings_btn.Text = "Settings";
            Settings_btn.UseVisualStyleBackColor = true;
            // 
            // NewProject_btn
            // 
            NewProject_btn.Location = new Point(12, 439);
            NewProject_btn.Name = "NewProject_btn";
            NewProject_btn.Size = new Size(94, 29);
            NewProject_btn.TabIndex = 3;
            NewProject_btn.Text = "New";
            NewProject_btn.UseVisualStyleBackColor = true;
            NewProject_btn.Click += NewProject_btn_Click;
            // 
            // ContentPanel
            // 
            ContentPanel.Location = new Point(112, 12);
            ContentPanel.Margin = new Padding(0);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(896, 529);
            ContentPanel.TabIndex = 4;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 550);
            Controls.Add(ContentPanel);
            Controls.Add(NewProject_btn);
            Controls.Add(Settings_btn);
            Controls.Add(Exit_btn);
            Controls.Add(Projects_btn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainMenuForm";
            Text = "MainMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button Projects_btn;
        private Button Exit_btn;
        private Button Settings_btn;
        private Button NewProject_btn;
        private Panel ContentPanel;
    }
}