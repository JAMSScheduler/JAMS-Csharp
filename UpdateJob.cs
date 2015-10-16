using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVPSI.JAMS;

namespace UpdateJob
{
    class Program
    {
        static void Main(string[] args)
        {
            Server jamsServer = Server.GetServer("localhost");

            //
            //  Load the JAMS job deinition
            //
            Job job;
            Job.Load(out job, @"\Samples\Sleep120");

            //
            //  Change the scheduled date
            //
            job.ScheduledDate = "First workday of month";

            //
            //  Save the changes
            //
            job.Update();
        }
    }
}
