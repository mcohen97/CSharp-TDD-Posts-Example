using BusinessLogic;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class ShowPostsView : UserControl
    {
        private PostsRepository posts;

        public ShowPostsView(PostsRepository repository)
        {
            InitializeComponent();
            posts = repository;
            FillList();
        }

        public ShowPostsView(PostsRepository repository, string message):this(repository) {
            lbMessage.Text = message;
        }


        private void FillList()
        {
            lstPosts.DataSource = null;
            lstPosts.DataSource = posts.GetAll();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Post selected = (Post)lstPosts.SelectedItem;
            if (selected != null) {
                posts.Delete(selected.Id);
                lbMessage.Text = "Post deleted succesfully";
                FillList();
            }
        }
    }
}
