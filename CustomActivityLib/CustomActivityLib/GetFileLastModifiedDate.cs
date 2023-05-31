using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVPSI.JAMS.Activities;
using MVPSI.JAMS;
using System.IO;
using MVPSI.JAMS.Extensions;

namespace CustomActivityLib
{
    public sealed class GetFileLastModifiedDate : NativeActivity
    {
        public GetFileLastModifiedDate()
        {
        }

        // Define an activity input argument of type string
        public InArgument<string> FilePath { get; set; }
        public OutArgument<string> LastModifiedDate { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(NativeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            string path = context.GetValue(this.FilePath);

            FileInfo file = new FileInfo(path);
            // last write time
            DateTime dt = file.LastWriteTime;
            string dateString = dt.ToString("G");
            this.LastModifiedDate.Set(context, dateString);


        }
    }
}
