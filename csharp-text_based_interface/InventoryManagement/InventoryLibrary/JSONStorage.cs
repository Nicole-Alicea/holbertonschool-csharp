using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace InventoryLibrary
{
    /// <summary>
    /// Handles serialization and deserialization of objects to JSON.
    /// </summary>
    public class JSONStorage
    {
        /// <summary>Stores all objects with keys as <ClassName>.<id>.</summary>
        private Dictionary<string, object> objects = new Dictionary<string, object>();

        /// <summary>File path for JSON storage.</summary>
        private readonly string filePath = Path.Combine("storage", "inventory_manager.json");

        /// <summary>Returns all stored objects.</summary>
        public Dictionary<string, object> All()
        {
            return objects;
        }

        /// <summary>Adds a new object to storage.</summary>
        /// <param name="obj">The object to store.</param>
        public void New(object obj)
        {
            // Generate the key as <ClassName>.<id>
            string key = $"{obj.GetType().Name}.{((BaseClass)obj).id}";
            objects[key] = obj;
        }

        /// <summary>Saves the objects to a JSON file.</summary>
        public void Save()
        {
            // Ensure the storage directory exists
            Directory.CreateDirectory("storage");

            // Serialize the objects dictionary to JSON
            string json = JsonSerializer.Serialize(objects, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            // Write the JSON to file
            File.WriteAllText(filePath, json);
        }

        /// <summary>Loads objects from the JSON file.</summary>
        public void Load()
        {
            if (File.Exists(filePath))
            {
                // Read the JSON from file
                string json = File.ReadAllText(filePath);

                // Check if the file is empty
                if (string.IsNullOrWhiteSpace(json))
                {
                    // Initialize an empty dictionary if the file is empty
                    objects = new Dictionary<string, object>();
                }
                else
                {
                    // Deserialize the JSON back into the objects dictionary, ensuring it isn't null
                    objects = JsonSerializer.Deserialize<Dictionary<string, object>>(json) ?? new Dictionary<string, object>();
                }
            }
            else
            {
                // If the file doesn't exist, initialize an empty dictionary
                objects = new Dictionary<string, object>();
            }
        }
    }
}