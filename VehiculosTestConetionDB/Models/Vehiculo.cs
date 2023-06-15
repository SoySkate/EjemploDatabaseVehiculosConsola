using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiculosTestConetionDB.Enums;

namespace VehiculosTestConetionDB.Models
{
    public class Vehiculo
    {
        private int id;
        private string modelo;//{get;set;} (Y que sea public) Es lo mismo pero más rapido supuestamente 
        private string numVIN="";
        private int maxPersonas;
        private int topSpeed;
        private Motor motor;
        private Color color;

        public Vehiculo(string modelo)
        {
            this.modelo = modelo;
        }
        //Estos getters and setters son más largos que que si lo hago como los de los atributos de arriba
        public string Modelo { get => modelo; set => modelo = value; }
        public string NumVIN { get => numVIN; set => numVIN = value; }
        public int MaxPersonas { get => maxPersonas; set => maxPersonas = value; }
        public int TopSpeed { get => topSpeed; set => topSpeed = value; }
        public Motor Motor { get => motor; set => motor = value; }
        public int ID { get => id; set => id = value; }
        //Lo del metodo de Color es igual que los de arriba simplemente lo hago algo diferente
        public Color Color
        {
            get => color;
            set => color = value;
        }
        //public Color Color { get => color; set => color = value; }

        public void Arrancar()
        {
            Console.WriteLine("Estamos arrancando motores... ");
        }
        public void Parar()
        {
            Console.WriteLine("Parando el motor...");
        }
        public virtual void Seguridad()
        {
            Console.WriteLine("Nos ponemos los cinturones por seguridad(default).");
        }
        
    }
}
