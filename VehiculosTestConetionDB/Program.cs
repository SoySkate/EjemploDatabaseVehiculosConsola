using Microsoft.EntityFrameworkCore;
using System;
using VehiculosTestConetionDB;
using VehiculosTestConetionDB.Models;

internal class Program
{
    static int getRuedas()
    {
        int ruedas;
        Console.WriteLine("Introduca el numero de ruedas del coche:");
        try { ruedas = int.Parse(Console.ReadLine()); } catch { Console.WriteLine("Valor incorrecto," +
            " se ha puesto el numero por defecto(4)"); ruedas = 4; }
        return ruedas;
    }
    static int getValoracion()

  
    {
        int valoracion;
        Console.WriteLine("Introduca la valoracion del Yate del 1 al 10:");
        try { valoracion = int.Parse(Console.ReadLine());
            if (valoracion < 1 || valoracion > 10) {
                Console.WriteLine("Valor incorrecto," +
            " se ha puesto una valoracion por defecto(7)"); return valoracion = 7;
            }
            else { return valoracion; }
        }
        catch
        {
            Console.WriteLine("Valor incorrecto," +
            " se ha puesto una valoracion por defecto(7)"); return valoracion = 7;
        }
    }
    static void crearVehiculo()
    {
        int maxVelo, maxPerso ,valoracion=0,numRuedas=0;
        string modelo, color, VIN, combustible;
        double horsepower, cilindrada;
        Console.WriteLine("Selecciona que Vehiculo desea crear(introduce un numero entre el 1 y el 3 segun que desea crear.");
        Console.WriteLine("Pulsa el 1 para crear un Coche, el 2 para crear un Avion, o el 3 para crear un Yate:");
        int option =0;
        for (int i=0; i<5; i++)
        {
            try {option=int.Parse(Console.ReadLine()); break; } catch { Console.WriteLine("Debes introducir un numero valido"); }
            if (i == 5) { option = 1; break; }
        }
        
        Console.WriteLine("Introduca el Modelo:");
        try { modelo = Console.ReadLine(); } catch { Console.WriteLine("Valor incorrecto, se ha puesto el modelo por defecto: RenaultClio"); modelo = "RenaultClio"; }
        Vehiculo V1 = new Vehiculo(modelo);
        //creamos el coche para poder proseguir  aponerle la otra data:
        switch (option)
        {
            case 1:
                Coche Coche1 = new Coche(numRuedas=getRuedas(), modelo);
                V1 = Coche1;
                break; 
            case 2:
                Avion Avion1 = new Avion(numRuedas=getRuedas(), modelo);
                V1 = Avion1;
                break; 
            case 3:
                Yate Yate1 = new Yate(valoracion=getValoracion(), modelo);
                V1= Yate1;
                break;
        }
       
        Console.WriteLine("Introduca la velocidad maxima que tiene:");
        try { maxVelo = int.Parse(Console.ReadLine()); } catch { Console.WriteLine("Valor incorrecto, se ha puesto el valor por defecto(100km/h)"); maxVelo = 100; }
        Console.WriteLine("Introduca el color del vehiculo en minusculas(negro,blanco, amarillo, rojo, azul, gris, verde):");
        try { color = Console.ReadLine(); } catch { Console.WriteLine("Color incorrecto;Valor por defecto establecido: (Gris)");color = "gris"; }
        switch (color)
        {
            case "negro":
                V1.Color = VehiculosTestConetionDB.Enums.Color.NEGRO;
                break;
            case "blanco":
                V1.Color = VehiculosTestConetionDB.Enums.Color.BLANCO;
                break;
            case "amarillo":
                V1.Color = VehiculosTestConetionDB.Enums.Color.AMARILLO;
                break;
            case "rojo":
                V1.Color = VehiculosTestConetionDB.Enums.Color.ROJO;
                break;
            case "azul":
                V1.Color = VehiculosTestConetionDB.Enums.Color.AZUL;
                break;
            case "gris":
                V1.Color = VehiculosTestConetionDB.Enums.Color.GRIS;
                break;
            case "verde":
                V1.Color = VehiculosTestConetionDB.Enums.Color.VERDE;
                break;
            default: Console.WriteLine("No has introducido ningun color valido, por lo tanto se ha puesto el color gris por defecto;");
                V1.Color = VehiculosTestConetionDB.Enums.Color.GRIS;
                break;
        }
        Console.WriteLine("Introduca el numero VIN de carroceria:");
        try { VIN = Console.ReadLine(); } catch { Console.WriteLine("Caracteres incorrectos, numero por defecto(123Model)");VIN = "123Model"; }
        Console.WriteLine("Introduca la capacidad maxima legal de personas que soporta el vehiculo:");
        try { maxPerso = int.Parse(Console.ReadLine()); } catch {
            Console.WriteLine("Debe introducir un numero entero" +
            "Se ha establecido un numero por defecto(5)");maxPerso = 5; }
        Console.WriteLine("Escriba el numero de caballos de potencia que tiene el motor:");
        try { horsepower = double.Parse(Console.ReadLine()); } catch { Console.WriteLine("Valor incorrecto. Establecido por defecto 80cv.");horsepower = 80; }
        Console.WriteLine("Introduzca los cm3 (la cilindrada del motor):");
        try { cilindrada = double.Parse(Console.ReadLine()); } catch { Console.WriteLine("Caracter invalido: cilindrada establecida (1500cc)");cilindrada = 1500.00; }
        var motor = V1.Motor;
        Console.WriteLine("Escribe en minusculas el combustible que usa el Motor: (diesel, gasolina, hibrido, electrico) :");
        try { combustible = Console.ReadLine(); } catch { Console.WriteLine("Valores incorrectos. Se ha establecido por defecto la Gasolina."); combustible = "gasolina"; }
        switch (combustible)
        {
            case "diesel":
                 motor = V1.Motor = new Motor(VehiculosTestConetionDB.Enums.Combustible.DIESEL,horsepower,cilindrada);
                break;
            case "gasolina":
                 motor = V1.Motor = new Motor(VehiculosTestConetionDB.Enums.Combustible.GASOLINA, horsepower, cilindrada);
                break;
            case "hibrido":
                 motor = V1.Motor = new Motor(VehiculosTestConetionDB.Enums.Combustible.HIBRIDO, horsepower, cilindrada);
                break;
            case "electrico":
                 motor = V1.Motor = new Motor(VehiculosTestConetionDB.Enums.Combustible.ELECTRICO, horsepower, cilindrada);
                break;
            default:
                motor = V1.Motor = new Motor(VehiculosTestConetionDB.Enums.Combustible.GASOLINA, horsepower, cilindrada);
                break;
        }
        VehiculosContexto Contexto1 = new VehiculosContexto();

        V1.TopSpeed = maxVelo;
        V1.MaxPersonas = maxPerso;
        V1.NumVIN = VIN;
        if(option == 1)
        {
            //Aqui lo suyo seria pasar el valor de V1 a uno nuevo de coche para poder hacer el toString
            //Que hay en la clase Coche y en las demas porque tiene el boolean de los cinturones.
            //CASTING SE LLAMA CAAAASTIIINGGG XD
            Coche CocheF = new Coche(numRuedas,modelo);
            CocheF = V1 as Coche;
            Console.WriteLine(CocheF.ToString());
            Contexto1.Coches.Add(CocheF);
        }
        else if(option == 2) { 
            Avion AvionF = new Avion(numRuedas, modelo);
            AvionF = V1 as Avion;
            Console.WriteLine(AvionF.ToString());
            Contexto1.Aviones.Add(AvionF);  
        } else {
            Yate YateF = new Yate(valoracion, modelo);
            YateF = V1 as Yate;
            Console.WriteLine(YateF.ToString());
            Contexto1.Yates.Add(YateF); 
        }
        //Guardamos los cambios a la database
        Contexto1.SaveChanges();
        Contexto1.Dispose();

    }
    static void RecogerLista()
    {
        int option;
        bool menulist = true;
        Console.WriteLine("Que lista deseas ver?");
        VehiculosContexto ContextoLista = new VehiculosContexto();
        do
        {
        Console.WriteLine("Pulsa el 1 para ver una Lista de Coches.");
        Console.WriteLine("Pulsa el 2 para ver una Lista de Aviones.");
        Console.WriteLine("Pulsa el 3 para ver una Lista de Yates.");
     
        
            try { option = int.Parse(Console.ReadLine()); } catch { Console.WriteLine("Valor incorrecto"); option = default; }
            switch (option)
            {
                case 1:
                    Console.WriteLine("ListaCoches:");

                    foreach (Coche coche in ContextoLista.Coches.Include(x => x.Motor))
                    {
                        Console.WriteLine(coche.ToString());
                    }    
                    menulist = false;
                    break;
                case 2:
                    Console.WriteLine("ListaAviones:");
                    foreach (Avion avion in ContextoLista.Aviones.Include(x=>x.Motor))
                    {
                        Console.WriteLine(avion.ToString());
                    }
                    menulist = false;
                    break;
                case 3:
                    Console.WriteLine("ListaYates:");
                    foreach (Yate yate in ContextoLista.Yates.Include(x => x.Motor))
                    {
                        Console.WriteLine(yate.ToString());
                    }
                    menulist = false;
                    break;
                default:
                    Console.WriteLine("Valor introducido incorrecto, introduca uno correcto porfavor:");
                    break;
            }
        } while (menulist == true);
        ContextoLista.Dispose();

    }
    static void EditarVechiculo()
    {
        int option;
        bool menu = true;
        VehiculosContexto ContextoEditar = new VehiculosContexto();
        do { 
        Console.WriteLine("Que vehiculo quiere editar?");
        Console.WriteLine("Introduzca el numero 1 para editar un Coche.");
        Console.WriteLine("Introduzca el numero 2 para editar un Avion.");
        Console.WriteLine("Introduzca el numero 3 para editar un Yate.");
      
        try { option = int.Parse(Console.ReadLine()); } catch { option = default; }
        switch (option)
        {
            case 1:
                    int id;
                    bool correcto=true;
                
                    Console.WriteLine("Introduzca el ID del Coche.(Con la lista de vehiculos puedes obtener el Id del vehiculo");
                    try { id = int.Parse(Console.ReadLine()); } catch { Console.WriteLine("Debes introducir un numero entero."); id = 0; }
                    //Si el id no coincide simplemente vuelve a preguntarlo mismo.
                    if (id != 0)
                    {
                        var queryId = ContextoEditar.Coches.Where(c => c.ID == id)
                            .Select(c => c);
                        if(queryId.Count() > 0)
                        {
                            Console.WriteLine("Que parte del vehiculo desea editar??");
                        }

                    }


                    menu = false;
                break;
            case 2:
                menu = false;
                break;
            case 3:
                menu = false;
                break; 
            case 4:
                Console.WriteLine("Cancelando...");
                menu = false;
                break;
            default:
                Console.WriteLine("No has introducido ni el numero 1, ni el 2 ni el 3. Ni el 4 para Cancelar la edicion.");
                break;
        }
        }while(menu == true);
    }

    private static void Main(string[] args)
    {
        bool menu = true;
        do
        {
            Console.WriteLine("\n---MenuOptions---Introduzca una opcion---");
            Console.WriteLine("1.Crear Vehicuo:");
            Console.WriteLine("2.Recoger lista Vehiculos:");
            Console.WriteLine("3.Editar Vehiculo:");
            Console.WriteLine("4.Eliminar Vehiculo:");
            Console.WriteLine("5.Salir\n");
            int option;
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch { option = default; }

            switch (option)
            {
                case 1:
                    void esconderdataDeEjemploDelPrincipioDelTodoDeCrearObjectsYMeterlosEnLaDataBase()
                    {
                        ////EJEMPLO DE CREACION DE OBJETOS HAY QUE HACERLO CON FUNCIONES
                        //Console.WriteLine("Aqui se debe Crear el vehiculo:");
                        ////creacion de objeto coche
                        //Coche C1 = new Coche(4, "Audi a3");
                        ////Lo paso a Vehiculo para ver que se puede hacer el poliformismo sin problema pero es innecesario
                        //Vehiculo V1 = C1 as Vehiculo;
                        //V1.TopSpeed = 160;
                        //V1.Color = VehiculosTestConetionDB.Enums.Color.AZUL;
                        //V1.Motor = new Motor(VehiculosTestConetionDB.Enums.Combustible.DIESEL, 125.34, 1900.40);
                        //V1.NumVIN = "fsfs";
                        //V1.MaxPersonas = 5;
                        //// Innecesario lo de pasar el objeto a Vehiculo a excepcion que quiera hacer una lista de objetos vehiculos o otras cosas especificas
                        ////creacion de un objeto avion
                        //Avion Avi1 = new Avion(20, "Boeing 747");
                        //Avi1.TopSpeed = 987;
                        //Avi1.Color = VehiculosTestConetionDB.Enums.Color.GRIS;
                        //Avi1.Motor = new Motor(VehiculosTestConetionDB.Enums.Combustible.DIESEL, 60000, 44000);
                        //Avi1.MaxPersonas = 400;
                        //Avi1.NumVIN = "supertripleBoeing_1234";
                        ////Creacion vehiculo acuatico (YAte)
                        //Yate Acua1 = new Yate(7,"Benetti");
                        //Acua1.Color = VehiculosTestConetionDB.Enums.Color.VERDE;
                        //Acua1.MaxPersonas = 12;
                        //Acua1.Motor = new Motor(VehiculosTestConetionDB.Enums.Combustible.HIBRIDO, 7000, 738);
                        //Acua1.NumVIN = "Benetti2341_213";
                        //Acua1.TopSpeed = 80;

                        ////El toString() del objeto C1 lo he sobreescrito.
                        //Console.WriteLine("____________________________\n");
                        //Console.WriteLine(V1.ToString());
                        //Console.WriteLine("____________________________\n");
                        //Console.WriteLine(Avi1.ToString());
                        //Console.WriteLine("____________________________\n");
                        //Console.WriteLine(Acua1.ToString());


                        //VehiculosContexto Contexto1 = new VehiculosContexto();
                        ////insertando objeto coche en la database
                        //Contexto1.Coches.Add(C1);
                        //Contexto1.Aviones.Add(Avi1);
                        //Contexto1.Yates.Add(Acua1);
                        ////guardando los cambios
                        //Contexto1.SaveChanges();
                    }

                    crearVehiculo();

                    break;
                case 2:
                    Console.WriteLine("Aqui se debe ver la Lista de vehiculos:");
                    RecogerLista();
                    break;
                case 3:
                    Console.WriteLine("Aqui se debe Editar el vehiculo selected:");
                    //NO TERMINADA LA FUNCION:
                    EditarVechiculo();
                    break;
                case 4:
                    Console.WriteLine("Aqui se debe crear el vehiculo:");
                    break;
                case 5:
                    Console.WriteLine("Saliendo...");
                    menu = false;
                    break;
                default:
                    Console.WriteLine("Porfavor seleccione una opcion válida:");
                    break;
            }

        } while (menu == true);

        Console.ReadKey();
    }
}