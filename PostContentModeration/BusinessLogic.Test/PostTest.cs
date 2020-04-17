using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogic.Test
{
    [TestClass]
    public class PostTest
    {
        [TestInitialize]
        public void SetUp() {
            //variables globales
        }

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
        public void NewPostMaxLengthBodyTest()
        {
            string testBody = new string('a', 300);
            Post testPost = new Post("A title", testBody, DateTime.Now);
            Assert.AreEqual(testBody, testPost.Body);
        }

        [TestMethod]
        public void NewPostPublishedDateTest()
        {

            DateTime testDate = DateTime.Now.AddDays(-1); //Yesterday.
            Post testPost = new Post("A title", "A body", testDate);
            Assert.AreEqual(testDate, testPost.DatePublished);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidPostException))]
        public void FuturePublishedDateTest() {
            Post testPost = new Post("A title", "A body", DateTime.Now.AddDays(1)); //Tomorrow.
        }

        [TestMethod]
        public void WordContainedInTitleTest() {
            string testTitle = "This is a title that contains words";
            Post testPost = new Post(testTitle, "a Body", DateTime.Now);
            Assert.IsTrue(testPost.ContainsWord("words"));
        }

        [TestMethod]
        public void SimilarWordNotContainedInTitleTest()
        {
            string testTitle = "This is a title that contains words";
            Post testPost = new Post(testTitle, "a Body", DateTime.Now);
            Assert.IsFalse(testPost.ContainsWord("word"));
        }

        [TestMethod]
        public void WordNotContainedInTitleTest()
        {
            string testTitle = "This is a title";
            Post testPost = new Post(testTitle, "a Body", DateTime.Now);
            Assert.IsFalse(testPost.ContainsWord("words"));
        }

        [TestMethod]
        public void WordContainedInBody() {
            string testBody = "This is a body that contains words";
            Post testPost = new Post("A title", testBody, DateTime.Now);
            Assert.IsTrue(testPost.ContainsWord("words"));
        }

        [TestMethod]
        public void WordNotContainedInBody()
        {
            string testBody = "This is a body";
            Post testPost = new Post("A title", testBody, DateTime.Now);
            Assert.IsFalse(testPost.ContainsWord("words"));
        }

        [TestMethod]
        public void SimilarWordNotContainedInBodyTest()
        {
            string testBody = "This is a body that contains words";
            Post testPost = new Post("A title", testBody, DateTime.Now);
            Assert.IsFalse(testPost.ContainsWord("word"));
        }
    }
}
