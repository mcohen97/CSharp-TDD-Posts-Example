using BusinessLogic;
using DataAccess;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class ShowPostsView : UserControl
    {
        private IPostsRepository posts;

        public ShowPostsView(IPostsRepository repository)
        {
            InitializeComponent();
            posts = repository;
            FillList();
        }

        public ShowPostsView(IPostsRepository repository, string message):this(repository) {
            lbMessage.Text = message;
        }


        private void FillList()
        {
            lstPosts.DataSource = null;
            try
            {
                lstPosts.DataSource = posts.GetAll().ToList();
            }
            catch (DataUnavailableException e) {
                Alerts.CrashApp(e.Message);
            }
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
