using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using ClassLibrary1;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace WindowsFormsApp1
{
    public partial class Peliculas : Form
    {
        Thread th;
        public BaseDeDatos baseDeDatos;

        BindingSource peliculaBinding = new BindingSource();



        public Peliculas(BaseDeDatos baseDeDatos1)
        {
            InitializeComponent();
            baseDeDatos = baseDeDatos1;
            peliculaBinding.DataSource = baseDeDatos.peliculas;
            PeliculasLB.DataSource = peliculaBinding;
            PeliculasLB.ValueMember = "DisplayP";
            PeliculasLB.DisplayMember = "DisplayP";

        }
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            th = new Thread(openLogin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openLogin()
        {
            Application.Run(new Form1(baseDeDatos));
        }
    }
}
