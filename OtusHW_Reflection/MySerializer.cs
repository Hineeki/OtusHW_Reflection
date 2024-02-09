using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace OtusHW_Reflection
{
    public class MySerializer
    {
        public string Serialize(Object obj)
        {
            Type type = obj.GetType();

            // Получаем свойства и поля
            PropertyInfo[] properties = type.GetProperties();
            FieldInfo[] fields = type.GetFields();
            
            var stringBuilder = new StringBuilder();
            foreach ( var field in fields )
            {
                stringBuilder.Append( $"{field.Name} : {field.GetValue(obj)} ");
            }
            foreach ( var property in properties )
            {
                stringBuilder.Append($"{property.Name} : {property.GetValue(obj)}" );
            }
            return stringBuilder.ToString();
        }
    }
}
