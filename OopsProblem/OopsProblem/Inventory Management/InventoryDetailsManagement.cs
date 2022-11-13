using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OopsProblem.Inventory_Management
{
    internal class InventoryDetailsManagement
    {
        public void ReadJsonFile(string file)
        {
            var JsonData = File.ReadAllText(file);
            List<Inventory> inventories = JsonConvert.DeserializeObject<List<Inventory>>(JsonData);
            foreach (var data in inventories)
            {
                Console.WriteLine(data.Name + "\n" + data.Price + "\n" + data.Weight);
            }
        }
    }
}
