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
    public partial class remove : Form
    {
         List<String> filenames = new List<String>();
        public remove()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            name.Visible = false;
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
        
        }

        private void remove_Load(object sender, EventArgs e)
        {

        }

        private void done_Click(object sender, EventArgs e)
        {
            
            if(done.Text.Equals("Delete")){
            String name,director;
                XmlDocument x = new XmlDocument();
                x.Load(comboBox3.Text+".xml");
                XmlNodeList xn = x.GetElementsByTagName("movie");
                for (int i = 0; i < xn.Count; i++)
                {
                    XmlNodeList xnl = xn[i].ChildNodes;
                    if (xnl[1].InnerText == title.Text)
                    {
                        name = xnl[1].InnerText;
                        director = xnl[2].InnerText;
                        xn[i].ParentNode.RemoveChild(xn[i]);
                        XmlDocument d = new XmlDocument();
                        d.Load("Director.xml");
                        XmlNodeList nl = d.GetElementsByTagName("director");
                        for (int j = 0; j < nl.Count; j++)
                        {
                            XmlNodeList dir = nl[j].ChildNodes;

                            if (dir[0].InnerText == director)
                            {
                               String[]s=dir[1].InnerText.Split(',');
                               String newmovies=null;
                               for (int k = 0; k < s.Length; k++)
                               {
                                   if (s[k] != name)
                                   {
                                       newmovies += s[k];
                                       if (k < s.Length - 1)
                                           newmovies += ",";
                                   }
                               }
                        dir[1].InnerText = newmovies;
                        d.Save("Director.xml");     
                                break;
                            }
                        }
                        x.Save(comboBox3.Text + ".xml");                                         
                        MessageBox.Show("Done");
                        Form1 f = new Form1();
                        this.Hide();
                        f.Show();
                    }
                }
        }
            else
            {
                bool exst = false;
                XmlDocument x = new XmlDocument();
                x.Load(comboBox3.Text+".xml");
                XmlNodeList xn = x.GetElementsByTagName("movie");
                for (int i = 0; i < xn.Count; i++)
                {
                    XmlNodeList xnl = xn[i].ChildNodes;
                    if (xnl[1].InnerText == title.Text)
                    {
                        pictureBox1.Visible = true;
                        name.Visible = true;
                        name.Text = xnl[1].InnerText;
                        pictureBox1.Image = Image.FromFile(xnl[6].InnerText);
                        exst = true;
                        break;
                    }
                }
                done.Text = "Delete";
                x.Save(comboBox3.Text + ".xml");
                if (!exst)
                    MessageBox.Show("Movie " + title.Text + " isn't exist !!");

            }
    }    
        

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Form1 RemoveOrUpdate = new Form1();
            this.Hide();
            RemoveOrUpdate.Show();
        }

        private void combo_rate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rate_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
