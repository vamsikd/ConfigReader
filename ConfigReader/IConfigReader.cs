using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigReader
{
    interface IConfigReader
    {
        string GetConfigValue(string key);
    }
}
