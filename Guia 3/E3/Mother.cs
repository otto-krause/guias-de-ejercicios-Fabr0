using System;
using System.Collections.Generic;
namespace E3
{
    public class Mother
    {
        string DDR4oDDR3;
        
        public string PedirDDR4oDDR3 { get => DDR4oDDR3; }
    
        string PCIE;

        public string PedirPCIE { get => PCIE; }

        string Sata;

        public string PedirSata { get => Sata; }
        

        public Mother(string dDR4oDDR3, string pCIE, string sata)
        {
            this.DDR4oDDR3 = dDR4oDDR3;
            this.PCIE = pCIE;
            this.Sata = sata;
        }

    }
}