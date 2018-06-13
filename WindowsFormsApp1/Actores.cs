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
    public partial class Actores : Form
    {
        Thread th;
        public BaseDeDatos baseDeDatos;

        BindingSource actorBinding = new BindingSource();

        public Actores(BaseDeDatos baseDeDatos1)
        {
            InitializeComponent();
            baseDeDatos = baseDeDatos1;
            actorBinding.DataSource = baseDeDatos.actores;
            actoresLB.DataSource = actorBinding;
            actoresLB.ValueMember = "Display";
            actoresLB.DisplayMember = "Display";
        }

        private void Actores_Load(object sender, EventArgs e)
        {

        }

        private void volver_Click(object sender, EventArgs e)
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
