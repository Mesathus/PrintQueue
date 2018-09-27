using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Management;
using System.Windows.Forms;

namespace PrintQueue
{
    public partial class Form1 : Form
    {
        List<string> loginNames = new List<string>();
        private static readonly System.Windows.Forms.Timer printTimer = new System.Windows.Forms.Timer();
        private static System.Threading.Timer queueTimer = new System.Threading.Timer(Callback,null,10,Timeout.Infinite);
        //Print queue network path:   \\ALABSPRINTSRV01\A-208 HP M605 Pool
        //ManagementObject a208printer = new ManagementObject("\\\\ALABSPRINTSRV01\\A-208 HP M605 Pool");
        private static void Callback(Object state)
        {
            queueTimer.Change(10, Timeout.Infinite);
        }


        public Form1()
        {
            InitializeComponent();
            //printTimer.Tick += CheckJobs;
            printTimer.Tick += TestCheck;
            printTimer.Interval = 5000;
            printTimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetPrintJob();
        }

        private void TestCheck(object sender, EventArgs e)
        {
            printTimer.Stop();
            if(pqListBox.Items.Count > 0)
            {
                for(int i = 0; i < pqListBox.Items.Count; i++)
                {
                    string[] user; int pages;
                    user = pqListBox.Items[i].ToString().Split('\t',' ');
                    pages = int.Parse(user[1]);
                    if (pages > 10)
                    {

                        DialogResult mBox = MessageBox.Show("User " + user[0] + " has created a job with " + pages.ToString()
                            + " pages.  Would you like to delete this job?", "Process Job?", MessageBoxButtons.YesNo);
                        if(mBox == DialogResult.Yes)
                        {
                            pqListBox.Items.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
            printTimer.Start();
        }

        

        private static void CheckJobs(object sender, EventArgs e)
        {
            printTimer.Stop();
            string searchQuery = "SELECT * FROM Win32_PrintJob";
            ManagementObjectSearcher printJobs = new ManagementObjectSearcher(searchQuery);
            ManagementObjectCollection printJobCollection = printJobs.Get();
            if(printJobCollection.Count > 0)
            {
                foreach(ManagementObject job in printJobCollection)
                {
                    if(int.TryParse(job["TotalPages"].ToString(), out int pages))
                    {
                        if (pages > 2)
                        {
                            job.Delete();
                        }
                        else
                        {
                            MessageBox.Show(job["TotalPages"].ToString() + " page to print");
                        }
                    }
                }
                MessageBox.Show("Jobs in Queue");
            }
            printTimer.Start();
        }

        private static void GetPrintJob()
        {
            string searchQuery = "SELECT * FROM Win32_PrintJob";
            ManagementObjectSearcher printJobs = new ManagementObjectSearcher(searchQuery);
            ManagementObjectCollection printJobCollection = printJobs.Get();
            foreach(ManagementObject job in printJobCollection)
            {
                MessageBox.Show(job["Name"].ToString() + 
                                "\n" + job["Owner"].ToString() +
                                "\n" + job["TimeSubmitted"].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //pause

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //resume

        }

        Random rand = new Random();
        private void testButton_Click(object sender, EventArgs e)
        {
            int ID = rand.Next(1, 34);
            int pages = rand.Next(1, 15);
            string job;
            if (ID < 10)
            {
                job = "A208-0" + ID + "\t" + pages + " pages";
            }
            else
            {
                job = "A208-" + ID + "\t" + pages + " pages";
            }
            pqListBox.Items.Add(job);
            /*
            List<string> loginNames = new List<string>();            
            loginNames.Clear();
            totalListBox.Items.Clear();
            loginNames.Add("A208-01\t\t15\t5");
            loginNames.Add("A208-02\t\t12\t8");
            loginNames.Add("A208-03\t\t17\t3");
            loginNames.Add("A208-04\t\t3\t2");
            totalListBox.Items.Add("Location\t\tDaily\tCurrent");
            foreach(string item in loginNames)
            {
                totalListBox.Items.Add(item);
            }
            */
        }

        private void resetUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(totalListBox.SelectedIndex != -1 && totalListBox.SelectedIndex > 0)
                {
                    int index = totalListBox.SelectedIndex;
                    string user = totalListBox.SelectedItem.ToString();
                    string[] userInfo = user.Split('\t');
                    userInfo[3] = "0";
                    totalListBox.Items.RemoveAt(index);
                    totalListBox.Items.Insert(index, userInfo[0] + "\t\t" + userInfo[2] + "\t" + userInfo[3]);
                }
                else
                {
                    MessageBox.Show("Please select a user to reset current page count for.");
                }
            }
            catch
            {
                MessageBox.Show("Error resetting user page count.");
            }
        }
    }
}
