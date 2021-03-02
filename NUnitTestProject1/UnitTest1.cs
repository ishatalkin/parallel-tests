using System;
using System.Threading;
using NUnit.Framework;

[assembly: Parallelizable(ParallelScope.Fixtures)]

namespace NUnitTestProject1
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Console.WriteLine($"Thread ${Thread.CurrentThread.ManagedThreadId} {Thread.CurrentThread.Name}");
            Thread.Sleep(1000);
            Assert.Pass();
        }
    }
}

namespace NUnitTestProject2
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Console.WriteLine($"Thread ${Thread.CurrentThread.ManagedThreadId} {Thread.CurrentThread.Name}");
            Thread.Sleep(1000);
            Assert.Pass();
        }
    }
}

namespace NUnitTestProject3
{

    public class Tests
    {
        [Test]
        public void Test1()
        {
            Console.WriteLine($"Thread ${Thread.CurrentThread.ManagedThreadId} {Thread.CurrentThread.Name}");
            Thread.Sleep(1000);
            Assert.Pass();
        }
    }
}

namespace NUnitTestProject4
{

    public class Tests
    {
        [Test]
        public void Test1()
        {
            Console.WriteLine($"Thread ${Thread.CurrentThread.ManagedThreadId} {Thread.CurrentThread.Name}");
            Thread.Sleep(1000);
            Assert.Pass();
        }
    }

}