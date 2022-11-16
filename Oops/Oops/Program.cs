using System;

namespace Oops
{
    public class Program
    {
        static string inventoryfilePath = @"C:\Users\suraj\source\repos\217 .Net\Oops\Oops\Oops\Inventory Management\Inventory.Json";
        public static void Main(string[] args)
        {
            InventoryManagement inventoryManagement = new InventoryManagement();
            inventoryManagement.ReadJsonFile(inventoryfilePath);           
        }
    }
}