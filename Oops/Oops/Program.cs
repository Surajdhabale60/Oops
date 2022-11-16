using System;
using Oops.InventoryDataManagement;

namespace Oops
{
    public class Program
    {
        static string inventoryfilePath = @"C:\Users\suraj\source\repos\217 .Net\Oops\Oops\Oops\Inventory Management\Inventory.Json";
        static string inventoryDataPath = @"C:\Users\suraj\source\repos\217 .Net\Oops\Oops\Oops\InventoryDataManagement\InventoryData.Json";
        public static void Main(string[] args)
        {
            InventoryManagement inventoryManagement = new InventoryManagement();
            inventoryManagement.ReadJsonFile(inventoryfilePath);
            
            InventoryDetailsManagement inventoryDetailsManagement = new InventoryDetailsManagement();
            inventoryDetailsManagement.ReadJsonFile(inventoryDataPath);
        }
    }
}