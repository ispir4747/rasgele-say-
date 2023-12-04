using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rasgele_sayı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //radom rasegele bir sayı next getir demek (0,100) arasında bir sayı seç demek
            Random ras= new Random();
            int say = ras.Next(0, 100);
            label1.Text = say.ToString();
            int sayy = ras.Next(2, 100);
            textBox1.Text = sayy.ToString();
        }
    }
}
