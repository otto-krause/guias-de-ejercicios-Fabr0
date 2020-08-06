/*
Crear la clase Matematicas2, la cual recibe listas de números enteros y devuelve:
Primos: devuelve solo los números que son primos.
Pares: devuelve solo los números que son pares.
Aplanar: muestra la lista sin repetidos.
Suma: devuelve la sumatoria de todos los números.
SumaDePrimos: devuelve la sumatoria de todos los números que son primos.
Máximo: devuelve el número más grande.
Minimo: Devuelve el número más chico.
*/
using System;
using System.Collections.Generic;
using System.Linq;
namespace E8
{
    public class Matematicas
    {
        List<int> numeros=new List<int>{};

        public Matematicas(List<int> numeros)
        {
            this.numeros = numeros;
        }

        public List<int> aplanar(){
            return numeros.Distinct().ToList();
        }
        public int minimo(){
            return numeros.Min(x=>x);
        }
        public int maximo(){
            return numeros.Max(x=>x);
        }
        public int suma(){
            return numeros.Sum(x=> x);
        }
        public List<int> pares(){
            return numeros.Where(x=> x%2==0).ToList();
        }

        public List<int> primo(){
            List<int> primos= new List<int>{};
            foreach (var item in numeros)
            {
                if(esPrimo(item))
                primos.Add(item);
            }  
            return primos; 
        }
        public bool esPrimo(int num){
            int cont=0;
            for (int i = 1; i <= num; i++)
            {
                if(num%i==0)
                cont++;
            }
            return cont<=2;
        }
       
    }
}