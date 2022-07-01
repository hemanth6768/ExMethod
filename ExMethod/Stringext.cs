using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExMethod
{
    static class Stringext
    {
        public static void Tocurrency(this String s, string value)
        {
            try
            {


                if (int.TryParse(value, out var i))
                {
                    Console.WriteLine("$"+value);
                }
                else
                {
                    throw new Exception();
                }


            }
            catch(Exception ex)
            {
                Console.WriteLine(" enter string as numeric",ex);   
            }

            
        
            
        }
    }
}
