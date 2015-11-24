using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    public class StringFactory : IStringFactory
    {
        private readonly Dictionary<string, string> _stringLookup = new Dictionary<string, string>();

        public StringFactory()
        {
            _stringLookup.Add("one", "hello world");
            _stringLookup.Add("two", "taco time");
            _stringLookup.Add("three", "burrito time");
            _stringLookup.Add("four", "wha?");
        }

        public string CreateString(string key) => _stringLookup[key];

        public void AddString(string key, string val)
        {
            _stringLookup.Add(key, val);
        }

        public void DeleteString(string key)
        {
            if (_stringLookup.ContainsKey(key))
                _stringLookup.Remove(key);
        }
    }
}
