using System;
using System.Collections.Generic;
using System.Data.Common;

namespace ConfigReader
{
    class DBConfigReader : IConfigReader
    {

        private Dictionary<string, string> _config = new Dictionary<string, string>
        {
            { "key1", "value1" },
            { "key2", "value2" },
            { "key3", "value3" }
        };

        public DBConfigReader()
        {
            this.InitializeConfig();
        }

        private void InitializeConfig()
        {
            // TODO: connect to DB and store all tthe key values in _config
        }

        public string GetConfigValue(string key)
        {
            string value;
            this._config.TryGetValue(key, out value);
            if(null == value)
            {
                throw new Exception("Key not present in the Config DB");
            }
            return value;

        }
    }
}

