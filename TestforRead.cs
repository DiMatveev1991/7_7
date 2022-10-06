using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal static class TestforRead
    {
        public static bool InputChek2(string num, out int corrnum)
        {
            if (int.TryParse(num, out int intnum))
            {
                if (intnum == 1 | intnum == 2)
                {
                    corrnum = intnum;
                    return false;
                }
            }
            {
                corrnum = 0;
                Console.WriteLine("Не корректный ввод, попробуйте снова");
                return true;
            }
        }
        public static bool InputChek3(string num, out int corrnum)
        {
            if (int.TryParse(num, out int intnum))
            {
                if (intnum == 1 | intnum == 2)
                {
                    corrnum = intnum;
                    return false;
                }
                else if (intnum == 3)
                {
                    corrnum = intnum;
                    return false;
                }
            }
            {
                corrnum = 0;
                Console.WriteLine("Не корректный ввод, попробуйте снова");
                return true;
            }
        }
    }
}
