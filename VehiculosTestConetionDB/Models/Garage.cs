using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculosTestConetionDB.Models
{
    public class Garage<T>
    {
        private List<T> datosElemento;
        //Añadir el elemento que se le pasa en el argumento a l'array y en caso no tener el Garage creado lo crea
        public Garage(T obj)
        {
            if (datosElemento == null)
            {
                datosElemento = new List<T>();
                datosElemento.Add(obj);
            }
            else { datosElemento.Add(obj); }
        }
        public void AddObject(T obj)
        {
            datosElemento.Add(obj);
        }
        //Recoger el elemento seleccionado
        public T GetElement(int x)
        {
            return datosElemento[x];
        }
    }
}
