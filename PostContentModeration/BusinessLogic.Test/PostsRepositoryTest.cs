using System;
using System.Collections.Generic;
using System.Linq;
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

        [TestMethod]
        [ExpectedException (typeof (PostNotFoundExeption))]
        public void GetPostNotExistingTest() {
            testRepo.Get(10);
        }

        [TestMethod]
        public void GetAllPostsTest() {
            Post post1 = new Post("Title1", "Body1", DateTime.Now);
            Post post2 = new Post("Title2", "Body2", DateTime.Now);
            Post post3 = new Post("Title3", "Body3", DateTime.Now);

            testRepo.Add(post1);
            testRepo.Add(post2);
            testRepo.Add(post3);

            IEnumerable<Post> allPosts = testRepo.GetAll();
            Assert.AreEqual(3, allPosts.Count());
        }

        [TestMethod]
        public void DeleteExistentTest() {
            Post post = new Post("Title", "Body", DateTime.Now);
            testRepo.Add(post);
            Assert.IsTrue(testRepo.Exists(post.Id));
            testRepo.Delete(post.Id);
            Assert.IsFalse(testRepo.Exists(post.Id));
        }

        [TestMethod]
        [ExpectedException(typeof(PostNotFoundExeption))]
        public void DeleteNonExistentTest() {
        }
    }
}
