using System;
using System.Collections.Generic;
using System.Text;

namespace GenerativeFactory
{
    public class Data
    {
        public int IntValue { get; set; }

        public string StringValue { get; set; }

        public Data()
        {
        }

        public Data(int intValue, string stringValue)
        {
            IntValue = intValue;
            StringValue = stringValue;
        }
    }
}
