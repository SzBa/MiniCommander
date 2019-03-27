using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace TotalComander
{
    public partial class ComandControlPanel : Form
    {      
        public ComandControlPanel()
        {
            InitializeComponent();
            minTCPanel1.CurrentPath = @"C:\";
            minTCPanel1.Drivers = Directory.GetLogicalDrives();
            minTCPanel1.SelectedDriver += MinTCPanel1_SelectedDriver;
        }

        private void MinTCPanel1_SelectedDriver()
        {
            minTCPanel1.CurrentPath = minTCPanel1.CurrentDrive;
            minTCPanel1.DisplayDirectoryContent();
        }

        
    }
}