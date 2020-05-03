using System;
using System.Collections.Generic;
/*3) Hacer un programa en el que se represente un album de figuritas del mundial. 
En cada figurita aparece el nombre del jugador, su posición, país y el número de figurita.
 Crearemos también la clase Album que contiene una lista con las figuritas que ya se agregaron.
Se pide:
Agregar una figurita al álbum: para esto el usuario ingresará los datos de la figurita por pantalla, 
y el abum controlará que esa figurita no haya sido ingresada previamente.
Mostrar CuantosDelanteros hay. 
Mostrar CuantosMediocampistas hay.
Decirle al usuario si el album EstaCompleto, para ello sabemos que en el álbum hay 32 equipos con 11 jugadores cada uno.

Nota: Pensar para los puntos B y C una forma de no repetir código.

*/
namespace E3
{
    public class Album
    {
       public List<Figurita> figuritas =new List<Figurita>();

        public Album()
        {
            figuritas.Add(new Figurita("Jorge","Delantero","Argentina",17));
            figuritas.Add(new Figurita("Juan","Delantero","España",25));
            figuritas.Add(new Figurita("Luis","Mediocampista","Argentina",11));
            figuritas.Add(new Figurita("Lorenzo","Mediocampista","Italia",23));
            figuritas.Add(new Figurita("Roke","Defensor","Argentina",15));
            figuritas.Add(new Figurita("Rafastungen","Defensor","Alemania",13));
            figuritas.Add(new Figurita("Josue","Delantero","Brasil",27));
        }
   
        
       public void Corroborar(string var1,string var2,string var3,int var4)
        {
            int cont=0;
          foreach (var item in figuritas)
          {
              cont++;
              if (item.Numero()==var4)
                  Console.WriteLine("La fogurita ya se encuentra en el album");
              else
                if(cont==figuritas.Count)
                  figuritas.Add(new Figurita(var1,var2,var3,var4));

          }
        } 
        public void Contar()
        {
            int med=0;
            int del=0;
            foreach (var j in figuritas)
            {
                if(j.Rol()=="Delantero")
                del++;
                if(j.Rol()=="Mediocampista")
                med++;
            }
            Console.WriteLine("Hay "+del+" delanteros");
            Console.WriteLine("Hay "+med+" delanteros");
        }
        public void EstaCompleto()
        {
            if(figuritas.Count==352)
            Console.WriteLine("El album esta completo");
            else
            Console.WriteLine("Al album no esta completo");
        }
    
            
    }
}
