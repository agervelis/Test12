using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snacks
{
   class Kaina
    {
        public double PVM = 1.21;
        public double preke;
        public double bendra=0;
        public double bendraPVM = 0;
        public double GetPrice()
        {
            bendra = bendra + preke;
            return bendra;
        }
        public double GetPricePVM()
        {
            bendraPVM= bendraPVM + (preke * PVM);
            return bendraPVM;
        }
        public double Atimt()
        {
            bendra= bendra - preke;
            return bendra;
        }
        public double AtimtPVM()
        {
            bendraPVM= bendraPVM - (preke * PVM);
            return bendraPVM;
        }
    }
}
