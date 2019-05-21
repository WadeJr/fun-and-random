using DirectoriesLib;
using System.ServiceProcess;
using System.Threading;
using TimeFunctions;

namespace SynologyService
{
    public partial class Service1 : ServiceBase
    {
        Synology school = new Synology(@"C:\Users\wade2\Desktop\School", @"D:\SynologyDrive\School");
        Synology personal = new Synology(@"C:\Users\wade2\Desktop\Personal or Others", @"D:\SynologyDrive\Personal or Others");
        Synology hacking = new Synology(@"C:\Users\wade2\Desktop\Hacking", @"D:\SynologyDrive\Hacking");

        Time schoolTimer;
        Time personalTimer;
        Time hackingTimer;


        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            schoolTimer = new Time (school.Start, 60 * 30);
            personalTimer = new Time(personal.Start, 60 * 30);
            hackingTimer = new Time(hacking.Start, 60 * 30);

            schoolTimer.Start();
            Thread.Sleep(3000);
            personalTimer.Start();
            Thread.Sleep(3000);
            hackingTimer.Start();
            

        }

        protected override void OnStop()
        {
            schoolTimer.Stop();
            personalTimer.Stop();
            hackingTimer.Stop();
        }
    }
}
