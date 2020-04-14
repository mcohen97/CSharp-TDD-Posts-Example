using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogic.Test
{
    [TestClass]
    public class PostTest
    {
        [TestMethod]
        public void GetTitleTest()
        {
            string testTitle = "A title";
            Post testPost = new Post(testTitle, "A body", DateTime.Now);
            Assert.AreEqual(testTitle, testPost.Title);
        }

        [TestMethod]
        public void GetBodyTest() {
            string testBody = "A body";
            Post testPost = new Post("A title", testBody, DateTime.Now);
            Assert.AreEqual(testBody, testPost.Body);
        }
    }
}
