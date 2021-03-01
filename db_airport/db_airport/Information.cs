using System;

namespace db_airport
{
    //данные регистрации
    //класс предназначен для сериализации информации в XML и log файл
    [Serializable]
    class Information_About_Airplane
    {
        private readonly string Airline;
        private readonly string NumberFlight;
        private readonly string ArrivalAirport; 
        private readonly string DepartureAirport;
        private readonly DateTime dateTimeArrival;
        private readonly DateTime dateTimeDeparture;
        private readonly int NumberOfSeats;
        public Information_About_Airplane(string Airline, string NumberFlight, string ArrivalAirport,
            string DepartureAirport, DateTime dateTimeArrival, DateTime dateTimeDeparture, int NumberOfSeats)
        {
            this.Airline = Airline;
            this.NumberFlight = NumberFlight;
            this.ArrivalAirport = ArrivalAirport;
            this.DepartureAirport = DepartureAirport;
            this.dateTimeDeparture = dateTimeDeparture;
            this.dateTimeArrival = dateTimeArrival;
            this.NumberOfSeats = NumberOfSeats;
        }
    }
}