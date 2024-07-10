namespace ConceptsPOO
{
    public abstract class Employee : Ipay
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Date BirthDay { get; set; }
        public Date HiringDate { get; set; }
        public bool IsActive { get; set; }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"ID:{id} - " +
                $"{FirstName} - " +
                $"{LastName} - Birth: " +
                $"{BirthDay}, Hiring: " +
                $"{HiringDate}, Active: " +
                $"{IsActive}";
        }
    }
}
