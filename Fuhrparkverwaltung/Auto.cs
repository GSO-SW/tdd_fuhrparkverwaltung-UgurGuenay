using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrparkverwaltung
{
    public class Auto
    {

        private int kilometerstand;

        public int    Kilometerstand
        {
            get
            {

                return kilometerstand;
         
            }
        }


        public Auto (int kilometerstand)
        {

            kilometerstand = this.kilometerstand;
        }

    }
}
