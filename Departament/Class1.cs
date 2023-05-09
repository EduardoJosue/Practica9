using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departamento
{
    public class Departament 
    {
        public int deptNumber;
        public bool isProducing;
        public float produce;
        public Departament()
        {
        }
        public Departament(int deptNumber, bool isProducing, float produce)
        {
            this.deptNumber = deptNumber;
            this.isProducing = isProducing;
            this.produce = produce;
        }
        public float GetIncentive(float multiplyFactor) {
            if(isProducing)
             return produce * multiplyFactor; // extra de productividad
            else return 0;  
        }
    }
}
