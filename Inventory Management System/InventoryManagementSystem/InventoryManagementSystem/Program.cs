using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    // Enum for Item Categories
    public enum ItemCategory
    {
        Electronics,
        Groceries,
        Clothing,
        Stationery,
        Miscellaneous
    }

    // Struct for Inventory Items
    public struct Item
    {
        public string Name { get; }
        public int Quantity { get; }
        public ItemCategory Category { get; }

        public Item(string name, int quantity, ItemCategory category)
        {
            Name = name;
            Quantity = quantity;
            Category = category;
        }

        public override string ToString()
        {
            return $"{Name}, {Quantity}, {Category}";
        }
    }

    internal class Program
    {
        private static List<Item> inventory = new List<Item>();
        private const string filePath = "inventory.txt";
        static void Main(string[] args)
        {
            LoadInventory();

            Console.WriteLine("Add items to the inventory (or type 'exit' to stop):");
            while (true)
            {
                Console.Write("Enter item name: ");
                string itemName = Console.ReadLine();
                if (itemName.ToLower() == "exit")
                {
                    break;
                }

                Console.Write("Enter quantity: ");
                if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity < 0)
                {
                    Console.WriteLine("Invalid quantity. Please enter a valid number.");
                    continue;
                }

                Console.WriteLine("Choose category:");
                foreach (var category in Enum.GetValues(typeof(ItemCategory)))
                {
                    Console.WriteLine($"{(int)category}: {category}");
                }

                if (!int.TryParse(Console.ReadLine(), out int categoryChoice) ||
                    !Enum.IsDefined(typeof(ItemCategory), categoryChoice))
                {
                    Console.WriteLine("Invalid category choice. Please try again.");
                    continue;
                }

                ItemCategory selectedCategory = (ItemCategory)categoryChoice;
                Item newItem = new Item(itemName, quantity, selectedCategory);
                inventory.Add(newItem);
                Console.WriteLine("Item added.");
            }

            SaveInventory();
            Console.WriteLine("Inventory saved.");
        }

        private static void LoadInventory()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    foreach (var line in lines)
                    {
                        var parts = line.Split(',');
                        if (parts.Length == 3 &&
                            int.TryParse(parts[1], out int quantity) &&
                            Enum.TryParse(parts[2].Trim(), out ItemCategory category))
                        {
                            Item item = new Item(parts[0].Trim(), quantity, category);
                            inventory.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading inventory: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("No previous inventory found.");
            }
        }

        private static void SaveInventory()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var item in inventory)
                    {
                        writer.WriteLine(item.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving inventory: {ex.Message}");
            }
        }
    }
}
