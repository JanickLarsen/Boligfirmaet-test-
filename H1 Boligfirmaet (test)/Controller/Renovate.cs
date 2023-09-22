using H1_Boligfirmaet__test_.Model;
using H1_Boligfirmaet__test_.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Boligfirmaet__test_.Controller
{
    /// <summary>
    /// the purpose of class <c>Renovate<\c> is to calculate what the cost is for the compney for the renovations
    /// </summary>
    internal class Renovate
    {
        internal const byte FLOOR_PRICE_KVM = 179;

        /// <summary>
        /// Takes all the prices to 1 and find the price for all renovations
        /// </summary>
        public void RenovateCalculation()
        {
            double TotelPrice = 0;
            Gui gui = new Gui();
            HousingCompany housingCompany = SetupCompany(new HousingCompany(550000000));

            for (int i = 0; i < 7; i++)
            {
                housingCompany.Workers.Add(new Worker("worker", 450));
            }

            foreach (Apartment apartment in housingCompany.Apartments)
            {
                try
                {
                    //Floor
                    TotelPrice += NewPriceFloor(FLOOR_PRICE_KVM, apartment.Kvm);
                    //Windows
                    TotelPrice += NewPriceWindows((1879 * 1.30), apartment.NumberOfWindowsBay1Frosted);
                    TotelPrice += NewPriceWindows(1879, apartment.NumberOfWindowsBay1);
                    TotelPrice += NewPriceWindows(2798, apartment.NumberOfWindowsBay2);
                    TotelPrice += NewPriceWindows(4678, apartment.NumberOfWindowsBay3);
                    //kitchen
                    TotelPrice += NewPricekitchen(37899, apartment.NumberOfRooms);
                    //Doors
                    TotelPrice += NewPriceDoor(6465, false, false);
                    TotelPrice += NewPriceDoor(4879, false, false);
                    //Pay workers
                    foreach(Worker worker in housingCompany.Workers)
                    {
                        TotelPrice += worker.HourlyRate * apartment.NumberOfRooms + 2; //Take 1 hour to make a room en the +2 is setup time
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Calculation of the renovations failed", e);
                }

            }
            housingCompany.Money -= Math.Round(TotelPrice); //Remove the cost from the company to pay for it
            gui.DisplayTotelRenovationPrice((long)Math.Round(TotelPrice));

        }
        /// <summary>
        /// Adds all the apartment to the company
        /// </summary>
        /// <param name="housingCompany"></param>
        /// <returns></returns>
        private HousingCompany SetupCompany(HousingCompany housingCompany)
        {
            housingCompany.Apartments.AddRange(MakeApartmentList(368, new Apartment(40, 1, 1, 2, 1, 0)));
            housingCompany.Apartments.AddRange(MakeApartmentList(235, new Apartment(55, 2, 1, 3, 1, 0)));
            housingCompany.Apartments.AddRange(MakeApartmentList(167, new Apartment(70, 3, 1, 4, 1, 0)));
            housingCompany.Apartments.AddRange(MakeApartmentList(97, new Apartment(85, 4, 1, 5, 0, 1)));
            housingCompany.Apartments.AddRange(MakeApartmentList(47, new Apartment(110, 5, 1, 6, 0, 1)));

            return housingCompany;
        }

        /// <summary>
        /// Calculate the price of the new floor 
        /// </summary>
        /// <param name="floorPriseKvm"></param>
        /// <param name="kvm"></param>
        /// <returns></returns>
        private double NewPriceFloor(short floorPriseKvm, short kvm)
        {
            double floorPrice = kvm * floorPriseKvm;
            return floorPrice;
        }
        /// <summary>
        /// Calculate the price of the new Windows 
        /// </summary>
        /// <param name="price"></param>
        /// <param name="numberOfWindows"></param>
        /// <returns></returns>
        private double NewPriceWindows(double price,short numberOfWindows)
        {
            double windowPrice = price * numberOfWindows;
            return windowPrice; 
        }
        /// <summary>
        /// Calculate the price For the new kitchen
        /// </summary>
        /// <param name="price"></param>
        /// <param name="numberOfRooms"></param>
        /// <returns></returns>
        private double NewPricekitchen(double price, short numberOfRooms)
        {
            price += price * ((numberOfRooms - 1) * 0.17);
            return price;
        }
        /// <summary>
        /// Calculate the price For a door front/back door
        /// </summary>
        /// <param name="price"></param>
        /// <param name="db60"></param>
        /// <param name="db40"></param>
        /// <returns></returns>
        private double NewPriceDoor(double price, bool db60, bool db40)
        {
            if (db60 || db40)
            {
                price *= 1.58;
                if (db40)
                {
                    price *= 0.85;
                }
            }
            return price;
        }
        /// <summary>
        /// Maks a list over 1 kind of apartments
        /// </summary>
        /// <param name="numberOfApertments"></param>
        /// <param name="apartment"></param>
        /// <returns></returns>
        private List<Apartment> MakeApartmentList(short numberOfApertments, Apartment apartment)
        {
            List<Apartment> list = new List<Apartment >();
            for (int i = 0; i < numberOfApertments; i++)
            {
                list.Add(apartment);
            }
            return list;
        }
    }
}
