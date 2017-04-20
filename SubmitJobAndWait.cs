//
// Get a connection to our JAMS Server
// You will probably have to change the node name "localhost"
// to the name of your JAMS Server
//
JAMS.Server server = JAMS.Server.GetServer("localhost");
//
// Load the job that we want to submit
//
JAMS.Submit.Info si;
JAMS.Submit.Load(out si, "BackupDB", server, JAMS.Submit.Type.Job);
//
// Finish the submit
//
si.Submit()

// Monitor a Job After Submitting

// If you want the application to wait for the completion  and then check you could add this code after your code:
//
            // Wait for the entry to complete with Info for better
            //
            WaitFor waitFor = new WaitFor(server);
            waitFor.Entry(si.JAMSEntry, Severity.Info);
            waitFor.Wait(new TimeSpan(0, 5, 0));
            //
            // Get the CurJob and check its completion severity
            //
            CurJob cJob = CurJob.Find(si.JAMSEntry, StateType.Any, server).FirstOrDefault();
            if (cJob != null)
            {
                //
                // Take some action based on the completion severity
                //
                switch (cJob.FinalSeverity)
                {
                    case Severity.Success:
                        break;
                    case Severity.Warning:
                        break;
                    case Severity.Info:
                        break;
                    case Severity.Fatal:
                        break;
                    case Severity.Error:
                        break;
                    default:
                        break;
                }
            }
