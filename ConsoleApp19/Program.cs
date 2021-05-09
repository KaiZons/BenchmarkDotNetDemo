using BenchmarkDotNet.Running;
using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            // 对比 https://blog.csdn.net/u013986317/article/details/112984388
            var summary = BenchmarkRunner.Run<TestClass>();
            Console.ReadLine();   
        }
    }
}
