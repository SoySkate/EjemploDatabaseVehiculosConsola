using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiculosTestConetionDB.Enums;

namespace VehiculosTestConetionDB.Models
{
    public class Motor
    {
       // private int id;
        private Combustible tipoMotor;
        private double horsePowerHP;
        private double cilindrada;
        public Motor() { }

        //una de las mil formas de hacer un constructorrr...
        public Motor(Combustible tipoMotor, double horsePowerHP, double cilindrada)
        {
            this.tipoMotor = tipoMotor;
            this.horsePowerHP = horsePowerHP;
            this.cilindrada = cilindrada;
            
        }
        public int ID { get; set; }
        public Combustible TipoMotor { get=> tipoMotor; set => tipoMotor = value; }
        public double HorsePowerHP { get => horsePowerHP; set => horsePowerHP = value; }
        public double Cilindrada { get=> cilindrada; set => cilindrada = value;}

        public string GetMotor() => "Combustible: " + TipoMotor + " Caballos de potencia: " + HorsePowerHP + "HP" + "Y los cm3 son: " + Cilindrada + "cc";
    }
   
}
