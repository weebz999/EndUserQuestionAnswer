using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllStateHomeOwners;
using System.IO;
using Newtonsoft.Json;

namespace AllStateHomeOwners
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = File.ReadAllText(@" E:\Home Owners tasks\Allstate -1 Dec.json");
            JsonHomeOwnersAllState.HomeOwners homeOwners = JsonConvert.DeserializeObject<JsonHomeOwnersAllState.HomeOwners>(json);
        }
    }
}
