using System;
namespace E5
{
    public class triangulo
    {
       int l1=0;
       int l2=0;
       int l3=0;

    public triangulo(int l1,int l2, int l3)
        {
            this.l1=l1;
            this.l2=l2;
            this.l3=l3;
        }
        public bool EsEscaleno(int l1,int l2, int l3)
        {
            return l1!=l2 && l1!=l3 && l2!=l3;
        }
        public bool EsIsoseles(int l1,int l2, int l3)
        {
            return l1==l2 || l1==l3 ||l2==l3;
        }
        public bool EsEquilatero(int l1,int l2, int l3)
        {
            return l1==l2 && l1==l3;
        }
         public bool EsRectangulo(int l1,int l2, int l3)
         {
             int mayor=0;
             int cat1=0;
             int cat2=0;
             
            if (l1>l2 &&l1>l3)
            {
                     mayor=l1;
                     cat1=l2;
                     cat2=l3;
             }
             else
             {
                if (l2>l1&&l2>l3)
                {
                    mayor=l2;
                    cat1=l1;
                    cat2=l3;
                }
                else
                {
                    mayor=l3;
                    cat1=l1;
                    cat2=l2;
                }
             }
            
             return  cat1*cat1+cat2*cat2==mayor*mayor;
         }
    }
}