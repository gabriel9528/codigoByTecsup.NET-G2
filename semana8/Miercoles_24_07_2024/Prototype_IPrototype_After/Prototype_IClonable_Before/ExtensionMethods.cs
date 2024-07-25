using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Prototype_IClonable_Before
{
    public static class ExtensionMethods
    {
        public static T DeepCopy<T>(this T source)
        {

            if(source == null)
            {
                throw new ArgumentNullException(nameof(source), "Es necesario enviar un objeto");
            }

            var options = new JsonSerializerOptions
            {
                WriteIndented = false,
                IncludeFields = true
            };

            var jsonString = JsonSerializer.Serialize(source, options);
            return JsonSerializer.Deserialize<T>(jsonString, options);
        }
    }
}
