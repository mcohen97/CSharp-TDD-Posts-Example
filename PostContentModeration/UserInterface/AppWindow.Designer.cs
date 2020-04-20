namespace UserInterface
{
    partial class AppWindow
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
            this.optionPanel = new System.Windows.Forms.Panel();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnViewPosts = new System.Windows.Forms.Button();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionPanel
            // 
            this.optionPanel.Location = new System.Drawing.Point(-2, 82);
            this.optionPanel.Name = "optionPanel";
            this.optionPanel.Size = new System.Drawing.Size(802, 370);
            this.optionPanel.TabIndex = 0;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.btnViewPosts);
            this.buttonsPanel.Controls.Add(this.btnAdd);
            this.buttonsPanel.Location = new System.Drawing.Point(-2, 0);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(801, 84);
            this.buttonsPanel.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(14, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 46);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Create Post";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnViewPosts
            // 
            this.btnViewPosts.Location = new System.Drawing.Point(163, 21);
            this.btnViewPosts.Name = "btnViewPosts";
            this.btnViewPosts.Size = new System.Drawing.Size(129, 46);
            this.btnViewPosts.TabIndex = 1;
            this.btnViewPosts.Text = "View Posts";
            this.btnViewPosts.UseVisualStyleBackColor = true;
            // 
            // AppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.optionPanel);
            this.Name = "AppWindow";
            this.Text = "Posts Example";
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel optionPanel;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button btnViewPosts;
        private System.Windows.Forms.Button btnAdd;
    }
}

