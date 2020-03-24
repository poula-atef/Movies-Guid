using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class view_movie : Form
    {
        movie mov;   
        public view_movie()
        {
            InitializeComponent();
        }
        public view_movie(movie m)
        {
            InitializeComponent();
            id.Text = m.id;
            title.Text = m.title;
            director.Text = m.director;
            year.Text = m.year;
            genre.Text = m.genres;
            rate.Text = m.rating;
            this.BackgroundImage = Image.FromFile(m.poster);
            mov = m;
        }

        private void view_movie_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            search s = new search(mov);
            this.Hide();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            movie_show ms = new movie_show(mov);
            this.Hide();
            ms.Show();
        }
    }
}
