using System;

namespace db_airport
{
    //данные регистрации
    //класс предназначен для сериализации информации в XML и log файл
    [Serializable]
    class Information_About_Airplane                    // так так новый комент для теста
    {
        private string Airline;                     // авиакомпания
        private string NumberFlight;                // Номер рейса
        private string ArrivalAirport;              // аэропорт прибытия
        private string DepartureAirport;            // аэропорт отправления
        private DateTime dateTimeArrival;           // время прибытия
        private DateTime dateTimeDeparture;         // время отправления
        private int NumberOfSeats;                  // счетски количества мест
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