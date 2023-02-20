using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIN_LIB
{
    public class Class1
    {
        public static List<char> vs = new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };


        public static bool CheckVIN(string vin)
        {

            int kolvo = 0;
            if (vin.Length == 17)
            {
                for (int i = 0; i < vin.Length; i++)
                {

                    for (int j = 0; j < vs.Count; j++)
                    {
                        if (vin[i] == vs[j])
                        {
                            kolvo++;

                        }
                    }
                }
                if (kolvo == 17)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static string GetVINCountry(string vin)
        {
            if (CheckVIN(vin))
            {
                for (int i = 10; i <= 17; i++)
                {
                    if (vin[11] == vs[i])
                    {
                        return "Африка";
                    }
                }
                for (int i = 18; i <= 24; i++)
                {
                    if (vin[11] == vs[i])
                    {
                        return "Азия";
                    }

                }
                for (int i = 25; i <= 32; i++)
                {
                    if (vin[11] == vs[i])
                    {
                        return "Европа";
                    }
                }
                for (int i = 1; i <= 5; i++)
                {
                    if (vin[11] == vs[i])
                    {
                        return "Северная Америка";
                    }
                }
                for (int i = 6; i <= 7; i++)
                {
                    if (vin[11] == vs[i])
                    {
                        return "Океания";
                    }
                }
                for (int i = 8; i <= 9; i++)
                {
                    if (vin[11] == vs[i])
                    {
                        return "Южная Америка";
                    }
                }
            }

            return "";
        }
    }

}

