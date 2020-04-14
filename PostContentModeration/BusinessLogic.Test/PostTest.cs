using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogic.Test
{
    [TestClass]
    public class PostTest
    {
        [TestMethod]
        public void NewPostTitleTest()
        {
            string testTitle = "A title";
            Post testPost = new Post(testTitle, "A body", DateTime.Now);
            Assert.AreEqual(testTitle, testPost.Title);
        }

        [TestMethod]
        public void NewPostBodyTest() {
            string testBody = "A body";
            Post testPost = new Post("A title", testBody, DateTime.Now);
            Assert.AreEqual(testBody, testPost.Body);
        }

        [TestMethod]
        public void NewPostPublishedDateTest() {

            DateTime testDate = DateTime.Now.AddDays(-1); //Yesterday
            Post testPost = new Post("A title", "A body", testDate);
            Assert.AreEqual(testDate, testPost.DatePublished);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidPostException))]
        public void NewPostEmptyTitleException() {
            Post testPost = new Post("", "A body", DateTime.Now);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidPostException))]
        public void NewPostWhiteSpaceTitleException()
        {
            Post testPost = new Post("     ", "A body", DateTime.Now);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidPostException))]
        public void NewPostEmptyBodyException() {
            Post testPost = new Post("A title", "", DateTime.Now);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidPostException))]
        public void NewPostWhiteSpaceBodyException()
        {
            Post testPost = new Post("A title", "   ", DateTime.Now);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidPostException))]
        public void NewPostTooLongTitleTest() {
            string testTitle = new string('a', 51);
            Post testPost = new Post(testTitle, "A body", DateTime.Now);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidPostException))]
        public void NewPostMaxLengthTitleTest()
        {
            string testTitle = new string('a', 50);
            Post testPost = new Post(testTitle, "A body", DateTime.Now);
            Assert.AreEqual(testTitle, testPost.Title);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidPostException))]
        public void NewPostTooLongBodyTest()
        {
            string testBody = new string('a', 301);
            Post testPost = new Post("A title", testBody, DateTime.Now);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidPostException))]
        public void NewPostMaxLengthBodyTest()
        {
            string testBody = new string('a', 300);
            Post testPost = new Post("A title", testBody, DateTime.Now);
            Assert.AreEqual(testBody, testPost.Body);

        }
    }
}
