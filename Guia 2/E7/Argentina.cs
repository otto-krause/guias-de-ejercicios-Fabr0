using System;
using System.Collections.Generic;
/*
Se pide:
Instanciar al menos 3 alfajores diferentes.
Crear los métodos para cada evento que cambia los precios.
Decir el estado de la inflación, siendo que se suman los precios de todos los alfajores existentes y:
Es normal, si el precio es menor a 500.
Es super, si el precio es mayor a 500 y menor a 1000.
Es hyper, si es mayor a 1000 pesos.
Mostrar si la Argentina está en default, esto ocurre si hay hiperinflación y solo existe un productor de alfajores (el resto se fundió).
Bajar el precio del petróleo: aumenta el precio el precio del alfajor en 80 pesos.
Milllai habla por tv: aumenta el precio de los alfajores al doble de lo que ya salen.
CoronaVairas: hace que el precio aumente 1000 pesos. Salvo que el nombre del productor sea  “Waymayen”

*/
namespace E7
{
    public class Argentina
    {
        List<Alfajor> alfajores=new List<Alfajor>();
         public Argentina()
         {
            alfajores.Add(new Alfajor("Triple de Dulce de leche",25.50,"Guaymallen"));
            alfajores.Add(new Alfajor("Clasico",35,"Terrabusi"));
            alfajores.Add(new Alfajor("Chocolate",40,"Jorgito"));
         }
        public void BajarElPrecioDelPetroleo()
        {
          foreach (var item in alfajores)
          {
              item.precio+=80;
          }
        }
        public void MilllaiHablaPorTV()
        {
            foreach (var item in alfajores)
            {
                item.precio+=item.precio;
            }
        }
        public void CoronaVairas()
        {
            foreach (var item in alfajores)
            {
                if(item.empresa!="Guaymallen")
                item.precio+=1000;
            }
        }
        public string Inflación()
        {
            double suma=0;
            foreach (var item in alfajores)
            {
                suma+=item.precio;
            }
            if(suma<500)
            {
                return "normal";
            }
            else
            {
                if (suma<1000)
                {
                    return "Super";
                }
                else
                {
                    return "Hyper";
                }
            }
        }
        int Productores()
        {
            int cont=0;
            foreach (var item in alfajores)
            {
                cont++;
            }
            return cont;
        }
        public bool Defoult()
            {
                return  Inflación()=="Hyper"&& Productores()==1;
             }
        public void Mostrar()
        {
            foreach (var item in alfajores)
            {
                Console.WriteLine(item.precio);
            }
        }
      
    }
}
