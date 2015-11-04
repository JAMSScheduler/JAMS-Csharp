using System;
using MVPSI.JAMS;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the instance of the server
            MVPSI.JAMS.Server server = MVPSI.JAMS.Server.GetServer("localhost");

            // Get the collection of Cfg objects
            List<Cfg> cfgList = Cfg.Find("*", server).ToList();

            //
            // Output all Cfg values
            //
            foreach (Cfg cfg in cfgList)
            {
                Console.WriteLine("{0,-30}: {1}", cfg.CfgName, cfg.Value.ToString());
            }
            Console.ReadLine();

        }
    }
}