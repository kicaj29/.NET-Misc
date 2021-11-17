using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaClosure
{
    public class WithClosure
    {
        private Dictionary<string, string> _cache = new Dictionary<string, string>();

        private string GetOrCreate(string key, Func<string> evaluator)
        {
            string ret;
            if (this._cache.TryGetValue(key, out ret)) {
                return ret;
            }
            ret = evaluator();
            this._cache[key] = ret;
            return ret;
        }

        public string Substring(string x)
        {
            // here we create a closure because we refrence to x variable  that is not in "scope" of the lambda!
            var ret = GetOrCreate(x, () => x.Substring(1));
            return ret;
        }
    }
}
