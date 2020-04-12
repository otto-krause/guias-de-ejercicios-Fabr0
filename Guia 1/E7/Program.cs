using System;
/*Crear la clase Celular de la que conocemos los atributos: NFC (si o no), Bluethoot (si o no), memoria de almacenamiento (medida en MB), cantidad de aplicaciones, y también sabemos que tiene dos cámaras (frontal y trasera). Para las cámaras crearemos una clase que contenga los atributos resolución en megapixeles y cantidad de fotos.
Para la clase cámara crear el método pesoPorFoto que calcula cuanto pesa una foto en el teléfono. Para calcular esto sabemos que cada pixel ocupa 3 bytes, y también sabemos que: 1 megapixel = 1.000.000 píxeles.
Para la clase cámara crear el método PesoTotalDeFotos, que devuelve cuanto pesan todas las fotos de esa cámara en conjunto.                                                                           
Para la clase celular crear el método MemoriaDisponible, que calcular cuanta memoria le queda disponible al celular restando el peso de las fotos de ambas cámaras, y el peso de las aplicaciones (cada una pesa 70 mb) a la memoria de almacenamiento.
Para la clase celular crear el método TeCargaLaSUBE que devuelve VoF si tiene NFC.
Crear un celular con dos cámaras en la clase Program y permitirle al usuario utilizar los métodos del celular
*/
namespace E7
{
    public class Program
    {
        static void main(string[] args)
        {
            int num=0;
  

            Celular nokia=new Celular(true,true,5000,4);
            while (num!=6)
            {
                Console.WriteLine("Ingrese el numero para la operacion deseada:\n1-Para ver la memoria disponible\n2-Para ver si te carga la sube\n3-Finalizar");
                num=int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("La memoria disponible es de "+nokia.MemoriaDisponible()+"Mb");
                        break;
                    
                    case 2:
                    
                        Console.WriteLine(nokia.TeCargaLaSUBE(true));
                        break;

                    case 3:
                        break;
                 }
            }
        }
    }
}
