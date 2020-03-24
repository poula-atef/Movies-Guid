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
    public partial class RemoveOrUpdate : Form
    {
        public RemoveOrUpdate()
        {
            InitializeComponent();
        }

        private void REM_btn_Click(object sender, EventArgs e)
        {
            remove r = new remove();
            this.Hide();
            r.Show();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            update u = new update();
            this.Hide();
            u.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
    }
}
