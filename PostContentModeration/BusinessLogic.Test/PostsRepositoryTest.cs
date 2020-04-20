using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogic.Test
{
    [TestClass]
    public class PostsRepositoryTest
    {
        PostsRepository testRepo;

        [TestInitialize]
        public void SetUp() {
            testRepo = new PostsRepository(); 
        }

        [TestMethod]
        public void NewRepositoryEmptyTest()
        {
            Assert.IsTrue(testRepo.IsEmpty());
        }

        [TestMethod]
        public void AddPostNotEmptyTest()
        {
            testRepo.Add(new Post("Title", "Body", DateTime.Now));
            Assert.IsFalse(testRepo.IsEmpty());
        }

        [TestMethod]
        public void ExistsPostTest() {
            Post post = new Post("Title", "Body", DateTime.Now);
            testRepo.Add(post);
            Assert.IsTrue(testRepo.Exists(post.Id));
        }

        [TestMethod]
        public void NotExistsPostTest() {
            Assert.IsFalse(testRepo.Exists(10));
        }

        [TestMethod]
        [ExpectedException(typeof(PostAlreadyExistsExeption))]
        public void AddRepeatedPostTest() {
            Post post = new Post("Title", "Body", DateTime.Now);
            testRepo.Add(post);
            testRepo.Add(post);
        }

        [TestMethod]
        public void GetPostTest() {
            Post post = new Post("Title", "Body", DateTime.Now);
            testRepo.Add(post);
            Assert.AreEqual(post.Title, testRepo.Get(post.Id).Title);
        }
    }
}
