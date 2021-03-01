using System;

namespace db_airport
{
    //данные регистрации
    //класс предназначен для сериализации информации в XML и log файл
    [Serializable]
    class Information_About_Airplane
    {
        private string Airline;
        private string NumberFlight;
        private string ArrivalAirport; 
        private string DepartureAirport;
        private DateTime dateTimeArrival;
        private DateTime dateTimeDeparture;
        private int NumberOfSeats;
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