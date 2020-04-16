
using System;
/*Crear la clase Celular de la que conocemos los atributos: NFC (si o no), Bluethoot (si o no), memoria de almacenamiento (medida en MB), cantidad de aplicaciones, y también sabemos que tiene dos cámaras (frontal y trasera). Para las cámaras crearemos una clase que contenga los atributos resolución en megapixeles y cantidad de fotos.
Para la clase cámara crear el método pesoPorFoto que calcula cuanto pesa una foto en el teléfono. Para calcular esto sabemos que cada pixel ocupa 3 bytes, y también sabemos que: 1 megapixel = 1.000.000 píxeles.
Para la clase cámara crear el método PesoTotalDeFotos, que devuelve cuanto pesan todas las fotos de esa cámara en conjunto.                                                                           
Para la clase celular crear el método MemoriaDisponible, que calcular cuanta memoria le queda disponible al celular restando el peso de las fotos de ambas cámaras, y el peso de las aplicaciones (cada una pesa 70 mb) a la memoria de almacenamiento.
Para la clase celular crear el método TeCargaLaSUBE que devuelve VoF si tiene NFC.
Crear un celular con dos cámaras en la clase Program y permitirle al usuario utilizar los métodos del celular*/
namespace Visual.guias_de_ejercicios_Fabr0.Guia_1.E7
{
    public class Celular
    {
        bool nfc,bt;
        int memoria=0, ap=0;
           Camara frontal=new Camara(10,30);
            Camara trasera=new Camara(15,20);
        public Celular(bool nfc,bool bt,int memoria,int ap)
        {
            this.nfc=nfc;
            this.bt=bt;
            this.memoria=memoria;
            this.ap=ap;
         
        }


    public int  MemoriaDisponible()
    {
        return memoria-(this.ap*70+ frontal.PesoTotalDeFotos(frontal.res,frontal.fotos)+trasera.PesoTotalDeFotos(trasera.res,trasera.fotos));
    }
    public bool TeCargaLaSUBE()
    {
        return nfc;
    }
    }
  
}



