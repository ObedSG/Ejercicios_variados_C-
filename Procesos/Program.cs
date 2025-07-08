using System.Diagnostics;
Console.WriteLine("***** Fun with Processes *****\n");
ListAllRunningProcesses();
Console.ReadLine();

static void ListAllRunningProcesses()
{
    // Get all the processes on the local machine, ordered by
    // PID.
    var runningProcs =
    from proc
    in Process.GetProcesses(".")
    orderby proc.Id
    select proc;
    // Print out PID and name of each process.
    foreach (var p in runningProcs)
    {
        string info = $"-> PID: {p.Id}\tName: {p.ProcessName}";
        Console.WriteLine(info);
    }
    Console.WriteLine("************************************\n");
}

static void GetSpecificProcess()
{
    Process theProc = null;
    try
    {
        theProc = Process.GetProcessById(30592);
        Console.WriteLine(theProc?.ProcessName);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
}


static void EnumModsForPid(int pID)
{
 Process theProc = null;
 try
 {
 theProc = Process.GetProcessById(pID);
 }
 catch(ArgumentException ex)
 {
 Console.WriteLine(ex.Message);
 return;
 }
 Console.WriteLine("Here are the loaded modules for: {0}",
 theProc.ProcessName);
 ProcessModuleCollection theMods = theProc.Modules;
 foreach(ProcessModule pm in theMods)
 {
 string info = $"-> Mod Name: {pm.ModuleName}";
 Console.WriteLine(info);
 }
 Console.WriteLine("************************************\n");
}