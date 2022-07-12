using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSalloni
{
    public class CarDetails
    {
        public string Firma;
        public string Model;
        public int Year;
        public bool IsAutomaticTransmission;
        public DateTime DateOfSale;
        public int Doors;
        public int Seats;
        public long Km;
        public string Colour;


        public string convertObjectToString()
        {
            return Firma + " - " + Model + " - " + Year;
        }
    }
}
