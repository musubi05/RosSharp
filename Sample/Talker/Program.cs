﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RosSharp;

namespace Talker
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new MasterClient();

            //var state = client.GetSystemState("/talker");
            
            client.LookupNodeAsync("/talker", null);
        }
    }
}
