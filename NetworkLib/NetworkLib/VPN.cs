using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NetworkLib
{
    public class VPN
    {
        public static void Connect(string connectionName, string username, string password)
        {
            System.Diagnostics.Process.Start("rasdial.exe", connectionName + " " + username + " " + password);
        }
        
        public static void Disconnect(string connectionName)
        {
            System.Diagnostics.Process.Start("rasdial.exe", connectionName + " /d");
        }
    }


    public class Network
    {
        private static List<string> users = new List<string>();

        private static string NetworkGateway()
        {
            string ip = null;

            foreach (System.Net.NetworkInformation.NetworkInterface f in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (f.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (GatewayIPAddressInformation d in f.GetIPProperties().GatewayAddresses)
                    {
                        ip = d.Address.ToString();
                    }
                }
            }

            return ip;
        }

        public List<string> Ping_all()
        {

            string gate_ip = NetworkGateway();

            //Extracting and pinging all other ip's.
            string[] array = gate_ip.Split('.');

            for (int i = 0; i <= 255; i++)
            {

                string ping_var = array[0] + "." + array[1] + "." + array[2] + "." + i;
               // users.Add("Testing: " + ping_var);
                //time in milliseconds           
                Ping(ping_var, 5, 20000);

            }

            return users;

        }

        public void Ping(string host, int attempts, int timeout)
        {
            for (int i = 0; i < attempts; i++)
            {
                //new Thread(delegate ()
                //{
                //    try
                //    {
                        System.Net.NetworkInformation.Ping ping = new System.Net.NetworkInformation.Ping();
                        ping.PingCompleted += new PingCompletedEventHandler(PingCompleted);
                        ping.SendAsync(host, timeout, host);
                //    }
                //    catch
                //    {
                //        // Do nothing and let it try again until the attempts are exausted.
                //        // Exceptions are thrown for normal ping failurs like address lookup
                //        // failed.  For this reason we are supressing errors.
                //    }
                //}).Start();
            }
        }




        private void PingCompleted(object sender, PingCompletedEventArgs e)
        {
           
            string user = "";
            string ip = (string)e.UserState;
            if (e.Reply != null && e.Reply.Status == IPStatus.Success)
            {
                string hostname = GetHostName(ip);
                string macaddres = GetMacAddress(ip);
                string[] arr = new string[3];

                //store all three parameters to be shown on ListView
                arr[0] = ip;
                arr[1] = hostname;
                arr[2] = macaddres;
                user = hostname + " " + ip + " " + macaddres;
                users.Add(user);

                // Logic for Ping Reply Success -----------HERE
                //ListViewItem item;
                //if (this.InvokeRequired)
                //{

                //    this.Invoke(new Action(() =>
                //    {

                //        item = new ListViewItem(arr);

                //        lstLocal.Items.Add(item);


                //    }));
                //}


            }
            else
            {
                // MessageBox.Show(e.Reply.Status.ToString());
            }
          
        }


        public string GetHostName(string ipAddress)
        {
            try
            {
                IPHostEntry entry = Dns.GetHostEntry(ipAddress);
                if (entry != null)
                {
                    return entry.HostName;
                }
            }
            catch (SocketException)
            {
                // MessageBox.Show(e.Message.ToString());
            }

            return null;
        }


        //Get MAC address
        public string GetMacAddress(string ipAddress)
        {
            string macAddress = string.Empty;
            System.Diagnostics.Process Process = new System.Diagnostics.Process();
            Process.StartInfo.FileName = "arp";
            Process.StartInfo.Arguments = "-a " + ipAddress;
            Process.StartInfo.UseShellExecute = false;
            Process.StartInfo.RedirectStandardOutput = true;
            Process.StartInfo.CreateNoWindow = true;
            Process.Start();
            string strOutput = Process.StandardOutput.ReadToEnd();
            string[] substrings = strOutput.Split('-');
            if (substrings.Length >= 8)
            {
                macAddress = substrings[3].Substring(Math.Max(0, substrings[3].Length - 2))
                         + "-" + substrings[4] + "-" + substrings[5] + "-" + substrings[6]
                         + "-" + substrings[7] + "-"
                         + substrings[8].Substring(0, 2);
                return macAddress;
            }

            else
            {
                return "OWN Machine";
            }
        }



















        static CountdownEvent countdown;
        static int upCount = 0;
        static object lockObj = new object();
        const bool resolveNames = true;

        static void Main(string[] args)
        {
            countdown = new CountdownEvent(1);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            string ipBase = "10.22.4.";
            for (int i = 1; i < 255; i++)
            {
                string ip = ipBase + i.ToString();

                Ping p = new Ping();
                p.PingCompleted += new PingCompletedEventHandler(p_PingCompleted);
                countdown.AddCount();
                p.SendAsync(ip, 100, ip);
            }
            countdown.Signal();
            countdown.Wait();
            sw.Stop();
            TimeSpan span = new TimeSpan(sw.ElapsedTicks);
            Console.WriteLine("Took {0} milliseconds. {1} hosts active.", sw.ElapsedMilliseconds, upCount);
            Console.ReadLine();
        }

        static void p_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            string ip = (string)e.UserState;
            if (e.Reply != null && e.Reply.Status == IPStatus.Success)
            {
                if (resolveNames)
                {
                    string name;
                    try
                    {
                        IPHostEntry hostEntry = Dns.GetHostEntry(ip);
                        name = hostEntry.HostName;
                    }
                    catch (SocketException ex)
                    {
                        name = "?";
                    }
                    Console.WriteLine("{0} ({1}) is up: ({2} ms)", ip, name, e.Reply.RoundtripTime);
                }
                else
                {
                    Console.WriteLine("{0} is up: ({1} ms)", ip, e.Reply.RoundtripTime);
                }
                lock (lockObj)
                {
                    upCount++;
                }
            }
            else if (e.Reply == null)
            {
                Console.WriteLine("Pinging {0} failed. (Null Reply object?)", ip);
            }
            countdown.Signal();
        }
   






    }






}
