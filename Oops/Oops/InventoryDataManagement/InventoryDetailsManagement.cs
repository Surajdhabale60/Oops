using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Oops.InventoryDataManagement
{
    internal class InventoryDetailsManagement
    {
        public void ReadJsonFile(string file)
        {
            var JsonData = File.ReadAllText(file);
            InventoryData inventories = JsonConvert.DeserializeObject<InventoryData>(JsonData);
            List<Inventory> RiceList = inventories.Rice;
            Display(RiceList);
            List<Inventory> WheatList = inventories.Wheat;
            Display(WheatList);
            List<Inventory> PulseList = inventories.Pulse;
            Display(PulseList);

        }
        public void Display(List<Inventory> inventories)
        {
            foreach (var data in inventories)
            {
                Console.WriteLine("Name: " + data.Name + " \nWeight: " + data.Weight + " \nPrice: " + data.Price + "\n");
            }
        }
    }
}
