﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cosmos.Shell.Console.Tests
{
    public class StringTest : TestBase
    {
        public override string Name
        {
            get { return "Strings"; }
        }

        public override void Initialize()
        {
            
        }

        public override void Teardown()
        {
            
        }

        public override void Test()
        {
            Assert("ABCDEFG".IndexOf('E') == 4, "\"ABCDEFG\".IndexOf('E') == 4");
            Assert("0123456789".IndexOf('5') == 5, "\"0123456789\".IndexOf('5') == 5");
            Assert("0123456789"[5] == '5', "\"0123456789\"[5] == '5'");
        }
    }
}
