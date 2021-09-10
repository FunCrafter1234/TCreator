using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TCreator.CodeBase.Usings
{
    public class UsingsList
    {
        public List<Using> AllUsings;

        public UsingsList()
        {
            AllUsings = new List<Using>();
            string filecontent = File.ReadAllText(@"C:\Users\Marvin\Documents\GitHub\TCreator\TCreator\JSONS\usings.json");
            var test = JsonConvert.DeserializeObject<List<Using>>(filecontent);
        }
    }
}
