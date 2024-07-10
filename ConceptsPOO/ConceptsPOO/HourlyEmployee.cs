
namespace ConceptsPOO
{
    public class HourlyEmployee : Employee
    {
        public float Hours { get; set; }
        public decimal HourVlaue { get; set; }
        public override decimal GetValueToPay()
        {
            return (decimal)Hours * HourVlaue;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tHours................: {$"{Hours:N2}",18}" +
                $"\n\tHour Value...........: {$"{HourVlaue:C2}",18}" +
                $"\n\tvalue to pay.........: {$"{GetValueToPay():C2}",18}";
        }
    }
}
