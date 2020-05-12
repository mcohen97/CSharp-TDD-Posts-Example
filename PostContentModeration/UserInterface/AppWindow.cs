using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class AppWindow : Form
    {
        private PostsRepository posts;

        public AppWindow()
        {
            InitializeComponent();
            posts = new PostsRepository();
            AddCreatePostPanel();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
           ClearPanel();
           AddCreatePostPanel();
        }

        private void AddCreatePostPanel() {
            CreatePostView view = new CreatePostView(posts);
            view.AddListener(PostCreated);
            optionPanel.Controls.Add(view);
        }

        private void PostCreated() {
            ShowPostsView view = new ShowPostsView(posts, "Post created successfully.");
            ClearPanel();
            optionPanel.Controls.Add(view);
        }

        private void BtnViewPosts_Click(object sender, EventArgs e)
        {
            ShowPostsView view = new ShowPostsView(posts);
            ClearPanel();
            optionPanel.Controls.Add(view);
        }

        private void ClearPanel()
        {
            optionPanel.Controls.Clear();
        }
    }
}
