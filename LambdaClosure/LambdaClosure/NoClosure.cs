using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaClosure
{
    public class NoClosure
    {
        private Dictionary<string, string> _cache = new Dictionary<string, string>();

        private string GetOrCreate(string key, Func<string, string> evaluator)
        {
            string ret;
            if (this._cache.TryGetValue(key, out ret)) {
                return ret;
            }
            ret = evaluator(key);
            this._cache[key] = ret;
            return ret;
        }

        public string Substring(string x)
        {
            // here we do not create a closure because it does not refer to the x variable, instead of this a paramter is used in the lambda expression
            var ret = GetOrCreate(x, (newX) => newX.Substring(1));
            return ret;
        }
    }
}
