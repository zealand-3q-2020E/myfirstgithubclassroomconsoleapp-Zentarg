using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp
{
    class Demo
    {
        public Demo(string name, string description, List<string> stringList)
        {
            Name = name;
            Description = description;
            StringList = stringList;
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<string> StringList { get; set; }



    }
}
