using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using InventoryService;

namespace Inventory.UI
{
    public interface IMapper
    {
        Type Type { get; }
        string TypeName { get; }
        string WheelCountPropertyName { get; }
    }

    /// <summary>
    /// this class maps the inventory type to display type name and a property that gives the wheel count
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Mapper<T> : IMapper
    {
        public Mapper(string typeName, Expression<Func<T, int?>> wheelCount)
        {
            Type = typeof(T);
            TypeName = typeName;
            WheelCountPropertyName = GetPropertyName(wheelCount);
        }

        public Type Type { private set; get; }
        public string TypeName { private set; get; }
        public string WheelCountPropertyName { private set; get; }

        private string GetPropertyName(Expression<Func<T, int?>> wheelCount)
        {
            if (wheelCount == null) return null;

            var body = wheelCount.Body.ToString();

            if (body == "null") return null;

            var matches = Regex.Match(body, @"^Convert\(([_a-zA-Z]+)\.([_a-zA-Z]+)\)$");

            if (matches.Groups.Count == 3)
            {
                return matches.Groups[2].Value;
            }

            throw new ArgumentException(@"The lambda expression to extract the wheel count property is not correct.
                                         You should either supply a null expression, or x=> null / x=> x.WheelCountProperty");
        }
    }
}
