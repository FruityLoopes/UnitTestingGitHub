using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingGitHub
{
     public class TestMe
    {
        private string strName, strVersion, strDescription, strAuthor;

        public TestMe(string strName, string strDescription, string strVersion, string strAuthor)
        {
            this.strName = strName;
            this.strVersion = strVersion;
            this.strDescription = strDescription;
            this.strAuthor = strAuthor;
        }

        public string ToString()
        {
            return $"My name is {strName} and {strDescription}";
        }
    }
}
