//
// Connect to the JAMS Server
//
Server s = Server.GetServer("localhost");
s.UserName = @"MVP\MyAccount";
s.Password = "passwordHere";

//
// Submit a Job
//
Submit.Info si;
Submit.Load(out si,@"\Sleep120",s, Submit.Type.Job);
si.Submit();
