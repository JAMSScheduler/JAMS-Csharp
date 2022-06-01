using MVPSI.JAMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMSCustomConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var server = Server.GetServer("DF-JAMS7.helpsysdev.com");

            Submit.Info si;
            Submit.Load(out si, "\\Samples\\Sleep180", server);
           
            si.Submit();
            

        }
    }
}
