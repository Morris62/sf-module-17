namespace Module_17;

public class RegularAccount(double balance) : Account(balance), IAccount
{
    public void CalculateInterest()
    {
        Interest = Balance * 0.4;

        if (Balance < 1000)
            Interest -= Balance * 0.2;

        if (Balance >= 1000)
            Interest -= Balance * 0.4;
    }
}