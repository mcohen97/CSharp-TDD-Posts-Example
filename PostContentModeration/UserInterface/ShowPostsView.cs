using BusinessLogic;
using DataAccess;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class ShowPostsView : UserControl
    {
        private IRepository<Post> posts;

        public ShowPostsView(IRepository<Post> repository)
        {
            InitializeComponent();
            posts = repository;
            FillList();
        }

        public ShowPostsView(IRepository<Post> repository, string message):this(repository) {
            lbMessage.Text = message;
        }


        private void FillList()
        {
            lstPosts.DataSource = null;
            lstPosts.DataSource = posts.GetAll().ToList();
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
