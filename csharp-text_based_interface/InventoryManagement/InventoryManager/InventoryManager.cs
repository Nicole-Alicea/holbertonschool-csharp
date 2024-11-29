using System;
using System.Collections.Generic;
using InventoryLibrary;

namespace InventoryManager
{
    class Program
    {
        static JSONStorage storage = new JSONStorage(); // Single instance of JSONStorage

        static void Main(string[] args)
        {
            // Load all objects from storage
            storage.Load();
            Console.WriteLine("Inventory Manager");
            Console.WriteLine("-------------------------");
            PrintCommands();

            while (true)
            {
                Console.Write("\n> ");
                string input = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(input))
                    continue;

                string[] commands = input.Split(" ", 2, StringSplitOptions.RemoveEmptyEntries);
                string action = commands[0].ToLower();
                string options = commands.Length > 1 ? commands[1] : null;

                switch (action)
                {
                    case "classnames":
                        ShowClassNames();
                        break;
                    case "all":
                        ShowAll(options);
                        break;
                    case "create":
                        CreateObject(options);
                        break;
                    case "show":
                        ShowObject(options);
                        break;
                    case "update":
                        UpdateObject(options);
                        break;
                    case "delete":
                        DeleteObject(options);
                        break;
                    case "exit":
                        Console.WriteLine("Exiting...");
                        storage.Save();
                        return;
                    default:
                        Console.WriteLine($"Unknown command: {action}");
                        break;
                }
            }
        }

        static void PrintCommands()
        {
            Console.WriteLine("<ClassNames> Show all ClassNames of objects");
            Console.WriteLine("<All> Show all objects");
            Console.WriteLine("<All [ClassName]> Show all objects of a ClassName");
            Console.WriteLine("<Create [ClassName]> Create a new object");
            Console.WriteLine("<Show [ClassName object_id]> Show an object");
            Console.WriteLine("<Update [ClassName object_id]> Update an object");
            Console.WriteLine("<Delete [ClassName object_id]> Delete an object");
            Console.WriteLine("<Exit> Quit the application");
        }

        static void ShowClassNames()
        {
            HashSet<string> classNames = new HashSet<string>();
            foreach (string key in storage.All().Keys)
            {
                string className = key.Split('.')[0];
                classNames.Add(className);
            }

            Console.WriteLine("Available ClassNames:");
            foreach (string className in classNames)
                Console.WriteLine($"- {className}");
        }

        static void ShowAll(string className = null)
        {
            var objects = storage.All();
            if (className == null)
            {
                foreach (var entry in objects)
                    Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
            else
            {
                className = className.ToLower();
                bool found = false;
                foreach (var entry in objects)
                {
                    if (entry.Key.ToLower().StartsWith(className + "."))
                    {
                        Console.WriteLine($"{entry.Key}: {entry.Value}");
                        found = true;
                    }
                }

                if (!found)
                    Console.WriteLine($"{className} is not a valid object type");
            }
        }

        static void CreateObject(string className)
        {
            if (string.IsNullOrEmpty(className))
            {
                Console.WriteLine("Please provide a ClassName to create.");
                return;
            }

            className = className.ToLower();
            switch (className)
            {
                case "user":
                    Console.Write("Enter name: ");
                    string userName = Console.ReadLine();
                    var user = new User(userName);
                    storage.New(user);
                    Console.WriteLine($"Created {user}");
                    break;

                case "item":
                    Console.Write("Enter name: ");
                    string itemName = Console.ReadLine();
                    Console.Write("Enter description: ");
                    string description = Console.ReadLine();
                    Console.Write("Enter price: ");
                    if (!float.TryParse(Console.ReadLine(), out float price))
                    {
                        Console.WriteLine("Invalid price.");
                        return;
                    }

                    var item = new Item(itemName, price, description);
                    storage.New(item);
                    Console.WriteLine($"Created {item}");
                    break;

                case "inventory":
                    Console.Write("Enter user ID: ");
                    string userId = Console.ReadLine();
                    Console.Write("Enter item ID: ");
                    string itemId = Console.ReadLine();
                    Console.Write("Enter quantity: ");
                    if (!int.TryParse(Console.ReadLine(), out int quantity))
                    {
                        Console.WriteLine("Invalid quantity.");
                        return;
                    }

                    var inventory = new Inventory(userId, itemId, quantity);
                    storage.New(inventory);
                    Console.WriteLine($"Created {inventory}");
                    break;

                default:
                    Console.WriteLine($"{className} is not a valid object type");
                    break;
            }
        }

        static void ShowObject(string options)
        {
            if (string.IsNullOrEmpty(options))
            {
                Console.WriteLine("Provide ClassName and object ID.");
                return;
            }

            string[] parts = options.Split(" ", 2);
            if (parts.Length < 2)
            {
                Console.WriteLine("Provide ClassName and object ID.");
                return;
            }

            string className = parts[0];
            string id = parts[1];
            string key = $"{className}.{id}";

            if (storage.All().TryGetValue(key, out object obj))
                Console.WriteLine(obj);
            else
                Console.WriteLine($"Object {id} could not be found");
        }

        static void UpdateObject(string options)
        {
            if (string.IsNullOrEmpty(options))
            {
                Console.WriteLine("Provide ClassName and object ID.");
                return;
            }

            string[] parts = options.Split(" ", 2);
            if (parts.Length < 2)
            {
                Console.WriteLine("Provide ClassName and object ID.");
                return;
            }

            string className = parts[0];
            string id = parts[1];
            string key = $"{className}.{id}";

            if (!storage.All().TryGetValue(key, out object obj))
            {
                Console.WriteLine($"Object {id} could not be found");
                return;
            }

            Console.WriteLine($"Updating {key}: {obj}");
            Console.Write("Enter property to update: ");
            string property = Console.ReadLine();
            Console.Write("Enter new value: ");
            string value = Console.ReadLine();

            var prop = obj.GetType().GetProperty(property);
            if (prop == null)
            {
                Console.WriteLine($"Property {property} does not exist on {className}");
                return;
            }

            try
            {
                object convertedValue = Convert.ChangeType(value, prop.PropertyType);
                prop.SetValue(obj, convertedValue);
                Console.WriteLine($"Updated {key}");
            }
            catch
            {
                Console.WriteLine("Failed to update property.");
            }
        }

        static void DeleteObject(string options)
        {
            if (string.IsNullOrEmpty(options))
            {
                Console.WriteLine("Provide ClassName and object ID.");
                return;
            }

            string[] parts = options.Split(" ", 2);
            if (parts.Length < 2)
            {
                Console.WriteLine("Provide ClassName and object ID.");
                return;
            }

            string className = parts[0];
            string id = parts[1];
            string key = $"{className}.{id}";

            if (storage.All().Remove(key))
            {
                Console.WriteLine($"Deleted {key}");
            }
            else
            {
                Console.WriteLine($"Object {id} could not be found");
            }
        }
    }
}
