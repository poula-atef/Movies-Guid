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
    public partial class join : Form
    {
        public join()
        {
            List<string> filenames = new List<string>();
            InitializeComponent();
            String name, movies = null;
            FileStream fs = new FileStream("file.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            filenames.Clear();
            while (sr.Peek() != -1)
            {
                filenames.Add(sr.ReadLine());
            }
            fs.Close();
            sr.Close();
            if (!File.Exists("Director.xml"))
            {
                XmlWriter wr = XmlWriter.Create("Director.xml");
                wr.WriteStartDocument();
                wr.WriteStartElement("dir");
                wr.WriteEndElement();
                wr.WriteEndDocument();
                wr.Close();
            }
            for (int i = 0; i < filenames.Count; i++)
            {
                XmlDocument moviedoc = new XmlDocument();
                moviedoc.Load(filenames[i] + ".xml");
                XmlNodeList movienodelist = moviedoc.GetElementsByTagName("movie");
                int size = movienodelist.Count;
                for (int j = 0; j < size; j++)
                {
                    bool existmov = false, existdir = false;
                    XmlNodeList movie_node = movienodelist[j].ChildNodes;
                    XmlDocument directordoc = new XmlDocument();
                    directordoc.Load("Director.xml");
                    XmlNodeList directornodelist = directordoc.GetElementsByTagName("director");
                    int size1 = directornodelist.Count;

                    for (int k = 0; k < size1; k++)
                    {
                        XmlNodeList director_node = directornodelist[k].ChildNodes;
                        name = movie_node[2].InnerText;
                        if (movie_node[2].InnerText == director_node[0].InnerText)
                        {
                            String[] director_movies = director_node[1].InnerText.Split(',');
                            List<String> new_director_movies = new List<string>();
                            existdir = true;
                            for (int m = 0; m < director_movies.Length; m++)
                            {
                                if (movie_node[1].InnerText == director_movies[m])
                                    existmov = true;
                                new_director_movies.Add(director_movies[m]);
                            }
                            if (!existmov)
                            {
                                String movie_name = "";
                                new_director_movies.Add(movie_node[1].InnerText);
                                for (int mn = 0; mn < new_director_movies.Count; mn++)
                                {
                                    if (mn != (new_director_movies.Count - 1))
                                        movie_name += new_director_movies[mn] + ",";
                                    else
                                        movie_name += new_director_movies[mn];
                                }
                                director_node[1].InnerText = movie_name;
                            }
                            directordoc.Save("Director.xml");
                            break;
                        }
                    }

                    if (!existdir)
                    {
                        XmlDocument director = new XmlDocument();
                        XmlElement director_element = director.CreateElement("director");

                        XmlElement node = director.CreateElement("name");
                        node.InnerText = movie_node[2].InnerText;
                        director_element.AppendChild(node);

                        node = director.CreateElement("movies");
                        node.InnerText = movie_node[1].InnerText;
                        director_element.AppendChild(node);

                        director_element.AppendChild(node);

                        director.Load("Director.xml");
                        XmlElement root = director.DocumentElement;
                        root.AppendChild(director_element);
                        director.Save("Director.xml");
                    }
                }  //aflam
                moviedoc.Save(filenames[i] + ".xml");
            }

            dataGridView1.Rows.Clear();
            int max = 0;
            XmlDocument directordoc2 = new XmlDocument();
            directordoc2.Load("Director.xml");
            XmlNodeList directornodelist2 = directordoc2.GetElementsByTagName("director");
            for (int i = 0; i < directornodelist2.Count; i++)
            {
                XmlNodeList director_node2 = directornodelist2[i].ChildNodes;
                String[] m = director_node2[1].InnerText.Split(',');
                if (m.Length > max)
                {
                    max = m.Length;
                }
            }
            dataGridView1.Columns.Add("Name", "Name");
            for (int j = 0; j < max; j++)
            {
                dataGridView1.Columns.Add("Movie " + (j + 1), "Movie " + (j + 1));
            }
            for (int i = 0; i < directornodelist2.Count; i++)
            {
                XmlNodeList xnl = directornodelist2[i].ChildNodes;
                String n = xnl[0].InnerText;
                String na = xnl[0].Name;
                String[] m = xnl[1].InnerText.Split(',');
                String mo = xnl[1].Name;
                String[] m1 = new String[m.Length + 1];
                m1[0] = n;
                for (int j = 0; j < m.Length; j++)
                {
                    m1[j + 1] = m[j];
                }
                dataGridView1.Rows.Add(m1);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();

        }

        private void join_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
