using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Thread th;
        public BaseDeDatos baseDeDatos;

        
        public Form1(BaseDeDatos baseDeDatos1)
        {
            InitializeComponent();
            baseDeDatos = baseDeDatos1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            th = new Thread(openProduct);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            th = new Thread(openPeli);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openPeli()
        {
            Application.Run(new Peliculas(baseDeDatos));
        }
        private void openDirect()
        {
            Application.Run(new Directores(baseDeDatos));
        }
        private void openEstud()
        {
            Application.Run(new Estudios(baseDeDatos));
        }
        private void openProduct()
        {
            Application.Run(new Productores(baseDeDatos));
        }
        private void openActor()
        {
            Application.Run(new Actores(baseDeDatos));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            th = new Thread(openActor);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            th = new Thread(openDirect);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            th = new Thread(openEstud);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
