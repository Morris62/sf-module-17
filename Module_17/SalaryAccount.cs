namespace Module_17;

public class SalaryAccount(double balance) : Account(balance), IAccount
{
    public void CalculateInterest()
    {
        Interest = Balance * 0.5;
    }
}