using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//ALL OFFSET FIND BY EFK
//ALL CODED BY : EFK
//- YouTube : EFK
// - Discord : EFK#6607
namespace PLUTONIUM_TOOL_BY_EFK
{
    public partial class HUB : Form
    {
        public HUB()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new ZOMBIES().Show();
            this.Hide();
        }
    }
}
//ALL OFFSET FIND BY EFK
//ALL CODED BY : EFK
//- YouTube : EFK
// - Discord : EFK#6607