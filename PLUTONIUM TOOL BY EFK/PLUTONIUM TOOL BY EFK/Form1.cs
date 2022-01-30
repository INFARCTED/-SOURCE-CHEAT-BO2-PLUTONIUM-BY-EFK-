using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;
//ALL OFFSET FIND BY EFK
//ALL CODED BY : EFK
//- YouTube : EFK
// - Discord : EFK#6607
namespace PLUTONIUM_TOOL_BY_EFK
{
    public partial class Form1 : Form
    {
        Mem m = new Mem();
        int mov;
        int movx;
        int movy;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           Form1.ActiveForm.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movx = e.X;
            movy = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m.OpenProcess("plutonium-bootstrapper-win32.exe");
            m.WriteMemory("0x2A44620", "int", "1");
            m.WriteMemory("0x2A44740", "int", "1");
            m.WriteMemory("0x298E013", "string", "^6INFARCTED^7.^2CC^6 GET DESTROY ^7[Black Ops 2 Plutonium]^6 SO FUCKING EASY ^7[THANKS FOR USING INFARCTED.^2CC^7] ^6https://discord.gg/EWvNEqjvwk");
            m.WriteMemory("0x298E001", "string", "^5GET HACKED EZZ ");
            label4.Text = "STATUS : UNDETECTED AND ATTACHED";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                m.WriteMemory("0x2A38DA0", "int", "0");
            }
            else
            {
                m.WriteMemory("0x2A38DA0", "int", "1");
            }
       }

        private void button1_Click(object sender, EventArgs e)
        {
            //r_sky_colortemp
            m.WriteMemory("0x2A3F2E0", "float", "1500");
            //r_skytransition
            m.WriteMemory("0x2A3F040", "float", "1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //r_sky_colortemp
            m.WriteMemory("0x2A3F2E0", "float", "1500");
            //r_skytransition
            m.WriteMemory("0x2A3F040", "float", "-10");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //r_sky_colortemp
            m.WriteMemory("0x2A3F2E0", "float", "6500");
            //r_skytransition
            m.WriteMemory("0x2A3F040", "float", "4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //r_sky_colortemp
            m.WriteMemory("0x2A3F2E0", "float", "1500");
            //r_skytransition
            m.WriteMemory("0x2A3F040", "float", "4");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //r_sky_colortemp
            m.WriteMemory("0x2A3F2E0", "float", "6500");
            //r_skytransition
            m.WriteMemory("0x2A3F040", "float", "1");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                m.WriteMemory("0x2A41140", "int", "1");
            }
            else
            {
                m.WriteMemory("0x2A41140", "int", "0");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
          

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                m.WriteMemory("0x2A46180", "int", "1");
            }
            else
            {
                m.WriteMemory("0x2A46180", "int", "0");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            m.WriteMemory("0x02A3EA40", "float", textBox1.Text);
            m.WriteMemory("0x02A3EA44", "float", textBox2.Text);
            m.WriteMemory("0x02A3EA48", "float", textBox3.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            m.WriteMemory("0x2A2E060", "float", "999999");
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new STATS().Show();
            MessageBox.Show("welcome to stats editor");
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                m.WriteMemory("0x2A34CC0", "int", "0");
            }
            else
            {
                m.WriteMemory("0x2A34CC0", "int", "1");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                m.WriteMemory("0x2A44DA0", "int", "1");
                m.WriteMemory("base+7FB154", "string", "^BXENONButtonStickAnimatedL^^5FPS : %i ^7| ^6MS : %02i ^7| ^2%dKBps ^BXENONButtonStickAnimatedR^     ");
            }
            else
            {
                m.WriteMemory("0x2A44DA0", "int", "0");
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                m.WriteMemory("0x2A44E00", "int", "1");
            }
            else
            {
                m.WriteMemory("0x2A44E00", "int", "0");
            }
        }
    }
}
//ALL OFFSET FIND BY EFK
//ALL CODED BY : EFK
//- YouTube : EFK
// - Discord : EFK#6607