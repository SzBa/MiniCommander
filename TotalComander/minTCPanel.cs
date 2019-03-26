using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TotalComander
{
    public partial class minTCPanel : UserControl
    {
        #region Prop

        public string[] Drivers
        {
            set
            {
                //int n = value.Length;
                foreach (var d in value)
                    comboBox1.Items.Add(d);
            }

        }

        public string CurrentPath
        {

            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }

        public string CurrentDrive
        {
            get
            {
                return comboBox1.SelectedItem.ToString();
            }
        }

        #endregion

        #region event
        public event Action SelectedDriver;
        #endregion

        public minTCPanel()
        {
            InitializeComponent();

            var drivers = Directory.GetLogicalDrives();

            foreach (var d in drivers)
                Console.WriteLine(d);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedDriver != null)
            {
                SelectedDriver();
            }
        }

    }
}
