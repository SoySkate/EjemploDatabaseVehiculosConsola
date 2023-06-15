using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiculosTestConetionDB.Interfaces;

namespace VehiculosTestConetionDB.Models
{
    public class Avion : Vehiculo, IAereo
    {
        private int id;
        private int numRuedas;
        const bool cinturones = true;
        public Avion(int numRuedas, string modelo) : base(modelo)
        {
            this.numRuedas = numRuedas;
        }
        public int NumRuedas { get => numRuedas; set => numRuedas = value; }
        public bool Cinturones { get => cinturones; }
        public int ID { get=> id; set => id = value; }
        public string Volar()
        {
            return "FIIIIIIIIIIAUU Volando a full xd";
        }
        public override void Seguridad()
        {
            Console.WriteLine("Los cinturones obligatorios al despegar y al aterrizar...");
        }
        public string VerifyCintus() => Cinturones ? "Si" : "No";
        public override string ToString()
        {
            return "ID del avion: "+ID+"\nNumero de ruedas: " + NumRuedas + "\nEste es el Color del coche: " + Color + "\n Esto es el Motor: " + Motor.GetMotor() + "\nY esto es el top speed: " + TopSpeed + "km/h" +
                "\nNumero maximo de personas: " + MaxPersonas + "\nEl modelo del coche es: " + Modelo + "\nY este es el numero de carroceria: " + NumVIN + "\n Tiene cinturones?: " + VerifyCintus();
        }
    }
}
