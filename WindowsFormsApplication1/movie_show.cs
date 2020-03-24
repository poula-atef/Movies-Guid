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
    public partial class movie_show : Form
    {
        movie m; 
        public movie_show()
        {
            InitializeComponent();
        }

        public movie_show(movie m)
        {
            InitializeComponent();
            this.m = m;
            this.BackgroundImage = Image.FromFile(m.poster);
            media.URL = m.mov;
        }
        private void back_Click(object sender, EventArgs e)
        {
            view_movie v = new view_movie(m);
            this.Close();
            v.Show();
        }
    }
}
