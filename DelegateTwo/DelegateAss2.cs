using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Delegate2
    {
        public delegate void Reel(int percentConcluded);
        public static void ReelUploader(Reel re)
        {
            
            {
                for (int i = 0; i < 100000; i++)
                {
                    var Concluded = i.ToString();
                    re(i);
                }
            }
        }
      

    }
}
