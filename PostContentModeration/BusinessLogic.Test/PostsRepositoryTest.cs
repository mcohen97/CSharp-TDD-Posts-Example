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
    }
}
