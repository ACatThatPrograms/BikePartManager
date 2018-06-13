using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikePartManager
{

    [Serializable]

    public class BikePart
    {


        public string name { get; set; }
        public string type { get; set; }
        public string mfg { get; set; }
        public string years { get; set; }
        public double price { get; set;}
        public double brkEven { get; set; }

        public string display { get; set; }

        public BikePart(string partName, string partType, string partMfg, string partYears, float partEbayPrice )
        {

            int spacesToAdd = 0;

            for (int i =0; i < 20 - partName.Length; i++)
            {

                spacesToAdd += 1;

            }

            name = partName + String.Concat(Enumerable.Repeat(" ", spacesToAdd));
            type = partType;
            mfg = partMfg;
            years = partYears;

            price = Math.Round(partEbayPrice, 2);

            display = String.Format("{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}", name, type, mfg, years,"$"+price.ToString());

        }

        public void updateDisplay()
        {

            display = String.Format("{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}", name, type, mfg, years, "$" + price.ToString());

        }

    }

 }

