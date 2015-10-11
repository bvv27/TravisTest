using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace TravisTest
{
    class Class1
    {
        public string Get(string str)
        {
            var json = JsonConvert.DeserializeObject<string>("\"+str+\"");
            return json;
        }
    }
}
