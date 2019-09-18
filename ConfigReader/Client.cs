using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigReader
{
    class Client
    {
        private IConfigReader _config;
        public Client(IConfigReader config)
        {
            this._config = config;
        }

        public void DoWork()
        {
            Console.WriteLine(this._config.GetConfigValue("key1"));
        }
    }
}
