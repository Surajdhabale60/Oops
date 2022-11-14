using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Oops
{
    internal class InventoryManagement
    {
        public void ReadJsonFile(string file)
        {
            var JsonData = File.ReadAllText(file);
            List<Inventory> inventories = JsonConvert.DeserializeObject<List<Inventory>>(JsonData);
            foreach (var data in inventories)
            {
                Console.WriteLine(" Name: " + data.Name + "\n Weight: " + data.Weight + "\n Price: " + data.Price);
            }
        }
    }
}
 