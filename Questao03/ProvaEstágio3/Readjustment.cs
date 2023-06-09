

namespace ProvaEstágio3
{
    class Readjustment
    {
        public double Salary { get; set; }
        public double Percent { get; set; }

        public Readjustment(double percent, double salary)
        {
            Percent = percent;
            Salary = salary;
        }

        public double CalculateReadjustment()
        {
            Salary = (Salary * (Percent+ 100))/ 100;
            return Salary;

        }

        public override string ToString()
        {
            return Salary.ToString("F2");
        }
    }
}
