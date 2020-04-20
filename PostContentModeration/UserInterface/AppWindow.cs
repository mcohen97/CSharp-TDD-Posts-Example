﻿using BusinessLogic;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
           optionPanel.Controls.Add(new CreatePostView(posts));
        }

    }
}
