namespace ProjetoQuinze
{
    internal class Funcionario
    {
        public string Name;
        public double AllSalary;
        public double Tax;
        public double IncreasePerc;

        public double LiqSalary()
        {
            return AllSalary - Tax;
        }
        public double IncreasedSal()
        {
            return LiqSalary() + (AllSalary * (IncreasePerc / 100.0));
        }
    }
}
