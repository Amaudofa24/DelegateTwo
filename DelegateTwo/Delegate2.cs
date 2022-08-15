using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTwo
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
        static void TryAnonymous()
        {
            Reel Ig = delegate (int percent)
            {
                var answer = percent / 100;
                Console.WriteLine(answer);
            };
        }

    }
}
