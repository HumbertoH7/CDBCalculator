namespace CdbCalculatorAPI.Services
{
    public interface IInvestmentService
    {
        InvestmentResult CalculateInvestment(decimal initialAmount, int months);
    }

    public class InvestmentService : IInvestmentService
    {
        private const decimal CDI = 0.009m;
        private const decimal TB = 1.08m;

        public InvestmentResult CalculateInvestment(decimal initialAmount, int months)
        {
            decimal grossValue = initialAmount;

            for (int i = 0; i < months; i++)
            {
                grossValue *= 1 + (CDI * TB);
            }

            decimal taxRate = GetTaxRate(months);
            decimal netValue = grossValue * (1 - taxRate);

            return new InvestmentResult
            {
                GrossValue = grossValue,
                NetValue = netValue
            };
        }

        private decimal GetTaxRate(int months)
        {
            if (months <= 6)
            {
                return 0.225m;
            }
            else if (months <= 12)
            {
                return 0.20m;
            }
            else if (months <= 24)
            {
                return 0.175m;
            }
            else
            {
                return 0.15m;
            }
        }
    }

    public class InvestmentResult
    {
        public decimal GrossValue { get; set; }
        public decimal NetValue { get; set; }
    }
}
