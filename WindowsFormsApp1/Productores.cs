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
    public partial class Productores : Form
    {
        Thread th;
        public BaseDeDatos baseDeDatos;

        BindingSource productoresBinding = new BindingSource();
        public Productores(BaseDeDatos baseDeDatos1)
        {
            baseDeDatos = baseDeDatos1;
            InitializeComponent();
            productoresBinding.DataSource = baseDeDatos.productores;
            ProductoresLB.DataSource = productoresBinding;
            ProductoresLB.ValueMember = "Display";
            ProductoresLB.DisplayMember = "Display";
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
