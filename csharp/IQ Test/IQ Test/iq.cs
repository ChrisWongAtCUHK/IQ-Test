using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class IQ
{
    public static int Test(string numbers)
    {
        // split the string into array by space
        string[] parts = numbers.Split(' ');
        int everness0 = Int32.Parse(parts[0]) % 2;
        int everness1 = Int32.Parse(parts[1]) % 2;

        for (int i = 2; i < parts.Length; i++)
        {
            int everness = Int32.Parse(parts[i]) % 2;
            if (everness0 == everness1)
            {
                if (everness != everness0)
                    return i + 1;
            }
            else
            {
                if (everness != everness0)
                    return 1;
                else
                    return 2;
            }
        }

        return 0;
    }
}

