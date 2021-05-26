using BusinessLogic;
using DataAccess;
using System;
using System.Windows.Forms;

namespace UserInterface
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IPostsRepository  posts = new PostsDBRepository();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppWindow(posts));
        }
    }
}
