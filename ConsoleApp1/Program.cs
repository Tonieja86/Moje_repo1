
using System.Diagnostics;


string a=Console.ReadLine();


Process process = new Process();
process.StartInfo.UseShellExecute = true;
process.StartInfo.WorkingDirectory = "C:\\";
process.StartInfo.FileName = @a;
process.Start();




//ProcessStartInfo startInfo = new ProcessStartInfo();
//startInfo.UseShellExecute=true;
//startInfo.WorkingDirectory = "C:\\";
//startInfo.FileName = @"C: \Users\kpajo\Downloads\tttt.xlsx";

//startInfo.UseShellExecute = true;

//startInfo.WindowStyle = ProcessWindowStyle.Maximized;

//System.Diagnostics.Process.Start(startInfo);

//startInfo = New System.Diagnostics.ProcessStartInfo;
//startInfo.FileName = "C:\PROGRA~1\MICROS~2\Office14\EXCEL.EXE";
// startInfo.Arguments = """" & "C:\Temp\1\Book1.xlsx" & """";
//startInfo.UseShellExecute = True;
//startInfo.WindowStyle = ProcessWindowStyle.Maximized;
//System.Diagnostics.Process.Start(startInfo);
// startInfo = New System.Diagnostics.ProcessStartInfo
// startInfo.FileName = "C:\PROGRA~1\MICROS~2\Office14\EXCEL.EXE"
// startInfo.Arguments = """" & "C:\Temp\2\Book2.xlsx" & """"
// startInfo.UseShellExecute = True
// startInfo.WindowStyle = ProcessWindowStyle.Maximized
// System.Diagnostics.Process.Start(startInfo)


//process





























//process.Start();






//System.Diagnostics.Process.Start(@"SteamSetup.exe");



//namespace MyProcessSample
//{
//    class MyProcess
//    {
//        // Opens the Internet Explorer application.
//        void OpenApplication(string myFavoritesPath)
//        {
//            // Start Internet Explorer. Defaults to the home page.
//            Process.Start("SteamSetup.exe");

//            // Display the contents of the favorites folder in the browser.
//            Process.Start(myFavoritesPath);
//        }

//        // Opens urls and .html documents using Internet Explorer.
//        void OpenWithArguments()
//        {
//            // url's are not considered documents. They can only be opened
//            // by passing them as arguments.
//            //Process.Start("IExplore.exe", "www.northwindtraders.com");

//            // Start a Web page using a browser associated with .html and .asp files.
//            Process.Start("IExplore.exe", "C:\\myPath\\myFile.htm");
//            Process.Start("IExplore.exe", "C:\\myPath\\myFile.asp");
//        }

//        // Uses the ProcessStartInfo class to start new processes,
//        // both in a minimized mode.
//        void OpenWithStartInfo()
//        {
//            ProcessStartInfo startInfo = new ProcessStartInfo("IExplore.exe");
//            startInfo.WindowStyle = ProcessWindowStyle.Minimized;

//            Process.Start(startInfo);

//            startInfo.Arguments = "www.northwindtraders.com";

//            Process.Start(startInfo);
//        }

//        static void Main()
//        {
//            // Get the path that stores favorite links.
//            string myFavoritesPath =
//                Environment.GetFolderPath(Environment.SpecialFolder.Favorites);

//            MyProcess myProcess = new MyProcess();

//            myProcess.OpenApplication(myFavoritesPath);
//            myProcess.OpenWithArguments();
//            myProcess.OpenWithStartInfo();
//        }
//    }
//}