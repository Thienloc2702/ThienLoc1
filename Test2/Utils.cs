using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    internal class Utils
    {
        public static String getString(String inpMsg)
        {
            Console.WriteLine(inpMsg);
            String s = "";
            try
            {
                s = Console.ReadLine();
                if(s == null)
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return 5;
        }


        public static int getInteger(String inpMsg)
        {
            int i = 0;
            try
            {
                i = Convert.ToInt32(Console.ReadLine());    
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return i;
        }
    }
}
