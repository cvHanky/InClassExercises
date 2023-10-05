using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr13_bonusøvelse
{
    public class JumpHelper
    {
        private int placeringTigerdyr;
        private int bevægelseTigerdyr;
        private int placeringPeterPlys;
        private int bevægelsePeterPlys;

        public int PlaceringTigerdyr
        {
            get { return placeringTigerdyr; }
            set { placeringTigerdyr = value; }
        }
        public int BevægelseTigerDyr 
        { 
            get { return bevægelseTigerdyr;  } 
            set { bevægelseTigerdyr = value;  } 
        }
        public int PlaceringPeterPlys
        {
            get { return placeringPeterPlys;  }
            set { placeringPeterPlys = value; }
        }
        public int BevægelsePeterPlys
        {
            get { return bevægelsePeterPlys;  }
            set { bevægelsePeterPlys = value; }
        }

        static public string MakeAJump(int placeringDyr1, int bevægelseDyr1, int placeringDyr2, int bevægelseDyr2)
        {    // note to self: koden i den her metode er IKKE smuk, for meget indentation. 
            string mødeKoordinater = "";
            int count = 0;
            bool validStart = true;

            
            if (placeringDyr1 > placeringDyr2 && bevægelseDyr1 > bevægelseDyr2)
            {
                validStart = false;
                mødeKoordinater = "NO";
            }
            if (placeringDyr1 < placeringDyr2 && bevægelseDyr1 < bevægelseDyr2)
            {
                validStart = false;
                mødeKoordinater = "NO";
            }
            

            while (validStart)
            {
                if (placeringDyr1 > placeringDyr2)
                    while (true)
                    {
                        placeringDyr1 += bevægelseDyr1;
                        placeringDyr2 += bevægelseDyr2;
                        if (placeringDyr1 == placeringDyr2)
                        {
                            mødeKoordinater = placeringDyr1.ToString() + "," + placeringDyr2.ToString();
                            validStart = false;
                            break;
                        }
                        else if (placeringDyr1 < placeringDyr2)
                        {
                            mødeKoordinater = "NO";
                            validStart = false;
                            break;
                        }
                        else if (placeringDyr1 >= 10000 || placeringDyr2 >= 10000)
                        {
                            mødeKoordinater = "NO";
                            validStart = false;
                            break;
                        }
                    }
                else
                    while (true)
                    {
                        placeringDyr1 += bevægelseDyr1;
                        placeringDyr2 += bevægelseDyr2;
                        if (placeringDyr1 == placeringDyr2)
                        {
                            mødeKoordinater = placeringDyr1.ToString() + "," + placeringDyr2.ToString();
                            validStart = false;
                            break;
                        }
                        else if (placeringDyr1 > placeringDyr2)
                        {
                            mødeKoordinater = "NO";
                            validStart = false;
                            break;
                        }
                        else if (placeringDyr1 >= 10000 || placeringDyr2 >= 10000)
                        {
                            mødeKoordinater = "NO";
                            validStart = false;
                            break;
                        }
                    }
            }
            
            return mødeKoordinater;
        }

    }
}
