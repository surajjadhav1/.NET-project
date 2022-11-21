namespace SimpleInterest.Service;

public class SimpleIntrest : ICalculate
{
    public double SimpleIntr(double principle, double rate, int period)
    {
        return (principle*rate*period)/100;
    }
}