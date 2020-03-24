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
    public partial class addmovie : Form
    {
        
        public List<String> filenames = new List<string>();
        public addmovie()
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
                    comboBox1.Items.Add(filenames[i]);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("There's no file write in !!");

            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || title.Text == "" || director.Text == "" || year.Text == "" || checkedListBox1.Text == "" || poster.Text == ""||movie.Text=="")
            {
                MessageBox.Show("Fill all the cells");
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Choose file to save in !!");
            }
            else
            {
                String m = movie.Text;
                String Id = id.Text;
                String Title = title.Text;
                String Director = director.Text;
                String Year = year.Text;
                String Genres=null;
                String Rating = textBox1.Text;
                String Poster = poster.Text;
                List<string> gen = new List<string>();
                int count = 0;
                foreach (String item in checkedListBox1.CheckedItems)
                {
                    count++;
                    gen.Add(item);
                }
                if (!File.Exists(comboBox1.Text + ".xml"))
                {
                    XmlWriter wr = XmlWriter.Create(comboBox1.Text + ".xml");
                    wr.WriteStartDocument();
                    wr.WriteStartElement("Movies");
                    wr.WriteStartElement("movie");

                    wr.WriteStartElement("id");
                    wr.WriteString(Id);
                    wr.WriteEndElement();

                    wr.WriteStartElement("title");
                    wr.WriteString(Title);
                    wr.WriteEndElement();

                    wr.WriteStartElement("director");
                    wr.WriteString(Director);
                    wr.WriteEndElement();

                    wr.WriteStartElement("year");
                    wr.WriteString(Year);
                    wr.WriteEndElement();


                    wr.WriteStartElement("genre");
                    for (int i = 0; i < count; i++)
                    {
                        Genres+=gen.ElementAt(i);
                        if (i < count - 1)
                        {
                            Genres += ",";
                        }
                    }
                    wr.WriteString(Genres);
                    wr.WriteEndElement();
                    
                    wr.WriteStartElement("rating");
                    wr.WriteString(Rating);
                    wr.WriteEndElement();

                    wr.WriteStartElement("poster");
                    wr.WriteString(Poster);
                    wr.WriteEndElement();

                    wr.WriteStartElement("mov");
                    wr.WriteString(m);
                    wr.WriteEndElement();

                    wr.WriteEndElement();
                    wr.WriteEndElement();
                    wr.Close();
                }
                else
                {
                    XmlDocument d = new XmlDocument();
                    XmlElement xe = d.CreateElement("movie");

                    XmlElement node = d.CreateElement("id");
                    node.InnerText = Id;
                    xe.AppendChild(node);

                    node = d.CreateElement("title");
                    node.InnerText = Title;
                    xe.AppendChild(node);

                    node = d.CreateElement("director");
                    node.InnerText = Director;
                    xe.AppendChild(node);

                    node = d.CreateElement("year");
                    node.InnerText = Year;
                    xe.AppendChild(node);

                    node = d.CreateElement("genre");
                    for (int i = 0; i < count; i++)
                    {
                        Genres += gen.ElementAt(i);
                        if (i < count - 1)
                        {
                            Genres += ",";
                        }
                    }
                    node.InnerText = Genres;
                    xe.AppendChild(node);

                    node = d.CreateElement("rating");
                    node.InnerText = Rating;
                    xe.AppendChild(node);

                    node = d.CreateElement("poster");
                    node.InnerText = Poster;
                    xe.AppendChild(node);

                    node = d.CreateElement("mov");
                    node.InnerText = m;
                    xe.AppendChild(node);

                    xe.AppendChild(node);
                    
                    d.Load(comboBox1.Text + ".xml");
                    XmlElement root = d.DocumentElement;
                    root.AppendChild(xe);
                    d.Save(comboBox1.Text + ".xml");
                }
                MessageBox.Show("Successfully added !!");
                Form1 f = new Form1();
                this.Hide();
                f.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(filenames);
            this.Hide();
            f.Show();
        }

        private void addmovie_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox1.Text) > 10)
                MessageBox.Show("you can't give rating more than 10 !!");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
                e.Handled = true;
        }

        private void year_TextChanged(object sender, EventArgs e)
        {

        }
        private void year_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
                e.Handled = true;
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
                e.Handled = true;
        }

        private void id_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
                e.Handled = true;
        }

        private void year_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
                e.Handled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "MP4(*.MP4)|*.mp4";
            if (o.ShowDialog() == DialogResult.OK)
            {
                movie.Text = o.FileName;
            }
        }
    }
}
