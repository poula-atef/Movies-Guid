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
    public partial class update : Form
    {
         List<String> filenames = new List<String>();
         String i,t,d,p,y,g,r;
        public update()
        {
            InitializeComponent();
            try
            {
                FileStream fs = new FileStream("file.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                filenames.Clear();
                while (sr.Peek() != -1)
                {
                    filenames.Add(sr.ReadLine());
                }
                fs.Close();
                sr.Close();
                for (int i = 0; i < filenames.Count; i++)
                {
                    comboBox3.Items.Add(filenames[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There's no file read from !!");
            }
           // this.Size = new System.Drawing.Size(739, 117);
            id.Visible = false;
            titl.Visible = false;
            director.Visible = false;
            year.Visible = false;
            genre.Visible = false;
            rating.Visible = false;
            poster.Visible = false;
           // done.Visible = false;
          //  back_btn.Visible = false;
            pictureBox1.Visible = false;
            choose.Visible = false;
        }

        private void update_Load(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void done_Click(object sender, EventArgs e)
        {
            if (done.Text == "Update")
            {
                XmlDocument x = new XmlDocument();
                x.Load(comboBox3.Text + ".xml");
                XmlNodeList xn = x.GetElementsByTagName("movie");
                for (int i = 0; i < xn.Count; i++)
                {
                    XmlNodeList xnl = xn[i].ChildNodes;
                    if (xnl[1].InnerText == title.Text)
                    {
                        xnl[0].InnerText = id.Text;
                        xnl[1].InnerText = titl.Text;
                        xnl[2].InnerText = director.Text;
                        xnl[3].InnerText = year.Text;
                        xnl[4].InnerText = genre.Text;
                        xnl[5].InnerText = rating.Text;
                        xnl[6].InnerText = poster.Text;
                        x.Save(comboBox3.Text + ".xml");
                        MessageBox.Show("Done !!");
                        Form1 f = new Form1();
                        this.Hide();
                        f.Show();
                        break;
                    }
                }
            }
            else
            {
                bool exst = false;
                XmlDocument x = new XmlDocument();
                x.Load(comboBox3.Text + ".xml");
                XmlNodeList xn = x.GetElementsByTagName("movie");
                for (int i = 0; i < xn.Count; i++)
                {
                    XmlNodeList xnl = xn[i].ChildNodes;
                    if (xnl[1].InnerText == title.Text)
                    {
                        exst = true;
                        id.Visible = true;
                        titl.Visible = true;
                        director.Visible = true;
                        year.Visible = true;
                        genre.Visible = true;
                        rating.Visible = true;
                        poster.Visible = true;
                        done.Visible = true;
                        back_btn.Visible = true;
                        pictureBox1.Visible = true;
                        choose.Visible = true;
                        id.Text = xnl[0].InnerText;
                        titl.Text = xnl[1].InnerText;
                        director.Text = xnl[2].InnerText;
                        year.Text = xnl[3].InnerText;
                        genre.Text = xnl[4].InnerText;
                        rating.Text = xnl[5].InnerText;
                        poster.Text = xnl[6].InnerText;
                        pictureBox1.Image = Image.FromFile(xnl[6].InnerText);
                        x.Save(comboBox3.Text + ".xml");
                        done.Text = "Update";
                        break;
                    }
                }
                if (!exst)
                    MessageBox.Show("Movie " + title.Text + " isn't exist !!");
            }
        
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void choose_Click(object sender, EventArgs e)
        {
            Image im;
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*.JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                poster.Text = f.FileName;
                im = Image.FromFile(f.FileName);
                pictureBox1.Image = im;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
