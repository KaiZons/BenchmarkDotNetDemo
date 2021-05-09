using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    [MemoryDiagnoser]
    public class TestClass
    {
        public List<int> lstCount => new List<int> { 100, 1000, 10000, 100000, 1000000 };// 
        public List<People> lstSource = new List<People>();
        public TestClass()
        {
            for (int i = 0; i < Count; i++)
            {
                lstSource.Add(new People(Guid.NewGuid(), i, i + 1, i + 2, i + 3, "测试"));
            }
        }

        [ParamsSource(nameof(lstCount))]
        public int Count { get; set; }

        [Benchmark]
        public void CopyOne()
        {
            List<People> lstCopy = lstSource.DeepCopy();//DeepCopyFactory<People>.DeepCopyList(lstSource);
        }

        [Benchmark]
        public void CopyTwo()
        {
            List<People> lstCopy2 = lstSource.DeepCopy2();
        }
    }
}
