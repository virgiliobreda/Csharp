using Interface.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; set; }
        public double PricePerDay { get; set; }

        private ITaxService _taxService;

        public RentalService(Double pricePerHour, double pricePerDay, ITaxService taxSerivce)
        {
            PricePerDay = pricePerDay;
            PricePerHour = pricePerHour;
            _taxService = taxSerivce;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayament = 0;

            if (duration.TotalHours <= 12.0)
            {
                basicPayament = PricePerHour * Math.Ceiling(duration.TotalHours);

            }
            else
            {
                basicPayament = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayament);

            carRental.Invoice = new Invoice(basicPayament, tax);
        }
    }
}
