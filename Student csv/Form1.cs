using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_csv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
    private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = openFileDialog.FileName;
                string data = File.ReadAllText(filepath);
                this.textBox1.Text = data;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string data = this.textBox1.Text;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV|*.csv";
            if(saveFileDialog.ShowDialog() ==DialogResult.OK)
            {
                string filepath = saveFileDialog.FileName;
                File.WriteAllText(filepath, data, Encoding.UTF8);
            }
        }
    }
    
}
