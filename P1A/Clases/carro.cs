using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1A.Clases
{
    internal class carro
    {
        public string Marca { get;  }
        public int Modelo { get;  }
        public String Color { get; set; }

        public int Maxvel { get; set; }

        private int Encendido = 0;
        private int velocidad_actual = 0;
        private const int MAXVELOCIDAD = 150;

        //public int MAXVELOCIDAD { get; }

        public carro(string _marca, int _modelo, string _color, int _maxvel )
        {
            Marca = _marca;
            Modelo = _modelo;
            Color = _color;
            Maxvel = _maxvel;
            Encendido = 0;
            //MAXVELOCIDAD = _maxvelocidad;
            this.velocidad_actual = 0;
            
        }

        ////contruir 2do constructor
        //public carro(string _marca, int _modelo, int _maxvelocidad )
        //{
        //    Marca= _marca;
        //    Modelo = _maxvelocidad;
        //    MAXVELOCIDAD = _maxvelocidad;
        //    this.velocidad_actual= 0;
        //}
        public string GetVelocidadActual()
        {
            return $"\nVamos a {velocidad_actual} KPH";
        }

        public void EncenderMotor()
        {
            if (Encendido == 0)
            {
                Console.WriteLine("\nRUN RUN RUN RUN, LISTO PARA IRNOS\n");
                Encendido = 1;
                this.velocidad_actual = 0;
            } else
            {
                Console.WriteLine("Orale no has encendido el motor");
            }
        }

        public string acelerar()
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = $"no puedo acelerar con el ccarro apagado";
                return mensaje;
            }

            velocidad_actual += 10;
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                mensaje = $"Vas a {velocidad_actual} KPH";
            } else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = $"{velocidad_actual}KPH Aguas vas muy rapido y ya llegaste al tope";
            }
            Console.WriteLine(mensaje);
            return mensaje;
        }

        public string acelerar(int CuantosKPH)
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = $"No puedo acelerar con el carro apagado";
                return mensaje;
            }

            velocidad_actual += CuantosKPH;
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                mensaje = $"Vas a {velocidad_actual} KPH";
            }else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = $"{velocidad_actual}KPH Aguas rapido y furioso, vas muy rapido ya lleagste al tope";
            }

            Console.WriteLine(mensaje);
            return mensaje;
        }

        public string desacelerar( int Disminucion)
        {
            string mensaje = "";
            velocidad_actual -= Disminucion;
            if (velocidad_actual >= 0)
            {
                mensaje = $"--Empieza la desaleracion {velocidad_actual} KPH";
            }
            Console.WriteLine(mensaje);
            return mensaje;
        }

        public string frenar()
        {

            string mesnaje = $"\tEl carro se ha detenido a {velocidad_actual} KPH";

            Console.WriteLine(mesnaje);
            return mesnaje;

        }


        public string apagar()
        {
            string mesnaje = "\n\tEl carro se a apagado";

            Console.WriteLine(mesnaje);
            return mesnaje;


        }

        public string bocinar()
        {
            string mesnaje = "------PIN PIN PIIIIIIIIIIIN-------";

            Console.WriteLine(mesnaje);
            return mesnaje;
        }


    }
}
