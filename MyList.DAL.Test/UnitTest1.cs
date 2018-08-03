namespace MyList.DAL.Test
{
    using System;
    using Xunit;
    using MyList.DAL;
    using System.Collections.Concurrent;

    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var directories = new Memories.Directory();
            var directory = new System.IO.DirectoryInfo("U:\\");
            directory.ListAll(directories.Add);
        }

        [Fact]
        public void Test2()
        {
            var directories = new Clouds.Directory();
            var directory = new System.IO.DirectoryInfo("U:\\");
            directory.ListAll(directories.Add);
        }

        [Fact]
        public void Test3()
        {
            var directories = new Memories.Directory();
            var directory = new System.IO.DirectoryInfo("U:\\");
            var exceptions = new ConcurrentBag<Exception>();
            directory.ListAll(directories.Add, exceptions.Add);
        }

        [Fact]
        public void Test4()
        {
            var directories = new Memories.Directory();
            var directory = new System.IO.DirectoryInfo("U:\\");
            var exceptions = new ConcurrentBag<Exception>();
            directory.ListAllParallel(directories.Add, exceptions.Add);
        }

        [Fact]
        public void Test5()
        {
            var directories = new Clouds.Directory();
            var directory = new System.IO.DirectoryInfo("U:\\");
            var exceptions = new ConcurrentBag<Exception>();
            directory.ListAll(directories.Add, exceptions.Add);
        }

        [Fact]
        public void Test6()
        {
            var directories = new Clouds.Directory();
            var directory = new System.IO.DirectoryInfo("U:\\");
            var exceptions = new ConcurrentBag<Exception>();
            directory.ListAllParallel(directories.Add, exceptions.Add);
        }
    }
}
