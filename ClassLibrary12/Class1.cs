using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ClassLibrary12
{
    public class Class1
    {
        public static string Foo()
        {
            return JsonConvert.SerializeObject(new { A = 1 });
        }
    }
}
