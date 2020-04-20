using BusinessLogic;
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
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
           CreatePostView view = new CreatePostView(posts);
           view.AddListener(PostCreated);
           optionPanel.Controls.Add(view);
        }

        private void PostCreated() {

        }

        private void BtnViewPosts_Click(object sender, EventArgs e)
        {
      
        }
    }
}
