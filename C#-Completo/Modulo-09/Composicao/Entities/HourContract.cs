using System;

namespace Composicao.Entities
{
    public class HourContract
    {
        public DateTime Date { get; set; }
        public Double valuePerHour { get; set; }   
        public int hours { get; set; }

        public Double totalValue()
        {
            return valuePerHour * hours;
        }

        public void setDate(DateTime dateTime)
        {
            Date = dateTime;
        }

        public void setValuePerHour(Double value)
        {
            valuePerHour = value;
        }

        public void setHours(int hour)
        {
            hours = hour;
        }
    }
}