using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TimeFunctions
{
    public class Time
    {
        private Timer timer = null;

        public delegate void functionToRun();
        private functionToRun function;

        public delegate void oneParam(string s);
        private oneParam one;
      
        

        public Time(functionToRun f, int intervalSeconds)
        {
            function = f;
            int time = intervalSeconds * 1000;
            timer = new Timer();
            timer.Interval = time;
            timer.Elapsed += new ElapsedEventHandler(timer_tick);
        }

    
        public void Start()
        {
            timer.Start();
        }
        
        public void Stop()
        {
            timer.Stop();
        }

        private void timer_tick(object sender, ElapsedEventArgs e)
        {
            function();
        }


       
        
    }
}
