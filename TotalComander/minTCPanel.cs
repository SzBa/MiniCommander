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
                foreach (var d in value)
                {
                    comboBox1.Items.Add(d);
                }

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
                listBox1.Items.Clear();
                SelectedDriver();
            }
        }

        public void DisplayDirectoryContent()
        {
            try
            {
                string[] files = Directory.GetFiles(CurrentPath, "*.*");

                foreach (string s in files)
                {
                    listBox1.Items.Add(s);
                }

                string[] directories = Directory.GetDirectories(CurrentPath);

                foreach (string s in directories)
                {
                    listBox1.Items.Add("<DIR> " + s);
                }
            }
            catch
            {
                textBox1.Text = "Nie znaleziono plików! Upewnij się że to jest dysk";
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string file_temp = listBox1.SelectedItem.ToString();
            string file = "";

            if (file_temp.Substring(0, 6) == "<DIR> ")
            {
                file = file_temp.Substring(6, file_temp.Length - 6);
            }
            else
            {
                file = file_temp;
            }

            textBox1.Text = file;

            listBox1.Items.Clear();

            string[] files = Directory.GetFiles(file, "*.*");

            foreach (string s in files)
            {
                listBox1.Items.Add(s);
            }

            string[] directories = Directory.GetDirectories(file);

            foreach (string s in directories)
            {
                listBox1.Items.Add("<DIR> " + s);
            }
        }

        private void wstecz_Click(object sender, EventArgs e)
        {
            string file_temp = CurrentPath;
            
            string file1 = "";
            string plik = null;

            if (file_temp.Substring(file_temp.Length-1,1) == @"\")
            {
                plik = file_temp.Substring(0, file_temp.Length - 1);
            }
            else
            {
                plik = file_temp;
            }

            string[] file = plik.Split('\\');

            for (int n = 0; n < file.Length - 1; n++)
            {
                file1 += file[n] + @"\";
            }

            CurrentPath = file1;
            textBox1.Text = file1;

            listBox1.Items.Clear();
            DisplayDirectoryContent();

        }
    }
}
    

