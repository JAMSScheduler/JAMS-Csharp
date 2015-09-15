Server svr = Server.GetServer("localhost");
 
//
// Load the CurJob
//
CurJob cj;
cj = CurJob.Find("Sleep120", StateType.Any, svr).FirstOrDefault();
 
// Hold the entry
if (cj != null)
{
    cj.Hold();
}
