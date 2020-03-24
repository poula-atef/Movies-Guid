using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
namespace WindowsFormsApplication1
{
    public partial class search : Form
    {
        int count;
        Image im;
        List<String> filenames = new List<String>();
        List<movie> movies = new List<movie>();
        
        public search()
        {
            InitializeComponent(); 
            title.Visible = false;
            year.Visible = false;
            rate.Visible = false;
            comboBox2.Visible = false;
            label5.Visible = false;
            label3.Visible = false;
            name.Visible = false;
            right.Visible = false;
            left.Visible = false;
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
            catch (Exception e)
            {
                MessageBox.Show("There's no file read from !!");
            }
        }
        public search(movie m)
        {
            InitializeComponent();
            pictureBox1.Visible = true;
            name.Visible = true;
            name.Text = m.title;
            pictureBox1.Image = Image.FromFile(m.poster);
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            left.Visible = false;
            right.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
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

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "title")
            {
               
                movies.Clear();
                XmlDocument x = new XmlDocument();
                x.Load(comboBox3.SelectedItem + ".xml");
                XmlNodeList xn = x.GetElementsByTagName("movie");
                for (int i = 0; i < xn.Count; i++)
                {
                    XmlNodeList xnl = xn[i].ChildNodes;
                    if (xnl[1].InnerText.Contains(title.Text))
                    {
                        movies.Add(new movie(xnl[0].InnerText, xnl[1].InnerText, xnl[2].InnerText, xnl[3].InnerText, xnl[4].InnerText, xnl[5].InnerText, xnl[6].InnerText, xnl[7].InnerText));
                    }
                }
                name.Visible = true;
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile(movies[count].poster);
                name.Text = movies[count].title;
                if (movies.Count > 1)
                {
                pictureBox2.Visible = true;
                pictureBox2.Image = Image.FromFile(movies[count+1].poster);
                right.Visible = true;
                }
            }
            else if (comboBox1.Text == "year")
            {
               
                movies.Clear();
                XmlDocument x = new XmlDocument();
                x.Load(comboBox3.Text + ".xml");
                XmlNodeList xn = x.GetElementsByTagName("movie");
                for (int i = 0; i < xn.Count; i++)
                {
                    XmlNodeList xnl = xn[i].ChildNodes;
                    if (xnl[3].InnerText == year.Text)
                    {
                        movies.Add(new movie(xnl[0].InnerText, xnl[1].InnerText, xnl[2].InnerText, xnl[3].InnerText, xnl[4].InnerText, xnl[5].InnerText, xnl[6].InnerText, xnl[7].InnerText));
                    }
                }
                name.Visible = true;
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile(movies[count].poster);
                name.Text = movies[count].title;
                if(movies.Count>1){
                pictureBox2.Visible = true;
                pictureBox2.Image = Image.FromFile(movies[count+1].poster);
                right.Visible = true;
                }
            }
            else if (comboBox1.Text == "rating")
            {
                movies.Clear();
                XmlDocument x = new XmlDocument();
                x.Load(comboBox3.Text + ".xml");
                XmlNodeList xn = x.GetElementsByTagName("movie");
                for (int i = 0; i < xn.Count; i++)
                {
                    XmlNodeList xnl = xn[i].ChildNodes;
                    if (comboBox2.Text == "below")
                    {
                        if (Convert.ToDouble(xnl[5].InnerText) <= Convert.ToDouble(rate.Text))
                        {
                            movies.Add(new movie(xnl[0].InnerText, xnl[1].InnerText, xnl[2].InnerText, xnl[3].InnerText, xnl[4].InnerText, xnl[5].InnerText, xnl[6].InnerText, xnl[7].InnerText));
                           }
                        }
                       else if (comboBox2.Text == "above")
                        {
                        if (Convert.ToDouble(xnl[5].InnerText) >= Convert.ToDouble(rate.Text))
                        {
                            movies.Add(new movie(xnl[0].InnerText, xnl[1].InnerText, xnl[2].InnerText, xnl[3].InnerText, xnl[4].InnerText, xnl[5].InnerText, xnl[6].InnerText, xnl[7].InnerText));                        
                        }
                        }
                }
                name.Visible = true;
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile(movies[count].poster);
                name.Text = movies[count].title;
                if (movies.Count > 1)
                {
                    pictureBox2.Visible = true;
                    pictureBox2.Image = Image.FromFile(movies[count + 1].poster);
                    right.Visible = true;
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "title")
            {
                title.Text = "";
                count = 0;
                left.Visible = false;
                right.Visible = false;
                name.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                title.Visible = true;
                year.Visible = false;
                rate.Visible = false;
                comboBox2.Visible = false;
                label5.Visible = false;
                label3.Visible = true;
                label3.Text = "title";
            }
            else if (comboBox1.Text == "rating")
            {
                rate.Text = "";
                count = 0;
                left.Visible = false;
                right.Visible = false;
                name.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                title.Visible = false;
                year.Visible = false;
                rate.Visible = true;
                comboBox2.Visible = true;
                label5.Visible = true;
                label3.Visible = true;
                label3.Text = "rating";
            }
            else if (comboBox1.Text == "year")
            {
                year.Text = "";
                count = 0;
                left.Visible = false;
                right.Visible = false;
                name.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                title.Visible = false;
                year.Visible = true;
                rate.Visible = false;
                comboBox2.Visible = false;
                label5.Visible = false;
                label3.Visible = true;
                label3.Text = "year";
            }
        }

        private void search_Load(object sender, EventArgs e)
        {

        }

        private void title_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void right_Click(object sender, EventArgs e)
        {
            if (count < movies.Count)
            {
                left.Visible = true;
                pictureBox3.Visible = true;
                pictureBox3.Image = Image.FromFile(movies[count].poster);
                count++;
                pictureBox1.Image = Image.FromFile(movies[count].poster);
                name.Text = movies[count].title;
                if (count == movies.Count - 1)
                {
                    pictureBox2.Visible = false;
                    right.Visible = false;
                }
                else
                    pictureBox2.Image = Image.FromFile(movies[count + 1].poster);
            }
        }

        private void left_Click(object sender, EventArgs e)
        {
            if (count >= 0)
            {
                right.Visible = true;
                pictureBox2.Visible = true;
                pictureBox2.Image = Image.FromFile(movies[count].poster);
                count--;
                pictureBox1.Image = Image.FromFile(movies[count].poster);
                name.Text = movies[count].title;
                if (count == 0)
                {
                    pictureBox3.Visible = false;
                    left.Visible = false;
                }
                else
                    pictureBox3.Image = Image.FromFile(movies[count - 1].poster);
            }

        }

        private void name_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            view_movie v = new view_movie(movies[count]);
            this.Hide();
            v.Show();
        }
    }
}
