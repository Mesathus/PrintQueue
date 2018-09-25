using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows.Forms;

namespace PrintQueue
{
    public partial class Form1 : Form
    {
        private static readonly Timer printTimer = new Timer();

        public Form1()
        {
            InitializeComponent();
            printTimer.Tick += CheckJobs;
            printTimer.Interval = 5000;
            printTimer.Start();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            GetPrintJob();
        }

        private static void CheckJobs(object myobject, EventArgs e)
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
                        if(pages > 1)
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
    }
}
