using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiculosTestConetionDB.Interfaces;

namespace VehiculosTestConetionDB.Models
{
    public class Coche : Vehiculo, ITerrestre
    {
        private int id;
        private int numRuedas;

        const bool cinturones = true;

        public Coche(int numRuedas, string modelo) : base(modelo)
        {
            this.numRuedas = numRuedas;
        }
       
        public int NumRuedas { get => numRuedas; set => numRuedas = value; }
        public bool Cinturones { get => cinturones; }
        public int ID { get => id; }
        public string Conducir()
        {
            return "BRUUUM HACE EL COCHEE XDD";
        }
        //public string VerifyCintus()
        //{
        //    if (Cinturones == true) { return "Si"; } else { return "No"; }
        //}
        //TODO: Ejemplo de TERNARIOS
        public string VerifyCintus()=>Cinturones?"Si":"No";
        public override string ToString()
        {
            return "ID del coche: "+ID+"\nNumero de ruedas: "+NumRuedas+"\nEste es el Color del coche: "+Color+ "\n Esto es el Motor: " + Motor.GetMotor()+ "\nY esto es el top speed: " + TopSpeed+""+
                "\nNumero maximo de personas: " + MaxPersonas+ "\nEl modelo del coche es: " + Modelo+ "\nY este es el numero de carroceria: " + NumVIN+"\n Tiene cinturones?: "+VerifyCintus();
        }
    }
}
