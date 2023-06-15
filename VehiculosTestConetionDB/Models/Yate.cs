using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiculosTestConetionDB.Interfaces;

namespace VehiculosTestConetionDB.Models
{
    public class Yate : Vehiculo, IAcuatico
    {
        private int id;
        private int valoracion;//Yo que se pienso en una valoracion rollo como un hotel con las estrellas
        const bool cinturones = false;

        public Yate(int valoracion, string modelo) : base(modelo)
        {
            this.valoracion = valoracion;
        }
        public int Valoracion { get => valoracion; set => valoracion = value; }
        public bool Cinturones { get => cinturones; }
        public int ID { get => id; set => id = value; }
        public override void Seguridad()
        {
            Console.WriteLine("Nada aqui sin cinturones bro xdd del chill");
        }
        public string Navegar()
        {
            return "Broww aqui navegando por el mar chillinnnnn'";
        }
        public string VerifyCintus() => Cinturones ? "Si" : "No";
        public override string ToString()
        {
            return "ID del yate: "+ID+"\nNumero de valoracion: " + Valoracion + "\nEste es el Color del yate: " + Color + "\n Esto es el Motor: " + Motor.GetMotor() + "\nY esto es el top speed: " + TopSpeed + "km/h" +
                "\nNumero maximo de personas: " + MaxPersonas + "\nEl modelo del coche es: " + Modelo + "\nY este es el numero de carroceria: " + NumVIN + "\n Tiene cinturones?: " + VerifyCintus();
        }
    }
}
