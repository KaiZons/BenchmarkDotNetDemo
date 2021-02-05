using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    [Serializable]
    public class People
    {
        public People() { }
        public People(Guid id, int name1, int name2, int name3, int name4, string uniqueName)
        {
            ID = id;
            Name1 = name1;
            Name2 = name2;
            Name3 = name3;
            Name4 = name4;
            UniqueName = uniqueName;
        }
        private static int sint = 10;

        public static string sstring { get; set; } = "2323";

        public static string sstring2 { get; set; }

        private Guid ID;

        private string UniqueName;

        private int Name1;

        private int Name2 { get; set; }

        public int Name3;

        public int Name4 { get; set; }
    }
}
