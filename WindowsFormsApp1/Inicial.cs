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
    public partial class Inicial : Form
    {
        Thread th;
        public BaseDeDatos baseDeDatos;
        public List<Pelicula> peliculas;
        public List<Persona> personas;
        public List<Estudio> estudios;
        public List<PeliculaActor> peliculaActors;
        public List<PeliculaProductor> peliculaProductors;
        public List<Productor> productores;
        public List<Director> directores;
        public List<Actor> actores;
        public Inicial()
        {
           
            InitializeComponent();
            baseDeDatos = new BaseDeDatos();
            peliculas = new List<Pelicula>();
            personas = new List<Persona>();
            actores = new List<Actor>();
            directores = new List<Director>();
            estudios = new List<Estudio>();
            peliculaActors = new List<PeliculaActor>();
            peliculaProductors = new List<PeliculaProductor>();
            productores = new List<Productor>();
            
            setupData();
            
            ini();


        }
        private void openForm1()
        {
            Application.Run(new Form1(baseDeDatos));
        }
        private void setupData()
        {
            Director director1 = (new Director { nombre = "bob", apellido = "diaz", biografia = "hola", fechaNacimiento = "1/1/1995" });
            Actor actor1 = new Actor { nombre = "a", apellido = "b", fechaNacimiento = "1/1/1995", biografia = "holo" };
            Estudio estudio1 = new Estudio { nombre = "est1", direcion = "por ahi", fechaApertura = "un dia" };
            peliculas.Add(new Pelicula { nombre = "p1", director = director1, estudio = estudio1, descripcion = "pasan cosas", FechaEstreno = "un dia", presupuesto = 1 });
            estudios.Add(estudio1);
            Productor productor1 = new Productor { nombre = "bobi", apellido = "caca", biografia = "le gusta jugar dota", fechaNacimiento = "hoydia" };
            productores.Add(productor1);
            PeliculaActor peliculaActor1 = new PeliculaActor { actor = actor1, pelicula = peliculas[0] };
            peliculaActors.Add(peliculaActor1);
            PeliculaProductor peliculaProductor1 = new PeliculaProductor { productor = productor1, pelicula = peliculas[0] };
            peliculaActors.Add(peliculaActor1);
            personas.Add(actor1);
            personas.Add(director1);
            personas.Add(productor1);
            baseDeDatos.peliculas = peliculas;
            baseDeDatos.personas = personas;
            baseDeDatos.peliculaActor = peliculaActors;
            baseDeDatos.peliculaProductor = peliculaProductors;
            baseDeDatos.estudios = estudios;
            baseDeDatos.productores = productores;
            baseDeDatos.actores = actores;
            baseDeDatos.productores = productores;

        }

        private void ini()
        {
            System.Threading.Thread.Sleep(5000);
            th = new Thread(openForm1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            
        }

        private void Inicial_Load(object sender, EventArgs e)
        {

        }

        private void dele()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream mistream = new FileStream("Personas.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
            if (mistream.Length!=0)
            {
                personas = (List<Persona>)formatter.Deserialize(mistream);
            }
            mistream.Close();


            BinaryFormatter formatter1 = new BinaryFormatter();
            Stream mistream1 = new FileStream("Peliculas.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
            if (mistream1.Length != 0)
            {
                peliculas = (List<Pelicula>)formatter1.Deserialize(mistream1);
            }
            mistream1.Close();

            BinaryFormatter formatter2 = new BinaryFormatter();
            Stream mistream2 = new FileStream("Estudios.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
            if (mistream2.Length != 0)
            {
                estudios = (List<Estudio>)formatter2.Deserialize(mistream2);
            }
            mistream2.Close();

            BinaryFormatter formatter3 = new BinaryFormatter();
            Stream mistream3 = new FileStream("Personas.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
            if (mistream3.Length != 0)
            {
                peliculaActors = (List<PeliculaActor>)formatter3.Deserialize(mistream3);
            }
            mistream3.Close();

            BinaryFormatter formatter4 = new BinaryFormatter();
            Stream mistream4 = new FileStream("PeliculaProductor.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
            if (mistream4.Length != 0)
            {
                peliculaProductors = (List<PeliculaProductor>)formatter4.Deserialize(mistream4);
            }
            mistream4.Close();

            


        }
    }
}
