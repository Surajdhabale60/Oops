using OopsProblem.Inventory_Management;

namespace OopsProblem
{
    public class Program
    {
        static string inventoryDetailsfilePath = @"C:\Users\suraj\source\repos\217 .Net\Oops\Oops\Oops\InventoryManagement\Inventory.json";

        public static void Main(string[] args)
        {
            InventoryDetailsManagement inventoryDetailsManagement = new InventoryDetailsManagement();
            inventoryDetailsManagement.ReadJsonFile(inventoryDetailsfilePath);
        }
    }
}