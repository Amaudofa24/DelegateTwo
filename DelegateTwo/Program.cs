using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Delegate2 de = new Delegate2();
            //de.ReelUploader(Instagram);

            Delegate2.ReelUploader(Instagram);


        }
        public static void Instagram(int r)
        {
            Console.WriteLine($"so far {r} done" );
        }
        
        

       
    } 
}

