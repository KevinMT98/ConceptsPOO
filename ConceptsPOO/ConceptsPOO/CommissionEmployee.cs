namespace ConceptsPOO
{
    public class CommissionEmployee : Employee
    {
        public float CommissionPercentaje { get; set; }
        public decimal sales { get; set; }

        public override decimal GetValueToPay()
        {
            return sales * (decimal)CommissionPercentaje;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tCommission Percentaje: {$"{CommissionPercentaje:P2}", 18}"+
                $"\n\tSales................: {$"{sales:C2}",18}" +
                $"\n\tvalue to pay.........: {$"{GetValueToPay():C2}",18}";
        }
    }
}
