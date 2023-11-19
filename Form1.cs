using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerenciador_produtos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] nomeFotosDosCarros = Directory.GetFiles(@"C:\Users\Marcele\OneDrive\Desktop\carros");
            foreach (string img in nomeFotosDosCarros)
            {
                string[] separador = img.Split('\\');
                string[] nomeSelecionado = separador[6].Split('.');
  
                if (comboBox2.Text == nomeSelecionado[0])
                {
                    pictureBox1.ImageLocation = @"C:\Users\Marcele\OneDrive\Desktop\carros\" + comboBox2.Text + ".jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = string.Empty;
           
            if (comboBox1.Text == "FIAT")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("ARGO");
                comboBox2.Items.Add("CRONOS");
                comboBox2.Items.Add("TORO");
                comboBox2.Items.Add("STRADA");
            }   
            else if (comboBox1.Text == "FORD")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("ECOSPORT");
                comboBox2.Items.Add("FORDKA");
                comboBox2.Items.Add("FUSION");
                comboBox2.Items.Add("RANGER");
            }
            else if (comboBox1.Text == "CHEVROLET")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("ONIX");
                comboBox2.Items.Add("PRISMA");
                comboBox2.Items.Add("S10");
                comboBox2.Items.Add("TRACKER");
            }
            else if (comboBox1.Text == "VOLKSWAGEN")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("GOL");
                comboBox2.Items.Add("NIVUS");
                comboBox2.Items.Add("TCROSS");
                comboBox2.Items.Add("VIRTUS");
            }
            else if (comboBox1.Text == "TOYOTA")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("COROLLA");
                comboBox2.Items.Add("HILUX");
                comboBox2.Items.Add("YARIS");
                comboBox2.Items.Add("SW4");
            }
        }
    }
}
