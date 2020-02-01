using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API
{
    public static class TESTModule
    {
        public static object Module(object testObject)
        {
            switch (testObject)
            {
                case 1:
                case 2:
                    return doubler((int)testObject);
                case int value when value >= 3: // we have to fix  "value = 3 "  not "value >=3" because if user input is 4,5,6... this case will work and this is a bug
                    return tripler(value);
                case float floatValue when floatValue == 1.0f://we have to move Line 19 and 20 to  case 1:  to solve this situation
                    return leveler(floatValue);
                default:
                    return testObject;
            }


            int doubler(int amount) => amount * 2;
            int tripler(int amount) => amount * 3;
            double leveler(double amount) => amount - 0.1f * 10f;// we have to fix "double leveler" to "float leveler" and float amount too
        }
    }

}
