namespace UserInterface
{
    partial class CreatePostView
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
            this.createPostTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbBody = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createPostTitle
            // 
            this.createPostTitle.AutoSize = true;
            this.createPostTitle.Location = new System.Drawing.Point(183, 46);
            this.createPostTitle.Name = "createPostTitle";
            this.createPostTitle.Size = new System.Drawing.Size(62, 13);
            this.createPostTitle.TabIndex = 0;
            this.createPostTitle.Text = "Create Post";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(186, 97);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(186, 153);
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(277, 20);
            this.txtBody.TabIndex = 3;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(100, 97);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(30, 13);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "Title:";
            // 
            // lbBody
            // 
            this.lbBody.AutoSize = true;
            this.lbBody.Location = new System.Drawing.Point(103, 153);
            this.lbBody.Name = "lbBody";
            this.lbBody.Size = new System.Drawing.Size(34, 13);
            this.lbBody.TabIndex = 5;
            this.lbBody.Text = "Body:";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(186, 216);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(371, 221);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 13);
            this.lbError.TabIndex = 8;
            // 
            // CreatePostView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lbBody);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.createPostTitle);
            this.Name = "CreatePostView";
            this.Size = new System.Drawing.Size(800, 370);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createPostTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbBody;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbError;
    }
}
