using BusinessLogic;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class ShowPostsView : UserControl
    {
        PostsRepository posts;

        public ShowPostsView(PostsRepository repository)
        {
            InitializeComponent();
            posts = repository;
            FillList();
        }

        public ShowPostsView(PostsRepository repository, string message):this(repository) {
            lbMessage.Text = message;
        }

        private void SetUp() {
        }

        private void FillList()
        {
            lstPosts.DataSource = posts.GetAll();
        }
    }
}
