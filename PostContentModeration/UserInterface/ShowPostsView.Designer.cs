namespace UserInterface
{
    partial class ShowPostsView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbPosts = new System.Windows.Forms.Label();
            this.lstPosts = new System.Windows.Forms.ListBox();
            this.lbMessage = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPosts
            // 
            this.lbPosts.AutoSize = true;
            this.lbPosts.Location = new System.Drawing.Point(183, 34);
            this.lbPosts.Name = "lbPosts";
            this.lbPosts.Size = new System.Drawing.Size(36, 13);
            this.lbPosts.TabIndex = 1;
            this.lbPosts.Text = "Posts:";
            // 
            // lstPosts
            // 
            this.lstPosts.FormattingEnabled = true;
            this.lstPosts.Location = new System.Drawing.Point(170, 72);
            this.lstPosts.Name = "lstPosts";
            this.lstPosts.Size = new System.Drawing.Size(538, 238);
            this.lstPosts.TabIndex = 2;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.ForeColor = System.Drawing.Color.Green;
            this.lbMessage.Location = new System.Drawing.Point(176, 333);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(0, 13);
            this.lbMessage.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(633, 333);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Post";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // ShowPostsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.lstPosts);
            this.Controls.Add(this.lbPosts);
            this.Name = "ShowPostsView";
            this.Size = new System.Drawing.Size(800, 370);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbPosts;
        private System.Windows.Forms.ListBox lstPosts;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Button btnDelete;
    }
}
