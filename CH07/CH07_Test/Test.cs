using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH07_Test
{
    public struct Test
    {
        public string Id { get; }
        public string TestName { get; }

        public Test(string id, string testName)
        {
            Id = id;
            TestName = testName;
        }
    }
}
