using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace takımoyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        Random rastgele=new Random();
        int fbpuan = 0, gspuan = 0, tspuan = 0, bjkpuan = 0;

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            label35.Visible = true;
            if (Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labelgspuan.Text) && Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labelbjkpuan.Text) && Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labeltspuan.Text))
            {
                label35.Text = "Şampiyon Fenerbahçe!";
                pictureBox1.ImageLocation = "C:\\Users\\edanu\\Desktop\\fblogo.png";


            }
            if (Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labelbjkpuan.Text) && Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labeltspuan.Text))
            {
                label35.Text = "Şampiyon Galatasaray!";
                pictureBox1.ImageLocation = "C:\\Users\\edanu\\Desktop\\gslogo.jpg";


            }
            if (Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labelgspuan.Text) && Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labeltspuan.Text))
            {
                label35.Text = "Şampiyon Beşiktaş!";
                pictureBox1.ImageLocation = "C:\\Users\\edanu\\Desktop\\bjklogo.png";


            }
            if (Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelgspuan.Text) && Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelbjkpuan.Text))
            {
                label35.Text = "Şampiyon Trabzonspor!";
                pictureBox1.ImageLocation = "C:\\Users\\edanu\\Desktop\\tslogo.png";


            }
            else
            {
                label35.Text = "Şampiyon Belirlenemedi:(";
            }
            


        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Visible = true;
            button3.Enabled = false;
            int f = rastgele.Next(0, 5);
            int g = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int t = rastgele.Next(0, 5);

            label30.Text = f.ToString();
            label32.Text = g.ToString();
            label29.Text = t.ToString();
            label31.Text = b.ToString();
            if (Convert.ToInt32(label30.Text) > Convert.ToInt32(label32.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label30.Text) < Convert.ToInt32(label32.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label30.Text) == Convert.ToInt32(label32.Text))
            {
                fbpuan = fbpuan + 1;
                gspuan = gspuan + 1;
                labelgspuan.Text = gspuan.ToString();
                labelfbpuan.Text = fbpuan.ToString();

            }
            if (Convert.ToInt32(label31.Text) > Convert.ToInt32(label29.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label31.Text) < Convert.ToInt32(label29.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label31.Text) == Convert.ToInt32(label29.Text))
            {
                tspuan = tspuan + 1;
                bjkpuan = bjkpuan + 1;
                labeltspuan.Text = tspuan.ToString();
                labelbjkpuan.Text = bjkpuan.ToString();
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            int f = rastgele.Next(0, 5);
            int g = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int t = rastgele.Next(0, 5);
            
            label3.Text = f.ToString();
            label4.Text = g.ToString();
            label7.Text = t.ToString();
            label8.Text = b.ToString();
            if (Convert.ToInt32(label3.Text) > Convert.ToInt32(label4.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text=fbpuan.ToString();
            }
            if (Convert.ToInt32(label3.Text) < Convert.ToInt32(label4.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text=gspuan.ToString();
            }
            if (Convert.ToInt32(label3.Text) == Convert.ToInt32(label4.Text))
            {
                fbpuan = fbpuan + 1;
                gspuan = gspuan + 1;
                labelgspuan.Text = gspuan.ToString();
                labelfbpuan.Text= fbpuan.ToString();

            }
            if(Convert.ToInt32(label8.Text) > Convert.ToInt32(label7.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text= bjkpuan.ToString();
            }
            if (Convert.ToInt32(label8.Text) < Convert.ToInt32(label7.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label8.Text) == Convert.ToInt32(label7.Text))
            {
                tspuan = tspuan + 1;
                bjkpuan=bjkpuan + 1;
                labeltspuan.Text = tspuan.ToString();
                labelbjkpuan.Text = bjkpuan.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            button2.Enabled = false;
            int f = rastgele.Next(0, 5);
            int g = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int t = rastgele.Next(0, 5);
            label20.Text = f.ToString();
            label22.Text = g.ToString();
            label21.Text = b.ToString();
            label19.Text = t.ToString();
            if (Convert.ToInt32(label20.Text) > Convert.ToInt32(label22.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label20.Text) < Convert.ToInt32(label22.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label20.Text) == Convert.ToInt32(label22.Text))
            {
                fbpuan = fbpuan + 1;
                gspuan = gspuan + 1;
                labelgspuan.Text = gspuan.ToString();
                labelfbpuan.Text = fbpuan.ToString();

            }
            if (Convert.ToInt32(label21.Text) > Convert.ToInt32(label19.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label21.Text) < Convert.ToInt32(label19.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label21.Text) == Convert.ToInt32(label19.Text))
            {
                tspuan = tspuan + 1;
                bjkpuan = bjkpuan + 1;
                labeltspuan.Text = tspuan.ToString();
                labelbjkpuan.Text = bjkpuan.ToString();
            }
        }
    }
}
