using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1
{
    [Serializable()]
    public class BaseDeDatos
    {
        // SERIALIZACION


        public static void SerializarP(BaseDeDatos bdd)
        {

            FileStream _fs = new FileStream(@"..\..\docs\bdd.dat", FileMode.Create);
            BinaryFormatter _formatter = new BinaryFormatter();
            _formatter.Serialize(_fs, bdd);
            _fs.Close();
        }
        public static BaseDeDatos DeserializarP(string pArchivo)
        {
            if (File.Exists(@"..\..\docs\" + pArchivo) == true)
            {
                FileStream _fs = new FileStream(@"..\..\docs\" + pArchivo, FileMode.Open);
                BinaryFormatter _formatter = new BinaryFormatter();
                BaseDeDatos bdd1 = _formatter.Deserialize(_fs) as BaseDeDatos;
                _fs.Close();
                return bdd1;
            }
            return new BaseDeDatos();


        }



        List<Pelicula> peliculas = new List<Pelicula>();
        List<Actor> actores = new List<Actor>();
        List<Director> directores = new List<Director>();
        List<Productor> productores = new List<Productor>();
        List<Estudio> estudios = new List<Estudio>();


        public class Pelicula
        {
            private string nombre;
            private string director;
            private string fecha;
            private string descripcion;
            private int presupuesto;
            private Estudio estudio;

            public Pelicula(string nombre, string director, string fecha, string descripcion, int presupuesto, Estudio estudio)
            {
                this.nombre = nombre;
                this.director = director;
                this.fecha = fecha;
                this.descripcion = descripcion;
                this.presupuesto = presupuesto;
                this.estudio = estudio;
            }

            public string Nombre { get => nombre; set => nombre = value; }
            public string Director { get => director; set => director = value; }
            public string Fecha { get => fecha; set => fecha = value; }
            public string Descripcion { get => descripcion; set => descripcion = value; }
            public int Presupuesto { get => presupuesto; set => presupuesto = value; }
            public Estudio Estudio { get => estudio; set => estudio = value; }
        }


        public class Persona
        {
            private string nombre;
            private string apellido;
            private string fechanacimiento;
            private string biografia;




            public Persona(string nombre, string apellido, string fechanacimiento, string biografia)
            {
                this.Nombre = nombre;
                this.Apellido = apellido;
                this.Fechanacimiento = fechanacimiento;
                this.Biografia = biografia;

            }

            public string Nombre { get => nombre; set => nombre = value; }
            public string Biografia { get => biografia; set => biografia = value; }
            public string Apellido { get => apellido; set => apellido = value; }
            public string Fechanacimiento { get => fechanacimiento; set => fechanacimiento = value; }


        }


        public class Actor:Persona
        {
            private string tipo="actor";

            public Actor(string actor, string nombre, string apellido, string fechanacimiento, string biografia, int tipo) : base(nombre,apellido,fechanacimiento,biografia)
            {
                this.tipo = actor;
            }

        }

        public class Director : Persona
        {
            private string tipo = "director";

            public Director(string actor, string nombre, string apellido, string fechanacimiento, string biografia, int tipo) : base(nombre, apellido, fechanacimiento, biografia)
            {
                this.tipo = actor;
            }

        }

        public class Productor : Persona
        {
            private string tipo = "productor";

            public Productor(string actor, string nombre, string apellido, string fechanacimiento, string biografia, int tipo) : base(nombre, apellido, fechanacimiento, biografia)
            {
                this.tipo = actor;
            }

        }
        public class Estudio
        {
            private string nombre;
            private string direccion;
            private string fechaApertura;

            public Estudio(string nombre, string direccion, string fechaApertura)
            {
                this.nombre = nombre;
                this.direccion = direccion;
                this.fechaApertura = fechaApertura;
            }

            public string Nombre { get => nombre; set => nombre = value; }
            public string Direccion { get => direccion; set => direccion = value; }
            public string FechaApertura { get => fechaApertura; set => fechaApertura = value; }
        }

        public class PeliculaActor
        {
            private Pelicula pelicula;
            private Actor actor;

            public PeliculaActor(Pelicula pelicula, Actor actor)
            {
                this.Pelicula = pelicula;
                this.Actor = actor;
            }

            public Pelicula Pelicula { get => pelicula; set => pelicula = value; }
            public Actor Actor { get => actor; set => actor = value; }
        }


        public class PeliculaProductor
        {
            private Pelicula pelicula;
            private Productor productor;

            public PeliculaProductor(Pelicula pelicula, Productor productor)
            {
                this.Pelicula = pelicula;
                this.Productor = productor;
            }

            public Pelicula Pelicula { get => pelicula; set => pelicula = value; }
            public Productor Productor { get => productor; set => productor = value; }
        }









        
    }


    


}
