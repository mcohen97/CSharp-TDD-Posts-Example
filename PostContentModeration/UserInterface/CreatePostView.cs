using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace UserInterface
{
    public partial class CreatePostView : UserControl
    {
        private PostsRepository posts;
        public CreatePostView(PostsRepository repository)
        {
            InitializeComponent();
            posts = repository;
        }

    }
}
