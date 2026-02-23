using Savable;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace SaveManagers
{
    public class SaveManager
    {
        public static void Save(ISaveable entity, string path)
        {
            string json = entity.ToJson();
            File.WriteAllText(path, json);

        }
        public static T Load<T>(string path)
        {
            if (!File.Exists(path))
                return default(T);

            string json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<T>(json);


        }
    }
}
