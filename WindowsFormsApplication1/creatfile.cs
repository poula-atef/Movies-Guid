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
using System.Xml;

namespace WindowsFormsApplication1
{
    public partial class creatfile : Form
    {

        public creatfile()
        {
            InitializeComponent();
        }
        public List<String> filenames = new List<string>();
        public creatfile(List<String> fn)
        {
            InitializeComponent();
            for (int i = 0; i < fn.Count; i++)
            {
                filenames.Add(fn[i]);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

            XmlWriter wr = XmlWriter.Create(textBox1.Text + ".xml");
            wr.WriteStartDocument();
            wr.WriteStartElement("Movies");
            wr.WriteEndElement();
            wr.WriteEndDocument();
            wr.Close();
            filenames.Add(textBox1.Text);
            textBox1.Text = "";
            MessageBox.Show("successfull !!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("file.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < filenames.Count; i++)
            {
                sw.WriteLine(filenames[i]);
            }
            sw.Close();
            fs.Close();
            filenames.Clear();
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void creatfile_Load(object sender, EventArgs e)
        {

        }


    }
}
