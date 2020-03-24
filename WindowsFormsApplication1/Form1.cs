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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public List<String> filenames = new List<String>();
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(List<String> fn)
        {
            InitializeComponent();
            for (int i = 0; i < fn.Count; i++)
            {
                filenames.Add(fn[i]);
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            creatfile cf = new creatfile();
            this.Hide();
            cf.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            addmovie a = new addmovie();
            this.Hide();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            search s = new search();
            this.Hide();
            s.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            creatfile c = new creatfile();
            this.Hide();
            c.Show();
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            addmovie a = new addmovie();
            this.Hide();
            a.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RemoveOrUpdate u = new RemoveOrUpdate();
            this.Hide();
            u.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            join j = new join();
            this.Hide();
            j.Show();
        }
    }
}
